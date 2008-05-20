using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Publicacion
    {
        public Publicacion() { }

        private int idPublicacion;
        private int idPropiedad;
        private DateTime fecha;
        private Valor valorPublicacion;
        private string medio;
        private string detalles;

        public int IdPublicacion
        {
            get { return idPublicacion; }
            set { idPublicacion = value; }
        }
       


        public int IdPropiedad
        {
            get { return idPropiedad; }
            set { idPropiedad = value; }
        }
        
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        

        public Valor ValorPublicacion
        {
            get { return valorPublicacion; }
            set { valorPublicacion = value; }
        }
        

        public string Medio
        {
            get { return medio; }
            set { medio = value; }
        }
        

        public string Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }


        public bool Crear()
        {
            IdPublicacion = new DA.PropiedadesData().CrearPublicacion(
                IdPropiedad,
                Medio,
                Detalles,
                Fecha,
                ValorPublicacion.Moneda.IdMoneda,
                ValorPublicacion.Importe);

            return IdPropiedad > 0;
        }

        public bool Actualizar()
        {
            return new DA.PropiedadesData().ActualizarPublicacion(
                IdPropiedad,
                Medio,
                Detalles,
                Fecha,
                ValorPublicacion.Moneda.IdMoneda,
                ValorPublicacion.Importe);
        }

        public bool Eliminar()
        {
            return new DA.PropiedadesData().EliminarPublicacion(IdPublicacion);
        }




    }
}
