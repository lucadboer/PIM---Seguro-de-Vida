namespace MagSeguros
{
    partial class Tela_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_login));
            this.frmInicial = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            this.bttEntrar = new System.Windows.Forms.Button();
            this.txbSenha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // frmInicial
            // 
            this.frmInicial.AutoSize = true;
            this.frmInicial.BackColor = System.Drawing.Color.MintCream;
            this.frmInicial.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.frmInicial.ForeColor = System.Drawing.Color.Black;
            this.frmInicial.Location = new System.Drawing.Point(593, 149);
            this.frmInicial.Name = "frmInicial";
            this.frmInicial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frmInicial.Size = new System.Drawing.Size(77, 28);
            this.frmInicial.TabIndex = 0;
            this.frmInicial.Text = "Login:";
            this.frmInicial.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbUsuario
            // 
            this.txbUsuario.AccessibleName = "";
            this.txbUsuario.BackColor = System.Drawing.Color.LightGray;
            this.txbUsuario.Location = new System.Drawing.Point(554, 231);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(154, 23);
            this.txbUsuario.TabIndex = 1;
            this.txbUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome.Location = new System.Drawing.Point(554, 204);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(57, 15);
            this.nome.TabIndex = 2;
            this.nome.Text = "Usuário :";
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.logo.Location = new System.Drawing.Point(90, 343);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(168, 19);
            this.logo.TabIndex = 3;
            this.logo.Text = "Sistema Mag Seguros";
            // 
            // bttEntrar
            // 
            this.bttEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(252)))));
            this.bttEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.bttEntrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttEntrar.Location = new System.Drawing.Point(588, 374);
            this.bttEntrar.Name = "bttEntrar";
            this.bttEntrar.Size = new System.Drawing.Size(82, 31);
            this.bttEntrar.TabIndex = 4;
            this.bttEntrar.Text = "Entrar";
            this.bttEntrar.UseVisualStyleBackColor = false;
            this.bttEntrar.Click += new System.EventHandler(this.bttEntrar_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.AutoSize = true;
            this.txbSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbSenha.Location = new System.Drawing.Point(554, 274);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(49, 15);
            this.txbSenha.TabIndex = 5;
            this.txbSenha.Text = "Senha :";
            this.txbSenha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(554, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // Tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1011, 550);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.bttEntrar);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.frmInicial);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mag Seguros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label frmInicial;
        private TextBox txbUsuario;
        private Label nome;
        private Label logo;
        private Button bttEntrar;
        private Label txbSenha;
        private TextBox textBox1;
    }
}