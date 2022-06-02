﻿using MySqlConnector;
using System;
using System.Windows.Forms;
using SistemaRefeitorio.Model.Entities;
using SistemaRefeitorio.Model.SQL;

namespace SistemaRefeitorio.Forms
{
    public partial class StudentForm : Form
    {
        Student studentF;
        StudentSQL studentSQL;

        bool edit = false;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbRa.Text.Equals(String.Empty))
            {
                MessageBox.Show("O Campo \"RA\" está vazio!", "Aviso");
                return;
            }

            studentF = new Student(Convert.ToInt32(tbRa.Text));

            studentSQL = new StudentSQL();

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

            Search();
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            New();
       
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           /* if (tbRa.Text.Equals(String.Empty) || tbNome.Text.Equals(String.Empty) || tbEmail.Text.Equals(String.Empty) || mtbCpf.MaskCompleted)
            {
                MessageBox.Show("Algum campo está vazio ou incompleto!", "Aviso");
                return;
            }*/
           
            studentF = new Student(Convert.ToInt32(tbRa.Text), tbNome.Text, tbEmail.Text, mtbCpf.Text, mtbTelefone.Text);
            studentSQL = new StudentSQL();

            if (edit == false)
            {
                 if (studentSQL.Insert(studentF) == 1)
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
                if(studentSQL.Update(studentF) == 1)
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

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            edit = true;
            Edit();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            edit = false;
            Cancel();
        }

        private void BtnSair_Click(object sender, EventArgs e)
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
