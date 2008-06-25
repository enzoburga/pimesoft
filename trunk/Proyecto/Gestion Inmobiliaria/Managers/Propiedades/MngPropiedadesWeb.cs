using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Propiedades
{
    public class MngPropiedadesWeb
    {

        public bool GuardarPropiedad(GI.BR.Propiedades.Propiedad p)
        {

            return p.Guardar();
        }

        public bool ActualizarPropiedad(GI.BR.Propiedades.Propiedad p)
        {
            return p.Actualizar();


        }


        public bool EliminarFotoGaleria(int IdFoto)
        {
            GI.BR.Propiedades.Galeria.Foto foto = new GI.BR.Propiedades.Galeria.Foto();
            foto.IdFoto = IdFoto;

            return foto.Eliminar();


        }


        public bool AgregarFotoAGaleria(GI.BR.Propiedades.Galeria.Foto Foto, GI.BR.Propiedades.Propiedad p)
        { 
            


            //Si la foto es fachada, eliminamos la fachada anterior.
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

            if (!Foto.Guardar(p))
                return false;

            return true;
        }



    }
}
