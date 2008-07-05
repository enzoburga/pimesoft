using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Galeria
{
    public class GaleriaFotos : List<Foto>
    {

        public GaleriaFotos() { }


        public Foto GetFotoFachada
        {
            get 
            {
                
                foreach (Foto f in this)
                {
                    if (f.EsFachada)
                        return f;
                }

                return null;
            }
        }

        public void RecuperarPorPropiedad(Propiedad p)
        {
            Clear();

            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarGaleria(p.IdPropiedad))
            {
                Foto f;
                System.IO.MemoryStream ms;
                while (dr.Read())
                {
                    f = new Foto();
                    f.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    f.EsFachada = dr.GetBoolean(dr.GetOrdinal("EsFachada"));
                    f.IdFoto = dr.GetInt32(dr.GetOrdinal("IdFoto"));

                    ms = new System.IO.MemoryStream(  (byte[])dr.GetValue(dr.GetOrdinal("Foto")));
                    f.Imagen = new System.Drawing.Bitmap(ms);
                    Add(f);
                }
            
            }


        }



        public Foto GetFotoPorId(int IdFoto)
        {

                
                foreach (Foto f in this)
                {
                    if (f.IdFoto == IdFoto)
                        return f;
                }

                return null;
        }
    }
}
