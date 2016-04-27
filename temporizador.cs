using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avisador
{
  
    public partial class temporizador : UserControl
    {
        public event EventHandler Quitar;
        bool esElSiguiente;
        static int contador = 0;
        int id;
        public temporizador()
        {
            InitializeComponent();
            Tiempo = "0:0";
            id = contador++;
            lblTiempo.Click += new EventHandler(ClicPonerEvent);

        }

        private void ClicPonerEvent(object sender, EventArgs e)
        {
            OnClick(null);
        }
        

        public temporizador(NumericUpDown horas, NumericUpDown minutos):this()
        {
            PonTiempo(horas, minutos);
        }
        public string Tiempo
        {
            get { return lblTiempo.Text; }
            private set { lblTiempo.Text = value; }
        }
        public bool EsElSiguiente
        {
            get { return esElSiguiente; }
            set { esElSiguiente = value;
            if (esElSiguiente)
                BackColor = Color.Green;
            else
                BackColor = SystemColors.Control;
            }
        }
        public void PonTiempo(NumericUpDown horas, NumericUpDown minutos)
        {
            Tiempo = horas.Value + ":" + minutos.Value;
        }
        public int Horas
        {
            get { return Convert.ToInt32(Tiempo.Split(':')[0]); }
        }
        public int Minutos
        {
            get { return Convert.ToInt32(Tiempo.Split(':')[1]); }
        }
        public TimeSpan DTiempo
        {
            get { return new TimeSpan(Horas, Minutos, 0); }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (Quitar != null)
                Quitar(this, e);
        }
        public override string ToString()
        {
            return "id:"+id;
        }
        public override bool Equals(object obj)
        {
            temporizador temp = obj as temporizador;
            if (temp != null)
                return temp.id == id;
            else
                return false;
        }
    }
}
