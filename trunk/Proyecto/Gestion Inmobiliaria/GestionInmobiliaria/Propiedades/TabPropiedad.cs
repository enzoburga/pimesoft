using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabPropiedad : TabContenidoPropiedad
    {
        public TabPropiedad() : base()
        {
            InitializeComponent();
            
        }



        protected override void Inicializar()
        {
            cbTipoPropiedad.Items.Add(GI.BR.Propiedades.TipoPropiedad.Casa);
            cbTipoPropiedad.Items.Add(GI.BR.Propiedades.TipoPropiedad.Departamento);
            cbTipoPropiedad.Items.Add(GI.BR.Propiedades.TipoPropiedad.PH);
            cbTipoPropiedad.Items.Add(GI.BR.Propiedades.TipoPropiedad.Campo);
            cbTipoPropiedad.Items.Add(GI.BR.Propiedades.TipoPropiedad.Chacra);
            cbTipoPropiedad.Items.Add(GI.BR.Propiedades.TipoPropiedad.Galpón);
            cbTipoPropiedad.Items.Add(GI.BR.Propiedades.TipoPropiedad.Terreno);
            cbTipoPropiedad.SelectedIndex = 0;

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


            GI.BR.Propiedades.Estados est = new GI.BR.Propiedades.Estados();
            est.RecuperarTodos();
            foreach (GI.BR.Propiedades.Estado e in est)
                cbEstadoProp.Items.Add(e);
            cbEstadoProp.SelectedIndex = 0;

            GI.BR.Propiedades.Ambientes ambientes = new GI.BR.Propiedades.Ambientes();
            ambientes.RecuperarTodos();
            foreach (GI.BR.Propiedades.Ambiente a in ambientes)
                cbAmbientes.Items.Add(a);
            cbAmbientes.SelectedIndex = 2;


        }

        protected override void CargarPropiedad()
        {
            base.CargarPropiedad();
        }



        
    }
}
