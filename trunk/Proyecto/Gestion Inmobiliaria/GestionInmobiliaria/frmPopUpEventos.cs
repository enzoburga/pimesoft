using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI
{
    public partial class frmPopUpEventos : Form
    {
        public frmPopUpEventos()
        {
            InitializeComponent();

            ListViewItem item;

            item = new ListViewItem();
            item.Text = "Cumpleaños";
            item.SubItems.Add("Faltan 7 días para el cumpleaños de Emilio Davidis.");
            lvEventos.Items.Add(item);

            item = new ListViewItem();
            item.Text = "Pago Alquiler";
            item.SubItems.Add("El alquiler de marzo de la pripiedad P00032 venció hace 10 días.");
            lvEventos.Items.Add(item);

            item = new ListViewItem();
            item.Text = "Visita";
            item.SubItems.Add("Faltan 3 horas para para la visita a la propiedad P00032 con Emilio Davidis.");
            lvEventos.Items.Add(item);

        }
    }
}