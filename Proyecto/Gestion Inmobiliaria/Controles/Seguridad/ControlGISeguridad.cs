using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.Framework.Seguridad
{
    public partial class ControlGISeguridad : UserControl, Interfaces.ISoloLectura
    {

        private bool soloLectura;

        public ControlGISeguridad()
        {
            InitializeComponent();
        }

        #region ISoloLectura Members

        public virtual bool SoloLectura
        {
            get
            {
                return soloLectura;
            }
            set
            {
                soloLectura = value;
            }
        }

        public virtual bool AsignarSoloLectura(Control Ctrl)
        {
            if (Ctrl is System.Windows.Forms.TextBox)
            {
                return true;
            }

            if (Ctrl is System.Windows.Forms.DateTimePicker)
                return true;

            if (Ctrl is System.Windows.Forms.CheckBox)
                return true;

            if (Ctrl is Framework.ComboBox)
                return true;

            if (Ctrl is System.Windows.Forms.LinkLabel)
                return true;

            if (Ctrl is System.Windows.Forms.ListView)
                return true;


        
            return false;
        }

        public virtual void RefrezcarSoloLectura(System.Windows.Forms.Control.ControlCollection Controles)
        {
            foreach (System.Windows.Forms.Control c in Controles)
            {
                if (c is Interfaces.ISoloLectura)
                {
                    ((Interfaces.ISoloLectura)c).SoloLectura = this.SoloLectura;
                    ((Interfaces.ISoloLectura)c).RefrezcarSoloLectura(c.Controls);
                    continue;
                }

                if (AsignarSoloLectura(c))
                {
                    c.Enabled = !SoloLectura;
                }

                if (c.Controls.Count > 0)
                {
                    RefrezcarSoloLectura(c.Controls);
                }



            }
        }

        #endregion
    }
}
