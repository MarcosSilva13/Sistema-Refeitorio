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
        StudentForm studentF = new StudentForm();
        RefectoryForm refectoryF = new RefectoryForm();
        CreditForm creditF = new CreditForm();
        public MainForm()
        {
            InitializeComponent();
        }

        public bool IsOpen(bool open)
        {
            throw new NotImplementedException();
        }

        private void CadastrarAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentF.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CafeDaManhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refectoryF.Text = "Refeitório - Café da manhã";
            refectoryF.ShowDialog();
        }

        private void CadastrarCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            creditF.ShowDialog();
        }
    }
}
