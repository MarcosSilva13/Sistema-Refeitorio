using System;
using SistemaRefeitorio.Model.SQL;
using System.Windows.Forms;

namespace SistemaRefeitorio.Forms
{
    public partial class ListStudentForm : Form
    {
        ListStudentSQL listStudentSQL = new ListStudentSQL();
        public ListStudentForm()
        {
            InitializeComponent();
            dgListStudent.Columns["Ra"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListStudent.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListStudent.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListStudent.Columns["CPF"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListStudent.Columns["Telefone"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListStudent.Columns["Coffe"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListStudent.Columns["Lunch"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgListStudent.Columns["Dinner"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ListStudentForm_Load(object sender, EventArgs e)
        {
            tbPesquisa.Text = String.Empty;
            btnVerTodos.Enabled = false;

            dgListStudent.Rows.Clear();
            listStudentSQL.GetDataStudent(dgListStudent);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (cbPesquisa.Text.Equals("Ra"))
            {
                if (tbPesquisa.Text.Equals(String.Empty))
                {
                    MessageBox.Show("O campo para os valores não pode ser vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnVerTodos.Enabled = true;
                    dgListStudent.Rows.Clear();
                    listStudentSQL.GetDataByRa(dgListStudent, Convert.ToInt32(tbPesquisa.Text));
                }
            } 
            else if (cbPesquisa.Text.Equals("Nome"))
            {
                if (tbPesquisa.Text.Equals(String.Empty))
                {
                    MessageBox.Show("O campo para os valores não pode ser vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    btnVerTodos.Enabled = true;
                    dgListStudent.Rows.Clear();
                    listStudentSQL.GetDataByName(dgListStudent, tbPesquisa.Text);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida de pesquisa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            tbPesquisa.Text = String.Empty;
            cbPesquisa.Text = String.Empty;
            lblTips.Text = String.Empty;
            btnVerTodos.Enabled = false;

            dgListStudent.Rows.Clear();
            listStudentSQL.GetDataStudent(dgListStudent);
            MessageBox.Show("Total de cadastros: " + dgListStudent.Rows.Count);
        }

        private void CbPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPesquisa.Text.Equals("Ra"))
            {
                lblTips.Text = "Digite apenas números";
            }
            else if (cbPesquisa.Text.Equals("Nome"))
            {
                lblTips.Text = "Digite apenas texto";
                
            }
            else
            {
                lblTips.Text = String.Empty;
            }

        }
    }
}
