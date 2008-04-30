using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Propiedades
{
    public class MngGaleriaFotos
    {


        public bool AgregarFotoAGaleria(GI.BR.Propiedades.Galeria.Foto Foto, GI.BR.Propiedades.Propiedad p)
        {



            try
            {

                if (Foto.EsFachada)
                {
                    foreach (GI.BR.Propiedades.Galeria.Foto f in p.GaleriaFotos)
                    {
                        if (f.EsFachada)
                        {
                            f.Eliminar();
                            break;
                        }
                    }
                }

                return Foto.Guardar(p);
            }
            catch 
            {
                return false;
            }
        
        
        
        }








    }
}
