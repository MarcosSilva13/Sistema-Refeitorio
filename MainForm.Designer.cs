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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refeitorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cafeDaManhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jantarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.refeitorioToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarAlunoToolStripMenuItem,
            this.cadastrarCreditoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarAlunoToolStripMenuItem
            // 
            this.cadastrarAlunoToolStripMenuItem.Name = "cadastrarAlunoToolStripMenuItem";
            this.cadastrarAlunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarAlunoToolStripMenuItem.Text = "Cadastrar Aluno";
            this.cadastrarAlunoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // cadastrarCreditoToolStripMenuItem
            // 
            this.cadastrarCreditoToolStripMenuItem.Name = "cadastrarCreditoToolStripMenuItem";
            this.cadastrarCreditoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarCreditoToolStripMenuItem.Text = "Cadastrar Crédito";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // refeitorioToolStripMenuItem
            // 
            this.refeitorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cafeDaManhaToolStripMenuItem,
            this.almocoToolStripMenuItem,
            this.jantarToolStripMenuItem});
            this.refeitorioToolStripMenuItem.Name = "refeitorioToolStripMenuItem";
            this.refeitorioToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.refeitorioToolStripMenuItem.Text = "Refeitorio";
            // 
            // cafeDaManhaToolStripMenuItem
            // 
            this.cafeDaManhaToolStripMenuItem.Name = "cafeDaManhaToolStripMenuItem";
            this.cafeDaManhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cafeDaManhaToolStripMenuItem.Text = "Café da manhã";
            this.cafeDaManhaToolStripMenuItem.Click += new System.EventHandler(this.cafeDaManhaToolStripMenuItem_Click);
            // 
            // almocoToolStripMenuItem
            // 
            this.almocoToolStripMenuItem.Name = "almocoToolStripMenuItem";
            this.almocoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.almocoToolStripMenuItem.Text = "Almoço";
            this.almocoToolStripMenuItem.Click += new System.EventHandler(this.almocoToolStripMenuItem_Click);
            // 
            // jantarToolStripMenuItem
            // 
            this.jantarToolStripMenuItem.Name = "jantarToolStripMenuItem";
            this.jantarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jantarToolStripMenuItem.Text = "Jantar";
            this.jantarToolStripMenuItem.Click += new System.EventHandler(this.jantarToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 343);
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
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAlunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refeitorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cafeDaManhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almocoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jantarToolStripMenuItem;
    }
}

