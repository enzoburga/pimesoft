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
        public TabPropiedad()
        {
            InitializeComponent();
            
        }


        public override GI.BR.Propiedades.Propiedad GetPropiedad()
        {
            Propiedad.Ubicacion = ctrlUbicacion1.Ubicacion;
            Propiedad.EsOtraInmobiliaria = checkBoxEsOtraPropiedad.Checked;


            return Propiedad;
        }

        #region Inicializar

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
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.MuyBueno);
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



        }

        protected override void CargarPropiedad()
        {

            if (Propiedad.GetType() == typeof(GI.BR.Propiedades.Venta))
            {
                cbMonedaPublicacion.SelectedIndex = 1;
                cbMonedaReal.SelectedIndex = 1;
            }
            
            if (Propiedad.IdPropiedad == 0)
            {
                Propiedad.TipoPropiedad = (GI.BR.Propiedades.TipoPropiedad)cbTipoPropiedad.SelectedItem;
                Propiedad.Estado = (GI.BR.Propiedades.EstadoPropiedad)cbEstado.SelectedItem;
                Propiedad.ValorPublicacion = new GI.BR.Valor();
                Propiedad.ValorPublicacion.Importe = 0;
                Propiedad.ValorPublicacion.Moneda = (GI.BR.Monedas.Moneda)cbMonedaPublicacion.SelectedItem;
                Propiedad.ValorMercado = new GI.BR.Valor();
                Propiedad.ValorMercado.Importe = 0;
                Propiedad.ValorMercado.Moneda = (GI.BR.Monedas.Moneda)cbMonedaReal.SelectedItem;
                Propiedad.EnumEstado = GI.BR.Propiedades.Estado.AEstrenar;
                Propiedad.CantidadAmbientes = 1;
                Propiedad.Medidas = new GI.BR.Propiedades.MedidasAmbiente();

                Propiedad.Direccion = new GI.BR.Propiedades.Direccion();

               

            }

            lvMedidas.Items.Clear();
            foreach (GI.BR.Propiedades.MedidaAmbiente medidaAmb in Propiedad.Medidas)
            {
                ListViewItem item = new ListViewItem();
                item.Text = medidaAmb.ToString();
                item.SubItems.Add(medidaAmb.Ancho.ToString());
                item.SubItems.Add(medidaAmb.Largo.ToString());
                item.SubItems.Add(medidaAmb.TipoDePiso.ToString());
                item.Tag = medidaAmb;
                lvMedidas.Items.Add(item);
            }


            propiedadBindingSource.Add(Propiedad);
            valorBindingSource.Add(Propiedad.ValorPublicacion);
            valorBindingSource1.Add(Propiedad.ValorMercado);
            direccionBindingSource.Add(Propiedad.Direccion);

            ctrlUbicacion1.Inicializar();
            if (Propiedad.IdPropiedad != 0)
                ctrlUbicacion1.Ubicacion = Propiedad.Ubicacion;

            ctrlDireccion1.Direccion = Propiedad.Direccion;

            foreach (GI.BR.Propiedades.Ambiente a in cbAmbientes.Items)
            {
                if (a.CantidadAmbientes == Propiedad.CantidadAmbientes)
                    cbAmbientes.SelectedItem = a;
            }

            if (Propiedad.IdPropiedad > 0)
                checkBoxEsOtraPropiedad.Enabled = false;

            if (Propiedad.Propietario == null)
            {

                LinkPropietario.Text = "Seleccione un propietario";
            }
            else
            {
                LinkPropietario.Text = Propiedad.Propietario.ToString();

            }


            if (Propiedad.EsOtraInmobiliaria)
            {
                linkLabelOtraInmb.Enabled = true;
                
                if (Propiedad.Inmobiliaria != null)
                {
                    linkLabelOtraInmb.Text = Propiedad.Inmobiliaria.Nombre;
                }
                else
                    linkLabelOtraInmb.Text = "Seleccione una inmobiliaria";
            }
            else
            {
                linkLabelOtraInmb.Text = GI.BR.Inmobiliaria.GetInmobiliaria().Nombre;
                linkLabelOtraInmb.Enabled = false;
            }
           

            GI.BR.Propiedades.Galeria.Foto foto = null;
            if ((foto = Propiedad.GaleriaFotos.GetFotoFachada) != null)
            {
                pictureBoxFechada.Image = foto.Imagen;

            }


            Propiedad.onCambioValorPropiedad += new GI.BR.Propiedades.DelegateCambioValorPropiedad(Propiedad_onCambioValorPropiedad);
            
        }

        public void Propiedad_onCambioValorPropiedad(GI.BR.Propiedades.Propiedad Propiedad)
        {
            CargarPropiedad();
        }

        #endregion

        #region Seguridad

        public override bool AsignarSoloLectura(Control Ctrl)
        {

            if (Ctrl.Name == "lvMedidas")
                return false;

            if (Ctrl.Name == "LinkPropietario" && Ctrl.Text != "Seleccione un propietario")
                return false;

            if (Ctrl.Name == "linkLabelOtraInmb" && Propiedad.EsOtraInmobiliaria && Ctrl.Text != "Seleccione una inmobiliaria")
                return false;

            return base.AsignarSoloLectura(Ctrl);
        }


        #endregion

        #region eventos

        private void linkLabelOtraInmb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabelOtraInmb.Text == "Seleccione una inmobiliaria")
            {
                GI.UI.Inmobiliarias.SeleccionadorInmobiliariaExterna seleccionador = new GI.UI.Inmobiliarias.SeleccionadorInmobiliariaExterna();
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(seleccionador);
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    linkLabelOtraInmb.Tag = (GI.BR.InmobiliariaExterna)frmSeleccionador.ObjetoSeleccionado;
                    linkLabelOtraInmb.Text = frmSeleccionador.ObjetoSeleccionado.ToString();
                }

            }
            else
            {
                if (linkLabelOtraInmb.Tag != null)
                {
                    Inmobiliarias.FrmInmobiliariaExterna frm = new Inmobiliarias.FrmInmobiliariaExterna((GI.BR.InmobiliariaExterna)linkLabelOtraInmb.Tag);
                    frm.SoloLectura = SoloLectura;
                    
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        linkLabelOtraInmb.Text = linkLabelOtraInmb.Tag.ToString();
                    }

                }
            }
            
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

        public void CambiarInmobiliaria()
        {
            if (SoloLectura)
            {
                Framework.General.GIMsgBox.Show("La ficha se encuentra en modo solo lectura", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            if (Propiedad.EsOtraInmobiliaria)
            {
                GI.UI.Inmobiliarias.SeleccionadorInmobiliariaExterna seleccionador = new GI.UI.Inmobiliarias.SeleccionadorInmobiliariaExterna();
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(seleccionador);
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    linkLabelOtraInmb.Tag = (GI.BR.InmobiliariaExterna)frmSeleccionador.ObjetoSeleccionado;
                    linkLabelOtraInmb.Text = frmSeleccionador.ObjetoSeleccionado.ToString();
                    Propiedad.Inmobiliaria = (GI.BR.InmobiliariaExterna)frmSeleccionador.ObjetoSeleccionado;
                }
            }
            else
            {
                Framework.General.GIMsgBox.Show("La propiedad no esta marcada como de otra Inmobiliaria", GI.Framework.General.enumTipoMensaje.Informacion);

            }
        }

        public void CambiarPropietario()
        {

            if (SoloLectura)
            {
                Framework.General.GIMsgBox.Show("La ficha se encuentra en modo solo lectura", GI.Framework.General.enumTipoMensaje.Advertencia);
                return;
            }

            Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(typeof(GI.BR.Clientes.Propietario)));
            if (frmSeleccionador.ShowDialog() == DialogResult.OK)
            {
                LinkPropietario.Tag = (GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado;
                LinkPropietario.Text = frmSeleccionador.ObjetoSeleccionado.ToString();
                Propiedad.Propietario = (GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado;
            }
        }

        private void LinkPropietario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (LinkPropietario.Text == "Seleccione un propietario")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(typeof(GI.BR.Clientes.Propietario)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkPropietario.Tag = (GI.BR.Clientes.Propietario)frmSeleccionador.ObjetoSeleccionado;
                    LinkPropietario.Text = frmSeleccionador.ObjetoSeleccionado.ToString();
                }

            }
            else
            {
                if (LinkPropietario.Tag != null)
                {
                    Clientes.frmFichaCliente frm = new GI.UI.Clientes.frmFichaCliente();
                    frm.SoloLectura = SoloLectura;
                    frm.Cliente = (GI.BR.Clientes.Cliente)LinkPropietario.Tag;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LinkPropietario.Text = frm.Cliente.ToString();
                    }

                }
            }


        }

        private void linkLabelAgregarMedida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GI.BR.Propiedades.MedidaAmbiente medidaAmb = new GI.BR.Propiedades.MedidaAmbiente();

            Formularios.FrmMedida frm = new GI.UI.Propiedades.Formularios.FrmMedida();
            frm.Medida = medidaAmb;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Propiedad.Medidas.Add(medidaAmb);
                ListViewItem item = new ListViewItem();
                item.Text = medidaAmb.ToString();
                item.SubItems.Add(medidaAmb.Ancho.ToString());
                item.SubItems.Add(medidaAmb.Largo.ToString());
                item.SubItems.Add(medidaAmb.TipoDePiso.ToString());
                item.Tag = medidaAmb;
                lvMedidas.Items.Add(item);

            }
        }


        private GI.BR.Propiedades.MedidasAmbiente ambientesAEliminar = new GI.BR.Propiedades.MedidasAmbiente();

        public GI.BR.Propiedades.MedidasAmbiente AmbientesAEliminar
        {
            get { return ambientesAEliminar; }

        }
        private void linkLabelEliminarMedida_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvMedidas.SelectedItems.Count != 1) return;
            if (Framework.General.GIMsgBox.Show("�Confirma eliminar la medida de ambiente seleccionada?", GI.Framework.General.enumTipoMensaje.Pregunta) == DialogResult.Yes)
            {
                GI.BR.Propiedades.MedidaAmbiente medida = (GI.BR.Propiedades.MedidaAmbiente)lvMedidas.SelectedItems[0].Tag;
                Propiedad.Medidas.Remove(medida);
                lvMedidas.Items.RemoveAt(lvMedidas.SelectedIndices[0]);
                ambientesAEliminar.Add(medida);

            }
        }

        private void cbTipoPropiedad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkBoxEsOtraPropiedad_CheckedChanged(object sender, EventArgs e)
        {
            linkLabelOtraInmb.Tag = null;

            if (!checkBoxEsOtraPropiedad.Checked)
            {
                linkLabelOtraInmb.Text = GI.BR.Inmobiliaria.GetInmobiliaria().Nombre;
                linkLabelOtraInmb.Enabled = false;


            }
            else
            {
                linkLabelOtraInmb.Enabled = true;
                if (Propiedad.Inmobiliaria == null)
                {
                    linkLabelOtraInmb.Text = "Seleccione una inmobiliaria";

                }
                else
                    linkLabelOtraInmb.Text = Propiedad.Inmobiliaria.Nombre;
            }
        }




        #endregion

       
        
    }
}
