namespace Granamiza.Forms.RedefinirSenha
{
    partial class FrmRedefinirSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRedefinirSenha));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.linkVoltar = new System.Windows.Forms.LinkLabel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.gpEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            this.gpEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitulo.BackgroundImage")));
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitulo.Controls.Add(this.linkVoltar);
            this.pnlTitulo.Controls.Add(this.lblSubtitulo);
            this.pnlTitulo.Controls.Add(this.pbLogo);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 1);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(459, 150);
            this.pnlTitulo.TabIndex = 110;
            // 
            // linkVoltar
            // 
            this.linkVoltar.ActiveLinkColor = System.Drawing.Color.SeaGreen;
            this.linkVoltar.AutoSize = true;
            this.linkVoltar.BackColor = System.Drawing.Color.Transparent;
            this.linkVoltar.Font = new System.Drawing.Font("Webdings", 19.25F);
            this.linkVoltar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkVoltar.LinkColor = System.Drawing.Color.White;
            this.linkVoltar.Location = new System.Drawing.Point(12, 8);
            this.linkVoltar.Name = "linkVoltar";
            this.linkVoltar.Size = new System.Drawing.Size(39, 29);
            this.linkVoltar.TabIndex = 120;
            this.linkVoltar.TabStop = true;
            this.linkVoltar.Text = "3";
            this.linkVoltar.Visible = false;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblSubtitulo.Location = new System.Drawing.Point(168, 96);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(144, 13);
            this.lblSubtitulo.TabIndex = 74;
            this.lblSubtitulo.Text = "Preencha todos os campos.";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(96, 35);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(40, 32);
            this.pbLogo.TabIndex = 73;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(142, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 35);
            this.lblTitulo.TabIndex = 63;
            this.lblTitulo.Text = "Redefinir Senha";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("SF Pro Display", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesc.Location = new System.Drawing.Point(93, 158);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(293, 45);
            this.lblDesc.TabIndex = 75;
            this.lblDesc.Text = "Insira o email cadastrado por você  na aplicação, \r\npara que possamos redefinir a" +
    " sua senha.\r\n \r\n";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.btnContinuar);
            this.pnlConteudo.Controls.Add(this.gpEmail);
            this.pnlConteudo.Location = new System.Drawing.Point(39, 206);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(389, 224);
            this.pnlConteudo.TabIndex = 119;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnContinuar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnContinuar.FlatAppearance.BorderSize = 2;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("SF Pro Display", 11F, System.Drawing.FontStyle.Bold);
            this.btnContinuar.ForeColor = System.Drawing.Color.Ivory;
            this.btnContinuar.Location = new System.Drawing.Point(95, 140);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(196, 40);
            this.btnContinuar.TabIndex = 121;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // gpEmail
            // 
            this.gpEmail.Controls.Add(this.txtEmail);
            this.gpEmail.Controls.Add(this.lblEmail);
            this.gpEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpEmail.Location = new System.Drawing.Point(33, 27);
            this.gpEmail.Name = "gpEmail";
            this.gpEmail.Size = new System.Drawing.Size(326, 85);
            this.gpEmail.TabIndex = 120;
            this.gpEmail.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(3, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(317, 20);
            this.txtEmail.TabIndex = 114;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("SF Pro Display", 9.75F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(110, 16);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 15);
            this.lblEmail.TabIndex = 111;
            this.lblEmail.Text = "Email cadastrado";
            // 
            // FrmRedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 471);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlConteudo);
            this.Name = "FrmRedefinirSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redefinir Senha - Granamiza";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            this.gpEmail.ResumeLayout(false);
            this.gpEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.GroupBox gpEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.LinkLabel linkVoltar;
        private System.Windows.Forms.TextBox txtEmail;
    }
}