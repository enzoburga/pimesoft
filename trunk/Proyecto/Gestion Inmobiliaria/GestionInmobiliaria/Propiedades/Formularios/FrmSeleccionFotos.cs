using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GI.UI.Propiedades.Formularios
{
    public partial class FrmSeleccionFotos : Form
    {
        public FrmSeleccionFotos()
        {
            InitializeComponent();


         
        }



        public GI.BR.Propiedades.Galeria.GaleriaFotos GaleriaSeleccionada
        {
            get
            {
                GI.BR.Propiedades.Galeria.GaleriaFotos galeria = new GI.BR.Propiedades.Galeria.GaleriaFotos();
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    GI.BR.Propiedades.Galeria.Foto foto = new GI.BR.Propiedades.Galeria.Foto();
                    foto.Descripcion = ((GI.BR.Propiedades.Propiedad)item.Group.Tag).Codigo + "_" + ((GI.BR.Propiedades.Galeria.Foto)item.Tag).Descripcion + ".Jpg";
                    foto.EsFachada = ((GI.BR.Propiedades.Galeria.Foto)item.Tag).EsFachada;
                    foto.IdFoto = ((GI.BR.Propiedades.Galeria.Foto)item.Tag).IdFoto;
                    foto.Imagen = ((GI.BR.Propiedades.Galeria.Foto)item.Tag).Imagen;
                    galeria.Add(foto);
                }

                return galeria;
            
            }
        
        }



        public FrmSeleccionFotos(GI.BR.Propiedades.Propiedades Propiedades)
            : this()
        {



            listView1.BeginUpdate();

            ListViewGroup lvg;


            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(100, 100);

            listView1.LargeImageList = imgList;


            ListViewItem item;

            int i = 0;
            foreach (GI.BR.Propiedades.Propiedad p in Propiedades)
            {
                lvg = new ListViewGroup("Fotos de Propiedad " + p.Codigo);
                lvg.Tag = p;
                listView1.Groups.Add(lvg);

                foreach (GI.BR.Propiedades.Galeria.Foto foto in p.GaleriaFotos)
                {
                    
                    item = new ListViewItem(foto.Descripcion);
                    item.Tag = foto;
                    item.Group = lvg;
                    imgList.Images.Add(foto.Imagen);
                    item.ImageIndex = i++;
                    listView1.Items.Add(item);
                }
            }


            listView1.EndUpdate();

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
            Close();



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
                item.Checked = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
                item.Checked = false;
        }





    }
}