using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaRefeitorio.Model.Entities;
using SistemaRefeitorio.Model.SQL;

namespace SistemaRefeitorio.Forms
{
    public partial class CreditForm : Form
    {
        Student sf;
        CreditSQL creditSQL;
        public CreditForm()
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
            creditSQL = new CreditSQL();

            sf = creditSQL.GetDataCredit(sf);

            if(sf == null)
            {
                return;
            }

            tbRa.Text = sf.RaStudent.ToString();
            tbNome.Text = sf.Name;
            tbEmail.Text = sf.Email;
            mtbCpf.Text = sf.Cpf;
            mtbTelefone.Text = sf.Telephone;
            tbCafe.Text = sf.CoffeCredit.ToString();
            tbAlmoco.Text = sf.LunchCredit.ToString();
            tbJanta.Text = sf.DinnerCredit.ToString();

            Search();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            New();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sf = new Student(Convert.ToInt32(tbRa.Text), Convert.ToInt32(tbCafe.Text),
                        Convert.ToInt32(tbAlmoco.Text), Convert.ToInt32(tbJanta.Text));
            creditSQL = new CreditSQL();

            if(creditSQL.UpdateCredit(sf) == 1)
            {
                MessageBox.Show("Crédito adicionado com sucesso!", "Aviso");
                Save();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!", "Erro");
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
