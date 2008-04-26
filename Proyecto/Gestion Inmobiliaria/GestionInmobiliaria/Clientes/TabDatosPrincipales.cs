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
        private GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory uff;

        public GI.BR.Cliente Cliente
        {
            get 
            {
                string error = Validar();
                if (error != "")
                    throw new Exception(error);

                cliente.Direccion = new GI.BR.Propiedades.Direccion();
                cliente.Direccion.Numero = int.Parse(this.tbAltura.Text);
                cliente.Apellido = this.tbApellido.Text;
                cliente.Direccion.Calle = this.tbCalle.Text;
                cliente.Direccion.CodigoPostal = this.tbCodigoPostal.Text;
                cliente.Direccion.Depto = this.tbDepto.Text;
                cliente.Email = this.tbEmail.Text;
                cliente.Nombres = this.tbNombres.Text;
                cliente.NroDocumento = this.tbNroDocumento.Text;
                cliente.Observaciones = this.tbObervaciones.Text;
                cliente.Direccion.Piso = this.tbPiso.Text;

                if (this.tbTelCelular.Text != "")
                    cliente.TelefonoCelular = int.Parse(this.tbTelCelular.Text);
                if (this.tbTelLaboral.Text != "")
                    cliente.TelefonoTrabajo = int.Parse(this.tbTelLaboral.Text);                
                
                cliente.TelefonoParticular = int.Parse(this.tbTelParticular.Text);
                cliente.Ubicacion = new GI.BR.Propiedades.Ubicacion();
                cliente.Ubicacion.Barrio = (GI.BR.Propiedades.Ubicaciones.Barrio)this.cbBarrio.SelectedItem;
                cliente.Ubicacion.Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)this.cbLocalidad.SelectedItem;
                cliente.Ubicacion.Pais = (GI.BR.Propiedades.Ubicaciones.Pais)this.cbPais.SelectedItem;
                cliente.Ubicacion.Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)this.cbProvincia.SelectedItem;
                cliente.TipoDocumento = (GI.BR.General.enumTipoDocumento)this.cbTipoDocumento.SelectedItem;
                cliente.FechaNacimiento = dtpFechaNac.Value;

                //DATOS NO UTILIZADOS
                cliente.Direccion.CalleEntre1 = "";
                cliente.Direccion.CalleEntre2 = "";
                
                
                return cliente;
            
            }
            set //cargar datos del cliente en el TAB.
            { 
                cliente = value;
                if (cliente.IdCliente == 0)
                    return;

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

                if(cliente.TelefonoCelular != 0)
                    this.tbTelCelular.Text = cliente.TelefonoCelular.ToString();
                if (cliente.TelefonoTrabajo != 0)
                    this.tbTelLaboral.Text = cliente.TelefonoTrabajo.ToString();

                this.tbTelParticular.Text = cliente.TelefonoParticular.ToString();
                this.cbBarrio.SelectedIndex = GetIndiceBarrio(cliente.Ubicacion.Barrio);
                this.cbLocalidad.SelectedIndex = GetIndiceLocalidad(cliente.Ubicacion.Localidad);
                this.cbPais.SelectedIndex = GetIndicePais(cliente.Ubicacion.Pais);
                this.cbProvincia.SelectedIndex = GetIndiceProvincia(cliente.Ubicacion.Provincia);
                this.cbTipoDocumento.SelectedItem = cliente.TipoDocumento;
                this.dtpFechaNac.Value = cliente.FechaNacimiento;
            }
        }

        private string Validar()
        {
            if (this.tbAltura.Text == "" ||
            this.tbApellido.Text == "" ||
            this.tbCalle.Text == "" ||
            this.tbCodigoPostal.Text == "" ||
            this.tbEmail.Text == "" ||
            this.tbNombres.Text == "" ||
            this.tbNroDocumento.Text == "" ||
            this.tbTelParticular.Text == "")

                return "Debe completar los datos marcados en rojo para continuar.";

            try { int.Parse(this.tbAltura.Text); }
            catch { return "La altura es un campo numérico."; }

            try
            {
                int.Parse(this.tbTelParticular.Text);

                if(this.tbTelCelular.Text != "")
                    int.Parse(this.tbTelCelular.Text);
                if (this.tbTelLaboral.Text != "")
                    int.Parse(this.tbTelLaboral.Text);
            }
            catch { return "Los telefonos son campos numéricos."; }

            if (!ValidarEmail(this.tbEmail.Text))
                return "La dirección de e-mail ingresada no es válida.";

            return "";
        }

        public static bool ValidarEmail(string email)
        {
            // string que contiene caracteres válidos dentro de un e-mail
            string caracteresvalidos = "abcdefghijklmnopqrstuvwxyz1234567890_-.@";
            if (email.Length < 6) return (false);
            // Se valida sobre e-mail en minúsculas y sin espacios antes y después
            email = email.ToLower().Trim();
            // Verifica todos los caracteres
            for (int i = 0; i < email.Length; i++)
                // ¿Es un caracter no-válido?
                if (caracteresvalidos.IndexOf(email[i]) < 0) return (false);
            // Cantidad de @
            if (email.IndexOf('@') < 0) return (false); // No había @
            if (email.IndexOf('@') != email.LastIndexOf('@'))
                return (false); // Hay más de 1 @
            // Cantidad de . a la derecha de @.
            // Se busca un . sólo en el substring a la derecha del @
            if (email.Substring(email.IndexOf('@'),
            email.Length - email.IndexOf('@') - 1).IndexOf('.') < 0)
                return (false);
            // Que el @ no sea el primer símbolo
            if (email.IndexOf('@') == 0) return (false);
            return true;
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
            throw new Exception("Elemento no encontrado (Barrio).");
        }

        public TabDatosPrincipales()
        {
            
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            //INICIALIZAR COMBOS

            dtpFechaNac.Value = DateTime.Today;

            uff = new GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory();
                
            cbPais.Items.AddRange(uff.GetPaises().ToArray());
            cbPais.SelectedItem = uff.GetPaises().GetDefault;

            cbTipoDocumento.Items.Add(GI.BR.General.enumTipoDocumento.DNI);
            cbTipoDocumento.Items.Add(GI.BR.General.enumTipoDocumento.LC);

            cbTipoDocumento.SelectedIndex = 0; 

        }

        private void TabDatosPrincipales_Load(object sender, EventArgs e)
        {
            
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProvincia.Items.Clear();
            cbProvincia.Items.AddRange(uff.GetProvincias(((GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem).IdPais).ToArray());
            cbProvincia.SelectedItem = uff.GetProvincias(((GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem).IdPais).GetDefault;
        }

        private void cbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBarrio.Items.Clear();
            cbBarrio.Items.AddRange(uff.GetBarrios(((GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem).IdLocalidad).ToArray());
            cbBarrio.SelectedItem = uff.GetBarrios(((GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem).IdLocalidad).GetDefault;
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLocalidad.Items.Clear();
            cbLocalidad.Items.AddRange(uff.GetLocalidades(((GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem).IdProvincia).ToArray());
            cbLocalidad.SelectedItem = uff.GetLocalidades(((GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem).IdProvincia).GetDefault;
        }

       
    }
}
