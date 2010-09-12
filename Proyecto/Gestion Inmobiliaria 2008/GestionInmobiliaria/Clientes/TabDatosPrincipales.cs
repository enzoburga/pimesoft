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

                //cliente.Direccion = new GI.BR.Propiedades.Direccion();

                cliente.Apellido = this.tbApellido.Text;
                cliente.Email = this.tbEmail.Text;
                cliente.Nombres = this.tbNombres.Text;
                cliente.NroDocumento = this.tbNroDocumento.Text;
                cliente.Observaciones = this.tbObervaciones.Text;


                cliente.TelefonoCelular = this.tbTelCelular.Text;
                cliente.TelefonoTrabajo = this.tbTelLaboral.Text;
                cliente.TelefonoParticular = this.tbTelParticular.Text;


                cliente.Ubicacion = ctrlUbicacion1.Ubicacion;
                //usa databindig, no hace falta volver a setearlo
                //cliente.Direccion = ctrlDireccion1.Direccion;

                cliente.TipoDocumento = (GI.BR.General.enumTipoDocumento)this.cbTipoDocumento.SelectedItem;
                if (dtpFechaNac.Checked)
                    cliente.FechaNacimiento = dtpFechaNac.Value;
                else
                    cliente.FechaNacimiento = null;

                //DATOS NO UTILIZADOS
                //cliente.Direccion.CalleEntre1 = "";
                //cliente.Direccion.CalleEntre2 = "";


                return cliente;

            }
            set //cargar datos del cliente en el TAB.
            { 
                cliente = value;
                if (cliente.Direccion == null)
                    cliente.Direccion = new GI.BR.Propiedades.Direccion();
                ctrlDireccion1.Direccion = cliente.Direccion;
                this.dtpFechaNac.Checked = false;
                if (cliente.IdCliente == 0)
                    return;

                this.tbApellido.Text = cliente.Apellido;

                this.tbEmail.Text = cliente.Email;
                this.tbNombres.Text = cliente.Nombres;
                this.tbNroDocumento.Text = cliente.NroDocumento;
                this.tbObervaciones.Text = cliente.Observaciones;

                this.tbTelCelular.Text = cliente.TelefonoCelular.ToString();
                this.tbTelLaboral.Text = cliente.TelefonoTrabajo.ToString();
                this.tbTelParticular.Text = cliente.TelefonoParticular.ToString();

                ctrlUbicacion1.Ubicacion = cliente.Ubicacion;
                
                this.cbTipoDocumento.SelectedItem = cliente.TipoDocumento;
                if (cliente.FechaNacimiento.HasValue)
                {
                    this.dtpFechaNac.Checked = true;
                    this.dtpFechaNac.Value = cliente.FechaNacimiento.Value;
                }
                else
                    this.dtpFechaNac.Checked = false;
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



            //if (this.tbApellido.Text == "")
            //{
            //    //this.tbApellido.BackColor = Color.LightSalmon;
            //    return "Debe completar el campo Apellido.";
            //}

            if (this.tbNombres.Text == "")
            {
                return "Debe completar el campo Nombres.";
            }
            //if (this.tbNroDocumento.Text == "")
            //{
            //    return "Debe completar el campo Numero de Documento.";
            //}

            if (this.tbTelParticular.Text == "" && this.tbTelCelular.Text == "" && this.tbTelLaboral.Text == "")
                return "Debe ingresar al menos un telefono.";


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

            uff = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia;

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
