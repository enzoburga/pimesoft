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
        private GI.BR.Propiedades.Propiedad propiedad;
        private bool activo;
        private Type tipoCartel;
        private UbicacionCartel ubicacionCartel;
        
        #endregion

        #region Propiedades Publicas
        public int IdCartel { get { return idCartel; } set { idCartel = value; } }

        public int Alto { get { return alto; } set { alto = value; } }

        public int Ancho { get { return ancho; } set { ancho = value; } }

        public DateTime FechaAlta { get { return fechaAlta; } set { fechaAlta = value; } }

        public DateTime FechaVencimiento { get { return fechaVencimiento; } set { fechaVencimiento = value; } }

        public GI.BR.Propiedades.Propiedad Propiedad { get { return propiedad; } set { propiedad = value; } }

        public bool Activo { get { return activo; } set { activo = value; } }

        public Type TipoCartel { get { return tipoCartel; } set { tipoCartel = value; } }

        public UbicacionCartel UbicacionCartel { get { return ubicacionCartel; } set { ubicacionCartel = value; } }
        #endregion

        #region Persistencia

        public bool Guardar()
        {
            DA.CartelesData cd = new GI.DA.CartelesData();
            this.IdCartel = cd.Guardar(this.Activo, this.Alto, this.Ancho, this.FechaAlta, this.FechaVencimiento, this.Propiedad.IdPropiedad, this.TipoCartel, this.ubicacionCartel.IdUbicacionCartel);
            return this.IdCartel > 0;
        }

        public bool Actualizar()
        {
            DA.CartelesData cd = new GI.DA.CartelesData();
            return cd.Actualizar(this.IdCartel, this.Activo, this.Alto, this.Ancho, this.FechaAlta, this.FechaVencimiento, this.Propiedad.IdPropiedad, this.TipoCartel, this.ubicacionCartel.IdUbicacionCartel);

        }

        public void fill(System.Data.IDataReader dr)
        {
            this.Activo = dr.GetBoolean(dr.GetOrdinal("Activo"));
            this.Alto = dr.GetInt32(dr.GetOrdinal("Alto"));
            this.Ancho = dr.GetInt32(dr.GetOrdinal("Ancho"));
            this.FechaAlta = dr.GetDateTime(dr.GetOrdinal("FechaAlta"));
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
            this.ubicacionCartel = UbicacionesCartelFlyweigthFactory.GetInstancia.GetUbicacionCartel(dr.GetInt32(dr.GetOrdinal("IdUbicacionCartel")));
        }

        #endregion



    }
}
