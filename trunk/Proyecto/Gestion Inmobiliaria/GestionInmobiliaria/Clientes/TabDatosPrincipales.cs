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
        private GI.BR.Clientes.Cliente cliente = null;
        private GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory uff;
        private bool cambioDatos = false;

        public bool CambioDatos
        {
            get { return cambioDatos; }
            set { cambioDatos = value; }
        }

        public GI.BR.Clientes.Cliente Cliente
        {
            get 
            {
                string error = Validar();
                if (error != "")
                    throw new Exception(error);

                cliente.Direccion = new GI.BR.Propiedades.Direccion();
                if (this.tbAltura.Text != "")
                {
                    cliente.Direccion.Numero = int.Parse(this.tbAltura.Text);
                }
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
                else
                    cliente.TelefonoCelular = 0;

                if (this.tbTelLaboral.Text != "")
                    cliente.TelefonoTrabajo = int.Parse(this.tbTelLaboral.Text);
                else
                    cliente.TelefonoTrabajo = 0;

                if (this.tbTelParticular.Text != "")
                    cliente.TelefonoParticular = int.Parse(this.tbTelParticular.Text);
                else
                    cliente.TelefonoParticular = 0;

                cliente.Ubicacion = ctrlUbicacion1.Ubicacion;

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

                if (cliente.Direccion.Numero != 0)
                {
                    this.tbAltura.Text = cliente.Direccion.Numero.ToString();
                }
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
                if (cliente.TelefonoParticular != 0)
                    this.tbTelParticular.Text = cliente.TelefonoParticular.ToString();

                ctrlUbicacion1.Ubicacion = cliente.Ubicacion;
                this.cbTipoDocumento.SelectedItem = cliente.TipoDocumento;
                this.dtpFechaNac.Value = cliente.FechaNacimiento;
                cambioDatos = false;
            }
        }

        private string Validar()
        {
            //if(this.tbCalle.Text == "")
            //    return "Debe completar los datos marcados en rojo para continuar.";
            //if(this.tbCodigoPostal.Text == "")
            //    return "Debe completar los datos marcados en rojo para continuar.";
            //if(this.tbEmail.Text == "")
            //    return "Debe completar los datos marcados en rojo para continuar.";



            if (this.tbApellido.Text == "")
            {
                //this.tbApellido.BackColor = Color.LightSalmon;
                return "Debe completar el campo Apellido.";
            }

            if (this.tbNombres.Text == "")
            {
                return "Debe completar el campo Nombres.";
            }
            if (this.tbNroDocumento.Text == "")
            {
                return "Debe completar el campo Numero de Documento.";
            }

            if (this.tbTelParticular.Text == "" && this.tbTelCelular.Text == "" && this.tbTelLaboral.Text == "")
                return "Debe ingresar al menos un telefono.";

            if (this.tbAltura.Text != "")
            {
                try { int.Parse(this.tbAltura.Text); }
                catch
                {
                    {
                        this.tbApellido.BackColor = Color.LightSalmon;
                    } return "La altura es un campo numérico.";
                }
            }

            try
            {
                if (this.tbTelParticular.Text != "")
                    int.Parse(this.tbTelParticular.Text);
                if (this.tbTelCelular.Text != "")
                    int.Parse(this.tbTelCelular.Text);
                if (this.tbTelLaboral.Text != "")
                    int.Parse(this.tbTelLaboral.Text);
            }
            catch { return "Los telefonos son campos numéricos."; }

            if (this.tbEmail.Text != "")
                if (!ValidarEmail(this.tbEmail.Text))
                {
                    return "La dirección de e-mail ingresada no es válida.";
                }
                    

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

        public TabDatosPrincipales()
        {

            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            //INICIALIZAR COMBOS

            dtpFechaNac.Value = DateTime.Today;
            ctrlUbicacion1.Inicializar();

            uff = new GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory();

            cbTipoDocumento.Items.Add(GI.BR.General.enumTipoDocumento.DNI);
            cbTipoDocumento.Items.Add(GI.BR.General.enumTipoDocumento.LC);

            cbTipoDocumento.SelectedIndex = 0;

        }

        private void TabDatosPrincipales_Load(object sender, EventArgs e)
        {
            
        }

        private void tbNombres_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbNroDocumento_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void cbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbTelParticular_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbTelLaboral_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbTelCelular_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void cbBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbCalle_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbAltura_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbPiso_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbDepto_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbCodigoPostal_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

        private void tbObervaciones_TextChanged(object sender, EventArgs e)
        {
            cambioDatos = true;
        }

       
    }
}
