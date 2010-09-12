using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Pedidos
{
    public partial class frmBuscarPedidos : Form,GI.Framework.Interfaces.IBuscador
    {
        private Type tipo;
        private GI.BR.Pedidos.Pedidos pedidos;
        GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory uff = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia;



        public frmBuscarPedidos(Type tipoPropiedad)
        {
            InitializeComponent();
            this.tipo = tipoPropiedad;
            Inicializar();

            bBuscar.Focus();            
        }


        public GI.BR.Pedidos.Pedidos Pedidos
        {
            get { return pedidos; }
           
        }
        
        private void Inicializar()
        {


        }



        private void bBuscar_Click(object sender, EventArgs e)
        {
            GI.Managers.Pedidos.MngPedidos mngPedidos = new GI.Managers.Pedidos.MngPedidos();

            #region Por Contacto



            pedidos = mngPedidos.RecuperarPedidosPorContacto(tbNombresInquilinos.Text, tipo, cbIncluirHistoricos.Checked);

            #endregion

            if (this.pedidos.Count == 0)
            {
                GI.Framework.General.GIMsgBox.ShowNoSeEncontraronDatos();
                return;
            }


            this.DialogResult = DialogResult.OK;
            this.Close();



        }

        #region IBuscador Members

        public List<object> GetObjetosEncontrados()
        {
            List<object> lista = new List<object>();
            lista.AddRange(this.pedidos.ToArray());
            return lista;
        }

        public void SetTipoBusqueda(Type tipoObjeto)
        {
        }

        public DialogResult MostrarBuscador()
        {
            return this.ShowDialog();
        }

        #endregion

        
    }
}