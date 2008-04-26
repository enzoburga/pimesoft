using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Generales
{
    public partial class CtrlDireccion : Framework.Seguridad.ControlGISeguridad
    {

        public CtrlDireccion()
        {
            InitializeComponent();
        }

        private GI.BR.Propiedades.Direccion direccion;

        public GI.BR.Propiedades.Direccion Direccion
        {
            get { return direccion; }
            set
            { 
                direccion = value;
                if (direccion != null)
                    direccionBindingSource.Add(direccion);
            }
        }






    }
}
