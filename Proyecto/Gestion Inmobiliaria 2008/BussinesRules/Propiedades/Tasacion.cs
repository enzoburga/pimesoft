using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades
{
    public class Tasacion
    {

        public Tasacion() { }

        private int idTasacion;
        private int idPropiedad;
        private DateTime fecha;
        private Valor valorPublicacion;
        private Valor valorReal;
        private string comentarios;

        public int IdTasacion
        {
            get { return idTasacion; }
            set { idTasacion = value; }
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


        public Valor ValorReal
        {
            get { return valorReal; }
            set { valorReal = value; }
        }
        

        public string Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }

        public bool Crear()
        {
            IdTasacion = new DA.PropiedadesData().CrearTasacion(
                IdPropiedad,
                Fecha,
                ValorReal.Importe,
                ValorPublicacion.Importe,
                ValorReal.Moneda.IdMoneda,
                ValorPublicacion.Moneda.IdMoneda,
                Comentarios);

            return IdTasacion > 0;
        }

        public bool Eliminar()
        {
            return new DA.PropiedadesData().EliminarTasacion(IdTasacion);
        }

        public bool Modificar()
        {
            return new DA.PropiedadesData().ActualizarTasacion(
                IdTasacion,
                Fecha,
                ValorReal.Importe,
                ValorPublicacion.Importe,
                ValorReal.Moneda.IdMoneda,
                ValorPublicacion.Moneda.IdMoneda,
                Comentarios);

        }


        

    }
}
