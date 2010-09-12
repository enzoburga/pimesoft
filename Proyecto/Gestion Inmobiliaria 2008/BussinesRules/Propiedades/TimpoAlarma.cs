using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class TiempoAlarma
    {
        public TiempoAlarma(TimeSpan Tiempo, string Descripcion)
        {
            tiempo = Tiempo;
            descripcion = Descripcion;
        }


        private TimeSpan tiempo;
        private string descripcion;


        public TimeSpan Tiempo
        {
            get { return tiempo; }
            set { tiempo = value; }
        }
        
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public override string ToString()
        {
            return Descripcion;
        }





    }


    public class TiemposAlarmaFactory
    {
    

        private List<TiempoAlarma> tiempos;

        public TiemposAlarmaFactory()
        {
            tiempos=new List<TiempoAlarma>();

            tiempos.Add(new TiempoAlarma(new TimeSpan(0, 15, 0), "15 Minutos"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(0, 30, 0), "30 Minutos"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(0, 45, 0), "45 Minutos"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(1, 0, 0), "1 Hora"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(2, 0, 0), "2 Horas"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(3, 0, 0), "3 Horas"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(4, 0, 0), "4 Horas"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(5, 0, 0), "5 Horas"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(12, 0, 0), "12 Horas"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(1, 0, 0, 0), "1 Día"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(2, 0, 0, 0), "2 Días"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(3, 0, 0, 0), "3 Días"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(4, 0, 0, 0), "4 Días"));
            tiempos.Add(new TiempoAlarma(new TimeSpan(5, 0, 0, 0), "5 Días"));






        }



        public List<TiempoAlarma> RecuperarTodos()
        {
            return tiempos;
        }


        public TiempoAlarma Recuperar(long ticks)
        {
            foreach (TiempoAlarma t in this.tiempos)
            {
                if (t.Tiempo.Ticks == ticks)
                    return t;
            }

            return null;
        }
    
    }
}
