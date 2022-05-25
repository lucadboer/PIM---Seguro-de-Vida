namespace MagSeguros
{
    partial class Tela_escolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_escolha));
            this.logo = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnProcurarCadastro = new System.Windows.Forms.Button();
            this.entrada = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.logo.Location = new System.Drawing.Point(93, 341);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(168, 19);
            this.logo.TabIndex = 4;
            this.logo.Text = "Sistema Mag Seguros";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCliente.Image")));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(419, 182);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCadastrarCliente.Size = new System.Drawing.Size(194, 198);
            this.btnCadastrarCliente.TabIndex = 5;
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProcurarCadastro
            // 
            this.btnProcurarCadastro.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProcurarCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurarCadastro.Image")));
            this.btnProcurarCadastro.Location = new System.Drawing.Point(682, 182);
            this.btnProcurarCadastro.Name = "btnProcurarCadastro";
            this.btnProcurarCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProcurarCadastro.Size = new System.Drawing.Size(194, 198);
            this.btnProcurarCadastro.TabIndex = 6;
            this.btnProcurarCadastro.UseVisualStyleBackColor = false;
            this.btnProcurarCadastro.Click += new System.EventHandler(this.btnProcurarCadastro_Click);
            // 
            // entrada
            // 
            this.entrada.AutoSize = true;
            this.entrada.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entrada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.entrada.Location = new System.Drawing.Point(419, 82);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(248, 24);
            this.entrada.TabIndex = 7;
            this.entrada.Text = "Olá , escolha uma opção:";
            this.entrada.Click += new System.EventHandler(this.entrada_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairDaContaToolStripMenuItem,
            this.fecharProgramaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // sairDaContaToolStripMenuItem
            // 
            this.sairDaContaToolStripMenuItem.Name = "sairDaContaToolStripMenuItem";
            this.sairDaContaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sairDaContaToolStripMenuItem.Text = "Sair da Conta";
            this.sairDaContaToolStripMenuItem.Click += new System.EventHandler(this.sairDaContaToolStripMenuItem_Click);
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar Programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.fecharProgramaToolStripMenuItem_Click);
            // 
            // Tela_escolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MagSeguros.Properties.Resources.logo_pim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1012, 537);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.btnProcurarCadastro);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Tela_escolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mag Seguros";
            this.Load += new System.EventHandler(this.tela2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label logo;
        private Button btnCadastrarCliente;
        private Button btnProcurarCadastro;
        private Label entrada;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem sairDaContaToolStripMenuItem;
        private ToolStripMenuItem fecharProgramaToolStripMenuItem;
    }
}