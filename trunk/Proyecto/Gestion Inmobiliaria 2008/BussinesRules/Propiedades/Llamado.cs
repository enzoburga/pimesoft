using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Llamado
    {
        public Llamado() { }


        private int idLlamado;
        private int idPropiedad;
        private DateTime fechaHora;
        private string contacto;
        private string telefono;
        private string comentario;

        public int IdLlamado
        {
            get { return idLlamado; }
            set { idLlamado = value; }
        }
       

        public int IdPropiedad
        {
            get { return idPropiedad; }
            set { idPropiedad = value; }
        }
        


        public DateTime FechaHora
        {
            get { return fechaHora; }
            set { fechaHora = value; }
        }
       

        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

        public bool Guardar()
        {
            idLlamado = new DA.PropiedadesData().CrearLlamado(
                FechaHora,
                Contacto,
                Telefono,
                Comentario,
                IdPropiedad);
            return IdLlamado > 0;
        }

        public bool Actualizar()
        {
            return new DA.PropiedadesData().ActualizarLlamado(
                FechaHora,
                Contacto,
                Telefono,
                Comentario,
                IdLlamado);
        }

        public bool Eliminar()
        {
            return new DA.PropiedadesData().EliminarLlamado(IdLlamado);
        }


    }
}
