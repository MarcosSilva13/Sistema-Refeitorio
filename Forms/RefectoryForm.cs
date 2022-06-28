using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SistemaRefeitorio.Model.Entities;
using SistemaRefeitorio.Model.SQL;

namespace SistemaRefeitorio.Forms
{
    public partial class RefectoryForm : Form
    {
        Student studentF;
        RefectorySQL refSQL;
        
        string status = String.Empty;
        public RefectoryForm()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("T");
        }

        private void RefectoryForm_Load(object sender, EventArgs e)
        {
            lblAcesso.Text = String.Empty;
            lblNumCredito.Text = "0";
            pbAluno.Image = null;
            mtbCpfRef.Text = String.Empty;
            mtbCpfRef.Focus();

            status = this.Text;
            
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            studentF = new Student(mtbCpfRef.Text);
            refSQL = new RefectorySQL();
            
            studentF = refSQL.GetData(studentF);

            if(studentF == null)
            {
                mtbCpfRef.Text = String.Empty;
                mtbCpfRef.Focus();
                return;
            }

            if(studentF.Picture == null)
            {
                pbAluno.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(studentF.Picture);
                pbAluno.Image = System.Drawing.Image.FromStream(mstream);

            }

            if(status.Equals("Café da manhã"))
            {
                UpdateCoffee();
            } 
            else if (status.Equals("Almoço"))
            {
                UpdateLunch();
            }
            else if (status.Equals("Jantar"))
            {
                UpdateDinner();
            }

        }

        private void UpdateCoffee()
        {
            
            if (refSQL.UpdateCoffeSQL(studentF) == 1)
            {
                lblNumCredito.Text = (studentF.CoffeCredit - 1).ToString();
                lblAcesso.ForeColor = System.Drawing.Color.Blue;
                lblAcesso.Text = studentF.Name + " - Acesso permitido!";
                mtbCpfRef.Text = String.Empty;
                mtbCpfRef.Focus();
            }
            else
            {
                lblNumCredito.Text = studentF.CoffeCredit.ToString();
                lblAcesso.ForeColor = System.Drawing.Color.Red;
                lblAcesso.Text = studentF.Name + " - Acesso negado!";
                mtbCpfRef.Text = String.Empty;
                mtbCpfRef.Focus();
                MessageBox.Show("O aluno não tem mais créditos para " + status + "!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateLunch()
        {
            if(refSQL.UpdateLunchSQL(studentF) == 1)
            {
                lblNumCredito.Text = (studentF.LunchCredit - 1).ToString();
                lblAcesso.ForeColor = System.Drawing.Color.Blue;
                lblAcesso.Text = studentF.Name + " - Acesso permitido!";
                mtbCpfRef.Text = String.Empty;
                mtbCpfRef.Focus();
            }
            else
            {
                lblNumCredito.Text = studentF.LunchCredit.ToString();
                lblAcesso.ForeColor = System.Drawing.Color.Red;
                lblAcesso.Text = studentF.Name + " - Acesso negado!";
                mtbCpfRef.Text = String.Empty;
                mtbCpfRef.Focus();

                MessageBox.Show("O aluno não tem mais créditos para " + status + "!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void UpdateDinner()
        {
            if (refSQL.UpdateDinnerSQL(studentF) == 1)
            {
                lblNumCredito.Text = (studentF.DinnerCredit - 1).ToString();
                lblAcesso.ForeColor = System.Drawing.Color.Blue;
                lblAcesso.Text = studentF.Name + " - Acesso permitido!";
                mtbCpfRef.Text = String.Empty;
                mtbCpfRef.Focus();
            }
            else
            {
                lblNumCredito.Text = studentF.DinnerCredit.ToString();
                lblAcesso.ForeColor = System.Drawing.Color.Red;
                lblAcesso.Text = studentF.Name + " - Acesso negado!";
                mtbCpfRef.Text = String.Empty;
                mtbCpfRef.Focus();

                MessageBox.Show("O aluno não tem mais créditos para " + status + "!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void MtbCpfRef_TextChanged(object sender, EventArgs e)
        {
            if(mtbCpfRef.Text.Length == 14)
            {
                btnConfirmar.Focus();
            }
        }
    }
}
