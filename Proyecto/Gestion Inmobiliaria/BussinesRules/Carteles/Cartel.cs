using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Carteles
{
    public class Cartel
    {
        #region Miembros privados
        private int idCartel;
        private int alto;
        private int ancho;
        private DateTime fechaAlta;
        private DateTime fechaVencimiento;
        private Nullable<DateTime> fechaBaja;
        private GI.BR.Propiedades.Propiedad propiedad;
        private bool activo;
        private Type tipoCartel;
        
        #endregion

        #region Propiedades Publicas
        public int IdCartel { get { return idCartel; } set { idCartel = value; } }

        public int Alto { get { return alto; } set { alto = value; } }

        public int Ancho { get { return ancho; } set { ancho = value; } }

        public DateTime FechaAlta { get { return fechaAlta; } set { fechaAlta = value; } }

        public DateTime FechaVencimiento { get { return fechaVencimiento; } set { fechaVencimiento = value; } }

        public Nullable<DateTime> FechaBaja { get { return fechaBaja; } set { fechaBaja = value; } }

        public GI.BR.Propiedades.Propiedad Propiedad { get { return propiedad; } set { propiedad = value; } }

        public bool Activo { get { return activo; } set { activo = value; } }

        public Type TipoCartel { get { return tipoCartel; } set { tipoCartel = value; } } 
        #endregion

        #region Persistencia

        public bool Guardar()
        {
            DA.CartelesData cd = new GI.DA.CartelesData();
            this.IdCartel = cd.Guardar(this.Activo, this.Alto, this.Ancho, this.FechaAlta, this.FechaBaja, this.FechaVencimiento, this.Propiedad.IdPropiedad, this.TipoCartel);
            return this.IdCartel > 0;
        }

        public bool Actualizar()
        {
            DA.CartelesData cd = new GI.DA.CartelesData();
            return cd.Actualizar(this.IdCartel, this.Activo, this.Alto, this.Ancho, this.FechaAlta, this.FechaBaja, this.FechaVencimiento, this.Propiedad.IdPropiedad, this.TipoCartel);

        }

        public void fill(System.Data.IDataReader dr)
        {
            this.Activo = dr.GetBoolean(dr.GetOrdinal("Activo"));
            this.Alto = dr.GetInt32(dr.GetOrdinal("Alto"));
            this.Ancho = dr.GetInt32(dr.GetOrdinal("Ancho"));
            this.FechaAlta = dr.GetDateTime(dr.GetOrdinal("FechaAlta"));

            if (!dr.IsDBNull(dr.GetOrdinal("FechaBaja")))
                this.FechaBaja = dr.GetDateTime(dr.GetOrdinal("FechaBaja"));
            else
                this.FechaBaja = null;

            this.FechaVencimiento = dr.GetDateTime(dr.GetOrdinal("FechaVencimiento"));
            this.IdCartel = dr.GetInt32(dr.GetOrdinal("IdCartel"));
            this.TipoCartel = Type.GetType(dr.GetString(dr.GetOrdinal("TipoCartel")));

            if (TipoCartel == typeof(GI.BR.Propiedades.Alquiler))
            {
                this.Propiedad = new GI.BR.Propiedades.Alquiler();
            }
            else
            {
                this.Propiedad = new GI.BR.Propiedades.Venta();
            }

            this.propiedad.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));            
        }

        #endregion



    }
}
