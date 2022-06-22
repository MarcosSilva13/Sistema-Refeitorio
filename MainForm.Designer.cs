namespace SistemaRefeitorio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadastrarCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefeitorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CafeDaManhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AlmocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JantarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastroToolStripMenuItem,
            this.RefeitorioToolStripMenuItem,
            this.SobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CadastroToolStripMenuItem
            // 
            this.CadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CadastrarAlunoToolStripMenuItem,
            this.CadastrarCreditoToolStripMenuItem,
            this.SairToolStripMenuItem});
            this.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem";
            this.CadastroToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.CadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // CadastrarAlunoToolStripMenuItem
            // 
            this.CadastrarAlunoToolStripMenuItem.Name = "CadastrarAlunoToolStripMenuItem";
            this.CadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.CadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            this.CadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.CadastrarAlunoToolStripMenuItem_Click);
            // 
            // CadastrarCreditoToolStripMenuItem
            // 
            this.CadastrarCreditoToolStripMenuItem.Name = "CadastrarCreditoToolStripMenuItem";
            this.CadastrarCreditoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.CadastrarCreditoToolStripMenuItem.Text = "Cadastrar Crédito/Consulta";
            this.CadastrarCreditoToolStripMenuItem.Click += new System.EventHandler(this.CadastrarCreditoToolStripMenuItem_Click);
            // 
            // SairToolStripMenuItem
            // 
            this.SairToolStripMenuItem.Name = "SairToolStripMenuItem";
            this.SairToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.SairToolStripMenuItem.Text = "Sair";
            this.SairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // RefeitorioToolStripMenuItem
            // 
            this.RefeitorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CafeDaManhaToolStripMenuItem,
            this.AlmocoToolStripMenuItem,
            this.JantarToolStripMenuItem});
            this.RefeitorioToolStripMenuItem.Name = "RefeitorioToolStripMenuItem";
            this.RefeitorioToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.RefeitorioToolStripMenuItem.Text = "Refeitorio";
            // 
            // CafeDaManhaToolStripMenuItem
            // 
            this.CafeDaManhaToolStripMenuItem.Name = "CafeDaManhaToolStripMenuItem";
            this.CafeDaManhaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.CafeDaManhaToolStripMenuItem.Text = "Café da manhã";
            this.CafeDaManhaToolStripMenuItem.Click += new System.EventHandler(this.CafeDaManhaToolStripMenuItem_Click);
            // 
            // AlmocoToolStripMenuItem
            // 
            this.AlmocoToolStripMenuItem.Name = "AlmocoToolStripMenuItem";
            this.AlmocoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.AlmocoToolStripMenuItem.Text = "Almoço";
            this.AlmocoToolStripMenuItem.Click += new System.EventHandler(this.AlmocoToolStripMenuItem_Click);
            // 
            // JantarToolStripMenuItem
            // 
            this.JantarToolStripMenuItem.Name = "JantarToolStripMenuItem";
            this.JantarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.JantarToolStripMenuItem.Text = "Jantar";
            this.JantarToolStripMenuItem.Click += new System.EventHandler(this.JantarToolStripMenuItem_Click);
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.SobreToolStripMenuItem.Text = "Sobre";
            this.SobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Refeitório";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadastrarCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefeitorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CafeDaManhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AlmocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem JantarToolStripMenuItem;
    }
}

