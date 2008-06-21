using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class TabDatosPrincipales : TabContenidoPedidos
    {
        public TabDatosPrincipales()
        {
            InitializeComponent();
        }

        private bool validado = false;

        public override GI.BR.Pedidos.Pedido getPedido()
        {
            if (cbTipoPropiedad.SelectedItem.ToString() == "Sin Definir")
                Pedido.TipoPropiedad = null;
            else
                Pedido.TipoPropiedad = (GI.BR.Propiedades.TipoPropiedad)cbTipoPropiedad.SelectedItem;

            if (cbDisposicion.SelectedIndex == 0)
                Pedido.Disposicion = null;
            else
                Pedido.Disposicion = (GI.BR.Propiedades.DepartamentoDisposicion)cbDisposicion.SelectedItem;

            switch (cbEsAptoProfesional.SelectedItem.ToString())
            {
                case "Sin Definir": Pedido.EsAptoProfesional = null; break;
                case "Si": Pedido.EsAptoProfesional = true; break;
                case "No": Pedido.EsAptoProfesional = false; break;
            }


            if (cbTipoZona.SelectedIndex == 0)
                Pedido.TipoZona = null;
            else
                Pedido.TipoZona = (GI.BR.Propiedades.TipoZona)cbTipoZona.SelectedItem;

            if (cbAmbientesFinal.SelectedIndex == 0)
                Pedido.CantidadAmbientesFinal = null;
            else
                Pedido.CantidadAmbientesFinal = (GI.BR.Propiedades.Ambiente)cbAmbientesFinal.SelectedItem;

            if (cbAmbientesInicial.SelectedIndex == 0)
                Pedido.CantidadAmbientesInicial = null;
            else
                Pedido.CantidadAmbientesInicial = (GI.BR.Propiedades.Ambiente)cbAmbientesInicial.SelectedItem;

            if (cbMoneda.SelectedIndex == 0)
                Pedido.Moneda = null;
            else
                Pedido.Moneda = (GI.BR.Monedas.Moneda)cbMoneda.SelectedItem;

            this.Pedido.Ubicacion = ctrlUbicacion1.Ubicacion;

            this.Pedido.Observaciones = tbObervaciones.Text;

            this.Pedido.Activo = !checkBox1.Checked; 

            return Pedido;

        }


        public override bool AsignarSoloLectura(Control Ctrl)
        {
            if (Ctrl.Name == "LinkContacto" && Ctrl.Text != "Seleccione un contacto")
                return false;
            
            if (Ctrl.Name == "LinkPropiedad" && Ctrl.Text != "Seleccione una Propiedad")
                return false;

            return base.AsignarSoloLectura(Ctrl);
        }

        public void Validar()
        {
            if (validado)
                return;


            
            if (tbValorDesde.Text != "0" || tbValorHasta.Text != "0")
                if (cbMoneda.SelectedIndex == 0)
                    throw new Exception("Debe seleccionar una moneda.");

            if( Pedido.ClientePedido == null)
                throw new Exception("Debe seleccionar un contacto.");

            if (int.Parse(tbValorDesde.Text) <0)
                throw new Exception("El valor inicial debe ser mayor a 0.");

            if (int.Parse(tbValorHasta.Text) < 0)
                throw new Exception("El valor final debe ser mayor a 0.");

            if (int.Parse(tbValorDesde.Text) > int.Parse(tbValorHasta.Text))
                if(tbValorHasta.Text != "0")
                    throw new Exception( "El valor inicial debe ser menor al final.");


            if (int.Parse(tbMedidaTerrenoDesde.Text) < 0)
                throw new Exception("La medida del terreno inicial debe ser positiva.");

            if (int.Parse(tbMedidaTerrenoHasta.Text) < 0)
                throw new Exception("La medida del terreno final debe positiva.");

            if (int.Parse(tbMedidaTerrenoDesde.Text) > int.Parse(tbMedidaTerrenoHasta.Text))
                if (tbMedidaTerrenoHasta.Text != "0")
                    throw new Exception( "La medida del terreno inicial debe ser menor a la final.");




            if (int.Parse(tbMetrosConstruiblesDesde.Text) < 0)
                throw new Exception("Los metros construibles iniciales deben positivos.");

            if (int.Parse(tbMetrosConstruiblesHasta.Text) < 0)
                throw new Exception("Los metros construibles finales deben ser positivos.");

            if (int.Parse(tbMetrosConstruiblesDesde.Text) > int.Parse(tbMetrosConstruiblesHasta.Text))
                if (tbMetrosConstruiblesHasta.Text != "0")
                    throw new Exception( "La medida construible inicial debe ser menor a la final.");




            if (int.Parse(tbMetrosCubiertosDesde.Text) < 0)
                throw new Exception("Los metros cubiertos iniciales deben ser positivos.");

            if (int.Parse(tbMetrosCubiertosHasta.Text) < 0)
                throw new Exception("Los metros cubiertos finales deben ser positivos.");

            if (int.Parse(tbMetrosCubiertosDesde.Text) > int.Parse(tbMetrosCubiertosHasta.Text))
                if (tbMetrosCubiertosHasta.Text != "0")
                    throw new Exception( "La medida de metos cubiertos inicial debe ser menor a la final.");

            if (cbAmbientesInicial.SelectedItem.ToString() != "Sin Definir" && cbAmbientesFinal.SelectedItem.ToString() != "Sin Definir")
                if (((GI.BR.Propiedades.Ambiente)cbAmbientesInicial.SelectedItem).CantidadAmbientes > ((GI.BR.Propiedades.Ambiente)cbAmbientesFinal.SelectedItem).CantidadAmbientes)
                    throw new Exception( "La cantidad de ambientes inicial debe ser menor a la final.");


            validado = true;
        }

        private bool inicializando = true;
        protected override void Inicializar()
        {


            #region inicializar combos
            cbEsAptoProfesional.Items.Clear();
            cbEsAptoProfesional.Items.Add("Sin Definir");
            cbEsAptoProfesional.Items.Add("Si");
            cbEsAptoProfesional.Items.Add("No");


            cbDisposicion.Items.Clear();
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.SinDefinir);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Frente);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Contrafrente);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Interno);
            cbDisposicion.Items.Add(GI.BR.Propiedades.DepartamentoDisposicion.Lateral);

            cbTipoZona.Items.Clear();
            cbTipoZona.Items.Add(GI.BR.Propiedades.TipoZona.SinDefinir);
            cbTipoZona.Items.Add(GI.BR.Propiedades.TipoZona.Comercial);
            cbTipoZona.Items.Add(GI.BR.Propiedades.TipoZona.Industrial);
            cbTipoZona.Items.Add(GI.BR.Propiedades.TipoZona.Residencial);   

            GI.BR.Propiedades.CategoriasPropiedad Categorias = new GI.BR.Propiedades.CategoriasPropiedad();
            Categorias.RecuperarTodas();
            cbCategoria.Items.Clear();
            cbCategoria.Items.Add("Sin Definir");
            foreach (GI.BR.Propiedades.CategoriaPropiedad Cat in Categorias)
            {
                cbCategoria.Items.Add(Cat);
            }

            if(Pedido.Categoria == null)
                cbCategoria.SelectedIndex = 0;


            GI.BR.Propiedades.EstadosPropiedad Estados = new GI.BR.Propiedades.EstadosPropiedad();
            Estados.RecuperarEstados(Pedido.EstadoPropiedad);
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Sin Definir");
            foreach (GI.BR.Propiedades.EstadoPropiedad Estado in Estados)
                cbEstado.Items.Add(Estado);
            cbEstado.SelectedIndex = 0;

            GI.BR.Monedas.Monedas Monedas = new GI.BR.Monedas.Monedas();
            Monedas.RecuperarTodas();
            cbMoneda.Items.Clear();
            cbMoneda.Items.Add("---");
            foreach (GI.BR.Monedas.Moneda M in Monedas)
            {
                cbMoneda.Items.Add(M);
            }
            cbMoneda.SelectedIndex = 0;

            cbEstadoProp.Items.Clear();
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.NoEspecifica);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.AEstrenar);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.AReciclar);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.Bueno);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.MuyBueno);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.Malo);            
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.Reciclado);
            cbEstadoProp.Items.Add(GI.BR.Propiedades.Estado.Regular);
            cbEstadoProp.SelectedIndex = 0;

            GI.BR.Propiedades.Ambientes ambientes = new GI.BR.Propiedades.Ambientes();
            ambientes.RecuperarTodos();

            cbAmbientesFinal.Items.Clear();
            cbAmbientesInicial.Items.Clear();
            cbAmbientesInicial.Items.Add("Sin Definir");
            cbAmbientesFinal.Items.Add("Sin Definir");  
            foreach (GI.BR.Propiedades.Ambiente a in ambientes)
            {
                cbAmbientesInicial.Items.Add(a);
                cbAmbientesFinal.Items.Add(a);               
            }

            cbAmbientesInicial.SelectedIndex = 0;
            cbAmbientesFinal.SelectedIndex = 0;

            #endregion

            gbTerreno.Enabled = false;
            gbDepartamento.Enabled = false;

            inicializando = false;
        }

        protected override void CargarPedido()
        {
            pedidoBindingSource.Add(Pedido);

            checkBox1.Checked = !Pedido.Activo;
            
            ctrlUbicacion1.Ubicacion = Pedido.Ubicacion;

            if (Pedido.EsAptoProfesional == null)
                cbEsAptoProfesional.SelectedIndex = 0;
            else
            {
                if (Pedido.EsAptoProfesional.Value)
                    cbEsAptoProfesional.SelectedIndex = 1;
                else
                    cbEsAptoProfesional.SelectedIndex = 2;
            }

            if (Pedido.Disposicion == null)
                cbDisposicion.SelectedIndex = 0;
            else
            {
                switch (Pedido.Disposicion)
                {
                    case GI.BR.Propiedades.DepartamentoDisposicion.Frente: cbDisposicion.SelectedIndex = 1; break;
                    case GI.BR.Propiedades.DepartamentoDisposicion.Contrafrente: cbDisposicion.SelectedIndex = 2; break;
                    case GI.BR.Propiedades.DepartamentoDisposicion.Interno: cbDisposicion.SelectedIndex = 3; break;
                    case GI.BR.Propiedades.DepartamentoDisposicion.Lateral: cbDisposicion.SelectedIndex = 4; break;
                }
            }

            if (Pedido.TipoZona == null)
                cbTipoZona.SelectedIndex = 0;
            else
            {
                switch (Pedido.TipoZona)
                {
                    case GI.BR.Propiedades.TipoZona.Comercial: cbTipoZona.SelectedIndex = 1; break;
                    case GI.BR.Propiedades.TipoZona.Industrial: cbTipoZona.SelectedIndex = 2; break;
                    case GI.BR.Propiedades.TipoZona.Residencial: cbTipoZona.SelectedIndex = 3; break;
                }
            }

            if (Pedido.ClientePedido != null)
            {
                LinkContacto.Tag = Pedido.ClientePedido;
                LinkContacto.Text = Pedido.ClientePedido.ToString();
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem == null) return;

            cbTipoPropiedad.Items.Clear();
            if (cbCategoria.SelectedItem.ToString() == "Sin Definir")
            {
                cbTipoPropiedad.Items.Add("Sin Definir");
                cbTipoPropiedad.SelectedIndex = 0;
                cbTipoPropiedad.Enabled = false;
                return;
            }

            cbTipoPropiedad.Enabled = true;

            GI.BR.Propiedades.TiposPropiedad tipos = ((GI.BR.Propiedades.CategoriaPropiedad)cbCategoria.SelectedItem).TiposPropiedad;

            cbTipoPropiedad.Items.Add("Sin Definir");
            foreach (GI.BR.Propiedades.TipoPropiedad tipo in tipos)
            {
                cbTipoPropiedad.Items.Add(tipo);
            }

            if (Pedido.TipoPropiedad == null)
                cbTipoPropiedad.SelectedIndex = 0;
            else
            {
                for (int i = 1; i < cbTipoPropiedad.Items.Count; i++)
                {
                    GI.BR.Propiedades.TipoPropiedad tipo = (GI.BR.Propiedades.TipoPropiedad)cbTipoPropiedad.Items[i];
                    if (tipo.IdTipoPropiedad == Pedido.TipoPropiedad.IdTipoPropiedad)
                    {
                        cbTipoPropiedad.SelectedIndex = i;
                        return;
                    }
                    
                }
                cbTipoPropiedad.SelectedIndex = 0;
            }
        }

        private void cbTipoPropiedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPropiedad.SelectedItem.ToString() == "Sin Definir")
            {
                //Pedido.TipoPropiedad = null;
                gbTerreno.Enabled = false;
                gbDepartamento.Enabled = false;
            }
            else
            {
                //Pedido.TipoPropiedad = (GI.BR.Propiedades.TipoPropiedad)cbTipoPropiedad.SelectedItem;

                if (((GI.BR.Propiedades.TipoPropiedad)cbTipoPropiedad.SelectedItem).Descripcion == "Departamento")
                    gbDepartamento.Enabled = true;
                else
                    gbDepartamento.Enabled = false;

                if (Pedido.EstadoPropiedad == typeof(GI.BR.Propiedades.Venta) && ((GI.BR.Propiedades.TipoPropiedad)cbTipoPropiedad.SelectedItem).Descripcion == "Campo")
                    gbTerreno.Enabled = true;
                else
                    gbTerreno.Enabled = false;

            }
        }


        private void LinkContacto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkContacto.Text == "Seleccione un contacto")
            {
                Framework.frmSeleccionador frmSeleccionador = new GI.Framework.frmSeleccionador(new Clientes.SeleccionadorPropietarios(typeof(GI.BR.Clientes.ClientePedido)));
                if (frmSeleccionador.ShowDialog() == DialogResult.OK)
                {
                    LinkContacto.Tag = (GI.BR.Clientes.ClientePedido)frmSeleccionador.ObjetoSeleccionado;
                    LinkContacto.Text = ((GI.BR.Clientes.ClientePedido)frmSeleccionador.ObjetoSeleccionado).ToString();
                    Pedido.ClientePedido = (GI.BR.Clientes.ClientePedido)frmSeleccionador.ObjetoSeleccionado;
                }

            }
            else
            {
                if (LinkContacto.Tag != null)
                {
                    Clientes.frmFichaCliente frm = new GI.UI.Clientes.frmFichaCliente();
                    frm.SoloLectura = SoloLectura;
                    frm.Cliente = (GI.BR.Clientes.Cliente)LinkContacto.Tag;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        LinkContacto.Text = frm.Cliente.ToString();
                    }

                }
            }
        }


        private void gbTerreno_EnabledChanged(object sender, EventArgs e)
        {
            if (!inicializando)
                if (!gbTerreno.Enabled)
                {
                    cbTipoZona.SelectedIndex = 0;
                    tbMetrosConstruiblesDesde.Text = "0";
                    tbMetrosConstruiblesHasta.Text = "0";

                }
        }

        private void gbDepartamento_EnabledChanged(object sender, EventArgs e)
        {
            if (!inicializando)
                if (!gbDepartamento.Enabled)
                {
                    cbDisposicion.SelectedIndex = 0;
                    cbEsAptoProfesional.SelectedIndex = 0;
                }
        }
    }
}
