using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Reportes.Managers
{
    public class ManagerGeneral
    {



        public System.Byte[] ConvertBitmapToArray(System.Drawing.Bitmap Imagen, System.Drawing.Imaging.ImageFormat Formato)
        {

            System.Byte [] array = null;
            using (System.IO.MemoryStream str = new System.IO.MemoryStream())
            {
                Imagen.Save(str, Formato);
                array = str.ToArray();
            }

            return array;
        }

    }
}
