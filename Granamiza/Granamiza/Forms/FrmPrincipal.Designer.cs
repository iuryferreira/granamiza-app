

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            dadosGraficoTotalCategoria = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnPreferencias = new System.Windows.Forms.Button();
            this.btnCotacao = new System.Windows.Forms.Button();
            this.btnSimulacao = new System.Windows.Forms.Button();
            this.btnMenuDespesa = new System.Windows.Forms.Button();
            this.linhaMenu = new System.Windows.Forms.Panel();
            this.btnMenuReceita = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.pbAjuda = new System.Windows.Forms.PictureBox();
            this.lblOla = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpVisaoGeral = new System.Windows.Forms.GroupBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceita = new System.Windows.Forms.Button();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.btnDespesa = new System.Windows.Forms.Button();
            this.btnSaldoAtual = new System.Windows.Forms.Button();
            this.graficoGastoCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.vwtotalcategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).BeginInit();
            this.gpVisaoGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoGastoCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwtotalcategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.lblTitulo);
            this.pnlMenu.Controls.Add(this.btnPreferencias);
            this.pnlMenu.Controls.Add(this.btnCotacao);
            this.pnlMenu.Controls.Add(this.btnSimulacao);
            this.pnlMenu.Controls.Add(this.btnMenuDespesa);
            this.pnlMenu.Controls.Add(this.linhaMenu);
            this.pnlMenu.Controls.Add(this.btnMenuReceita);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(170, 561);
            this.pnlMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 2);
            this.panel1.TabIndex = 2;
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
            // btnPreferencias
            // 
            this.btnPreferencias.BackColor = System.Drawing.Color.Transparent;
            this.btnPreferencias.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnPreferencias.FlatAppearance.BorderSize = 0;
            this.btnPreferencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPreferencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPreferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreferencias.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreferencias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreferencias.Image = ((System.Drawing.Image)(resources.GetObject("btnPreferencias.Image")));
            this.btnPreferencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreferencias.Location = new System.Drawing.Point(0, 511);
            this.btnPreferencias.Name = "btnPreferencias";
            this.btnPreferencias.Size = new System.Drawing.Size(170, 51);
            this.btnPreferencias.TabIndex = 87;
            this.btnPreferencias.Text = "Preferências";
            this.btnPreferencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreferencias.UseVisualStyleBackColor = false;
            this.btnPreferencias.Click += new System.EventHandler(this.btnPreferencias_Click);
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
            this.btnCotacao.Size = new System.Drawing.Size(170, 55);
            this.btnCotacao.TabIndex = 86;
            this.btnCotacao.Text = "Cotações";
            this.btnCotacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCotacao.UseVisualStyleBackColor = false;
            this.btnCotacao.Click += new System.EventHandler(this.BtnCotacao_Click);
            // 
            // btnSimulacao
            // 
            this.btnSimulacao.BackColor = System.Drawing.Color.Transparent;
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
            this.btnSimulacao.Size = new System.Drawing.Size(170, 55);
            this.btnSimulacao.TabIndex = 85;
            this.btnSimulacao.Text = "Simulação";
            this.btnSimulacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSimulacao.UseVisualStyleBackColor = false;
            this.btnSimulacao.Click += new System.EventHandler(this.BtnSimulacao_Click);
            // 
            // btnMenuDespesa
            // 
            this.btnMenuDespesa.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuDespesa.FlatAppearance.BorderSize = 0;
            this.btnMenuDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMenuDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMenuDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDespesa.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuDespesa.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuDespesa.Image")));
            this.btnMenuDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDespesa.Location = new System.Drawing.Point(0, 195);
            this.btnMenuDespesa.Name = "btnMenuDespesa";
            this.btnMenuDespesa.Size = new System.Drawing.Size(170, 55);
            this.btnMenuDespesa.TabIndex = 84;
            this.btnMenuDespesa.Text = "Despesas";
            this.btnMenuDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuDespesa.UseVisualStyleBackColor = false;
            this.btnMenuDespesa.Click += new System.EventHandler(this.BtnMenuDespesa_Click);
            // 
            // linhaMenu
            // 
            this.linhaMenu.BackColor = System.Drawing.Color.White;
            this.linhaMenu.Location = new System.Drawing.Point(0, 67);
            this.linhaMenu.Name = "linhaMenu";
            this.linhaMenu.Size = new System.Drawing.Size(166, 2);
            this.linhaMenu.TabIndex = 1;
            // 
            // btnMenuReceita
            // 
            this.btnMenuReceita.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuReceita.FlatAppearance.BorderSize = 0;
            this.btnMenuReceita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMenuReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMenuReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReceita.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReceita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuReceita.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuReceita.Image")));
            this.btnMenuReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReceita.Location = new System.Drawing.Point(0, 140);
            this.btnMenuReceita.Name = "btnMenuReceita";
            this.btnMenuReceita.Size = new System.Drawing.Size(170, 55);
            this.btnMenuReceita.TabIndex = 83;
            this.btnMenuReceita.Text = "Receita";
            this.btnMenuReceita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenuReceita.UseVisualStyleBackColor = false;
            this.btnMenuReceita.Click += new System.EventHandler(this.BtnMenuReceita_Click);
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
            this.pbAvatar.Location = new System.Drawing.Point(719, 15);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(42, 38);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 7;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Click += new System.EventHandler(this.PbAvatar_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("SF Pro Display", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.DimGray;
            this.lblBemVindo.Location = new System.Drawing.Point(206, 39);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(331, 20);
            this.lblBemVindo.TabIndex = 75;
            this.lblBemVindo.Text = "                                          Seja Bem Vinda, Amanda.";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.lblAjuda);
            this.pnlConteudo.Controls.Add(this.pbAjuda);
            this.pnlConteudo.Controls.Add(this.lblOla);
            this.pnlConteudo.Controls.Add(this.label2);
            this.pnlConteudo.Controls.Add(this.gpVisaoGeral);
            this.pnlConteudo.Controls.Add(this.graficoGastoCategoria);
            this.pnlConteudo.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConteudo.Location = new System.Drawing.Point(176, 75);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(604, 463);
            this.pnlConteudo.TabIndex = 76;
            // 
            // lblAjuda
            // 
            this.lblAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.BackColor = System.Drawing.Color.White;
            this.lblAjuda.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblAjuda.ForeColor = System.Drawing.Color.DimGray;
            this.lblAjuda.Location = new System.Drawing.Point(21, 307);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(151, 112);
            this.lblAjuda.TabIndex = 119;
            this.lblAjuda.Text = "Esta é uma visão geral\r\ndas suas despesas. \r\n\r\nAdicione suas despesas\r\ne receitas" +
    ", para obter\r\num maior controle\r\nde sua vida financeira.";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbAjuda
            // 
            this.pbAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAjuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAjuda.BackgroundImage")));
            this.pbAjuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAjuda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbAjuda.ErrorImage = null;
            this.pbAjuda.InitialImage = null;
            this.pbAjuda.Location = new System.Drawing.Point(57, 266);
            this.pbAjuda.Name = "pbAjuda";
            this.pbAjuda.Size = new System.Drawing.Size(23, 24);
            this.pbAjuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAjuda.TabIndex = 117;
            this.pbAjuda.TabStop = false;
            // 
            // lblOla
            // 
            this.lblOla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblOla.AutoSize = true;
            this.lblOla.BackColor = System.Drawing.Color.White;
            this.lblOla.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblOla.ForeColor = System.Drawing.Color.DimGray;
            this.lblOla.Location = new System.Drawing.Point(84, 272);
            this.lblOla.Name = "lblOla";
            this.lblOla.Size = new System.Drawing.Size(32, 16);
            this.lblOla.TabIndex = 118;
            this.lblOla.Text = "Olá!";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(445, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 115;
            this.label2.Text = "Gastos por Categoria";
            // 
            // gpVisaoGeral
            // 
            this.gpVisaoGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.gpVisaoGeral.Controls.Add(this.lblSaldo);
            this.gpVisaoGeral.Controls.Add(this.label1);
            this.gpVisaoGeral.Controls.Add(this.btnReceita);
            this.gpVisaoGeral.Controls.Add(this.lblDespesa);
            this.gpVisaoGeral.Controls.Add(this.btnDespesa);
            this.gpVisaoGeral.Controls.Add(this.btnSaldoAtual);
            this.gpVisaoGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpVisaoGeral.Location = new System.Drawing.Point(33, 17);
            this.gpVisaoGeral.Name = "gpVisaoGeral";
            this.gpVisaoGeral.Size = new System.Drawing.Size(552, 217);
            this.gpVisaoGeral.TabIndex = 2;
            this.gpVisaoGeral.TabStop = false;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.White;
            this.lblSaldo.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblSaldo.ForeColor = System.Drawing.Color.DimGray;
            this.lblSaldo.Location = new System.Drawing.Point(242, 56);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(72, 16);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo atual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(15, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "Receita";
            // 
            // btnReceita
            // 
            this.btnReceita.BackColor = System.Drawing.Color.White;
            this.btnReceita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceita.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReceita.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceita.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnReceita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.btnReceita.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceita.Location = new System.Drawing.Point(0, 157);
            this.btnReceita.Name = "btnReceita";
            this.btnReceita.Size = new System.Drawing.Size(552, 60);
            this.btnReceita.TabIndex = 112;
            this.btnReceita.Text = "R$ 15.200,00 ";
            this.btnReceita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceita.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReceita.UseVisualStyleBackColor = false;
            this.btnReceita.Click += new System.EventHandler(this.BtnReceita_Click);
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.BackColor = System.Drawing.Color.White;
            this.lblDespesa.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblDespesa.ForeColor = System.Drawing.Color.DimGray;
            this.lblDespesa.Location = new System.Drawing.Point(15, 118);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(107, 16);
            this.lblDespesa.TabIndex = 1;
            this.lblDespesa.Text = "Despesas Ativas";
            // 
            // btnDespesa
            // 
            this.btnDespesa.BackColor = System.Drawing.Color.White;
            this.btnDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespesa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDespesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDespesa.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnDespesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.btnDespesa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDespesa.Location = new System.Drawing.Point(0, 101);
            this.btnDespesa.Name = "btnDespesa";
            this.btnDespesa.Size = new System.Drawing.Size(552, 57);
            this.btnDespesa.TabIndex = 111;
            this.btnDespesa.Text = "R$ 12.452,00";
            this.btnDespesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDespesa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDespesa.UseVisualStyleBackColor = false;
            this.btnDespesa.Click += new System.EventHandler(this.BtnDespesa_Click);
            // 
            // btnSaldoAtual
            // 
            this.btnSaldoAtual.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaldoAtual.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSaldoAtual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaldoAtual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSaldoAtual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaldoAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaldoAtual.Font = new System.Drawing.Font("SF Pro Display", 16.75F, System.Drawing.FontStyle.Bold);
            this.btnSaldoAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.btnSaldoAtual.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaldoAtual.Location = new System.Drawing.Point(1, 7);
            this.btnSaldoAtual.Name = "btnSaldoAtual";
            this.btnSaldoAtual.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnSaldoAtual.Size = new System.Drawing.Size(551, 94);
            this.btnSaldoAtual.TabIndex = 114;
            this.btnSaldoAtual.Text = "R$ 12.452,00";
            this.btnSaldoAtual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaldoAtual.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaldoAtual.UseVisualStyleBackColor = false;
            // 
            // graficoGastoCategoria
            // 
            this.graficoGastoCategoria.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.graficoGastoCategoria.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.graficoGastoCategoria.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.graficoGastoCategoria.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Name = "ChartArea1";
            this.graficoGastoCategoria.ChartAreas.Add(chartArea1);
            this.graficoGastoCategoria.DataSource = this.vwtotalcategoriaBindingSource;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.DimGray;
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.graficoGastoCategoria.Legends.Add(legend1);
            this.graficoGastoCategoria.Location = new System.Drawing.Point(178, 240);
            this.graficoGastoCategoria.Name = "graficoGastoCategoria";
            this.graficoGastoCategoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            dadosGraficoTotalCategoria.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            dadosGraficoTotalCategoria.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            dadosGraficoTotalCategoria.ChartArea = "ChartArea1";
            dadosGraficoTotalCategoria.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            dadosGraficoTotalCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dadosGraficoTotalCategoria.Label = "#PERCENT{P1}";
            dadosGraficoTotalCategoria.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            dadosGraficoTotalCategoria.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dadosGraficoTotalCategoria.Legend = "Legend1";
            dadosGraficoTotalCategoria.LegendText = "#VALX";
            dadosGraficoTotalCategoria.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            dadosGraficoTotalCategoria.Name = "dadosGraficoTotalCategoria";
            dadosGraficoTotalCategoria.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            dadosGraficoTotalCategoria.XValueMember = "nome";
            dadosGraficoTotalCategoria.YValueMembers = "quantidade";
            this.graficoGastoCategoria.Series.Add(dadosGraficoTotalCategoria);
            this.graficoGastoCategoria.Size = new System.Drawing.Size(407, 208);
            this.graficoGastoCategoria.TabIndex = 3;
            this.graficoGastoCategoria.Text = "Gráfico";
            // 
            // vwtotalcategoriaBindingSource
            // 
            this.vwtotalcategoriaBindingSource.DataSource = typeof(Granamiza.Modelo.vwtotalcategoria);
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.BackColor = System.Drawing.Color.Transparent;
            this.lnkLogout.Font = new System.Drawing.Font("Bahnschrift", 8.25F);
            this.lnkLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLogout.LinkColor = System.Drawing.Color.Gray;
            this.lnkLogout.Location = new System.Drawing.Point(725, 56);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(31, 13);
            this.lnkLogout.TabIndex = 3;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "SAIR";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLogout_LinkClicked);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
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
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAjuda)).EndInit();
            this.gpVisaoGeral.ResumeLayout(false);
            this.gpVisaoGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graficoGastoCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwtotalcategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMenuReceita;
        private System.Windows.Forms.Panel linhaMenu;
        private System.Windows.Forms.Button btnMenuDespesa;
        private System.Windows.Forms.Button btnCotacao;
        private System.Windows.Forms.Button btnSimulacao;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.GroupBox gpVisaoGeral;
        private System.Windows.Forms.Button btnReceita;
        private System.Windows.Forms.Button btnDespesa;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaldoAtual;
        private System.Windows.Forms.Button btnPreferencias;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoGastoCategoria;
        System.Windows.Forms.DataVisualization.Charting.Series dadosGraficoTotalCategoria;
        private System.Windows.Forms.BindingSource vwtotalcategoriaBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.PictureBox pbAjuda;
        private System.Windows.Forms.Label lblOla;
        private System.Windows.Forms.Panel panel1;
    }
}