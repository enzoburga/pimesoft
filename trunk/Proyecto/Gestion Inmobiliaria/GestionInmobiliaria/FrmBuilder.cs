using System;
using System.Collections.Generic;
using System.Text;

namespace GI.UI
{
    public class FrmBuilder
    {


        #region Constructor

        public FrmBuilder(System.Windows.Forms.Form Parent)
        {
            parent = Parent;
        }

        #endregion

        #region miembros estaticas. Hash con los formularios activos

        private static System.Collections.Hashtable hashForms = new System.Collections.Hashtable();

        #endregion

        #region miembros

        private System.Windows.Forms.Form parent;

        #endregion


        #region metodos publicos

        /// <summary>
        /// Llamamos a este metodo pasandole un formulario no tener mas de una instancia por form
        /// </summary>
        /// <param name="frm"></param>
        public void AbrirFormulario(string Type)
        {

            System.Windows.Forms.Form frm;

            if ((frm = (System.Windows.Forms.Form)FrmBuilder.hashForms[Type]) == null)
            {
                frm = MostrarFormPorClaveSeguridad(Type);
                if (frm == null) return;

                frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frm_FormClosed);
                FrmBuilder.hashForms[Type] = frm;
                return;
            }

            // el Formulario para este caso de uso ya esta abierto. lo llevamos al frente.
            if ( frm.WindowState == System.Windows.Forms.FormWindowState.Minimized )
                frm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            frm.BringToFront();



        }


        #endregion

        /// <summary>
        /// Eliminamos nuestra referencia al formulario cuando lo cierran.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            FrmBuilder.hashForms[((System.Windows.Forms.Form)sender).GetType().ToString()] = null;

        }

        public System.Windows.Forms.Form MostrarFormPorClaveSeguridad(string Type)
        {

            if (Type == "GI.UI.Propiedades.FrmListadoPropiedades")
            {
                GI.UI.Propiedades.FrmListadoPropiedades FrmPropsVenta = new GI.UI.Propiedades.FrmListadoPropiedades(typeof(GI.BR.Propiedades.Venta));
                FrmPropsVenta.MdiParent = this.parent;
                FrmPropsVenta.Show();
                return FrmPropsVenta;
            }


            return null;
        }



    }
}
