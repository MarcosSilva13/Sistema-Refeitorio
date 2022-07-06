
namespace SistemaRefeitorio.Forms
{
    partial class ListStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListStudentForm));
            this.dgListStudent = new System.Windows.Forms.DataGridView();
            this.Ra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coffe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dinner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.cbPesquisa = new System.Windows.Forms.ComboBox();
            this.lblTips = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgListStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListStudent
            // 
            this.dgListStudent.AllowUserToAddRows = false;
            this.dgListStudent.AllowUserToDeleteRows = false;
            this.dgListStudent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgListStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgListStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ra,
            this.Nome,
            this.Email,
            this.Cpf,
            this.Telefone,
            this.Coffe,
            this.Lunch,
            this.Dinner});
            this.dgListStudent.Location = new System.Drawing.Point(12, 99);
            this.dgListStudent.Name = "dgListStudent";
            this.dgListStudent.ReadOnly = true;
            this.dgListStudent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgListStudent.Size = new System.Drawing.Size(760, 270);
            this.dgListStudent.TabIndex = 0;
            // 
            // Ra
            // 
            this.Ra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ra.DefaultCellStyle = dataGridViewCellStyle2;
            this.Ra.DividerWidth = 1;
            this.Ra.HeaderText = "Ra";
            this.Ra.Name = "Ra";
            this.Ra.ReadOnly = true;
            this.Ra.Width = 50;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nome.DividerWidth = 1;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 130;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.DefaultCellStyle = dataGridViewCellStyle4;
            this.Email.DividerWidth = 1;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 186;
            // 
            // Cpf
            // 
            this.Cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpf.DefaultCellStyle = dataGridViewCellStyle5;
            this.Cpf.DividerWidth = 1;
            this.Cpf.FillWeight = 90F;
            this.Cpf.HeaderText = "CPF";
            this.Cpf.Name = "Cpf";
            this.Cpf.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.DefaultCellStyle = dataGridViewCellStyle6;
            this.Telefone.DividerWidth = 1;
            this.Telefone.FillWeight = 95F;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Coffe
            // 
            this.Coffe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coffe.DefaultCellStyle = dataGridViewCellStyle7;
            this.Coffe.DividerWidth = 1;
            this.Coffe.FillWeight = 50F;
            this.Coffe.HeaderText = "Crédito Café";
            this.Coffe.Name = "Coffe";
            this.Coffe.ReadOnly = true;
            this.Coffe.Width = 50;
            // 
            // Lunch
            // 
            this.Lunch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lunch.DefaultCellStyle = dataGridViewCellStyle8;
            this.Lunch.DividerWidth = 1;
            this.Lunch.FillWeight = 52F;
            this.Lunch.HeaderText = "Crédito Almoço";
            this.Lunch.Name = "Lunch";
            this.Lunch.ReadOnly = true;
            this.Lunch.Width = 53;
            // 
            // Dinner
            // 
            this.Dinner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dinner.DefaultCellStyle = dataGridViewCellStyle9;
            this.Dinner.DividerWidth = 1;
            this.Dinner.FillWeight = 50F;
            this.Dinner.HeaderText = "Crédito Jantar";
            this.Dinner.Name = "Dinner";
            this.Dinner.ReadOnly = true;
            this.Dinner.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar por:";
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisa.Location = new System.Drawing.Point(326, 41);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(116, 26);
            this.tbPesquisa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(457, 39);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(116, 30);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseCompatibleTextRendering = true;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerTodos.Location = new System.Drawing.Point(656, 39);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(116, 30);
            this.btnVerTodos.TabIndex = 25;
            this.btnVerTodos.Text = "Ver Todos";
            this.btnVerTodos.UseCompatibleTextRendering = true;
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // cbPesquisa
            // 
            this.cbPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPesquisa.FormattingEnabled = true;
            this.cbPesquisa.Items.AddRange(new object[] {
            "Ra",
            "Nome"});
            this.cbPesquisa.Location = new System.Drawing.Point(245, 41);
            this.cbPesquisa.Name = "cbPesquisa";
            this.cbPesquisa.Size = new System.Drawing.Size(75, 26);
            this.cbPesquisa.TabIndex = 29;
            this.cbPesquisa.SelectedIndexChanged += new System.EventHandler(this.CbPesquisa_SelectedIndexChanged);
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTips.Location = new System.Drawing.Point(323, 25);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(0, 13);
            this.lblTips.TabIndex = 30;
            // 
            // ListStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.cbPesquisa);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgListStudent);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 420);
            this.MinimizeBox = false;
            this.Name = "ListStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista dos Alunos";
            this.Load += new System.EventHandler(this.ListStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coffe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.ComboBox cbPesquisa;
        private System.Windows.Forms.Label lblTips;
    }
}