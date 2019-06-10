

namespace Granamiza.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.btnCotacao = new System.Windows.Forms.Button();
            this.btnSimulacao = new System.Windows.Forms.Button();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.linhaMenu = new System.Windows.Forms.Panel();
            this.btnReceita = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.gpVisaoGeral = new System.Windows.Forms.GroupBox();
            this.btnAdicionarDespesa = new System.Windows.Forms.Button();
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.lblValorDespesaTotal = new System.Windows.Forms.Label();
            this.lblValorReceitaTotal = new System.Windows.Forms.Label();
            this.linhaDivisao = new System.Windows.Forms.Panel();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.lblReceita = new System.Windows.Forms.Label();
            this.tpAvatar = new System.Windows.Forms.ToolTip(this.components);
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            this.gpVisaoGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.lblTitulo);
            this.pnlMenu.Controls.Add(this.btnHistorico);
            this.pnlMenu.Controls.Add(this.btnCotacao);
            this.pnlMenu.Controls.Add(this.btnSimulacao);
            this.pnlMenu.Controls.Add(this.btnDespesa);
            this.pnlMenu.Controls.Add(this.linhaMenu);
            this.pnlMenu.Controls.Add(this.btnReceita);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(170, 562);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("SF Pro Display", 16.75F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(43, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 28);
            this.lblTitulo.TabIndex = 74;
            this.lblTitulo.Text = "Granamiza";
            this.lblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.Transparent;
            this.btnHistorico.Enabled = false;
            this.btnHistorico.FlatAppearance.BorderSize = 0;
            this.btnHistorico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHistorico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorico.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorico.Image")));
            this.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorico.Location = new System.Drawing.Point(0, 360);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(166, 55);
            this.btnHistorico.TabIndex = 87;
            this.btnHistorico.Text = "Histórico";
            this.btnHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorico.UseVisualStyleBackColor = false;
            // 
            // btnCotacao
            // 
            this.btnCotacao.BackColor = System.Drawing.Color.Transparent;
            this.btnCotacao.FlatAppearance.BorderSize = 0;
            this.btnCotacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCotacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotacao.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCotacao.Image = ((System.Drawing.Image)(resources.GetObject("btnCotacao.Image")));
            this.btnCotacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotacao.Location = new System.Drawing.Point(0, 305);
            this.btnCotacao.Name = "btnCotacao";
            this.btnCotacao.Size = new System.Drawing.Size(166, 55);
            this.btnCotacao.TabIndex = 86;
            this.btnCotacao.Text = "Cotações";
            this.btnCotacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCotacao.UseVisualStyleBackColor = false;
            this.btnCotacao.Click += new System.EventHandler(this.BtnCotacao_Click);
            // 
            // btnSimulacao
            // 
            this.btnSimulacao.BackColor = System.Drawing.Color.Transparent;
            this.btnSimulacao.Enabled = false;
            this.btnSimulacao.FlatAppearance.BorderSize = 0;
            this.btnSimulacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSimulacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSimulacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulacao.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSimulacao.Image = ((System.Drawing.Image)(resources.GetObject("btnSimulacao.Image")));
            this.btnSimulacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimulacao.Location = new System.Drawing.Point(0, 250);
            this.btnSimulacao.Name = "btnSimulacao";
            this.btnSimulacao.Size = new System.Drawing.Size(166, 55);
            this.btnSimulacao.TabIndex = 85;
            this.btnSimulacao.Text = "Simulação";
            this.btnSimulacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimulacao.UseVisualStyleBackColor = false;
            // 
            // btnDespesa
            // 
            this.btnDespesa.BackColor = System.Drawing.Color.Transparent;
            this.btnDespesa.FlatAppearance.BorderSize = 0;
            this.btnDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesa.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnDespesa.Image")));
            this.btnDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespesa.Location = new System.Drawing.Point(0, 195);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(166, 55);
            this.btnDespesa.TabIndex = 84;
            this.btnDespesa.Text = "Despesas";
            this.btnDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDespesa.UseVisualStyleBackColor = false;
            this.btnDespesa.Click += new System.EventHandler(this.BtnDespesa_Click);
            // 
            // linhaMenu
            // 
            this.linhaMenu.BackColor = System.Drawing.Color.White;
            this.linhaMenu.Location = new System.Drawing.Point(0, 67);
            this.linhaMenu.Name = "linhaMenu";
            this.linhaMenu.Size = new System.Drawing.Size(166, 2);
            this.linhaMenu.TabIndex = 1;
            // 
            // btnReceita
            // 
            this.btnReceita.BackColor = System.Drawing.Color.Transparent;
            this.btnReceita.FlatAppearance.BorderSize = 0;
            this.btnReceita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceita.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReceita.Image = ((System.Drawing.Image)(resources.GetObject("btnReceita.Image")));
            this.btnReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceita.Location = new System.Drawing.Point(0, 140);
            this.btnReceita.Name = "btnReceita";
            this.btnReceita.Size = new System.Drawing.Size(166, 55);
            this.btnReceita.TabIndex = 83;
            this.btnReceita.Text = "Receita";
            this.btnReceita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceita.UseVisualStyleBackColor = false;
            this.btnReceita.Click += new System.EventHandler(this.BtnReceita_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Location = new System.Drawing.Point(3, 18);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(34, 41);
            this.pbLogo.TabIndex = 75;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.PbLogo_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAvatar.BackgroundImage")));
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbAvatar.ErrorImage = null;
            this.pbAvatar.InitialImage = null;
            this.pbAvatar.Location = new System.Drawing.Point(707, 0);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(65, 61);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 7;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.PbAvatar_Click);
            this.pbAvatar.MouseHover += new System.EventHandler(this.PbAvatar_MouseHover);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("SF Pro Display", 16F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBemVindo.Location = new System.Drawing.Point(176, 18);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(433, 26);
            this.lblBemVindo.TabIndex = 75;
            this.lblBemVindo.Text = "                                          Seja Bem Vinda, Amanda.";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.gpVisaoGeral);
            this.pnlConteudo.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConteudo.Location = new System.Drawing.Point(176, 87);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(604, 463);
            this.pnlConteudo.TabIndex = 76;
            // 
            // gpVisaoGeral
            // 
            this.gpVisaoGeral.Controls.Add(this.btnAdicionarDespesa);
            this.gpVisaoGeral.Controls.Add(this.btnAdicionarReceita);
            this.gpVisaoGeral.Controls.Add(this.lblValorDespesaTotal);
            this.gpVisaoGeral.Controls.Add(this.lblValorReceitaTotal);
            this.gpVisaoGeral.Controls.Add(this.linhaDivisao);
            this.gpVisaoGeral.Controls.Add(this.lblDespesa);
            this.gpVisaoGeral.Controls.Add(this.lblReceita);
            this.gpVisaoGeral.Location = new System.Drawing.Point(16, 19);
            this.gpVisaoGeral.Name = "gpVisaoGeral";
            this.gpVisaoGeral.Size = new System.Drawing.Size(580, 200);
            this.gpVisaoGeral.TabIndex = 2;
            this.gpVisaoGeral.TabStop = false;
            this.gpVisaoGeral.Text = "Visão Geral";
            // 
            // btnAdicionarDespesa
            // 
            this.btnAdicionarDespesa.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarDespesa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdicionarDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.btnAdicionarDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarDespesa.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarDespesa.Image")));
            this.btnAdicionarDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarDespesa.Location = new System.Drawing.Point(383, 142);
            this.btnAdicionarDespesa.Name = "btnAdicionarDespesa";
            this.btnAdicionarDespesa.Size = new System.Drawing.Size(109, 33);
            this.btnAdicionarDespesa.TabIndex = 112;
            this.btnAdicionarDespesa.Text = "  Adicionar";
            this.btnAdicionarDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarDespesa.UseVisualStyleBackColor = false;
            this.btnAdicionarDespesa.Click += new System.EventHandler(this.BtnAdicionarDespesa_Click);
            // 
            // btnAdicionarReceita
            // 
            this.btnAdicionarReceita.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarReceita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarReceita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionarReceita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdicionarReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdicionarReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarReceita.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarReceita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarReceita.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarReceita.Image")));
            this.btnAdicionarReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarReceita.Location = new System.Drawing.Point(85, 142);
            this.btnAdicionarReceita.Name = "btnAdicionarReceita";
            this.btnAdicionarReceita.Size = new System.Drawing.Size(109, 33);
            this.btnAdicionarReceita.TabIndex = 111;
            this.btnAdicionarReceita.Text = "  Adicionar";
            this.btnAdicionarReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionarReceita.UseVisualStyleBackColor = false;
            this.btnAdicionarReceita.Click += new System.EventHandler(this.BtnAdicionarReceita_Click);
            // 
            // lblValorDespesaTotal
            // 
            this.lblValorDespesaTotal.AutoSize = true;
            this.lblValorDespesaTotal.Font = new System.Drawing.Font("SF Pro Display", 19F);
            this.lblValorDespesaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.lblValorDespesaTotal.Location = new System.Drawing.Point(387, 90);
            this.lblValorDespesaTotal.Name = "lblValorDespesaTotal";
            this.lblValorDespesaTotal.Size = new System.Drawing.Size(105, 31);
            this.lblValorDespesaTotal.TabIndex = 3;
            this.lblValorDespesaTotal.Text = "0,00 R$";
            // 
            // lblValorReceitaTotal
            // 
            this.lblValorReceitaTotal.AutoSize = true;
            this.lblValorReceitaTotal.Font = new System.Drawing.Font("SF Pro Display", 19F);
            this.lblValorReceitaTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.lblValorReceitaTotal.Location = new System.Drawing.Point(87, 90);
            this.lblValorReceitaTotal.Name = "lblValorReceitaTotal";
            this.lblValorReceitaTotal.Size = new System.Drawing.Size(105, 31);
            this.lblValorReceitaTotal.TabIndex = 2;
            this.lblValorReceitaTotal.Text = "0,00 R$";
            // 
            // linhaDivisao
            // 
            this.linhaDivisao.BackColor = System.Drawing.Color.DarkGray;
            this.linhaDivisao.Location = new System.Drawing.Point(276, 48);
            this.linhaDivisao.Name = "linhaDivisao";
            this.linhaDivisao.Size = new System.Drawing.Size(2, 100);
            this.linhaDivisao.TabIndex = 1;
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesa.ForeColor = System.Drawing.Color.DimGray;
            this.lblDespesa.Location = new System.Drawing.Point(393, 50);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(86, 23);
            this.lblDespesa.TabIndex = 1;
            this.lblDespesa.Text = "Despesa:";
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceita.ForeColor = System.Drawing.Color.DimGray;
            this.lblReceita.Location = new System.Drawing.Point(102, 50);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(76, 23);
            this.lblReceita.TabIndex = 0;
            this.lblReceita.Text = "Receita:";
            // 
            // tpAvatar
            // 
            this.tpAvatar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tpAvatar.ToolTipTitle = "Preferências";
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.BackColor = System.Drawing.Color.Transparent;
            this.lnkLogout.Font = new System.Drawing.Font("Bahnschrift", 10.25F);
            this.lnkLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLogout.LinkColor = System.Drawing.Color.Gray;
            this.lnkLogout.Location = new System.Drawing.Point(721, 64);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(39, 17);
            this.lnkLogout.TabIndex = 3;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "SAIR";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLogout_LinkClicked);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Granamiza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
            this.gpVisaoGeral.ResumeLayout(false);
            this.gpVisaoGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnReceita;
        private System.Windows.Forms.Panel linhaMenu;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Button btnCotacao;
        private System.Windows.Forms.Button btnSimulacao;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.GroupBox gpVisaoGeral;
        private System.Windows.Forms.Button btnAdicionarDespesa;
        private System.Windows.Forms.Button btnAdicionarReceita;
        private System.Windows.Forms.Label lblValorDespesaTotal;
        private System.Windows.Forms.Label lblValorReceitaTotal;
        private System.Windows.Forms.Panel linhaDivisao;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.ToolTip tpAvatar;
        private System.Windows.Forms.LinkLabel lnkLogout;
    }
}