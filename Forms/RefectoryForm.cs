using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaRefeitorio.Forms
{
    public partial class RefectoryForm : Form
    {
        public RefectoryForm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("T");
        }


       

        private void groupBox2_Paint(object sender, PaintEventArgs p)
        {
            //ControlPaint.DrawBorder(p.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
            //ControlPaint.DrawBorder3D(p.Graphics, this.ClientRectangle, Border3DStyle.SunkenInner);
            /*GroupBox box = (GroupBox)sender;
            p.Graphics.Clear(SystemColors.ControlDark);
            p.Graphics.DrawString(box.Text, box.Font, Brushes.Black, 0, 0);
            groupBox2.Paint += PaintBorderlessGroupBox;*/
        }
    }
}
