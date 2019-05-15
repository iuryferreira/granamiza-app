namespace Granamiza.Forms
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtConfirmeSenha = new System.Windows.Forms.Label();
            this.linhaEmail = new System.Windows.Forms.Panel();
            this.linhaConSenha = new System.Windows.Forms.Panel();
            this.picUsuarioCadastro = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.linhaNome = new System.Windows.Forms.Panel();
            this.linhaSenha = new System.Windows.Forms.Panel();
            this.chkTermosUso = new System.Windows.Forms.CheckBox();
            this.txtConSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(14, 254);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 23);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(14, 214);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(101, 216);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(305, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(14, 298);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 23);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha:";
            // 
            // txtConfirmeSenha
            // 
            this.txtConfirmeSenha.AutoSize = true;
            this.txtConfirmeSenha.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmeSenha.ForeColor = System.Drawing.Color.White;
            this.txtConfirmeSenha.Location = new System.Drawing.Point(14, 343);
            this.txtConfirmeSenha.Name = "txtConfirmeSenha";
            this.txtConfirmeSenha.Size = new System.Drawing.Size(140, 23);
            this.txtConfirmeSenha.TabIndex = 7;
            this.txtConfirmeSenha.Text = "Confirme a senha:";
            // 
            // linhaEmail
            // 
            this.linhaEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaEmail.Location = new System.Drawing.Point(101, 277);
            this.linhaEmail.Name = "linhaEmail";
            this.linhaEmail.Size = new System.Drawing.Size(305, 2);
            this.linhaEmail.TabIndex = 9;
            // 
            // linhaConSenha
            // 
            this.linhaConSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaConSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaConSenha.Location = new System.Drawing.Point(173, 364);
            this.linhaConSenha.Name = "linhaConSenha";
            this.linhaConSenha.Size = new System.Drawing.Size(232, 2);
            this.linhaConSenha.TabIndex = 12;
            // 
            // picUsuarioCadastro
            // 
            this.picUsuarioCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUsuarioCadastro.BackgroundImage")));
            this.picUsuarioCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUsuarioCadastro.Location = new System.Drawing.Point(155, 27);
            this.picUsuarioCadastro.Name = "picUsuarioCadastro";
            this.picUsuarioCadastro.Size = new System.Drawing.Size(120, 95);
            this.picUsuarioCadastro.TabIndex = 13;
            this.picUsuarioCadastro.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(149, 125);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 35);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Cadastre-se";
            // 
            // linhaNome
            // 
            this.linhaNome.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaNome.Location = new System.Drawing.Point(101, 236);
            this.linhaNome.Name = "linhaNome";
            this.linhaNome.Size = new System.Drawing.Size(305, 2);
            this.linhaNome.TabIndex = 10;
            // 
            // linhaSenha
            // 
            this.linhaSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaSenha.Location = new System.Drawing.Point(101, 316);
            this.linhaSenha.Name = "linhaSenha";
            this.linhaSenha.Size = new System.Drawing.Size(306, 2);
            this.linhaSenha.TabIndex = 10;
            // 
            // chkTermosUso
            // 
            this.chkTermosUso.AutoSize = true;
            this.chkTermosUso.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTermosUso.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkTermosUso.Location = new System.Drawing.Point(131, 401);
            this.chkTermosUso.Name = "chkTermosUso";
            this.chkTermosUso.Size = new System.Drawing.Size(173, 17);
            this.chkTermosUso.TabIndex = 25;
            this.chkTermosUso.Text = "Aceito todos os termos de uso";
            this.chkTermosUso.UseVisualStyleBackColor = true;
            // 
            // txtConSenha
            // 
            this.txtConSenha.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtConSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConSenha.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConSenha.Location = new System.Drawing.Point(173, 343);
            this.txtConSenha.Name = "txtConSenha";
            this.txtConSenha.Size = new System.Drawing.Size(232, 20);
            this.txtConSenha.TabIndex = 24;
            this.txtConSenha.UseSystemPasswordChar = true;
            this.txtConSenha.Enter += new System.EventHandler(this.TxtConSenha_Enter);
            this.txtConSenha.Leave += new System.EventHandler(this.TxtConSenha_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.Location = new System.Drawing.Point(101, 296);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(306, 20);
            this.txtSenha.TabIndex = 23;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.TxtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.TxtSenha_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(103, 257);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 20);
            this.txtEmail.TabIndex = 21;
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(128, 451);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 45);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(432, 578);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkTermosUso);
            this.Controls.Add(this.txtConSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.linhaSenha);
            this.Controls.Add(this.linhaNome);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picUsuarioCadastro);
            this.Controls.Add(this.linhaConSenha);
            this.Controls.Add(this.linhaEmail);
            this.Controls.Add(this.txtConfirmeSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblEmail);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCadastro";
            this.Text = "Cadastre-se";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label txtConfirmeSenha;
        private System.Windows.Forms.Panel linhaEmail;
        private System.Windows.Forms.Panel linhaConSenha;
        private System.Windows.Forms.PictureBox picUsuarioCadastro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel linhaNome;
        private System.Windows.Forms.Panel linhaSenha;
        private System.Windows.Forms.CheckBox chkTermosUso;
        private System.Windows.Forms.TextBox txtConSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSalvar;
    }
}