using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GI.BR.Propiedades.Galeria
{
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
        

        public System.Drawing.Bitmap Imagen
        {
            get { return imagen; }
            set { imagen = value; }
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
