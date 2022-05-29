using MySqlConnector;
using System;
using System.Windows.Forms;
using SistemaRefeitorio.Model.Entities;
using SistemaRefeitorio.Model.SQL;

namespace SistemaRefeitorio.Forms
{
    public partial class StudentForm : Form
    {
        Student sf;
        StudentSQL sfSQL;

        bool edit = false;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbRa.Text.Equals(String.Empty))
            {
                MessageBox.Show("O Campo \"RA\" está vazio!", "Aviso");
                return;
            }

            sf = new Student(Convert.ToInt32(tbRa.Text));

            sfSQL = new StudentSQL();

            sf = sfSQL.GetData(sf);

            if(sf == null)
            {
                return;
            }

            tbRa.Text = sf.RaStudent.ToString();
            tbNome.Text = sf.Name;
            tbEmail.Text = sf.Email;
            mtbCpf.Text = sf.Cpf;
            mtbTelefone.Text = sf.Telephone;

            Search();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            New();
       
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           /* if (tbRa.Text.Equals(String.Empty) || tbNome.Text.Equals(String.Empty) || tbEmail.Text.Equals(String.Empty) || mtbCpf.MaskCompleted)
            {
                MessageBox.Show("Algum campo está vazio ou incompleto!", "Aviso");
                return;
            }*/
           
            sf = new Student(Convert.ToInt32(tbRa.Text), tbNome.Text, tbEmail.Text, mtbCpf.Text, mtbTelefone.Text);
            sfSQL = new StudentSQL();

            if (edit == false)
            {
                 if (sfSQL.Insert(sf) == 1)
                 {
                     MessageBox.Show("Novo aluno inserido com sucesso!", "Confirmação");
                     Save();
                 }
                 else
                 {
                    MessageBox.Show("Ocorreu um erro!", "Aviso");
                 }
            }
            else
            {
                if(sfSQL.Update(sf) == 1)
                {
                    MessageBox.Show("Dados do aluno atualizados com sucesso!", "Atualização");
                    Save();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro!", "Aviso");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            edit = true;
            Edit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            edit = false;
            Cancel();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            tbNome.Enabled = false;
            tbEmail.Enabled = false;
            mtbCpf.Enabled = false;
            mtbTelefone.Enabled = false;

            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAddFoto.Enabled = false;
        }

        private void New()
        {
            tbRa.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbEmail.Text = String.Empty;
            mtbCpf.Text = String.Empty;
            mtbTelefone.Text = String.Empty;

            tbRa.Enabled = true;
            tbNome.Enabled = true;
            tbEmail.Enabled = true;
            mtbCpf.Enabled = true;
            mtbTelefone.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAddFoto.Enabled = true;
            
        }

        private void Cancel()
        {
            tbRa.Enabled = true;
            tbNome.Enabled = false;
            tbEmail.Enabled = false;
            mtbCpf.Enabled = false;
            mtbTelefone.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAddFoto.Enabled = false;
           
        }

        private void Save()
        {
            tbRa.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbEmail.Text = String.Empty;
            mtbCpf.Text = String.Empty;
            mtbTelefone.Text = String.Empty;

            tbRa.Enabled = true;
            tbNome.Enabled = false;
            tbEmail.Enabled = false;
            mtbCpf.Enabled = false;
            mtbTelefone.Enabled = false;

            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAddFoto.Enabled = false;
            
        }

        private void Edit()
        {
            tbRa.Enabled = false;
            tbNome.Enabled = true;
            tbEmail.Enabled = true;
            mtbCpf.Enabled = true;
            mtbTelefone.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAddFoto.Enabled = true;
            
        }

        private void Search()
        {
            tbRa.Enabled = false;
            tbNome.Enabled = false;
            tbEmail.Enabled = false;
            mtbCpf.Enabled = false;
            mtbTelefone.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;

        }

        
    }
}
