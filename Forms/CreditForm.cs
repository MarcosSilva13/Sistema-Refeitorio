using System;
using System.IO;
using System.Windows.Forms;
using SistemaRefeitorio.Model.Entities;
using SistemaRefeitorio.Model.SQL;

namespace SistemaRefeitorio.Forms
{
    public partial class CreditForm : Form
    {
        Student studentF;
        CreditSQL creditSQL = new CreditSQL();
        public CreditForm()
        {
            InitializeComponent();
        }

        private void CreditForm_Load(object sender, EventArgs e)
        {
            tbRa.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbEmail.Text = String.Empty;
            mtbCpf.Text = String.Empty;
            mtbTelefone.Text = String.Empty;
            tbCafe.Text = String.Empty;
            tbAlmoco.Text = String.Empty;
            tbJanta.Text = String.Empty;
            pbAluno.Image = null;

            tbRa.Enabled = true;
            tbNome.Enabled = false;
            tbEmail.Enabled = false;
            mtbCpf.Enabled = false;
            mtbTelefone.Enabled = false;
            tbCafe.Enabled = false;
            tbAlmoco.Enabled = false;
            tbJanta.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;

            tbRa.Focus();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbRa.Text.Equals(String.Empty))
            {
                MessageBox.Show("O Campo \"RA\" está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            studentF = new Student(Convert.ToInt32(tbRa.Text));
           

            studentF = creditSQL.GetDataCredit(studentF);

            if(studentF == null)
            {
                return;
            }

            tbRa.Text = studentF.RaStudent.ToString();
            tbNome.Text = studentF.Name;
            tbEmail.Text = studentF.Email;
            mtbCpf.Text = studentF.Cpf;
            mtbTelefone.Text = studentF.Telephone;
            tbCafe.Text = studentF.CoffeCredit.ToString();
            tbAlmoco.Text = studentF.LunchCredit.ToString();
            tbJanta.Text = studentF.DinnerCredit.ToString();

            if (studentF.Picture == null)
            {
                pbAluno.Image = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(studentF.Picture);
                pbAluno.Image = System.Drawing.Image.FromStream(mstream);

            }

            Search();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            New();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if(tbCafe.Text.Equals(String.Empty) || tbAlmoco.Text.Equals(String.Empty) || tbJanta.Text.Equals(String.Empty))
            {
                MessageBox.Show("O Campo não pode ser vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            studentF = new Student(Convert.ToInt32(tbRa.Text), Convert.ToInt32(tbCafe.Text),
                        Convert.ToInt32(tbAlmoco.Text), Convert.ToInt32(tbJanta.Text));

            if(creditSQL.UpdateCredit(studentF) == 1)
            {
                MessageBox.Show("Crédito adicionado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Save();
            }   
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAjudaCredito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ao clicar em \"Novo\" só é possível fazer uma nova pesquisa\n" +
                            "Ao clicar em \"Editar\" só é possível editar o número de créditos do estudante!", 
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void New()
        {
            tbRa.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbEmail.Text = String.Empty;
            mtbCpf.Text = String.Empty;
            mtbTelefone.Text = String.Empty;
            tbCafe.Text = String.Empty;
            tbAlmoco.Text = String.Empty;
            tbJanta.Text = String.Empty;
            pbAluno.Image = null;

            tbRa.Enabled = true;
            tbRa.Focus();

            btnNovo.Enabled = false;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
        }

        private void Cancel()
        {
            tbRa.Enabled = true;
            tbCafe.Enabled = false;
            tbAlmoco.Enabled = false;
            tbJanta.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;

        }

        private void Save()
        {
            tbRa.Enabled = false;
            tbCafe.Enabled = false;
            tbAlmoco.Enabled = false;
            tbJanta.Enabled = false;
            

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void Edit()
        {
            tbRa.Enabled = false;
            tbCafe.Enabled = true;
            tbAlmoco.Enabled = true;
            tbJanta.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;

        }

        private void Search()
        {
            tbRa.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;
            btnPesquisar.Enabled = false;

        }

        
    }
}
