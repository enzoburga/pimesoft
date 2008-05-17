using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class VisitaPropiedad
    {

        public VisitaPropiedad() 
        {
            
        
        }

        private int idVisita;
        private DateTime fechaHora;
        private bool realizada;
        private TiempoAlarma tiempoAlarma;
        private string visita;
        private string telefonoContacto;
        private string detalles;
        private int idPropiedad;
        private bool conAlarma;

        public int IdPropiedad
        {
            get { return idPropiedad; }
            set { idPropiedad = value; }
        }


        public int IdVisita
        {
            get { return idVisita; }
            set { idVisita = value; }
        }
        

        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }
        

        public bool ConAlarma
        {
            get { return conAlarma; }
            set { conAlarma = value; }
        }
        

        public bool Realizada
        {
            get { return realizada; }
            set { realizada = value; }
        }


        public TiempoAlarma TiempoAlarma
        {
            get { return tiempoAlarma; }
            set { tiempoAlarma = value; }
        }
        

        public string Visita
        {
            get { return visita; }
            set { visita = value; }
        }
        

        public string TelefonoContacto
        {
            get { return telefonoContacto; }
            set { telefonoContacto = value; }
        }
        

        public string Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }




        public bool Guardar()
        {
            return false;
        }

        public bool Actualizar()
        { return false; }

        public bool Eliminar()
        { return false; }






    }
}
