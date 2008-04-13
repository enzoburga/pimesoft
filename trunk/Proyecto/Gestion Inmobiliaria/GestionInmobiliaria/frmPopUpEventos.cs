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
            item.Text = "Cumplea�os";
            item.SubItems.Add("Faltan 7 d�as para el cumplea�os de Emilio Davidis.");
            lvEventos.Items.Add(item);

            item = new ListViewItem();
            item.Text = "Pago Alquiler";
            item.SubItems.Add("El alquiler de marzo de la pripiedad P00032 venci� hace 10 d�as.");
            lvEventos.Items.Add(item);

            item = new ListViewItem();
            item.Text = "Visita";
            item.SubItems.Add("Faltan 3 horas para para la visita a la propiedad P00032 con Emilio Davidis.");
            lvEventos.Items.Add(item);

        }
    }
}