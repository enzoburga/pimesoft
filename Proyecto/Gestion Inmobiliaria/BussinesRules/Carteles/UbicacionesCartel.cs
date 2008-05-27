using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Carteles
{
    public class UbicacionesCartel : List<UbicacionCartel>
    {
        public void RecuperarUbicaciones()
        {
            this.Clear();
            UbicacionCartel uc;
            using (System.Data.IDataReader dr = new GI.DA.UbicacionCartelData().RecuperarTodas())
            {
                while (dr.Read())
                {
                    uc = new UbicacionCartel();
                    uc.fill(dr);
                    this.Add(uc);
                }
            }
        }
    }
}
