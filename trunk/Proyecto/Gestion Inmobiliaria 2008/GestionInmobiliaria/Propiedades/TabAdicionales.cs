using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades
{
    public partial class TabAdicionales : TabContenidoPropiedad
    {
        public TabAdicionales()
        {
            InitializeComponent();
        }




        public override GI.BR.Propiedades.Propiedad GetPropiedad()
        {
            Propiedad.Jardin = checkBoxJardin.Checked;
            Propiedad.Patio = checkBoxPatio.Checked;
            Propiedad.Piscina = checkBoxPiscina.Checked;
            Propiedad.Lavadero = checkBoxLavadero.Checked;
            Propiedad.Dependencia = checkBoxDependencia.Checked;
            Propiedad.Quincho = checkBoxQuincho.Checked;
            Propiedad.Parrilla = checkBoxParrilla.Checked;
            Propiedad.Balcon = checkBoxBalcon.Checked;
            Propiedad.Terraza = checkBoxTerraza.Checked;
            Propiedad.Playroom = checkBoxPlayroom.Checked;
            Propiedad.Baulera = checkBoxBaulera.Checked;
            Propiedad.CuartoHerraminetas = checkBoxCuartoHerramientas.Checked;


            return Propiedad;


        }


        protected override void CargarPropiedad()
        {


            checkBoxBalcon.Checked = Propiedad.Balcon;
            checkBoxBaulera.Checked = Propiedad.Baulera;
            checkBoxCuartoHerramientas.Checked = Propiedad.CuartoHerraminetas;
            checkBoxDependencia.Checked = Propiedad.CuartoHerraminetas;
            checkBoxJardin.Checked = Propiedad.Jardin;
            checkBoxLavadero.Checked = Propiedad.Lavadero;
            checkBoxParrilla.Checked = Propiedad.Parrilla;
            checkBoxPatio.Checked = Propiedad.Patio;
            checkBoxPiscina.Checked = Propiedad.Piscina;
            checkBoxPlayroom.Checked = Propiedad.Playroom;
            checkBoxQuincho.Checked = Propiedad.Quincho;
            checkBoxTerraza.Checked = Propiedad.Terraza;









        }

        private void TabAdicionales_Load(object sender, EventArgs e)
        {

        }
    }
}
