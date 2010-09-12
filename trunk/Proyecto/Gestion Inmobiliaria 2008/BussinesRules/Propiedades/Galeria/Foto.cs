using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GI.BR.Propiedades.Galeria
{
    [Serializable]
    public class Foto
    {
        public Foto()
        { 
        
        }

        private int idFoto;
        private System.Drawing.Bitmap imagen;
        private bool esFachada;
        private string descripcion;

        public int IdFoto
        {
            get { return idFoto; }
            set { idFoto = value; }
        }
        

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        

        public bool EsFachada
        {
            get { return esFachada; }
            set { esFachada = value; }
        }
        
        [System.Xml.Serialization.XmlIgnore]
        public System.Drawing.Bitmap Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        private byte[] fotoArray;
        public byte[] FotoByteArray
        {
            get
            {
                if (fotoArray == null)
                {
                    if (Imagen == null) return null;

                    System.Byte[] array = null;
                    using (System.IO.MemoryStream str = new System.IO.MemoryStream())
                    {
                        Imagen.Save(str, System.Drawing.Imaging.ImageFormat.Jpeg);
                        array = str.ToArray();
                    }
                    fotoArray = array;
                }
                return fotoArray;
            }
            set
            {
                fotoArray = value;
            }
        }


        public void RecuperarPorId(int IdFoto)
        {
            this.IdFoto = IdFoto;
            using (System.Data.IDataReader dr = new DA.PropiedadesData().RecuperarFoto(this.IdFoto))
            {
                
                System.IO.MemoryStream ms;
                while (dr.Read())
                {
                    this.Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"));
                    this.EsFachada = dr.GetBoolean(dr.GetOrdinal("EsFachada"));
                   
                    ms = new System.IO.MemoryStream((byte[])dr.GetValue(dr.GetOrdinal("Foto")));
                    this.Imagen = new System.Drawing.Bitmap(ms);
                    
                }

            }
        }

        public bool Guardar(GI.BR.Propiedades.Propiedad p)
        {

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imgBytes = ms.GetBuffer();
                    imagen.Dispose();
                    ms.Close();


                    IdFoto = new DA.PropiedadesData().FotoGuardar(p.IdPropiedad, EsFachada, Descripcion, imgBytes);

                    return IdFoto > 0;
                }
            }
            catch(Exception ex)
            {

                return false;
            }
        }

        public bool Eliminar()
        {
            return new DA.PropiedadesData().FotoEliminar(this.IdFoto);
        }



        public override string ToString()
        {
            return Descripcion;
        }



    }
}
