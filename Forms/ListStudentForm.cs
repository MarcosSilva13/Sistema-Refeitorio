using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRefeitorio.Model.Entities;
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
            tbRa.Text = String.Empty;
            btnVerTodos.Enabled = false;

            dgListStudent.Rows.Clear();
            listStudentSQL.GetDataStudent(dgListStudent);
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbRa.Text.Equals(String.Empty))
            {
                MessageBox.Show("O campo \"Pesquisar por Ra\" está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                btnVerTodos.Enabled = true;
                dgListStudent.Rows.Clear();
                listStudentSQL.GetDataByRa(dgListStudent, Convert.ToInt32(tbRa.Text));
            }
        }

        private void BtnVerTodos_Click(object sender, EventArgs e)
        {
            tbRa.Text = String.Empty;
            btnVerTodos.Enabled = false;

            dgListStudent.Rows.Clear();
            listStudentSQL.GetDataStudent(dgListStudent);
        }
    }
}
