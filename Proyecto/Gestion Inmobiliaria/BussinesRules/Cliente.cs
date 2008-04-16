using System;
using System.Collections.Generic;
using System.Text;

namespace GI.BR
{
    public abstract class Cliente
    {
        #region Miembros Privados

        private int idCliente;
        private string nombres;
        private string apellido;
        private string nroDocumento;
        private General.emunTipoDocumento tipoDocumento;
        private int telefonoParticular;
        private int telefonoTrabajo;
        private int telefonoCelular;
        private Propiedades.Ubicacion ubicacion;
        private Propiedades.Direccion direccion;
        private string observaciones;
        private DateTime fechaNacimiento;
        private string email;
        #endregion


        #region Propiedades Publicas

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        

        public string NroDocumento
        {
            get { return nroDocumento; }
            set { nroDocumento = value; }
        }


        public General.emunTipoDocumento TipoDocumento
        {
            get { return tipoDocumento; }
            set { tipoDocumento = value; }
        }
        
        public int TelefonoParticular
        {
            get { return telefonoParticular; }
            set { telefonoParticular = value; }
        }

        public int TelefonoTrabajo
        {
            get { return telefonoTrabajo; }
            set { telefonoTrabajo = value; }
        }

        public int TelefonoCelular
        {
            get { return telefonoCelular; }
            set { telefonoCelular = value; }
        }

        public Propiedades.Ubicacion Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }

        public Propiedades.Direccion Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }


        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region Metodos Persistencia

        public bool Guardar()
        {

            GI.DA.ClientesData data = new GI.DA.ClientesData();
            this.IdCliente = data.Guardar(this.FechaNacimiento, this.Email, this.apellido, this.Nombres, this.NroDocumento, this.Observaciones, this.TelefonoCelular, this.TelefonoParticular, this.TelefonoTrabajo, (int)this.TipoDocumento, this.Ubicacion.Barrio.IdBarrio, this.Ubicacion.Provincia.IdProvincia, this.Direccion.Calle, this.Direccion.CodigoPostal, this.Direccion.Depto, this.Direccion.Numero, this.Direccion.Piso);
            
            
            return this.IdCliente > 0;
        }

        public bool Actualizar()
        {
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            return data.Actualizar(this.IdCliente, this.FechaNacimiento, this.Email, this.apellido, this.Nombres, this.NroDocumento, this.Observaciones, this.TelefonoCelular, this.TelefonoParticular, this.TelefonoTrabajo, (int)this.TipoDocumento, this.Ubicacion.Barrio.IdBarrio, this.Ubicacion.Provincia.IdProvincia, this.Direccion.Calle, this.Direccion.CodigoPostal, this.Direccion.Depto, this.Direccion.Numero, this.Direccion.Piso);

        }

        public bool Eliminar()
        {
            GI.DA.ClientesData data = new GI.DA.ClientesData();
            return data.Eliminar(this.IdCliente);
        }


        #endregion


    }
}
