using System;
using System.Windows.Forms;
using SistemaRefeitorio.Model.Entities;
using SistemaRefeitorio.Model.SQL;
using System.IO;

namespace SistemaRefeitorio.Forms
{
    public partial class StudentForm : Form
    {
        Student studentF;
        StudentSQL studentSQL = new StudentSQL();

        bool editing = false;
        string foto = String.Empty;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            tbRa.Focus();
            tbRa.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbEmail.Text = String.Empty;
            mtbCpf.Text = String.Empty;
            mtbTelefone.Text = String.Empty;
            pbAluno.Image = null;

            tbRa.Enabled = true;
            tbNome.Enabled = false;
            tbEmail.Enabled = false;
            mtbCpf.Enabled = false;
            mtbTelefone.Enabled = false;

            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAddFoto.Enabled = false;

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbRa.Text.Equals(String.Empty))
            {
                MessageBox.Show("O Campo \"RA\" está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            studentF = new Student(Convert.ToInt32(tbRa.Text));

            studentF = studentSQL.GetData(studentF);

            if(studentF == null)
            {
                return;
            }

            tbRa.Text = studentF.RaStudent.ToString();
            tbNome.Text = studentF.Name;
            tbEmail.Text = studentF.Email;
            mtbCpf.Text = studentF.Cpf;
            mtbTelefone.Text = studentF.Telephone;
            foto = studentF.PicturePath;

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
            ClearFotoPath();
            New();
        }

        private void BtnAddFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName.ToString();
                pbAluno.ImageLocation = foto;
            }
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (tbRa.Text.Equals(String.Empty) || tbNome.Text.Equals(String.Empty) || tbEmail.Text.Equals(String.Empty) || mtbCpf.Text.Length < 14)
            {
                 MessageBox.Show("Algum campo está vazio ou incompleto!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }
            
            byte[] imageByte = null;

            if (!foto.Equals(""))
            {
                FileStream fstream = new FileStream(foto, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fstream);

                imageByte = br.ReadBytes((int)fstream.Length);
            }
           
            studentF = new Student(Convert.ToInt32(tbRa.Text), tbNome.Text, tbEmail.Text, mtbCpf.Text, mtbTelefone.Text, imageByte, foto);

            if (editing == false)
            {
                 if (studentSQL.Insert(studentF) == 1)
                 {
                    MessageBox.Show("Novo aluno inserido com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFotoPath();
                    Save();
                 }
            }
            else
            {
                if(studentSQL.Update(studentF) == 1)
                {
                    MessageBox.Show("Dados do aluno atualizados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFotoPath();
                    Save();
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            editing = true;
            Edit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            editing = false;
            Cancel();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            editing = false;
            this.Close();
        }

        private void ClearFotoPath()
        {
            foto = String.Empty;
        }

        private void New()
        {
            tbRa.Text = String.Empty;
            tbNome.Text = String.Empty;
            tbEmail.Text = String.Empty;
            mtbCpf.Text = String.Empty;
            mtbTelefone.Text = String.Empty;
            pbAluno.Image = null;

            tbRa.Enabled = true;
            tbRa.Focus();
            tbNome.Enabled = true;
            tbEmail.Enabled = true;
            mtbCpf.Enabled = true;
            mtbTelefone.Enabled = true;

            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAddFoto.Enabled = true;
            btnPesquisar.Enabled = true;
            
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
            btnPesquisar.Enabled = true;
           
        }

        private void Save()
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
            btnPesquisar.Enabled = true;
            
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
            btnPesquisar.Enabled = false;
            
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
            btnAddFoto.Enabled = false;
            btnPesquisar.Enabled = false;

        }
    }
}
