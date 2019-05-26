

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
            this.visaoGeralUC = new Granamiza.Forms.UControl.UcVisaoGeral();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnlConteudo.SuspendLayout();
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
            this.btnHistorico.Location = new System.Drawing.Point(0, 315);
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
            this.btnCotacao.Enabled = false;
            this.btnCotacao.FlatAppearance.BorderSize = 0;
            this.btnCotacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCotacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCotacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotacao.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCotacao.Image = ((System.Drawing.Image)(resources.GetObject("btnCotacao.Image")));
            this.btnCotacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCotacao.Location = new System.Drawing.Point(0, 260);
            this.btnCotacao.Name = "btnCotacao";
            this.btnCotacao.Size = new System.Drawing.Size(166, 55);
            this.btnCotacao.TabIndex = 86;
            this.btnCotacao.Text = "Cotações";
            this.btnCotacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCotacao.UseVisualStyleBackColor = false;
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
            this.btnSimulacao.Location = new System.Drawing.Point(0, 205);
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
            this.btnDespesa.Location = new System.Drawing.Point(0, 150);
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
            this.btnReceita.Location = new System.Drawing.Point(0, 95);
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
            this.pbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvatar.Location = new System.Drawing.Point(703, 12);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(69, 69);
            this.pbAvatar.TabIndex = 7;
            this.pbAvatar.TabStop = false;
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("SF Pro Display", 16F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblBemVindo.Location = new System.Drawing.Point(312, 27);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(324, 26);
            this.lblBemVindo.TabIndex = 75;
            this.lblBemVindo.Text = "Bem vindo ao Granamiza, John.";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.visaoGeralUC);
            this.pnlConteudo.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConteudo.Location = new System.Drawing.Point(176, 87);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(596, 463);
            this.pnlConteudo.TabIndex = 76;
            // 
            // visaoGeralUC
            // 
            this.visaoGeralUC.Location = new System.Drawing.Point(12, 24);
            this.visaoGeralUC.Name = "visaoGeralUC";
            this.visaoGeralUC.Size = new System.Drawing.Size(574, 204);
            this.visaoGeralUC.TabIndex = 1;
            this.visaoGeralUC.Load += new System.EventHandler(this.VisaoGeralUC_Load);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.pnlMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Granamiza";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pnlConteudo.ResumeLayout(false);
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
        private UControl.UcVisaoGeral visaoGeralUC;
    }
}