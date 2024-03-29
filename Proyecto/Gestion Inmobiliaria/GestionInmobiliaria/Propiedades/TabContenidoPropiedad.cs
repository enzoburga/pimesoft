using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabContenidoPropiedad : Framework.Seguridad.ControlGISeguridad
    {

        private GI.BR.Propiedades.Propiedad _Propiedad;
        public virtual event EventHandler onSolicitarGuardarFicha;



        public TabContenidoPropiedad()
        {
            InitializeComponent();
            
        }

        public GI.BR.Propiedades.Propiedad Propiedad
        {
            get { return _Propiedad; }
            set 
            {
                _Propiedad = value;
                Inicializar();
                CargarPropiedad();
            }
        }

        protected virtual void Inicializar()
        {
            return;
        }

        protected virtual void CargarPropiedad()
        {
            return;
        }


        public virtual GI.BR.Propiedades.Propiedad GetPropiedad()
        {
            return Propiedad;
        }


    }
}
