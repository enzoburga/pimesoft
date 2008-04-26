using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class Contrato
    {
        #region Miembros Privados
        private GI.BR.Clientes.Inquilino inquilino;
        private DateTime fechaInicio;
        private DateTime fechaVencimiento;
        private Nullable<DateTime> fechaCancelacion;
        private GI.BR.Valor monto;
        private GI.BR.Valor deposito; 
        private int diaCobro;
        private string observaciones;
        #endregion

        #region Propiedade Publicas

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
        #endregion
    }
}
