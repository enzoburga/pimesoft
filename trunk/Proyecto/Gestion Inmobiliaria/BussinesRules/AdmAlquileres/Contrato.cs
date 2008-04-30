using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class Contrato
    {
        #region Miembros Privados
        private int idContrato;
        private GI.BR.Clientes.Inquilino inquilino;
        private DateTime fechaInicio;
        private DateTime fechaVencimiento;
        private Nullable<DateTime> fechaCancelacion;
        private GI.BR.Valor monto;
        private GI.BR.Valor deposito; 
        private int diaCobro;
        private string observaciones;
        private Contrato contratoAnterior;
        private GI.BR.Propiedades.Alquiler alquiler;
        #endregion

        #region Propiedade Publicas

        public int IdContrato { get { return idContrato; } set { idContrato = value; } }

        public GI.BR.Clientes.Inquilino Inquilino
        {
            get { return inquilino; }
            set { inquilino = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public GI.BR.Valor Deposito
        {
            get { return deposito; }
            set { deposito = value; }
        }

        public DateTime FechaVencimiento { get { return fechaVencimiento; } set { fechaVencimiento = value; } }

        public Nullable<DateTime> FechaCancelacion { get { return fechaCancelacion; } set { fechaCancelacion = value; } }

        public GI.BR.Valor Monto { get { return monto; } set { monto = value; } }

        public string Observaciones { get { return observaciones; } set { observaciones = value; } }

        public int DiaCobro { get { return diaCobro; } set { diaCobro = value; } }

        public Contrato ContratoAnterior { get { return contratoAnterior; } set { contratoAnterior = value; } }

        public GI.BR.Propiedades.Alquiler Alquiler { get { return alquiler; } set { alquiler = value; } }


        #endregion

        public bool Guardar()
        {
            GI.DA.ContratosData cd = new GI.DA.ContratosData();
            this.IdContrato = cd.GuardarConrato((Inquilino == null) ? 0:Inquilino.IdCliente, Alquiler.IdPropiedad, FechaInicio, FechaVencimiento, Monto.Importe, Monto.Moneda.IdMoneda, Deposito.Importe, Deposito.Moneda.IdMoneda, DiaCobro, (ContratoAnterior == null) ? 0 : ContratoAnterior.IdContrato, FechaCancelacion, Observaciones);
            return IdContrato > 0;
        }

        public bool Actualizar()
        {
            GI.DA.ContratosData cd = new GI.DA.ContratosData();
            return cd.ActualizarContrato(IdContrato, (Inquilino == null) ? 0 : Inquilino.IdCliente, Alquiler.IdPropiedad, FechaInicio, FechaVencimiento, Monto.Importe, Monto.Moneda.IdMoneda, Deposito.Importe, Deposito.Moneda.IdMoneda, DiaCobro, (ContratoAnterior == null) ? 0 : ContratoAnterior.IdContrato, FechaCancelacion, Observaciones);
            
        }
    }
}
