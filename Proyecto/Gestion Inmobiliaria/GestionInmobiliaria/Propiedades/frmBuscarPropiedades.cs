using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class frmBuscarPropiedades : Form,GI.Framework.Interfaces.IBuscador
    {
        private Type tipo;
        private GI.BR.Propiedades.Propiedades propiedades;
        GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory uff =GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia;
         


        public frmBuscarPropiedades()
        {
            InitializeComponent();
        }

        public frmBuscarPropiedades(Type Tipo)
            : this()
        {
            tipo = Tipo;
            Inicializar();

            bBuscar.Focus();
        }


        public GI.BR.Propiedades.Propiedades Propiedades
        {
            get { return propiedades; }
           
        }
        
        private void Inicializar()
        {

            GI.BR.Monedas.Monedas monedas = new GI.BR.Monedas.Monedas();
            monedas.RecuperarTodas();
            foreach (GI.BR.Monedas.Moneda m in monedas)
                cbMonedaReal.Items.Add(m);

            cbMonedaReal.SelectedIndex = 0;

            #region Tipo de Propiedad
            cbTipoPropiedad.Items.Add("Seleccione opción...");
            GI.BR.Propiedades.TiposPropiedad tiposPropiedad = new GI.BR.Propiedades.TiposPropiedad();
            tiposPropiedad.RecuperarTodos();
            foreach (GI.BR.Propiedades.TipoPropiedad tipoProp in tiposPropiedad)
            {
                cbTipoPropiedad.Items.Add(tipoProp);
            }


            cbTipoPropiedad.SelectedIndex = 0;
            #endregion

            #region Ambientes
            GI.BR.Propiedades.Ambientes ambientes = new GI.BR.Propiedades.Ambientes();
            ambientes.RecuperarTodos();
            cbAmbientes.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ambiente a in ambientes)
                cbAmbientes.Items.Add(a);
            cbAmbientes.SelectedIndex = 0;
            #endregion

            #region Localidad
            GI.BR.Propiedades.Ubicaciones.Paises Paises = new GI.BR.Propiedades.Ubicaciones.Paises();
            Paises.RecuperarTodos();
            foreach (GI.BR.Propiedades.Ubicaciones.Pais p in Paises)
            {
                cbPais.Items.Add(p);
                if (p.EsDefault)
                    cbPais.SelectedItem = p;
            }
            #endregion

            #region Estados

            GI.BR.Propiedades.EstadosPropiedad Estados = new GI.BR.Propiedades.EstadosPropiedad();
            Estados.RecuperarEstados(tipo);
            cbEstadoPropiedad.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.EstadoPropiedad estado in Estados)
            {
                cbEstadoPropiedad.Items.Add(estado);

            }
            cbEstadoPropiedad.SelectedIndex = 1;



            #endregion
        }



        private void cbPais_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbPais.SelectedIndex > 0) return;

            GI.BR.Propiedades.Ubicaciones.Pais Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Provincias Provincias = uff.GetProvincias(Pais.IdPais); 
            

            cbProvincia.Items.Clear();
            cbLocalidad.Items.Clear();
            cbBarrio.Items.Clear();
            cbProvincia.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Provincia p in Provincias)
            {
                cbProvincia.Items.Add(p);
                if (p.EsDefault)
                    cbProvincia.SelectedItem = p;
            }
                
        }

        private void cbProvincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbProvincia.SelectedIndex <= 0) return;

            GI.BR.Propiedades.Ubicaciones.Provincia Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Localidades Localidades = uff.GetLocalidades(Provincia.IdProvincia);

            cbLocalidad.Items.Clear();
            cbBarrio.Items.Clear();

            cbLocalidad2.Items.Clear();
            cbLocalidad3.Items.Clear();
            cbBarrio2.Items.Clear();
            cbBarrio3.Items.Clear();

            cbLocalidad.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Localidad l in Localidades)
            {
                cbLocalidad.Items.Add(l);
                cbLocalidad2.Items.Add(l);
                cbLocalidad3.Items.Add(l);
                if (l.EsDefault)
                    cbLocalidad.SelectedItem = l;
            }
                //cbLocalidad.SelectedIndex = 0;
        }

        private void cbLocalidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbLocalidad.SelectedIndex <= 0) return;



            GI.BR.Propiedades.Ubicaciones.Localidad Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Barrios Barrios = uff.GetBarrios(Localidad.IdLocalidad);

            cbBarrio.Items.Clear();
            cbBarrio.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in Barrios)
                cbBarrio.Items.Add(b);
            cbBarrio.SelectedIndex = 0;
        }

        private void cbBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBarrio.SelectedIndex <= 0) return;
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            GI.Managers.Propiedades.MngPropiedades mngPropiedades = new GI.Managers.Propiedades.MngPropiedades();



            #region TAB 1

            if (tabControlTiposDeBusqueda.SelectedIndex == 0)
            {

                GI.BR.Propiedades.UbicacionesCollection Ubicaciones = new GI.BR.Propiedades.UbicacionesCollection();

                GI.BR.Propiedades.TipoPropiedad TipoProp = null;
                GI.BR.Propiedades.Ubicacion Ubicacion = new GI.BR.Propiedades.Ubicacion();


                GI.BR.Propiedades.Ambiente Ambiente = null;
                GI.BR.Propiedades.EstadoPropiedad Estado = null;
                GI.BR.Valor ValorDesde = null;
                GI.BR.Valor ValorHasta = null;
                if (cbTipoPropiedad.SelectedIndex > 0)
                    TipoProp = (GI.BR.Propiedades.TipoPropiedad)cbTipoPropiedad.SelectedItem;

                if (cbPais.SelectedIndex > 0)
                    Ubicacion.Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;
                if (cbProvincia.SelectedIndex > 0)
                    Ubicacion.Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;
                if (cbLocalidad.SelectedIndex > 0)
                    Ubicacion.Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem;
                if (cbBarrio.SelectedIndex > 0)
                    Ubicacion.Barrio = (GI.BR.Propiedades.Ubicaciones.Barrio)cbBarrio.SelectedItem;

                Ubicaciones.Add(Ubicacion);

                // 2da Ubicacion
                if (cbLocalidad2.SelectedItem != null)
                {
                    GI.BR.Propiedades.Ubicacion ub2 = new GI.BR.Propiedades.Ubicacion();
                    ub2.Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;
                    ub2.Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;
                    ub2.Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad2.SelectedItem;
                    if (cbBarrio2.SelectedItem != null)
                    {
                        ub2.Barrio = (GI.BR.Propiedades.Ubicaciones.Barrio)cbBarrio2.SelectedItem;
                    }
                    Ubicaciones.Add(ub2);
                }

                // 3ra Ubicacion
                if (cbLocalidad3.SelectedItem != null)
                {
                    GI.BR.Propiedades.Ubicacion ub3 = new GI.BR.Propiedades.Ubicacion();
                    ub3.Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;
                    ub3.Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;
                    ub3.Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad3.SelectedItem;
                    if (cbBarrio3.SelectedItem != null)
                    {
                        ub3.Barrio = (GI.BR.Propiedades.Ubicaciones.Barrio)cbBarrio3.SelectedItem;
                    }
                    Ubicaciones.Add(ub3);
                }



                if (cbAmbientes.SelectedIndex > 0)
                    Ambiente = (GI.BR.Propiedades.Ambiente)cbAmbientes.SelectedItem;

                if (cbEstadoPropiedad.SelectedIndex > 0)
                    Estado = (GI.BR.Propiedades.EstadoPropiedad)cbEstadoPropiedad.SelectedItem;

                decimal importeDesde = 0;
                if (decimal.TryParse(textBoxValorDesde.Text, out importeDesde))
                {
                    ValorDesde = new GI.BR.Valor();
                    ValorDesde.Importe = importeDesde;
                    ValorDesde.Moneda = (GI.BR.Monedas.Moneda)cbMonedaReal.SelectedItem;

                }

                decimal importeHasta = 0;
                if (decimal.TryParse(textBoxValorHasta.Text, out importeHasta))
                {
                    ValorHasta = new GI.BR.Valor();
                    ValorHasta.Importe = importeHasta;
                    ValorHasta.Moneda = (GI.BR.Monedas.Moneda)cbMonedaReal.SelectedItem;

                }

                propiedades = mngPropiedades.RecuperarPropiedades(tipo, TipoProp, Estado, Ambiente, Ubicaciones, ValorDesde, ValorHasta);
            } 
            #endregion

            #region TAB 2
            if (tabControlTiposDeBusqueda.SelectedIndex == 1)
            {
                int numero = 0;
                Int32.TryParse(textBoxNumero.Text, out numero);
                propiedades = mngPropiedades.RecuperarPropiedades(tipo, textBoxDireccion.Text, numero);
            }
            #endregion


            GI.BR.Propiedades.Propiedad Prop = null;
            if (tipo is GI.BR.Propiedades.Alquiler)
                Prop = new GI.BR.Propiedades.Alquiler();
            else
                Prop = new GI.BR.Propiedades.Venta();

            int id = 0;
            Int32.TryParse(textBoxIdProp.Text, out id);
            Prop.RecuperarPorId(id);
            if (Prop.IdPropiedad > 0)
            {
                propiedades = new GI.BR.Propiedades.Propiedades();
                propiedades.Add(Prop);
            }
            






            if (this.Propiedades == null || this.Propiedades.Count == 0)
            {
                GI.Framework.General.GIMsgBox.ShowNoSeEncontraronDatos();
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();



        }

        #region IBuscador Members

        public List<object> GetObjetosEncontrados()
        {
            List<object> lista = new List<object>();
            lista.AddRange(this.Propiedades.ToArray());
            return lista;
        }

        public void SetTipoBusqueda(Type tipoObjeto)
        {
            
        }

        public DialogResult MostrarBuscador()
        {
            return this.ShowDialog();
        }

        #endregion

        private void cbLocalidad2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalidad2.SelectedIndex <= 0) return;



            GI.BR.Propiedades.Ubicaciones.Localidad Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad2.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Barrios Barrios = uff.GetBarrios(Localidad.IdLocalidad);

            cbBarrio2.Items.Clear();
            //cbBarrio2.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in Barrios)
                cbBarrio2.Items.Add(b);
            //cbBarrio.SelectedIndex = 0;
        }

        private void cbLocalidad3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocalidad3.SelectedIndex <= 0) return;



            GI.BR.Propiedades.Ubicaciones.Localidad Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad3.SelectedItem;
            GI.BR.Propiedades.Ubicaciones.Barrios Barrios = uff.GetBarrios(Localidad.IdLocalidad);

            cbBarrio3.Items.Clear();
            //cbBarrio2.Items.Add("Seleccione opción...");
            foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in Barrios)
                cbBarrio3.Items.Add(b);
            //cbBarrio.SelectedIndex = 0;
        }

        
    }
}