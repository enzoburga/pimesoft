using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.AdmAlquileres
{
    public class AdmAlquiler : ICloneable
    {
        public AdmAlquiler()
        {
        }

        #region Miembros Privados

        private Clientes.Propietario contacto;
        private Contrato contratoVigente;
        private Contratos contratos;
        private Propiedades.Alquiler alquiler;

        #endregion

        #region Propiedades

        public Contrato ContratoVigente
        {
            get { return contratoVigente; }
            set { contratoVigente = value; }
        }

        /// <summary>
        /// Historico de contratos para esta administración de alquiler.
        /// Contiene el contrato vigente.
        /// </summary>
        public Contratos Contratos
        {
            get
            {
                
                if (contratos == null && this.Alquiler != null)
                {
                    contratos = new Contratos();
                    contratos.RecuperarPorAdmAlquiler(this);
                }

                return contratos;
            }
            set
            {
                contratos = value;
            }
        }

        public GI.BR.Propiedades.Alquiler Alquiler
        {
            get { return alquiler; }
            set
            {
                alquiler = value;
                this.ContratoVigente.Alquiler = value;
            }

        }



        public Clientes.Propietario Contacto { get { return contacto; } set { contacto = value; } }

        #endregion

        #region Persistencia
        internal void fill(System.Data.IDataReader dr)
        {
            #region Contacto

            if(!dr.IsDBNull(dr.GetOrdinal("IdContacto")))
            {
                this.contacto = new GI.BR.Clientes.Propietario();
                contacto.IdCliente = dr.GetInt32(dr.GetOrdinal("IdContacto"));
            }
            
            
            #endregion

            #region Contratos
            this.ContratoVigente = new Contrato();
            this.ContratoVigente.fill(dr);

            if (!dr.IsDBNull(dr.GetOrdinal("IdContratoAnterior")))
            {
                this.ContratoVigente.ContratoAnterior = new Contrato();
                this.ContratoVigente.ContratoAnterior.IdContrato = dr.GetInt32(dr.GetOrdinal("IdContratoAnterior"));
            }

            #endregion

            #region Alquiler
            this.Alquiler = new GI.BR.Propiedades.Alquiler();
            this.Alquiler.IdPropiedad = dr.GetInt32(dr.GetOrdinal("IdPropiedad"));
            #endregion
        }

        public bool Guardar()
        {
            GI.DA.AdmAlquileresData ad = new GI.DA.AdmAlquileresData();
            return ad.Guardar(this.Alquiler.IdPropiedad, (this.Contacto == null) ? 0 : this.Contacto.IdCliente);
        }

        public bool Actualizar()
        {
            GI.DA.AdmAlquileresData ad = new GI.DA.AdmAlquileresData();
            return ad.Actualizar(this.Alquiler.IdPropiedad, (this.Contacto == null) ? 0 : this.Contacto.IdCliente);
        }
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return base.MemberwiseClone();
        }

        #endregion
    }
}
