using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Avisador
{
    public delegate void HoraSiguienteEventHandler(string hora, int segundosRestantes);
    public delegate void TemporizadorEventHandler(temporizador temp);
    public partial class ListaTemporizadores : UserControl
    {
        List<temporizador> temporitzadors;

        Semaphore semafor;
        public event TemporizadorEventHandler TemporizadorSiguiente;
        public event HoraSiguienteEventHandler Hora;
    
        public ListaTemporizadores()
        {
            InitializeComponent();
            semafor = new Semaphore(1, 1);
            temporitzadors = new List<temporizador>();
            pnlTemp.BringToFront();
            pnlTemp.AutoScroll = true;
        }

        public string HoraSiguiente()
        {
            Actual.EsElSiguiente = false;
            temporizador temporizadorS = Siguiente;
            temporizadorS.EsElSiguiente = true;
            string hora = (DateTime.Now + temporizadorS.DTiempo).ToShortTimeString();
            if (Hora != null)
                Hora(hora, Convert.ToInt32(temporizadorS.DTiempo.TotalSeconds));
            if (TemporizadorSiguiente != null)
                TemporizadorSiguiente(Siguiente);
            return hora;

        }
        public void PonerTemporizador(temporizador temporizador)
        {
            
            Actual.EsElSiguiente = false;
            temporizador.EsElSiguiente = true;
            if (Hora != null)
                Hora((DateTime.Now + temporizador.DTiempo).ToShortTimeString(), Convert.ToInt32(temporizador.DTiempo.TotalSeconds));
            if (TemporizadorSiguiente != null)
                TemporizadorSiguiente(Siguiente);
        }
        public void Añadir(temporizador temporizador)
        {
            semafor.WaitOne();
            pnlTemp.Controls.Add(temporizador);
            if (temporitzadors.Count != 0)
                temporizador.Location = new Point(0, temporizador.Height + temporitzadors[temporitzadors.Count - 1].Location.Y);
            else
            {
                temporizador.Location = new Point(0, 0);
                temporizador.EsElSiguiente = true;
            }
            temporizador.Click += new EventHandler(SeleccionaTempEvent);
            temporitzadors.Add(temporizador);
            temporizador.Quitar += new EventHandler(QuitarEvent);
            if (TemporizadorSiguiente != null)
                TemporizadorSiguiente(Siguiente);
            semafor.Release();

        }

        private void SeleccionaTempEvent(object sender, EventArgs e)
        {
            PonerTemporizador(sender as temporizador);
        }
        public void Reset()
        { pnlTemp.Controls.Clear(); temporitzadors.Clear(); semafor = new Semaphore(1, 1); }
        private void QuitarEvent(object sender, EventArgs e)
        {
            Avisador.temporizador temp = sender as temporizador;
            if (temp != null)
            {
                temp.Quitar -= QuitarEvent;
                Quitar(temp);
            }
        }
        public void Quitar(temporizador temporitzador)
        {
            semafor.WaitOne();
            temporizador temSeg = null;
            if (temporitzador.EsElSiguiente)
            {

                HoraSiguiente();
                temSeg = Siguiente;
                temSeg.EsElSiguiente = true;
                if (Hora != null)
                    Hora((DateTime.Now + temSeg.DTiempo).ToShortTimeString(), Convert.ToInt32(temSeg.DTiempo.TotalSeconds));
            }
            temporitzadors.Remove(temporitzador);
            pnlTemp.Controls.Remove(temporitzador);
            Avisador.temporizador tempAnt = new temporizador();
            tempAnt.Location = new Point(0, -tempAnt.Height);
            for (int i = 0; i < temporitzadors.Count; i++)
            {
                temporitzadors[i].Location = new Point(temporitzadors[i].Location.X, tempAnt.Height + tempAnt.Location.Y);
                tempAnt = temporitzadors[i];
            }
            if (TemporizadorSiguiente != null)
                TemporizadorSiguiente(Siguiente);
            semafor.Release();

        }



        public temporizador Siguiente
        {
            get
            {
                try
                {
                    return temporitzadors[IndexSiguiente];
                }
                catch { return null; }
            }


        }
        private int IndexSiguiente
        {
            get
            {
                int indexSeg = IndexActual;
                if (indexSeg == temporitzadors.Count - 1)
                    indexSeg = 0;
                else
                    indexSeg++;
                return indexSeg;
            }
        }
        public temporizador Actual
        {
            get
            {

                return temporitzadors[IndexActual];
            }
        }
        private int IndexActual
        {
            get
            {
                int index = -1;
                for (int i = 0; i < temporitzadors.Count && index == -1; i++)
                    if (temporitzadors[i].EsElSiguiente)
                        index = i;
                return index;
            }
        }

    }

}
