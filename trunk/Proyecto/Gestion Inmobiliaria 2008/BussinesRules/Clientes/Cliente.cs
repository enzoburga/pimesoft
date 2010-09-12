using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR.Clientes
{


    [Serializable]
    [System.Xml.Serialization.XmlInclude(typeof(ClientePedido))]
    public abstract class Cliente: ICloneable
    {
        #region Miembros Privados

        private int idCliente;
        private string nombres;
        private string apellido;
        private string nroDocumento;
        private General.enumTipoDocumento tipoDocumento;
        private string telefonoParticular;
        private string telefonoTrabajo;
        private string telefonoCelular;
        private Propiedades.Ubicacion ubicacion;
        private Propiedades.Direccion direccion;
        private string observaciones;
        private Nullable<DateTime> fechaNacimiento;
        private string email;
        private bool cargado = false;

        #endregion


        #region Propiedades Publicas




        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public abstract enumTipoClientes TipoCliente
        { get;}
        

        public string Nombres
        {
            get
            {
                if (!cargado)
                    Cargar();
                return nombres; 
            }
            set { nombres = value; }
        }
        

        public string Apellido
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return apellido;
            }
            set { apellido = value; }
        }
        

        public string NroDocumento
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return nroDocumento;
            }
            set { nroDocumento = value; }
        }


        public General.enumTipoDocumento TipoDocumento
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return tipoDocumento;
            }
            set { tipoDocumento = value; }
        }

        public string TelefonoParticular
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return telefonoParticular;
            }
            set { telefonoParticular = value; }
        }

        public bool Cargado
        {
            get { return cargado; }
            set { cargado = value; }
        }


        public string TelefonoTrabajo
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return telefonoTrabajo;
            }
            set { telefonoTrabajo = value; }
        }

        public string TelefonoCelular
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return telefonoCelular;
            }
            set { telefonoCelular = value; }
        }

        public Propiedades.Ubicacion Ubicacion
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return ubicacion;
            }
            set { ubicacion = value; }
        }

        public Propiedades.Direccion Direccion
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return direccion;
            }
            set { direccion = value; }
        }

        public string Observaciones
        {
            get 
            {
                if (!cargado)
                    Cargar(); 
                return observaciones;
            }
            set { observaciones = value; }
        }


        public Nullable< DateTime> FechaNacimiento
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return fechaNacimiento;
            }
            set { fechaNacimiento = value; }
        }


        public string Email
        {
            get
            {
                if (!cargado)
                    Cargar(); 
                return email;
            }
            set { email = value; }
        }
        #endregion

        #region Metodos Persistencia

        private void Cargar()
        {
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            using (System.Data.IDataReader dr = data.RecuperarDatosClientePorId(this.idCliente))
            {
                if (dr.Read())
                    llenar(dr);                
            }
            this.cargado = true;
        }

        public virtual bool Guardar()
        {
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            this.IdCliente = data.GuardarCliente(this.fechaNacimiento, this.email, this.apellido, this.nombres, this.nroDocumento, this.observaciones, this.telefonoCelular, this.telefonoParticular, this.telefonoTrabajo, (int)this.tipoDocumento, (this.ubicacion.Barrio == null) ? 0 : this.ubicacion.Barrio.IdBarrio, (this.ubicacion.Provincia == null) ? 0 : this.ubicacion.Provincia.IdProvincia, this.direccion.Calle, this.direccion.CodigoPostal, this.direccion.Depto, this.direccion.Numero, this.direccion.Piso, this.direccion.CalleEntre1, this.direccion.CalleEntre2, (this.ubicacion.Pais == null) ? 0 : this.ubicacion.Pais.IdPais, (this.ubicacion.Localidad == null)?0:this.ubicacion.Localidad.IdLocalidad);

            return this.IdCliente > 0;
        }

        public virtual bool Actualizar()
        {
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            return data.Actualizar(this.IdCliente, this.fechaNacimiento, this.email, this.apellido, this.nombres, this.nroDocumento, this.observaciones, this.telefonoCelular, this.telefonoParticular, this.telefonoTrabajo, (int)this.tipoDocumento, (this.ubicacion.Barrio == null) ? 0 : this.ubicacion.Barrio.IdBarrio, (this.ubicacion.Provincia == null) ? 0 : this.ubicacion.Provincia.IdProvincia, this.direccion.Calle, this.direccion.CodigoPostal, this.direccion.Depto, this.direccion.Numero, this.direccion.Piso, this.direccion.CalleEntre1, this.direccion.CalleEntre2, (this.ubicacion.Pais == null) ? 0 : this.ubicacion.Pais.IdPais, (this.ubicacion.Localidad == null) ? 0 : this.ubicacion.Localidad.IdLocalidad);

        }

        internal void llenar(System.Data.IDataReader dr)
        {
            this.cargado = true;
            this.Apellido = dr.GetString(dr.GetOrdinal("Apellido"));
            this.Email = dr.GetString(dr.GetOrdinal("Email"));
            if (dr.IsDBNull(dr.GetOrdinal("FechaNacimiento")))
                this.FechaNacimiento = null;
            else
                this.FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento"));

            this.IdCliente = dr.GetInt32(dr.GetOrdinal("IdCliente"));
            this.Nombres = dr.GetString(dr.GetOrdinal("Nombres"));
            this.NroDocumento = dr.GetString(dr.GetOrdinal("NroDocumento"));
            this.Observaciones = dr.GetString(dr.GetOrdinal("Observaciones"));
            this.TelefonoCelular = dr.GetString(dr.GetOrdinal("TelefonoCelular"));
            this.TelefonoParticular = dr.GetString(dr.GetOrdinal("TelefonoParticular"));
            this.TelefonoTrabajo = dr.GetString(dr.GetOrdinal("TelefonoTrabajo"));
            this.TipoDocumento = (GI.BR.General.enumTipoDocumento)dr.GetInt32(dr.GetOrdinal("TipoDocumento"));
            this.Ubicacion = new GI.BR.Propiedades.Ubicacion();
            if (!dr.IsDBNull(dr.GetOrdinal("IdBarrio")))
            {                
                this.Ubicacion.Barrio = new GI.BR.Propiedades.Ubicaciones.Barrio();
                this.Ubicacion.Barrio.IdBarrio = dr.GetInt32(dr.GetOrdinal("IdBarrio"));
            }
            if (!dr.IsDBNull(dr.GetOrdinal("IdLocalidad")))
            {
                this.Ubicacion.Localidad = new GI.BR.Propiedades.Ubicaciones.Localidad();
                this.Ubicacion.Localidad.IdLocalidad = dr.GetInt32(dr.GetOrdinal("IdLocalidad"));
            }
            if (!dr.IsDBNull(dr.GetOrdinal("IdPais")))
            {
                this.Ubicacion.Pais = new GI.BR.Propiedades.Ubicaciones.Pais();
                this.Ubicacion.Pais.IdPais = dr.GetInt32(dr.GetOrdinal("IdPais"));
            }
            if (!dr.IsDBNull(dr.GetOrdinal("IdProvincia")))
            {
                this.Ubicacion.Provincia = new GI.BR.Propiedades.Ubicaciones.Provincia();
                this.Ubicacion.Provincia.IdProvincia = dr.GetInt32(dr.GetOrdinal("IdProvincia"));
            }
            this.Direccion = new GI.BR.Propiedades.Direccion();
            this.Direccion.Calle = dr.GetString(dr.GetOrdinal("Calle"));
            this.Direccion.CalleEntre1 = dr.GetString(dr.GetOrdinal("CalleEntre1"));
            this.Direccion.CalleEntre2 = dr.GetString(dr.GetOrdinal("CalleEntre2"));
            this.Direccion.CodigoPostal = dr.GetString(dr.GetOrdinal("CodigoPostal"));
            this.Direccion.Numero = dr.GetInt32(dr.GetOrdinal("Numero"));
            this.Direccion.Piso = dr.GetString(dr.GetOrdinal("Piso"));
            this.Direccion.Depto = dr.GetString(dr.GetOrdinal("Depto"));
        }


        #endregion

        public override string ToString()
        {
            return this.Apellido + ", " + this.Nombres;
        }

                public string GetTelefonoPpal
        {
            get 
            {
                if (TelefonoParticular != "")
                    return TelefonoParticular.ToString();
                if (TelefonoCelular != "")
                    return TelefonoCelular.ToString();
                if (TelefonoTrabajo != "")
                    return TelefonoTrabajo.ToString();

                return "No hay telefonos cargados.";
            }
        }



        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        public string TelefonosString()
        {
            string sTel = "";
            if (TelefonoParticular != "")
                sTel += TelefonoParticular.ToString() +"/";
            if (TelefonoCelular != "")
                sTel += TelefonoCelular.ToString() + "/";
            if (TelefonoTrabajo != "")
                sTel += TelefonoTrabajo.ToString()+ "/";

            sTel = sTel.Remove(sTel.Length-1);
            return sTel;
        }
    }
}
