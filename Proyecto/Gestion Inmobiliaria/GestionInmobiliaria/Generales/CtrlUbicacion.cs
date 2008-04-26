using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Generales
{
    public partial class CtrlUbicacion : Framework.Seguridad.ControlGISeguridad
    {

        private GI.BR.Propiedades.Ubicacion ubicacion;
        private GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory uff;

        


        public CtrlUbicacion()
        {
            InitializeComponent();

           

        }


        public void Inicializar()
        {
            uff = new GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory();

            cbPais.Items.AddRange(uff.GetPaises().ToArray());
            cbPais.SelectedItem = uff.GetPaises().GetDefault;
        }

        
        public GI.BR.Propiedades.Ubicacion Ubicacion
        {
            get
            {
                return ubicacion;
            }
            set
            {
               
                ubicacion = value;
                ubicacionBindingSource.Add(ubicacion);
            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProvincia.Items.Clear();
            cbProvincia.Items.AddRange(uff.GetProvincias(((GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem).IdPais).ToArray());
            cbProvincia.SelectedItem = uff.GetProvincias(((GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem).IdPais).GetDefault;
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbLocalidad.Items.Clear();
            cbLocalidad.Items.AddRange(uff.GetLocalidades(((GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem).IdProvincia).ToArray());
            cbLocalidad.SelectedItem = uff.GetLocalidades(((GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem).IdProvincia).GetDefault;
        }

        private void cbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBarrio.Items.Clear();
            cbBarrio.Items.AddRange(uff.GetBarrios(((GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem).IdLocalidad).ToArray());
            cbBarrio.SelectedItem = uff.GetBarrios(((GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem).IdLocalidad).GetDefault;
        }

        private void cbBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
