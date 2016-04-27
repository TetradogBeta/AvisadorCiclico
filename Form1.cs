using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avisador
{
	public partial class frmAvisador : Form
	{
		Timer tiempoRestante;
		int segonsRestants;
		private string musica = "";
		private System.Windows.Forms.NotifyIcon notify;
		public frmAvisador()
		{

			InitializeComponent();

			if (File.Exists("ultimTo.txt")){
				var fileSt=new StreamReader(File.OpenRead("ultimTo.txt"));
				musica = (fileSt.ReadLine());
				fileSt.Close();
				if(!File.Exists(musica))
					musica="";
			}
			if(!File.Exists(musica))
				button1_Click_1(null, null);
			lblNombreTono.Text = Path.GetFileNameWithoutExtension(musica);
			this.BringToFront();
			if(!File.Exists(musica))this.Close();
			else{
				tiempoRestante = new Timer();
				tiempoRestante.Tick += new EventHandler(CambiaTiempoRestante);
				tiempoRestante.Interval = 1000;
				btnSig.Visible = Debugger.IsAttached;
				//notify
				this.notify = new NotifyIcon();
				this.notify.Icon = icono.tempIco;
				this.notify.Text = "temps";

				this.notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
				Resize += new EventHandler(ResizeEvent);
				listaTemporizadores1.TemporizadorSiguiente += new TemporizadorEventHandler(TempSegNotifyEvent);
			}
		}

		private void TempSegNotifyEvent(temporizador temp)
		{
			
			notify.Tag = temp;

		}

		private void ResizeEvent(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Minimized)
			{
				Hide();
				this.notify.Visible = true;
				this.notify.Tag = listaTemporizadores1.Siguiente;
				notify.BalloonTipTitle = "La aplicació continua funcionant!!";
				notify.BalloonTipText = "Quan vulguis tornarla a posar fes-li clic ;)";
				notify.ShowBalloonTip(3000);
			}
		}
		
		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.notify.Visible = false;
			Show();
			this.notify.Tag = null;
			WindowState = FormWindowState.Normal;
		}
		public bool Continuar
		{
			get { return musica!=""; }
		}
		private void CambiaTiempoRestante(object sender, EventArgs e)
		{
			segonsRestants--;
			if (segonsRestants >= 0)
			{
				int hores = segonsRestants / 3600;
				int minutos = (segonsRestants - (hores * 3600)) / 60;
				int segundos = segonsRestants - hores * 3600 - minutos * 60;
				lblTiempoRestante.Text = hores + ":" + minutos + ":" + segundos;
				this.notify.Text = "Queda: "+lblTiempoRestante.Text;
			}
			if (segonsRestants <= 0)
			{
				tiempoRestante.Enabled = false;
				SuenaAlarma();
				if (notify.Tag == null)
					listaTemporizadores1.HoraSiguiente();
				else
					listaTemporizadores1.PonerTemporizador(notify.Tag as temporizador);
			}
		}

		private void SuenaAlarma()
		{
			playSound(musica);
		}
		private void playSound(string path)
		{
			try
			{
				System.Media.SoundPlayer player =
					new System.Media.SoundPlayer();
				player.SoundLocation = path;
				player.Load();
				player.Play();
			}
			catch { MessageBox.Show("El fixero no se ha podio abrir"); }
		}

		private void listaTemporizadores1_Hora(string hora, int segundosRestantes)
		{
			lblTiempoParaSonar.Text = hora;
			this.segonsRestants = segundosRestantes;
			if (this.segonsRestants != 0)
				tiempoRestante.Enabled = true;


		}

		private void btnAñadirTemp_Click(object sender, EventArgs e)
		{
			temporizador temp = new temporizador(numericUpDown1, numericUpDown2);
			listaTemporizadores1.Añadir(temp);
			if (!tiempoRestante.Enabled)
			{

				segonsRestants = 0;
				tiempoRestante.Enabled = true;
				label1.Visible = true;
				label2.Visible = true;
				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			segonsRestants = 4;
		}

		private void frmAvisador_FormClosing(object sender, FormClosingEventArgs e)
		{
			musica = "";
		}

		public void Reset()
		{

			lblTiempoParaSonar.Text = "";
			lblTiempoRestante.Text = "";
			segonsRestants = 0;
			listaTemporizadores1.Reset();
			tiempoRestante.Enabled = false;
			label1.Visible = false;
			label2.Visible = false;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "Audio Files (.wav)|*.wav";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				musica = dialog.FileName;
				lblNombreTono.Text = Path.GetFileNameWithoutExtension(musica);

			}
			if (musica != "")
			{
				var fileRecord = new FileStream("ultimTo.txt", FileMode.OpenOrCreate);
				var fileStream = new StreamWriter(fileRecord, Encoding.UTF8);

				fileStream.WriteLine(musica);
				fileStream.Close();
				fileRecord.Close();
			}

		}
	}
}
