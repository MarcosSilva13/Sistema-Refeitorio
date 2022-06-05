using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaRefeitorio.Forms;

namespace SistemaRefeitorio
{
    public partial class MainForm : Form
    {
        StudentForm studentF = new StudentForm();
        RefectoryForm refectoryF = new RefectoryForm();
        CreditForm creditF = new CreditForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void CadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentF.ShowDialog();
        }
        private void CadastrarCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creditF.ShowDialog();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CafeDaManhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refectoryF.Text = "Café da manhã";
            refectoryF.ShowDialog();
        }

        private void AlmocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refectoryF.Text = "Almoço";
            refectoryF.ShowDialog();
        }

        private void JantarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refectoryF.Text = "Jantar";
            refectoryF.ShowDialog();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema Refeitório\nCopyright © All Right Reserved. Marcos Antônio", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
