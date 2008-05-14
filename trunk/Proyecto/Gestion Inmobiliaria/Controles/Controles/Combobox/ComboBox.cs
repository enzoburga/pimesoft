using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;


namespace GI.Framework
{
    public class ComboBox : System.Windows.Forms.ComboBox
    {
        public ComboBox()
            : base()
        {
            base.DropDown += new EventHandler(SGMComboBox_DropDown);
            base.DropDownStyle = ComboBoxStyle.DropDownList;

            
        }

        
        protected override void OnPaint(PaintEventArgs e)
        {
            
            if (this.Enabled)
            {
                SolidBrush drawBrush = new SolidBrush(Color.Red); //Use the ForeColor property
                // Draw string to screen.
                e.Graphics.DrawString(Text, Font, drawBrush, 0f, 0f); //Use the Font property
            }
            else
            {
                SolidBrush drawBrush = new SolidBrush(Color.Blue); //Use the ForeColor property
                // Draw string to screen.
                e.Graphics.DrawString(Text, Font, drawBrush, 0f, 0f); //Use the Font property
            }
        }

        void SGMComboBox_DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (object o in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(o.ToString(), font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

    }
}
