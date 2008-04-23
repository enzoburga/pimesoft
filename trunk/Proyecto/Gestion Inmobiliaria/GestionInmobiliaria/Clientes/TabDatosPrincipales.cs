using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Clientes
{
    public partial class TabDatosPrincipales : Framework.Seguridad.ControlGISeguridad
    {
        private GI.BR.Cliente cliente = null;

        public GI.BR.Cliente Cliente
        {
            get 
            {
                string error = Validar();
                if (error != "")
                    throw new Exception(error);

                cliente.Direccion.Numero = int.Parse( this.tbAltura.Text);
                cliente.Apellido = this.tbApellido.Text;
                cliente.Direccion.Calle = this.tbCalle.Text;
                cliente.Direccion.CodigoPostal = this.tbCodigoPostal.Text;
                cliente.Direccion.Depto = this.tbDepto.Text;
                cliente.Email = this.tbEmail.Text;
                cliente.Nombres = this.tbNombres.Text;
                cliente.NroDocumento = this.tbNroDocumento.Text;
                cliente.Observaciones = this.tbObervaciones.Text;
                cliente.Direccion.Piso = this.tbPiso.Text;
                cliente.TelefonoCelular = int.Parse(this.tbTelCelular.Text);
                cliente.TelefonoTrabajo = int.Parse(this.tbTelLaboral.Text);
                cliente.TelefonoParticular = int.Parse(this.tbTelParticular.Text);
                cliente.Ubicacion.Barrio = (GI.BR.Propiedades.Ubicaciones.Barrio)this.cbBarrio.SelectedItem;
                cliente.Ubicacion.Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)this.cbLocalidad.SelectedItem;
                cliente.Ubicacion.Pais = (GI.BR.Propiedades.Ubicaciones.Pais)this.cbPais.SelectedItem;
                cliente.Ubicacion.Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)this.cbProvincia.SelectedItem;
                cliente.TipoDocumento = (GI.BR.General.enumTipoDocumento)this.cbTipoDocumento.SelectedItem;
                return cliente;
            
            }
            set //cargar datos del cliente en el TAB.
            { 
                cliente = value;
                this.tbAltura.Text = cliente.Direccion.Numero.ToString();
                this.tbApellido.Text = cliente.Apellido;
                this.tbCalle.Text = cliente.Direccion.Calle;
                this.tbCodigoPostal.Text = cliente.Direccion.CodigoPostal;
                this.tbDepto.Text = cliente.Direccion.Depto;
                this.tbEmail.Text = cliente.Email;
                this.tbNombres.Text = cliente.Nombres;
                this.tbNroDocumento.Text = cliente.NroDocumento;
                this.tbObervaciones.Text = cliente.Observaciones;
                this.tbPiso.Text = cliente.Direccion.Piso;
                this.tbTelCelular.Text = cliente.TelefonoCelular.ToString();
                this.tbTelLaboral.Text = cliente.TelefonoTrabajo.ToString();
                this.tbTelParticular.Text = cliente.TelefonoParticular.ToString();
                //this.cbBarrio.SelectedIndex = GetIndiceBarrio(cliente.Ubicacion.Barrio);
                //this.cbLocalidad.SelectedIndex = GetIndiceLocalidad(cliente.Ubicacion.Localidad);
                //this.cbPais.SelectedIndex = GetIndicePais(cliente.Ubicacion.Pais);
                //this.cbProvincia.SelectedIndex = GetIndiceProvincia(cliente.Ubicacion.Provincia);
                this.cbTipoDocumento.SelectedItem = cliente.TipoDocumento;            
            }
        }

        private string Validar()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        private int GetIndiceProvincia(GI.BR.Propiedades.Ubicaciones.Provincia provincia)
        {
            int index = 0;
            foreach (GI.BR.Propiedades.Ubicaciones.Provincia p in cbProvincia.Items)
            {
                if (p.IdProvincia == provincia.IdProvincia)
                    return index;
                index++;
            }
            return 0;
            throw new Exception("Elemento no encontrado (Provincia).");
        }

        private int GetIndicePais(GI.BR.Propiedades.Ubicaciones.Pais pais)
        {
            int index = 0;
            foreach (GI.BR.Propiedades.Ubicaciones.Pais p in cbPais.Items)
            {
                if (p.IdPais == pais.IdPais)
                    return index;
                index++;
            }

            return 0;
            throw new Exception("Elemento no encontrado (Pais).");
        }

        private int GetIndiceLocalidad(GI.BR.Propiedades.Ubicaciones.Localidad localidad)
        {
            int index = 0;
            foreach (GI.BR.Propiedades.Ubicaciones.Localidad l in cbLocalidad.Items)
            {
                if (l.IdLocalidad == localidad.IdLocalidad)
                    return index;
                index++;
            }
            return 0;
            throw new Exception("Elemento no encontrado (Localidad).");
        }

        private int GetIndiceBarrio(GI.BR.Propiedades.Ubicaciones.Barrio barrio)
        {
            int index = 0;
            foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in cbBarrio.Items)
            {
                if (b.IdBarrio == barrio.IdBarrio)
                    return index;
                index++;
            }
            return 0;
            throw new Exception("Elemento no encontrado (Barrio).");
        }

        public TabDatosPrincipales()
        {
            InitializeComponent();
        }

        private void Inicializar()
        {
            //INICIALIZAR COMBOS
            cbBarrio.Items.Add("Beccar");
            cbLocalidad.Items.Add("San Isidro");
            cbPais.Items.Add("Argentina");
            cbProvincia.Items.Add("Buenos Aires");
            cbTipoDocumento.Items.Add(GI.BR.General.enumTipoDocumento.DNI);
            cbTipoDocumento.Items.Add(GI.BR.General.enumTipoDocumento.LC);

        }

        private void TabDatosPrincipales_Load(object sender, EventArgs e)
        {
            Inicializar();
        }
    }
}
