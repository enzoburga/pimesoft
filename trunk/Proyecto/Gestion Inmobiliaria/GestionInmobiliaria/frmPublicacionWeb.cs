using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI
{
    public partial class frmPublicacionWeb : GI.Framework.Seguridad.FrmGISeguridad
    {

        System.Threading.Thread thread;
        List<GI.BR.Propiedades.Tranasacciones.Transaccion> transacciones;
        GI.BR.Propiedades.Propiedad propiedad;

        public frmPublicacionWeb()
        {
            InitializeComponent();
        }

        public frmPublicacionWeb(bool TodasLasTransacciones)
            : this()
        {
            //transacciones = Transacciones;
            //Inicializar();
            recuperarTransaccionesPendientes();

            StatusLabel.Text = "";

        }


        public frmPublicacionWeb(GI.BR.Propiedades.Propiedad Propiedad)
            : this()
        {
            propiedad = Propiedad;
            Managers.Sincronizacion.MngSincronizacionTransacciones mng = new GI.Managers.Sincronizacion.MngSincronizacionTransacciones();

            transacciones = mng.RecuperarTransaccionesPendientes(propiedad);

            Inicializar();

        }




        private void recuperarTransaccionesPendientes()
        { 
            Managers.Sincronizacion.MngSincronizacionTransacciones mng = new GI.Managers.Sincronizacion.MngSincronizacionTransacciones();
            
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(mng.RecuperarTransaccionesPendientes));
            mng.onHayTransaccionesPendientes+=new GI.Managers.Sincronizacion.DeteccionTransacciones(mng_onHayTransaccionesPendientes);


            StatusLabel.Text = "Recuperando Transacciones disponibles. Por favor espere unos segundos...";

            t.IsBackground=true;

            t.Start();

        }



        private void cargarTransaccionesPendientes(List<GI.BR.Propiedades.Tranasacciones.Transaccion> Transacciones)
        {
            StatusLabel.Text = "";
            transacciones = Transacciones;
            Inicializar();
        }

        private void mng_onHayTransaccionesPendientes(List<GI.BR.Propiedades.Tranasacciones.Transaccion> Transacciones)
        {
            this.Invoke(new Managers.Sincronizacion.DeteccionTransacciones(cargarTransaccionesPendientes), new object[] { Transacciones });

            
        }

        private void Inicializar()
        {
            lvTransacciones.BeginUpdate();
            lvTransacciones.Items.Clear();
            foreach (GI.BR.Propiedades.Tranasacciones.Transaccion t in transacciones)
            {
                lvTransacciones.Items.Add(generarListViewIten(t));
            }

            lvTransacciones.EndUpdate();



        }

        private void HabilitarControles(bool EnProceso)
        {
            bIniciar.Enabled = !EnProceso;
            bCancelar.Enabled = EnProceso;
            bRefresh.Enabled = !EnProceso;
            linkLabelSelectNone.Enabled = linkLabelSelectAll.Enabled = !EnProceso;


        }

        private ListViewItem generarListViewIten(GI.BR.Propiedades.Tranasacciones.Transaccion tran)
        {

            ListViewItem item = new ListViewItem();

            switch (tran.GetType().ToString())
            { 
                case "GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad":
                    item.Text = "Propiedad código " + ((GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad)tran).Propiedad.Codigo;
                    break;
                case "GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad":


                    item.Text = "Foto de Propiedad " + ((GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad)tran).IdPropiedad.ToString() + " " + ((GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad)tran).Foto.Descripcion;

                    break;

                case "GI.BR.Propiedades.Tranasacciones.TransaccionPedido":
                   item.Text = "Descarga de nuevo pedido  web Id " + ((GI.BR.Propiedades.Tranasacciones.TransaccionPedido)tran).IdPedido;
                   break;
                    
                default:
                    item.Text = "Objeto no identificado";
                    break;
            }

            item.SubItems.Add(tran.TipoTransaccion.ToString());
            item.SubItems.Add(tran.Fecha.ToShortDateString());
          
            item.SubItems.Add(tran.Estado.ToString());
            item.SubItems.Add(tran.MensajeRespuesta);
            item.Tag = tran;

            return item;


        }

        private List<GI.BR.Propiedades.Tranasacciones.Transaccion> TransaccionesASincronizar()
        {

            List<GI.BR.Propiedades.Tranasacciones.Transaccion> trans = new List<GI.BR.Propiedades.Tranasacciones.Transaccion>();

            foreach (ListViewItem item in lvTransacciones.Items)
            {
                if (item.Checked && ((GI.BR.Propiedades.Tranasacciones.Transaccion)item.Tag).Estado != GI.BR.Propiedades.Tranasacciones.EnumEstadoTrans.Sincronizado)
                {
                    trans.Add((GI.BR.Propiedades.Tranasacciones.Transaccion)item.Tag);
                }
            }

            return trans;



        }


        #region Eventos


        private void lvTransacciones_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void frmPublicacionWeb_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null && thread.ThreadState == System.Threading.ThreadState.Background)
            {
                if (Framework.General.GIMsgBox.Show("¿Desea cancelar el proceso de sincronización?", GI.Framework.General.enumTipoMensaje.PreguntaSinCancelar) == DialogResult.Yes)
                {
                    thread.Abort();

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            List<GI.BR.Propiedades.Tranasacciones.Transaccion> trans = TransaccionesASincronizar();
            if (trans == null || trans.Count == 0)
            {
                GI.Framework.General.GIMsgBox.Show("No hay objetos seleccionados en estado pendiente", GI.Framework.General.enumTipoMensaje.Informacion);
                return;
            }
            progressBar1.Value = 0;

            GI.Managers.Sincronizacion.MngSincronizacionTransacciones mngSinc = new GI.Managers.Sincronizacion.MngSincronizacionTransacciones();
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(mngSinc.Sincronizar));
            thread.IsBackground = true;

            mngSinc.onProcesoFinalizado += new GI.Managers.Sincronizacion.SincronizacionEventHandler(mngSinc_onProcesoFinalizado);
            mngSinc.onTransaccionSincronizada += new GI.Managers.Sincronizacion.TransaccionEventHandler(mngSinc_onTransaccionSincronizada);
            
            HabilitarControles(true);

            mngSinc.Transacciones = trans;

            thread.Start();


        }

        private void mngSinc_onTransaccionSincronizada(GI.BR.Propiedades.Tranasacciones.Transaccion xTran, int PorcentajeEnvio)
        {
            this.Invoke(new Managers.Sincronizacion.TransaccionEventHandler(transaccionSincronizada), new object[] { xTran, PorcentajeEnvio });

        }

        private void mngSinc_onProcesoFinalizado(bool Error, string Mensaje)
        {
            this.Invoke(new Managers.Sincronizacion.SincronizacionEventHandler(procesoFinalizado), new object[] { Error, Mensaje });
        }

        private void transaccionSincronizada(GI.BR.Propiedades.Tranasacciones.Transaccion xTran, int PorcentajeEnvio)
        {

            ListViewItem lvitem = null;
            foreach (ListViewItem item in lvTransacciones.Items)
            {
                if (((GI.BR.Propiedades.Tranasacciones.Transaccion)item.Tag).IdTransaccion == xTran.IdTransaccion)
                {
                    lvitem = item;
                }
            }

            if (lvitem == null) return;

            int index = lvitem.Index;

            lvTransacciones.Items.RemoveAt(index);
            lvTransacciones.Items.Insert(index, generarListViewIten(xTran));

            progressBar1.Value = PorcentajeEnvio;

        }

        private void procesoFinalizado(bool Error, string Mensaje)
        {
            HabilitarControles(false);
            if (Error)
            {
                Framework.General.GIMsgBox.Show(Mensaje, GI.Framework.General.enumTipoMensaje.Error);
            }
            else
            {
                Framework.General.GIMsgBox.Show(Mensaje, GI.Framework.General.enumTipoMensaje.Informacion);
            }
        
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            if (thread != null && thread.ThreadState == System.Threading.ThreadState.Background)
            {
                if (Framework.General.GIMsgBox.Show("¿Desea cancelar el proceso de sincronización?", GI.Framework.General.enumTipoMensaje.PreguntaSinCancelar) == DialogResult.Yes)
                {
                    thread.Abort();
                    thread = null;
                    HabilitarControles(false);

                }
                
            }
        }

        private void linkLabelSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            lvTransacciones.BeginUpdate();
            foreach (ListViewItem item in lvTransacciones.Items)
            {
                item.Checked = true;
            }

            lvTransacciones.EndUpdate();



        }

        private void linkLabelSelectNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            lvTransacciones.BeginUpdate();
            foreach (ListViewItem item in lvTransacciones.Items)
            {
                item.Checked = false;
            }

            lvTransacciones.EndUpdate();

        }

        private void bRefresh_Click(object sender, EventArgs e)
        {

            Managers.Sincronizacion.MngSincronizacionTransacciones mng = new Managers.Sincronizacion.MngSincronizacionTransacciones();

            if (propiedad == null)
                recuperarTransaccionesPendientes();
            else
                transacciones = mng.RecuperarTransaccionesPendientes(propiedad);
            
            Inicializar();





        }
 

        #endregion

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}