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
        StudentForm sf = new StudentForm();
        RefectoryForm rf = new RefectoryForm();
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
            sf.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CafeDaManhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rf.ShowDialog();
        }
    }
}
