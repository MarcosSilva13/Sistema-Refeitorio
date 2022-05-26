using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaRefeitorio.Forms;
using SistemaRefeitorio.Interface;

namespace SistemaRefeitorio
{
    public partial class MainForm : Form, IVerify
    {
        bool open = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();

            if(IsOpen(open))
            {
                sf.Show();
                open = false;
            }
           /* else if(open == true)
            {
                return;
            }  */
           
        }

        public bool IsOpen(bool open)
        {
            return open;
        }

        private void cafeDaManhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefectoryForm rf = new RefectoryForm();
            rf.Text = "Refeitório - Café da manhã";
            rf.Show();

            //Quandor sair desse form habilitar true;
            almocoToolStripMenuItem.Enabled = false;
        }

        private void almocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefectoryForm rf = new RefectoryForm();
            rf.Text = "Refeitório - Almoço";
            rf.Show();
        }

        private void jantarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
