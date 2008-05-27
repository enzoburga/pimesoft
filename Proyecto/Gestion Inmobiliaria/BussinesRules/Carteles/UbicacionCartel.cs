using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Carteles
{
    public class UbicacionCartel
    {
        private int idUbicacionCartel;
        private string descripcion;

        public int IdUbicacionCartel { get { return idUbicacionCartel; } set { idUbicacionCartel = value; } }

        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public void fill(System.Data.IDataReader dr)
        {
            this.IdUbicacionCartel = dr.GetInt32(dr.GetOrdinal("IdUbicacionCartel"));
            this.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
        }

        public override string ToString()
        {
            return descripcion.ToString();
        }
    }
}
