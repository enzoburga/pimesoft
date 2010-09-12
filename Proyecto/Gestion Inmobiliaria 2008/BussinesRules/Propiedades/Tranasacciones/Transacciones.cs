using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Tranasacciones
{
    [Serializable]
    public class Transacciones : List<Transaccion>
    {


        public void RecuperarTransaccionesPedidosPedientes()
        {
            Clear();
            TransaccionPedido tran;
            using (System.Data.IDataReader dr = new DA.TransaccionesData().RecuperarTransaccionesPedidoPendientes())
            {
                while (dr.Read())
                {
                    tran = new TransaccionPedido();

                    tran.Activa = true;
                    tran.Estado = EnumEstadoTrans.Pendiente;
                    tran.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    
                    tran.IdTransaccion = dr.GetInt32(dr.GetOrdinal("IdTransaccion"));
                    tran.TipoTransaccion = (EnumTipoTransaccion)dr.GetInt32(dr.GetOrdinal("TipoTransaccion"));
                    tran.IdPedido = dr.GetInt32(dr.GetOrdinal("IdPedido"));

                    Add(tran);
                }
            }
        }

        public void RecuperarTransaccionesFotosPendientes(Propiedad p)
        {
            Clear();
            TransaccionFotoPropiedad tran;
            using (System.Data.IDataReader dr = new DA.TransaccionesData().RecuperarTransaccionesFotoPendientes(p.IdPropiedad))
            {
                while (dr.Read())
                {
                    tran = new TransaccionFotoPropiedad();

                    tran.Activa = true;
                    tran.Estado = EnumEstadoTrans.Pendiente;
                    tran.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    tran.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));
                    tran.IdTransaccion = dr.GetInt32(dr.GetOrdinal("IdTransaccion"));
                    tran.TipoTransaccion = (EnumTipoTransaccion)dr.GetInt32(dr.GetOrdinal("TipoTransaccion"));
                    tran.IdFoto = dr.GetInt32(dr.GetOrdinal("IdFoto"));

                    Add(tran);
                }
            }
        }

        public void RecuperarTransaccionesFotosPendientes()
        {
            Clear();
            TransaccionFotoPropiedad tran;
            using (System.Data.IDataReader dr = new DA.TransaccionesData().RecuperarTransaccionesFotoPendientes())
            {
                while (dr.Read())
                {
                    tran = new TransaccionFotoPropiedad();

                    tran.Activa = true;
                    tran.Estado = EnumEstadoTrans.Pendiente;
                    tran.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    tran.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));
                    tran.IdTransaccion = dr.GetInt32(dr.GetOrdinal("IdTransaccion"));
                    tran.TipoTransaccion = (EnumTipoTransaccion)dr.GetInt32(dr.GetOrdinal("TipoTransaccion"));
                    tran.IdFoto = dr.GetInt32(dr.GetOrdinal("IdFoto"));

                    Add(tran);
                }
            }
        }

        public void RecuperarTransaccionesPropiedadesPendientes()
        {
            Clear();
            TransaccionPropiedad tran;
            using (System.Data.IDataReader dr = new DA.TransaccionesData().RecuperarTransaccionesPropiedadesPendientes())
            {
                while (dr.Read())
                {
                    tran = new TransaccionPropiedad();

                    tran.Activa = true;
                    tran.Estado = EnumEstadoTrans.Pendiente;
                    tran.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    tran.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));
                    tran.IdTransaccion = dr.GetInt32(dr.GetOrdinal("IdTransaccion"));
                    tran.TipoTransaccion = (EnumTipoTransaccion)dr.GetInt32(dr.GetOrdinal("TipoTransaccion"));
                    tran.TypePropopiedad = dr.GetString(dr.GetOrdinal("TypePropopiedad"));

                    Add(tran);
                }
            }
        }

        public void RecuperarTransaccionesPropiedadesPendientes(Propiedad p)
        {
            Clear();
            TransaccionPropiedad tran;
            using (System.Data.IDataReader dr = new DA.TransaccionesData().RecuperarTransaccionesPropiedadesPendientes(p.IdPropiedad))
            {
                while (dr.Read())
                {
                    tran = new TransaccionPropiedad();

                    tran.Activa = true;
                    tran.Estado = EnumEstadoTrans.Pendiente;
                    tran.Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha"));
                    tran.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));
                    tran.IdTransaccion = dr.GetInt32(dr.GetOrdinal("IdTransaccion"));
                    tran.TipoTransaccion = (EnumTipoTransaccion)dr.GetInt32(dr.GetOrdinal("TipoTransaccion"));
                    tran.TypePropopiedad = dr.GetString(dr.GetOrdinal("TypePropopiedad"));

                    Add(tran);
                }
            }
        }

    }
}
