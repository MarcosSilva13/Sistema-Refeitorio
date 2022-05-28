using MySqlConnector;
using System;
using System.Windows.Forms;

namespace SistemaRefeitorio.Forms
{
    public partial class StudentForm : Form
    {
        MySqlConnection Conexao;
        string data_soucer = "DATABASE=refeitorio; port=3306; SERVER=localhost; username=root; password=Kurorotepshi_13";
        public StudentForm()
        {
            InitializeComponent();
        }
        
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            New();
           /* try
            {
                Conexao = new MySqlConnection(data_soucer);

                string sql = "INSERT INTO students (raStudent, name, email, cpf)" +
                        "VALUES" + "('" + tbRa.Text + "', '" + tbNome.Text + "', '" + tbEmail.Text + "', '" + mtbCpf.Text + "')";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                cmd.ExecuteReader();

                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            } */
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Save();
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
