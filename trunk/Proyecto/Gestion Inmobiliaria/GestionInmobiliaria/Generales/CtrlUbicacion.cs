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

        private bool opcionTodos = false;
        public bool OpcionTodos
        {
            get { return opcionTodos; }
            set { opcionTodos = value; }
        }

        public void Inicializar()
        {
            try
            {
                if (!inicializado)
                {
                    uff = GI.BR.Propiedades.Ubicaciones.UbicacionFlyweightFactory.GetInstancia;
                    if(opcionTodos)
                        cbPais.Items.Add("Todos");
                    cbPais.Items.AddRange(uff.GetPaises().ToArray());
                    if (opcionTodos)
                        cbPais.SelectedIndex = 0;
                    else
                        cbPais.SelectedItem = uff.GetPaises().GetDefault;
                    inicializado = true;
                }
            }
            catch { }
        }

        
        public GI.BR.Propiedades.Ubicacion Ubicacion
        {
            get
            {
                if (ubicacion == null) ubicacion = new GI.BR.Propiedades.Ubicacion();

                if (cbBarrio.SelectedItem.ToString() == "Todos")
                    this.ubicacion.Barrio = null;
                else
                    this.ubicacion.Barrio = (GI.BR.Propiedades.Ubicaciones.Barrio)cbBarrio.SelectedItem;

                if (cbPais.SelectedItem.ToString() == "Todos")
                    this.ubicacion.Pais = null;
                else
                    this.ubicacion.Pais = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem;

                if (cbProvincia.SelectedItem.ToString() == "Todos")
                    this.ubicacion.Provincia = null;
                else
                    this.ubicacion.Provincia = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem;

                if (cbLocalidad.SelectedItem.ToString() == "Todos")
                    this.ubicacion.Localidad = null;
                else
                    this.ubicacion.Localidad = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem;

                return ubicacion;
            }
            set
            {
                if (!inicializado)
                    Inicializar();

                ubicacion = value;

                if (ubicacion == null || ubicacion.Pais==null) return;
                if(opcionTodos)

                this.cbPais.SelectedIndex = GetIndicePais(ubicacion.Pais);
                this.cbProvincia.SelectedIndex = GetIndiceProvincia(ubicacion.Provincia);
                this.cbLocalidad.SelectedIndex = GetIndiceLocalidad(ubicacion.Localidad);
                this.cbBarrio.SelectedIndex = GetIndiceBarrio(ubicacion.Barrio);  
            }
        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProvincia.Items.Clear();
            if (opcionTodos)
            {
                cbProvincia.Items.Add("Todos");
                if (cbPais.SelectedItem.ToString() != "Todos")
                    cbProvincia.Items.AddRange(uff.GetProvincias(((GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem).IdPais).ToArray());
                cbProvincia.SelectedIndex = 0;
            }
            else
            {
                cbProvincia.Items.AddRange(uff.GetProvincias(((GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem).IdPais).ToArray());
                cbProvincia.SelectedItem = uff.GetProvincias(((GI.BR.Propiedades.Ubicaciones.Pais)cbPais.SelectedItem).IdPais).GetDefault;

            }
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbLocalidad.Items.Clear();
            if (opcionTodos)
            {
                cbLocalidad.Items.Add("Todos");
                if (cbProvincia.SelectedItem.ToString() != "Todos")
                    cbLocalidad.Items.AddRange(uff.GetLocalidades(((GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem).IdProvincia).ToArray());
                cbLocalidad.SelectedIndex = 0;
            }
            else
            {
                cbLocalidad.Items.AddRange(uff.GetLocalidades(((GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem).IdProvincia).ToArray());
                cbLocalidad.SelectedItem = uff.GetLocalidades(((GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.SelectedItem).IdProvincia).GetDefault;

            }
        }

        private void cbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbBarrio.Items.Clear();
            if (opcionTodos)
            {
                cbBarrio.Items.Add("Todos");
                if (cbLocalidad.SelectedItem.ToString() != "Todos")
                    cbBarrio.Items.AddRange(uff.GetBarrios(((GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem).IdLocalidad).ToArray());
                cbBarrio.SelectedIndex = 0;
            }
            else
            {
                cbBarrio.Items.AddRange(uff.GetBarrios(((GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem).IdLocalidad).ToArray());
                cbBarrio.SelectedItem = uff.GetBarrios(((GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.SelectedItem).IdLocalidad).GetDefault;
            }
        }

        private void CtrlUbicacion_Load(object sender, EventArgs e)
        {
        }

        #region GetIndices
        private int GetIndiceProvincia(GI.BR.Propiedades.Ubicaciones.Provincia provincia)
        {
            int index = 0;
            if (opcionTodos)
            {
                index = 1;
                if (provincia == null)
                    return 0;
            }

            GI.BR.Propiedades.Ubicaciones.Provincia p;

            for (; index < cbProvincia.Items.Count;index++ )
            {
                p = (GI.BR.Propiedades.Ubicaciones.Provincia)cbProvincia.Items[index];
                if (p.IdProvincia == provincia.IdProvincia)
                    return index;
            }
            throw new Exception("Elemento no encontrado (Provincia).");
        }

        private int GetIndicePais(GI.BR.Propiedades.Ubicaciones.Pais pais)
        {
            int index = 0;
            if (opcionTodos)
            {
                index = 1;
                if (pais == null)
                    return 0;
            }

            GI.BR.Propiedades.Ubicaciones.Pais p;

            for (; index < cbPais.Items.Count; index++)
            {
                p = (GI.BR.Propiedades.Ubicaciones.Pais)cbPais.Items[index];
                if (p.IdPais == pais.IdPais)
                    return index;
            }

            //int index = 0;
            //foreach (GI.BR.Propiedades.Ubicaciones.Pais p in cbPais.Items)
            //{
            //    if (p.IdPais == pais.IdPais)
            //        return index;
            //    index++;
            //}
            throw new Exception("Elemento no encontrado (Pais).");
        }

        private int GetIndiceLocalidad(GI.BR.Propiedades.Ubicaciones.Localidad localidad)
        {

            int index = 0;
            if (opcionTodos)
            {
                index = 1;
                if (localidad == null)
                    return 0;
            }

            GI.BR.Propiedades.Ubicaciones.Localidad p;

            for (; index < cbLocalidad.Items.Count; index++)
            {
                p = (GI.BR.Propiedades.Ubicaciones.Localidad)cbLocalidad.Items[index];
                if (p.IdLocalidad == localidad.IdLocalidad)
                    return index;
            }

            //int index = 0;
            //foreach (GI.BR.Propiedades.Ubicaciones.Localidad l in cbLocalidad.Items)
            //{
            //    if (l.IdLocalidad == localidad.IdLocalidad)
            //        return index;
            //    index++;
            //}
            throw new Exception("Elemento no encontrado (Localidad).");
        }

        private int GetIndiceBarrio(GI.BR.Propiedades.Ubicaciones.Barrio barrio)
        {

            int index = 0;
            if (opcionTodos)
            {
                index = 1;
                if (barrio == null)
                    return 0;
            }

            GI.BR.Propiedades.Ubicaciones.Barrio p;

            for (; index < cbBarrio.Items.Count; index++)
            {
                p = (GI.BR.Propiedades.Ubicaciones.Barrio)cbBarrio.Items[index];
                if (p.IdBarrio == barrio.IdBarrio)
                    return index;
            }

            //int index = 0;
            //foreach (GI.BR.Propiedades.Ubicaciones.Barrio b in cbBarrio.Items)
            //{
            //    if (b.IdBarrio == barrio.IdBarrio)
            //        return index;
            //    index++;
            //}
            throw new Exception("Elemento no encontrado (Barrio).");
        } 
        #endregion
    }
}
