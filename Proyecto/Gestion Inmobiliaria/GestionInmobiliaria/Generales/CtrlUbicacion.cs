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
        private bool inicializado = false;
        


        public CtrlUbicacion()
        {
            InitializeComponent();
            
        }


        public void Inicializar()
        {
            if (!inicializado)
            {
                uff = new GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory();

                cbPais.Items.AddRange(uff.GetPaises().ToArray());
                cbPais.SelectedItem = uff.GetPaises().GetDefault;
                inicializado = true;
            }
        }

        
        public GI.BR.Propiedades.Ubicacion Ubicacion
        {
            get
            {
                this.ubicacion.Barrio = (GI.BR.Propiedades.Ubicaciones.Barrio)cbBarrio.SelectedItem;
                this.ubicacion.Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;
                this.ubicacion.Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;
                this.ubicacion.Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem;
                return ubicacion;
            }
            set
            {
                if (!inicializado)
                    Inicializar();

                ubicacion = value;

                

                this.cbPais.SelectedIndex = GetIndicePais(ubicacion.Pais);
                this.cbProvincia.SelectedIndex = GetIndiceProvincia(ubicacion.Provincia);
                this.cbLocalidad.SelectedIndex = GetIndiceLocalidad(ubicacion.Localidad);
                this.cbBarrio.SelectedIndex = GetIndiceBarrio(ubicacion.Barrio);  
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

        private void CtrlUbicacion_Load(object sender, EventArgs e)
        {
        }

        #region GetIndices
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
        #endregion
    }
}
