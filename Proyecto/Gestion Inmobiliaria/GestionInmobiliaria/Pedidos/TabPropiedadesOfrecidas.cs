using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class TabPropiedadesOfrecidas : TabContenidoPedidos
    {
        public TabPropiedadesOfrecidas()
        {
            InitializeComponent();
        }

        GI.Managers.Pedidos.MngPedidos mng = new GI.Managers.Pedidos.MngPedidos();
        protected override void Inicializar()
        {
            LlenarLista(mng.GetPropiedadesOfrecidas(Pedido));

        }

        private void LlenarLista(GI.BR.Propiedades.Propiedades propiedades)
        {
            ListViewItem lvi;
            foreach (GI.BR.Propiedades.Propiedad p in propiedades)
            {
                lvPropiedades.BeginUpdate();
                lvPropiedades.Items.Clear();

                lvi = new ListViewItem();
                lvi.Text = p.Codigo;
                lvi.SubItems.Add(p.Direccion.ToString());
                if (p.Propietario != null)
                    lvi.SubItems.Add(p.Propietario.ToString());
                else
                    lvi.SubItems.Add("Sin Propietario.");
                lvi.Tag = p;
                lvPropiedades.Items.Add(lvi);
                
                lvPropiedades.EndUpdate();                
            }
        }
    }
}
