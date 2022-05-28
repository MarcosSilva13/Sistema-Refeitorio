using MySqlConnector;
using System;
using System.Windows.Forms;
using SistemaRefeitorio.Model.Entities;
using SistemaRefeitorio.Model.SQL;

namespace SistemaRefeitorio.Forms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            New();
       
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           Student sf = new Student(Convert.ToInt32(tbRa.Text), tbNome.Text, tbEmail.Text, mtbCpf.Text, mtbTelefone.Text);
           StudentSQL sfSQL = new StudentSQL();
           
            if(sfSQL.Insert(sf) == 1)
            {
                MessageBox.Show("Dados inseridos com sucesso!");
                Save();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            } 
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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
            tbRa.Text = "";
            tbNome.Text = "";
            tbEmail.Text = "";
            mtbCpf.Text = "";
            mtbTelefone.Text = "";

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
            tbRa.Text = "";
            tbNome.Text = "";
            tbEmail.Text = "";
            mtbCpf.Text = "";
            mtbTelefone.Text = "";

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
            tbNome.Enabled = false;
            tbEmail.Enabled = false;
            mtbCpf.Enabled = false;
            mtbTelefone.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
