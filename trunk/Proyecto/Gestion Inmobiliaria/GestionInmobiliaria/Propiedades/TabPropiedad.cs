using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabPropiedad :  TabContenidoPropiedad
    {
        public TabPropiedad() : base()
        {
            InitializeComponent();
            
        }



        protected override void Inicializar()
        {


            #region inicializar combos
            GI.BR.Propiedades.CategoriasPropiedad Categorias = new GI.BR.Propiedades.CategoriasPropiedad();
            Categorias.RecuperarTodas();
            foreach (GI.BR.Propiedades.CategoriaPropiedad Cat in Categorias)
            {
                cbCategoria.Items.Add(Cat);
            }
            cbCategoria.SelectedIndex = 0;


            GI.BR.Propiedades.EstadosPropiedad Estados = new GI.BR.Propiedades.EstadosPropiedad();
            Estados.RecuperarEstados(Propiedad.GetType());
            foreach (GI.BR.Propiedades.EstadoPropiedad Estado in Estados)
                cbEstado.Items.Add(Estado);
            cbEstado.SelectedIndex = 0;

            GI.BR.Monedas.Monedas Monedas = new GI.BR.Monedas.Monedas();
            Monedas.RecuperarTodas();
            foreach (GI.BR.Monedas.Moneda M in Monedas)
            {
                cbMonedaPublicacion.Items.Add(M);
                cbMonedaReal.Items.Add(M);
            }
            cbMonedaReal.SelectedIndex = cbMonedaPublicacion.SelectedIndex = 0;


            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.AEstrenar);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.AReciclar);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.Bueno);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.Malo);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.NoEspecifica);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.Reciclado);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.Regular);
            cbEstadoProp.SelectedIndex = 0;

            GI.BR.Propiedades.Ambientes ambientes = new GI.BR.Propiedades.Ambientes();
            ambientes.RecuperarTodos();
            foreach (GI.BR.Propiedades.Ambiente a in ambientes)
                cbAmbientes.Items.Add(a);

            #endregion


            //databondig
            propiedadBindingSource.Add(Propiedad);
            valorBindingSource.Add(Propiedad.ValorPublicacion);
            valorBindingSource1.Add(Propiedad.ValorMercado);
            direccionBindingSource.Add(Propiedad.Direccion);

            foreach (GI.BR.Propiedades.Ambiente a in cbAmbientes.Items)
            {
                if (a.CantidadAmbientes == Propiedad.CantidadAmbientes)
                    cbAmbientes.SelectedItem = a;
            }


            if (Propiedad.Propietario == null)
                LinkPropietario.Text = "Seleccione un propietario";
            else
            {
                LinkPropietario.Text = Propiedad.Propietario.ToString();

            }
        }

        protected override void CargarPropiedad()
        {
            base.CargarPropiedad();
        }


        public override bool AsignarSoloLectura(Control Ctrl)
        {
            if (Ctrl.Name == "LinkPropietario")
                return false;

            return base.AsignarSoloLectura(Ctrl);
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem == null) return;

            GI.BR.Propiedades.TiposPropiedad tipos = ((GI.BR.Propiedades.CategoriaPropiedad)cbCategoria.SelectedItem).TiposPropiedad;
            cbTipoPropiedad.Items.Clear();

            foreach (GI.BR.Propiedades.TipoPropiedad tipo in tipos)
            {
                cbTipoPropiedad.Items.Add(tipo);
            }

            cbTipoPropiedad.SelectedIndex = 0;
        }

        private void textBoxEntreCalle2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAmbientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAmbientes.SelectedItem == null) return;

            Propiedad.CantidadAmbientes = ((GI.BR.Propiedades.Ambiente)cbAmbientes.SelectedItem).CantidadAmbientes;

        }

        private void LinkPropietario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (LinkPropietario.Text == "Seleccione un propietario")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorClientes(typeof(GI.BR.Propietario)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                { 
                
                
                }
            
            }


        }



        
    }
}
