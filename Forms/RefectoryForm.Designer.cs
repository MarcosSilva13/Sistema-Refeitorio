
namespace SistemaRefeitorio.Forms
{
    partial class RefectoryForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumCredito = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.mtbCpfRef = new System.Windows.Forms.MaskedTextBox();
            this.pbAluno = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblStatusAcesso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblAcesso);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acesso do Aluno";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso.Location = new System.Drawing.Point(12, 32);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(188, 29);
            this.lblAcesso.TabIndex = 0;
            this.lblAcesso.Text = "Resultado aqui";
            this.lblAcesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatusAcesso);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblNumCredito);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnConfirmar);
            this.groupBox3.Controls.Add(this.mtbCpfRef);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(448, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 137);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "CPF:";
            // 
            // lblNumCredito
            // 
            this.lblNumCredito.AutoSize = true;
            this.lblNumCredito.Location = new System.Drawing.Point(226, 60);
            this.lblNumCredito.Name = "lblNumCredito";
            this.lblNumCredito.Size = new System.Drawing.Size(19, 20);
            this.lblNumCredito.TabIndex = 14;
            this.lblNumCredito.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nº Créditos Restantes:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(198, 105);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(47, 26);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "OK";
            this.btnConfirmar.UseCompatibleTextRendering = true;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // mtbCpfRef
            // 
            this.mtbCpfRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfRef.Location = new System.Drawing.Point(70, 105);
            this.mtbCpfRef.Mask = "###,###,###-##";
            this.mtbCpfRef.Name = "mtbCpfRef";
            this.mtbCpfRef.Size = new System.Drawing.Size(122, 26);
            this.mtbCpfRef.TabIndex = 11;
            this.mtbCpfRef.TextChanged += new System.EventHandler(this.MtbCpfRef_TextChanged);
            // 
            // pbAluno
            // 
            this.pbAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAluno.Location = new System.Drawing.Point(46, 12);
            this.pbAluno.Name = "pbAluno";
            this.pbAluno.Size = new System.Drawing.Size(338, 267);
            this.pbAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAluno.TabIndex = 3;
            this.pbAluno.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.lblRelogio);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(447, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hora/Data";
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(16, 22);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(104, 25);
            this.lblRelogio.TabIndex = 0;
            this.lblRelogio.Text = "00:00:00";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(16, 66);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(130, 25);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "00/00/0000";
            // 
            // lblStatusAcesso
            // 
            this.lblStatusAcesso.AutoSize = true;
            this.lblStatusAcesso.Location = new System.Drawing.Point(17, 19);
            this.lblStatusAcesso.Name = "lblStatusAcesso";
            this.lblStatusAcesso.Size = new System.Drawing.Size(119, 20);
            this.lblStatusAcesso.TabIndex = 15;
            this.lblStatusAcesso.Text = "Acesso para: ";
            // 
            // RefectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(724, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbAluno);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(740, 450);
            this.Name = "RefectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refeitório";
            this.Load += new System.EventHandler(this.RefectoryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAluno)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.MaskedTextBox mtbCpfRef;
        private System.Windows.Forms.PictureBox pbAluno;
        private System.Windows.Forms.Label lblNumCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblStatusAcesso;
    }
}