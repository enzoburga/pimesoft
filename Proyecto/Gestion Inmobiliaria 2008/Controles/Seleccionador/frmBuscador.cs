using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.Framework.Seleccionador
{
    public partial class frmBuscador : Form
    {

        System.Collections.Generic.List<Seleccionador.MetodoBusqueda> metodos;

        public frmBuscador()
        {
            InitializeComponent();
        }




        public frmBuscador(System.Collections.Generic.List<Seleccionador.MetodoBusqueda> Metodos)
            : this()
        {

            foreach (Seleccionador.MetodoBusqueda metodo in Metodos)
                cbCriterios.Items.Add(metodo);

            cbCriterios.SelectedIndex = 0;
    



        
        }


        public Seleccionador.MetodoBusqueda Metodo
        {
            get 
            {
                return (Seleccionador.MetodoBusqueda)cbCriterios.SelectedItem;
            }
        }

        private void cbCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCriterios.SelectedItem == null) return;

            switch (((Seleccionador.MetodoBusqueda)cbCriterios.SelectedItem).TipoBusqueda)
            { 
                case EnumTipoBusqueda.Texto:
                    cbOpciones.Visible = false;
                    txtbuscador.Visible = true;
                    txtbuscador.Text = "";
                    break;
                case EnumTipoBusqueda.Seleccion:
                    cbOpciones.Visible = true;
                    txtbuscador.Visible = false;
                    cbOpciones.Items.Clear();
                    foreach (object o in ((Seleccionador.MetodoBusqueda)cbCriterios.SelectedItem).ValoresPosibles)
                    {
                        cbOpciones.Items.Add(o);
                    }
                    cbOpciones.SelectedIndex = 0;
                    break;
                case EnumTipoBusqueda.SinEntrada:
                    cbOpciones.Visible = false;
                    txtbuscador.Visible = false;
                    break;

            
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            switch (((Seleccionador.MetodoBusqueda)cbCriterios.SelectedItem).TipoBusqueda)
            {
                case EnumTipoBusqueda.Texto:
                    ((Seleccionador.MetodoBusqueda)cbCriterios.SelectedItem).ValorSeleccionado = txtbuscador.Text;
                    break;
                case EnumTipoBusqueda.Seleccion:
                    ((Seleccionador.MetodoBusqueda)cbCriterios.SelectedItem).ValorSeleccionado = (Seleccionador.MetodoBusqueda)cbCriterios.SelectedItem;
                    break;
                case EnumTipoBusqueda.SinEntrada:
                    ((Seleccionador.MetodoBusqueda)cbCriterios.SelectedItem).ValorSeleccionado = null;
                    break;


            }


            DialogResult = DialogResult.OK;
            Close();
        }
    }
}