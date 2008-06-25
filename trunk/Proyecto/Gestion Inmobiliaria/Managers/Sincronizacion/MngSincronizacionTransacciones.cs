using System;
using System.Collections.Generic;
using System.Text;

namespace GI.Managers.Sincronizacion
{

    public delegate void TransaccionEventHandler(GI.BR.Propiedades.Tranasacciones.Transaccion xTran, int PorcentajeEnvio);
    public delegate void SincronizacionEventHandler(bool Error, string Mensaje);

    public class MngSincronizacionTransacciones
    {

        public event TransaccionEventHandler onTransaccionSincronizada;
        public event SincronizacionEventHandler onProcesoFinalizado;



        private List<GI.BR.Propiedades.Tranasacciones.Transaccion> transacciones;

        public List<GI.BR.Propiedades.Tranasacciones.Transaccion> Transacciones
        {
            get { return transacciones; }
            set { transacciones = value; }
        }

        public MngSincronizacionTransacciones()
        { }


        public List<GI.BR.Propiedades.Tranasacciones.Transaccion> RecuperarTransaccionesPendientes(GI.BR.Propiedades.Propiedad p)
        {
            List<GI.BR.Propiedades.Tranasacciones.Transaccion> trans = new List<GI.BR.Propiedades.Tranasacciones.Transaccion>();

            GI.BR.Propiedades.Tranasacciones.Transacciones transPropiedades = new GI.BR.Propiedades.Tranasacciones.Transacciones();
            transPropiedades.RecuperarTransaccionesPropiedadesPendientes(p);
            trans.AddRange(transPropiedades.ToArray());

            GI.BR.Propiedades.Tranasacciones.Transacciones transFotos = new GI.BR.Propiedades.Tranasacciones.Transacciones();
            transFotos.RecuperarTransaccionesFotosPendientes(p);
            trans.AddRange(transFotos.ToArray());


            return trans;
        }

        public List<GI.BR.Propiedades.Tranasacciones.Transaccion> RecuperarTransaccionesPendientes()
        {
            List<GI.BR.Propiedades.Tranasacciones.Transaccion> trans = new List<GI.BR.Propiedades.Tranasacciones.Transaccion>();

            GI.BR.Propiedades.Tranasacciones.Transacciones transPropiedades = new GI.BR.Propiedades.Tranasacciones.Transacciones();
            transPropiedades.RecuperarTransaccionesPropiedadesPendientes();
            trans.AddRange(transPropiedades.ToArray());

            GI.BR.Propiedades.Tranasacciones.Transacciones transFotos = new GI.BR.Propiedades.Tranasacciones.Transacciones();
            transFotos.RecuperarTransaccionesFotosPendientes();
            trans.AddRange(transFotos.ToArray());


            return trans;
        }




        public void Sincronizar()
        {

            int progreso = 0;
            WebService.PropiedadesServicioSinc ws = new GI.Managers.WebService.PropiedadesServicioSinc();
            ws.Url = System.Configuration.ConfigurationManager.AppSettings["UrlWebServiceSin"].ToString();

            try
            {
                foreach (GI.BR.Propiedades.Tranasacciones.Transaccion tran in Transacciones)
                {

                    try
                    {

                        #region SWITCH POR TIPO DE TRANS
                        switch (tran.GetType().ToString())
                        {
                            #region Trans Props
                            case "GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad":
                                {
                                    if (tran.TipoTransaccion == GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Modificar)
                                    {
                                        if (!ws.ActualizarPropiedad(((GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad)tran).Propiedad))
                                            throw new Exception("La propiedad " + ((GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad)tran).Propiedad.Codigo.ToString() + " no pudo ser actualizada en el servidor remoto");


                                    }
                                    else if (tran.TipoTransaccion == GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Crear)
                                    {
                                        if (!ws.IngresarPropiedad(((GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad)tran).Propiedad))
                                            throw new Exception("La propiedad " + ((GI.BR.Propiedades.Tranasacciones.TransaccionPropiedad)tran).Propiedad.Codigo.ToString() + " no pudo ser creada en el servidor remoto");


                                    }
                                    break;
                                }
                            #endregion

                            #region Trans Fotos
                            case "GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad":
                                {

                                    if (tran.TipoTransaccion == GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Crear)
                                    {
                                        if (!ws.AgregarFotoAGaleria(((GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad)tran).Foto, ((GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad)tran).IdPropiedad))
                                            throw new Exception("La Foto " + ((GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad)tran).Foto.Descripcion + " de la propiedad no pudo ser procesada por el servidor remoto");

                                    }
                                    else if (tran.TipoTransaccion == GI.BR.Propiedades.Tranasacciones.EnumTipoTransaccion.Eliminar)
                                    {
                                        if (!ws.EliminarFotoPropiedad(((GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad)tran).IdFoto))
                                            throw new Exception("La Foto " + ((GI.BR.Propiedades.Tranasacciones.TransaccionFotoPropiedad)tran).Foto.Descripcion + " de la propiedad no pudo ser procesada por el servidor remoto");
                                    }

                                    break;
                                }

                            #endregion


                            default:
                                throw new Exception("Tipo de transaccion no manejada para la sincronizacion");
                        }
                        #endregion

                        tran.DesactivarTransaccion();
                        tran.MensajeRespuesta = "El objeto se ha sincronizado con éxito";
                        tran.Estado = GI.BR.Propiedades.Tranasacciones.EnumEstadoTrans.Sincronizado;

                        onTransaccionSincronizada(tran, ((++progreso * 100) / transacciones.Count));
                    }
                    catch(Exception ex)
                    {
                        tran.Estado = GI.BR.Propiedades.Tranasacciones.EnumEstadoTrans.Error;
                        tran.MensajeRespuesta = ex.Message;
                        onTransaccionSincronizada(tran, ((++progreso * 100) / transacciones.Count));

                    }
                    
                }





                onProcesoFinalizado(false, "El proceso de sincronización ha finalizado.\nVerifique el estado de sincronización.");


            

            }
            catch(Exception ex)
            {
                onProcesoFinalizado(true, ex.Message);
            }
            finally
            {
            
            }



        }




    }
}
