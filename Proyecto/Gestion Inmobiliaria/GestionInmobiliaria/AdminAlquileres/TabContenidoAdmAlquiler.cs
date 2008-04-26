using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.AdminAlquileres
{
    public partial class TabContenidoAdmAlquiler : Framework.Seguridad.ControlGISeguridad
    {
        public TabContenidoAdmAlquiler()
        {
            InitializeComponent();
        }

        private GI.BR.AdmAlquileres.AdmAlquiler admAlquiler;


        public GI.BR.AdmAlquileres.AdmAlquiler AdmAlquiler
        {
            get { return admAlquiler; }
            set 
            {
                admAlquiler = value;
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
    }
}
