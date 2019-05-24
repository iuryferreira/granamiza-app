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
            this.picUsuarioCadastro = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.lblSenhaErro = new System.Windows.Forms.Label();
            this.lblNomeErro = new System.Windows.Forms.Label();
            this.lblConSenhaErro = new System.Windows.Forms.Label();
            this.lblEmailErro = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chkTermosUso = new System.Windows.Forms.CheckBox();
            this.txtConSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.linhaSenha = new System.Windows.Forms.Panel();
            this.linhaNome = new System.Windows.Forms.Panel();
            this.linhaConSenha = new System.Windows.Forms.Panel();
            this.linhaEmail = new System.Windows.Forms.Panel();
            this.txtConfirmeSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOU = new System.Windows.Forms.Label();
            this.avatarFemale = new System.Windows.Forms.PictureBox();
            this.avatarMale = new System.Windows.Forms.PictureBox();
            this.rbJoana = new System.Windows.Forms.RadioButton();
            this.rbJohn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioCadastro)).BeginInit();
            this.gbDadosUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarFemale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarMale)).BeginInit();
            this.SuspendLayout();
            // 
            // picUsuarioCadastro
            // 
            this.picUsuarioCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picUsuarioCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUsuarioCadastro.BackgroundImage")));
            this.picUsuarioCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picUsuarioCadastro.Location = new System.Drawing.Point(14, 7);
            this.picUsuarioCadastro.Name = "picUsuarioCadastro";
            this.picUsuarioCadastro.Size = new System.Drawing.Size(48, 39);
            this.picUsuarioCadastro.TabIndex = 13;
            this.picUsuarioCadastro.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("SF Pro Display", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(55, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(229, 44);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Cadastre-se";
            // 
            // gbDadosUsuario
            // 
            this.gbDadosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.gbDadosUsuario.Controls.Add(this.lblSenhaErro);
            this.gbDadosUsuario.Controls.Add(this.lblNomeErro);
            this.gbDadosUsuario.Controls.Add(this.lblConSenhaErro);
            this.gbDadosUsuario.Controls.Add(this.lblEmailErro);
            this.gbDadosUsuario.Controls.Add(this.btnSalvar);
            this.gbDadosUsuario.Controls.Add(this.chkTermosUso);
            this.gbDadosUsuario.Controls.Add(this.txtConSenha);
            this.gbDadosUsuario.Controls.Add(this.txtSenha);
            this.gbDadosUsuario.Controls.Add(this.txtEmail);
            this.gbDadosUsuario.Controls.Add(this.linhaSenha);
            this.gbDadosUsuario.Controls.Add(this.linhaNome);
            this.gbDadosUsuario.Controls.Add(this.linhaConSenha);
            this.gbDadosUsuario.Controls.Add(this.linhaEmail);
            this.gbDadosUsuario.Controls.Add(this.txtConfirmeSenha);
            this.gbDadosUsuario.Controls.Add(this.lblSenha);
            this.gbDadosUsuario.Controls.Add(this.txtNome);
            this.gbDadosUsuario.Controls.Add(this.lblNome);
            this.gbDadosUsuario.Controls.Add(this.lblEmail);
            this.gbDadosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDadosUsuario.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbDadosUsuario.Location = new System.Drawing.Point(-2, 261);
            this.gbDadosUsuario.Name = "gbDadosUsuario";
            this.gbDadosUsuario.Size = new System.Drawing.Size(436, 396);
            this.gbDadosUsuario.TabIndex = 10;
            this.gbDadosUsuario.TabStop = false;
            this.gbDadosUsuario.Text = "Preencha os dados:";
            this.gbDadosUsuario.Enter += new System.EventHandler(this.GbDadosUsuario_Enter);
            // 
            // lblSenhaErro
            // 
            this.lblSenhaErro.AutoSize = true;
            this.lblSenhaErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaErro.ForeColor = System.Drawing.Color.Brown;
            this.lblSenhaErro.Location = new System.Drawing.Point(48, 201);
            this.lblSenhaErro.Name = "lblSenhaErro";
            this.lblSenhaErro.Size = new System.Drawing.Size(0, 13);
            this.lblSenhaErro.TabIndex = 68;
            // 
            // lblNomeErro
            // 
            this.lblNomeErro.AutoSize = true;
            this.lblNomeErro.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeErro.ForeColor = System.Drawing.Color.Brown;
            this.lblNomeErro.Location = new System.Drawing.Point(47, 78);
            this.lblNomeErro.Name = "lblNomeErro";
            this.lblNomeErro.Size = new System.Drawing.Size(0, 13);
            this.lblNomeErro.TabIndex = 67;
            // 
            // lblConSenhaErro
            // 
            this.lblConSenhaErro.AutoSize = true;
            this.lblConSenhaErro.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSenhaErro.ForeColor = System.Drawing.Color.Crimson;
            this.lblConSenhaErro.Location = new System.Drawing.Point(47, 271);
            this.lblConSenhaErro.Name = "lblConSenhaErro";
            this.lblConSenhaErro.Size = new System.Drawing.Size(0, 13);
            this.lblConSenhaErro.TabIndex = 66;
            // 
            // lblEmailErro
            // 
            this.lblEmailErro.AutoSize = true;
            this.lblEmailErro.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailErro.ForeColor = System.Drawing.Color.Brown;
            this.lblEmailErro.Location = new System.Drawing.Point(47, 137);
            this.lblEmailErro.Name = "lblEmailErro";
            this.lblEmailErro.Size = new System.Drawing.Size(0, 13);
            this.lblEmailErro.TabIndex = 65;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(126, 331);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 45);
            this.btnSalvar.TabIndex = 64;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // chkTermosUso
            // 
            this.chkTermosUso.AutoSize = true;
            this.chkTermosUso.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTermosUso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkTermosUso.Location = new System.Drawing.Point(122, 299);
            this.chkTermosUso.Name = "chkTermosUso";
            this.chkTermosUso.Size = new System.Drawing.Size(188, 18);
            this.chkTermosUso.TabIndex = 63;
            this.chkTermosUso.Text = "Aceito todos os termos de uso";
            this.chkTermosUso.UseVisualStyleBackColor = true;
            this.chkTermosUso.CheckedChanged += new System.EventHandler(this.ChkTermosUso_CheckedChanged);
            // 
            // txtConSenha
            // 
            this.txtConSenha.BackColor = System.Drawing.Color.White;
            this.txtConSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConSenha.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConSenha.Location = new System.Drawing.Point(48, 244);
            this.txtConSenha.Name = "txtConSenha";
            this.txtConSenha.Size = new System.Drawing.Size(351, 20);
            this.txtConSenha.TabIndex = 62;
            this.txtConSenha.UseSystemPasswordChar = true;
            this.txtConSenha.Enter += new System.EventHandler(this.TxtConSenha_Enter);
            this.txtConSenha.Leave += new System.EventHandler(this.TxtConSenha_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha.Location = new System.Drawing.Point(48, 174);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(351, 20);
            this.txtSenha.TabIndex = 61;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.Enter += new System.EventHandler(this.TxtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.TxtSenha_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(48, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(347, 20);
            this.txtEmail.TabIndex = 60;
            this.txtEmail.Enter += new System.EventHandler(this.TxtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // linhaSenha
            // 
            this.linhaSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaSenha.Location = new System.Drawing.Point(48, 196);
            this.linhaSenha.Name = "linhaSenha";
            this.linhaSenha.Size = new System.Drawing.Size(351, 2);
            this.linhaSenha.TabIndex = 58;
            // 
            // linhaNome
            // 
            this.linhaNome.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaNome.Location = new System.Drawing.Point(48, 72);
            this.linhaNome.Name = "linhaNome";
            this.linhaNome.Size = new System.Drawing.Size(351, 2);
            this.linhaNome.TabIndex = 57;
            // 
            // linhaConSenha
            // 
            this.linhaConSenha.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaConSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaConSenha.Location = new System.Drawing.Point(48, 266);
            this.linhaConSenha.Name = "linhaConSenha";
            this.linhaConSenha.Size = new System.Drawing.Size(351, 2);
            this.linhaConSenha.TabIndex = 59;
            // 
            // linhaEmail
            // 
            this.linhaEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaEmail.Location = new System.Drawing.Point(48, 132);
            this.linhaEmail.Name = "linhaEmail";
            this.linhaEmail.Size = new System.Drawing.Size(351, 2);
            this.linhaEmail.TabIndex = 56;
            // 
            // txtConfirmeSenha
            // 
            this.txtConfirmeSenha.AutoSize = true;
            this.txtConfirmeSenha.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.txtConfirmeSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmeSenha.Location = new System.Drawing.Point(43, 219);
            this.txtConfirmeSenha.Name = "txtConfirmeSenha";
            this.txtConfirmeSenha.Size = new System.Drawing.Size(134, 14);
            this.txtConfirmeSenha.TabIndex = 55;
            this.txtConfirmeSenha.Text = "Digite a senha novamente";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSenha.Location = new System.Drawing.Point(43, 154);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 14);
            this.lblSenha.TabIndex = 54;
            this.lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(48, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(349, 20);
            this.txtNome.TabIndex = 53;
            this.txtNome.Enter += new System.EventHandler(this.TxtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.TxtNome_Leave);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(43, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(37, 14);
            this.lblNome.TabIndex = 52;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(43, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 14);
            this.lblEmail.TabIndex = 51;
            this.lblEmail.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblOU);
            this.panel1.Controls.Add(this.picUsuarioCadastro);
            this.panel1.Controls.Add(this.avatarFemale);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.avatarMale);
            this.panel1.Controls.Add(this.rbJoana);
            this.panel1.Controls.Add(this.rbJohn);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 262);
            this.panel1.TabIndex = 34;
            // 
            // lblOU
            // 
            this.lblOU.AutoSize = true;
            this.lblOU.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblOU.Location = new System.Drawing.Point(196, 130);
            this.lblOU.Name = "lblOU";
            this.lblOU.Size = new System.Drawing.Size(40, 25);
            this.lblOU.TabIndex = 9;
            this.lblOU.Text = "OU";
            // 
            // avatarFemale
            // 
            this.avatarFemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avatarFemale.BackgroundImage")));
            this.avatarFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarFemale.Location = new System.Drawing.Point(295, 94);
            this.avatarFemale.Name = "avatarFemale";
            this.avatarFemale.Size = new System.Drawing.Size(100, 93);
            this.avatarFemale.TabIndex = 7;
            this.avatarFemale.TabStop = false;
            // 
            // avatarMale
            // 
            this.avatarMale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avatarMale.BackgroundImage")));
            this.avatarMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarMale.Location = new System.Drawing.Point(42, 94);
            this.avatarMale.Name = "avatarMale";
            this.avatarMale.Size = new System.Drawing.Size(100, 93);
            this.avatarMale.TabIndex = 6;
            this.avatarMale.TabStop = false;
            // 
            // rbJoana
            // 
            this.rbJoana.AutoSize = true;
            this.rbJoana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJoana.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJoana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbJoana.Location = new System.Drawing.Point(316, 191);
            this.rbJoana.Name = "rbJoana";
            this.rbJoana.Size = new System.Drawing.Size(60, 20);
            this.rbJoana.TabIndex = 5;
            this.rbJoana.TabStop = true;
            this.rbJoana.Text = "Joana";
            this.rbJoana.UseVisualStyleBackColor = true;
            this.rbJoana.CheckedChanged += new System.EventHandler(this.RbJoana_CheckedChanged);
            // 
            // rbJohn
            // 
            this.rbJohn.AutoSize = true;
            this.rbJohn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJohn.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJohn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rbJohn.Location = new System.Drawing.Point(62, 193);
            this.rbJohn.Name = "rbJohn";
            this.rbJohn.Size = new System.Drawing.Size(53, 20);
            this.rbJohn.TabIndex = 4;
            this.rbJohn.TabStop = true;
            this.rbJohn.Text = "John";
            this.rbJohn.UseVisualStyleBackColor = true;
            this.rbJohn.CheckedChanged += new System.EventHandler(this.RbJohn_CheckedChanged);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 652);
            this.Controls.Add(this.gbDadosUsuario);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCadastro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastre-se";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastro_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarioCadastro)).EndInit();
            this.gbDadosUsuario.ResumeLayout(false);
            this.gbDadosUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarFemale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarMale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picUsuarioCadastro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDadosUsuario;
        private System.Windows.Forms.Label lblSenhaErro;
        private System.Windows.Forms.Label lblNomeErro;
        private System.Windows.Forms.Label lblConSenhaErro;
        private System.Windows.Forms.Label lblEmailErro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chkTermosUso;
        private System.Windows.Forms.TextBox txtConSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel linhaSenha;
        private System.Windows.Forms.Panel linhaNome;
        private System.Windows.Forms.Panel linhaConSenha;
        private System.Windows.Forms.Panel linhaEmail;
        private System.Windows.Forms.Label txtConfirmeSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOU;
        private System.Windows.Forms.PictureBox avatarFemale;
        private System.Windows.Forms.PictureBox avatarMale;
        private System.Windows.Forms.RadioButton rbJoana;
        private System.Windows.Forms.RadioButton rbJohn;
    }
}