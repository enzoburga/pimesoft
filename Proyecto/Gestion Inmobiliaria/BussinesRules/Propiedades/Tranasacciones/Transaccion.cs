using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Propiedades.Tranasacciones
{
    public abstract class Transaccion
    {


        public Transaccion()
        { }


        private int idTransaccion;
        private EnumTipoTransaccion tipoTransaccion;
        private DateTime fecha;
        private bool activa;
        private EnumEstadoTrans estado;
        private string mensajeRespuesta;

        public string MensajeRespuesta
        {
            get { return mensajeRespuesta; }
            set { mensajeRespuesta = value; }
        }

        public EnumEstadoTrans Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public int IdTransaccion
        {
            get { return idTransaccion; }
            set { idTransaccion = value; }
        }
        

        public EnumTipoTransaccion TipoTransaccion
        {
            get { return tipoTransaccion; }
            set { tipoTransaccion = value; }
        }
        

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        

        public bool Activa
        {
            get { return activa; }
            set { activa = value; }
        }



        public abstract bool Crear();

        public bool DesactivarTransaccion()
        {
            return new DA.TransaccionesData().DesactivarTransaccion(IdTransaccion);
        }


    }
}
