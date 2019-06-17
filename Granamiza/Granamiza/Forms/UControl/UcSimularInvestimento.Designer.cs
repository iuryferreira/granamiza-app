﻿namespace Granamiza.Forms.UControl
{
    partial class UcSimularInvestimento
    { 
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSimularInvestimento));
            this.dgvSimulacao = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorinseridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntmesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacoesmensaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendimentototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simulacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.linhaAplicacoesMensais = new System.Windows.Forms.Panel();
            this.linhaHora = new System.Windows.Forms.Panel();
            this.lblAplicacoesMensais = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.linhaData = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.linhaValor = new System.Windows.Forms.Panel();
            this.lblValor = new System.Windows.Forms.Label();
            this.linhaJuros = new System.Windows.Forms.Panel();
            this.lblTituloRendTotal = new System.Windows.Forms.Label();
            this.lblRendimentoTotal = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.numJuros = new System.Windows.Forms.NumericUpDown();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.numAplicacoesMensais = new System.Windows.Forms.NumericUpDown();
            this.numQntMeses = new System.Windows.Forms.NumericUpDown();
            this.lblQntMeses = new System.Windows.Forms.Label();
            this.lblValorRs = new System.Windows.Forms.Label();
            this.lblJurosPorcentagem = new System.Windows.Forms.Label();
            this.lblAplicacoesMensaisRs = new System.Windows.Forms.Label();
            this.linhaQntMeses = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblObr1 = new System.Windows.Forms.Label();
            this.lblObr2 = new System.Windows.Forms.Label();
            this.lblObr3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJuros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAplicacoesMensais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQntMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSimulacao
            // 
            this.dgvSimulacao.AllowUserToAddRows = false;
            this.dgvSimulacao.AllowUserToDeleteRows = false;
            this.dgvSimulacao.AllowUserToOrderColumns = true;
            this.dgvSimulacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSimulacao.AutoGenerateColumns = false;
            this.dgvSimulacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSimulacao.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSimulacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSimulacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.valorinseridoDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn,
            this.qntmesesDataGridViewTextBoxColumn,
            this.datacriacaoDataGridViewTextBoxColumn,
            this.aplicacoesmensaisDataGridViewTextBoxColumn,
            this.rendimentototalDataGridViewTextBoxColumn});
            this.dgvSimulacao.DataSource = this.simulacaoBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSimulacao.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSimulacao.EnableHeadersVisualStyles = false;
            this.dgvSimulacao.GridColor = System.Drawing.Color.White;
            this.dgvSimulacao.Location = new System.Drawing.Point(20, 309);
            this.dgvSimulacao.Name = "dgvSimulacao";
            this.dgvSimulacao.ReadOnly = true;
            this.dgvSimulacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSimulacao.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvSimulacao.Size = new System.Drawing.Size(538, 149);
            this.dgvSimulacao.TabIndex = 115;
            this.dgvSimulacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSimulacao_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorinseridoDataGridViewTextBoxColumn
            // 
            this.valorinseridoDataGridViewTextBoxColumn.DataPropertyName = "valor_inserido";
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.valorinseridoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.valorinseridoDataGridViewTextBoxColumn.FillWeight = 119.0139F;
            this.valorinseridoDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorinseridoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.valorinseridoDataGridViewTextBoxColumn.Name = "valorinseridoDataGridViewTextBoxColumn";
            this.valorinseridoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "juros";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.jurosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.jurosDataGridViewTextBoxColumn.FillWeight = 63.03066F;
            this.jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            this.jurosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qntmesesDataGridViewTextBoxColumn
            // 
            this.qntmesesDataGridViewTextBoxColumn.DataPropertyName = "qnt_meses";
            this.qntmesesDataGridViewTextBoxColumn.FillWeight = 60.9137F;
            this.qntmesesDataGridViewTextBoxColumn.HeaderText = "Meses";
            this.qntmesesDataGridViewTextBoxColumn.Name = "qntmesesDataGridViewTextBoxColumn";
            this.qntmesesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacriacaoDataGridViewTextBoxColumn
            // 
            this.datacriacaoDataGridViewTextBoxColumn.DataPropertyName = "data_criacao";
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.datacriacaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.datacriacaoDataGridViewTextBoxColumn.FillWeight = 119.0139F;
            this.datacriacaoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datacriacaoDataGridViewTextBoxColumn.Name = "datacriacaoDataGridViewTextBoxColumn";
            this.datacriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aplicacoesmensaisDataGridViewTextBoxColumn
            // 
            this.aplicacoesmensaisDataGridViewTextBoxColumn.DataPropertyName = "aplicacoes_mensais";
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.aplicacoesmensaisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.aplicacoesmensaisDataGridViewTextBoxColumn.FillWeight = 119.0139F;
            this.aplicacoesmensaisDataGridViewTextBoxColumn.HeaderText = "Aplicações Mensais";
            this.aplicacoesmensaisDataGridViewTextBoxColumn.Name = "aplicacoesmensaisDataGridViewTextBoxColumn";
            this.aplicacoesmensaisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendimentototalDataGridViewTextBoxColumn
            // 
            this.rendimentototalDataGridViewTextBoxColumn.DataPropertyName = "rendimento_total";
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.rendimentototalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.rendimentototalDataGridViewTextBoxColumn.FillWeight = 119.0139F;
            this.rendimentototalDataGridViewTextBoxColumn.HeaderText = "Rendimento Total";
            this.rendimentototalDataGridViewTextBoxColumn.Name = "rendimentototalDataGridViewTextBoxColumn";
            this.rendimentototalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // simulacaoBindingSource
            // 
            this.simulacaoBindingSource.DataSource = typeof(Granamiza.Modelo.simulacao);
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInfo.BackgroundImage")));
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picInfo.Location = new System.Drawing.Point(7, 10);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(28, 26);
            this.picInfo.TabIndex = 114;
            this.picInfo.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Gray;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(456, 211);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 39);
            this.btnCalcular.TabIndex = 110;
            this.btnCalcular.Text = "   Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // linhaAplicacoesMensais
            // 
            this.linhaAplicacoesMensais.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaAplicacoesMensais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaAplicacoesMensais.Location = new System.Drawing.Point(31, 173);
            this.linhaAplicacoesMensais.Name = "linhaAplicacoesMensais";
            this.linhaAplicacoesMensais.Size = new System.Drawing.Size(146, 2);
            this.linhaAplicacoesMensais.TabIndex = 103;
            // 
            // linhaHora
            // 
            this.linhaHora.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaHora.Location = new System.Drawing.Point(456, 105);
            this.linhaHora.Name = "linhaHora";
            this.linhaHora.Size = new System.Drawing.Size(99, 2);
            this.linhaHora.TabIndex = 109;
            // 
            // lblAplicacoesMensais
            // 
            this.lblAplicacoesMensais.AutoSize = true;
            this.lblAplicacoesMensais.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblAplicacoesMensais.ForeColor = System.Drawing.Color.Gray;
            this.lblAplicacoesMensais.Location = new System.Drawing.Point(24, 125);
            this.lblAplicacoesMensais.Name = "lblAplicacoesMensais";
            this.lblAplicacoesMensais.Size = new System.Drawing.Size(106, 14);
            this.lblAplicacoesMensais.TabIndex = 99;
            this.lblAplicacoesMensais.Text = "Aplicações Mensais";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblHora.ForeColor = System.Drawing.Color.Gray;
            this.lblHora.Location = new System.Drawing.Point(451, 59);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(31, 14);
            this.lblHora.TabIndex = 107;
            this.lblHora.Text = "Hora";
            // 
            // linhaData
            // 
            this.linhaData.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaData.Location = new System.Drawing.Point(334, 105);
            this.linhaData.Name = "linhaData";
            this.linhaData.Size = new System.Drawing.Size(99, 2);
            this.linhaData.TabIndex = 106;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblData.ForeColor = System.Drawing.Color.Gray;
            this.lblData.Location = new System.Drawing.Point(329, 60);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 14);
            this.lblData.TabIndex = 104;
            this.lblData.Text = "Data";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblJuros.ForeColor = System.Drawing.Color.Gray;
            this.lblJuros.Location = new System.Drawing.Point(209, 60);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(35, 14);
            this.lblJuros.TabIndex = 98;
            this.lblJuros.Text = "Juros";
            // 
            // linhaValor
            // 
            this.linhaValor.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaValor.Location = new System.Drawing.Point(31, 106);
            this.linhaValor.Name = "linhaValor";
            this.linhaValor.Size = new System.Drawing.Size(146, 2);
            this.linhaValor.TabIndex = 97;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblValor.ForeColor = System.Drawing.Color.Gray;
            this.lblValor.Location = new System.Drawing.Point(26, 60);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(32, 14);
            this.lblValor.TabIndex = 95;
            this.lblValor.Text = "Valor";
            // 
            // linhaJuros
            // 
            this.linhaJuros.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaJuros.Location = new System.Drawing.Point(209, 106);
            this.linhaJuros.Name = "linhaJuros";
            this.linhaJuros.Size = new System.Drawing.Size(99, 2);
            this.linhaJuros.TabIndex = 102;
            // 
            // lblTituloRendTotal
            // 
            this.lblTituloRendTotal.AutoSize = true;
            this.lblTituloRendTotal.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloRendTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblTituloRendTotal.Location = new System.Drawing.Point(24, 213);
            this.lblTituloRendTotal.Name = "lblTituloRendTotal";
            this.lblTituloRendTotal.Size = new System.Drawing.Size(167, 23);
            this.lblTituloRendTotal.TabIndex = 117;
            this.lblTituloRendTotal.Text = "Rendimento Total:";
            // 
            // lblRendimentoTotal
            // 
            this.lblRendimentoTotal.AutoSize = true;
            this.lblRendimentoTotal.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendimentoTotal.ForeColor = System.Drawing.Color.Gray;
            this.lblRendimentoTotal.Location = new System.Drawing.Point(208, 213);
            this.lblRendimentoTotal.MinimumSize = new System.Drawing.Size(120, 23);
            this.lblRendimentoTotal.Name = "lblRendimentoTotal";
            this.lblRendimentoTotal.Size = new System.Drawing.Size(120, 23);
            this.lblRendimentoTotal.TabIndex = 118;
            // 
            // numValor
            // 
            this.numValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.numValor.ForeColor = System.Drawing.Color.Black;
            this.numValor.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numValor.Location = new System.Drawing.Point(63, 84);
            this.numValor.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(114, 22);
            this.numValor.TabIndex = 119;
            this.numValor.ThousandsSeparator = true;
            this.numValor.Click += new System.EventHandler(this.NumValor_Click);
            // 
            // numJuros
            // 
            this.numJuros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numJuros.DecimalPlaces = 2;
            this.numJuros.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.numJuros.ForeColor = System.Drawing.Color.Black;
            this.numJuros.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numJuros.Location = new System.Drawing.Point(209, 84);
            this.numJuros.Name = "numJuros";
            this.numJuros.Size = new System.Drawing.Size(99, 22);
            this.numJuros.TabIndex = 120;
            this.numJuros.Click += new System.EventHandler(this.NumJuros_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.Window;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtData.ForeColor = System.Drawing.Color.Black;
            this.txtData.Location = new System.Drawing.Point(334, 86);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(99, 19);
            this.txtData.TabIndex = 121;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.SystemColors.Window;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtHora.ForeColor = System.Drawing.Color.Black;
            this.txtHora.Location = new System.Drawing.Point(456, 86);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(99, 19);
            this.txtHora.TabIndex = 122;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            // 
            // numAplicacoesMensais
            // 
            this.numAplicacoesMensais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numAplicacoesMensais.DecimalPlaces = 2;
            this.numAplicacoesMensais.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.numAplicacoesMensais.ForeColor = System.Drawing.Color.Black;
            this.numAplicacoesMensais.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numAplicacoesMensais.Location = new System.Drawing.Point(63, 151);
            this.numAplicacoesMensais.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAplicacoesMensais.Name = "numAplicacoesMensais";
            this.numAplicacoesMensais.Size = new System.Drawing.Size(114, 22);
            this.numAplicacoesMensais.TabIndex = 123;
            this.numAplicacoesMensais.ThousandsSeparator = true;
            this.numAplicacoesMensais.Click += new System.EventHandler(this.NumAplicacoesMensais_Click);
            // 
            // numQntMeses
            // 
            this.numQntMeses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQntMeses.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.numQntMeses.ForeColor = System.Drawing.Color.Black;
            this.numQntMeses.Location = new System.Drawing.Point(209, 151);
            this.numQntMeses.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numQntMeses.Name = "numQntMeses";
            this.numQntMeses.Size = new System.Drawing.Size(99, 22);
            this.numQntMeses.TabIndex = 125;
            this.numQntMeses.Click += new System.EventHandler(this.NumQntMeses_Click);
            // 
            // lblQntMeses
            // 
            this.lblQntMeses.AutoSize = true;
            this.lblQntMeses.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblQntMeses.ForeColor = System.Drawing.Color.Gray;
            this.lblQntMeses.Location = new System.Drawing.Point(202, 125);
            this.lblQntMeses.Name = "lblQntMeses";
            this.lblQntMeses.Size = new System.Drawing.Size(117, 14);
            this.lblQntMeses.TabIndex = 124;
            this.lblQntMeses.Text = "Quantidade de Meses";
            // 
            // lblValorRs
            // 
            this.lblValorRs.AutoSize = true;
            this.lblValorRs.BackColor = System.Drawing.Color.White;
            this.lblValorRs.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblValorRs.ForeColor = System.Drawing.Color.Black;
            this.lblValorRs.Location = new System.Drawing.Point(31, 84);
            this.lblValorRs.MinimumSize = new System.Drawing.Size(0, 22);
            this.lblValorRs.Name = "lblValorRs";
            this.lblValorRs.Size = new System.Drawing.Size(32, 22);
            this.lblValorRs.TabIndex = 126;
            this.lblValorRs.Text = "R$ ";
            // 
            // lblJurosPorcentagem
            // 
            this.lblJurosPorcentagem.AutoSize = true;
            this.lblJurosPorcentagem.BackColor = System.Drawing.Color.White;
            this.lblJurosPorcentagem.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblJurosPorcentagem.ForeColor = System.Drawing.Color.Black;
            this.lblJurosPorcentagem.Location = new System.Drawing.Point(255, 85);
            this.lblJurosPorcentagem.Name = "lblJurosPorcentagem";
            this.lblJurosPorcentagem.Size = new System.Drawing.Size(22, 19);
            this.lblJurosPorcentagem.TabIndex = 127;
            this.lblJurosPorcentagem.Text = "%";
            // 
            // lblAplicacoesMensaisRs
            // 
            this.lblAplicacoesMensaisRs.AutoSize = true;
            this.lblAplicacoesMensaisRs.BackColor = System.Drawing.Color.White;
            this.lblAplicacoesMensaisRs.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.lblAplicacoesMensaisRs.ForeColor = System.Drawing.Color.Black;
            this.lblAplicacoesMensaisRs.Location = new System.Drawing.Point(31, 151);
            this.lblAplicacoesMensaisRs.MinimumSize = new System.Drawing.Size(0, 22);
            this.lblAplicacoesMensaisRs.Name = "lblAplicacoesMensaisRs";
            this.lblAplicacoesMensaisRs.Size = new System.Drawing.Size(32, 22);
            this.lblAplicacoesMensaisRs.TabIndex = 128;
            this.lblAplicacoesMensaisRs.Text = "R$ ";
            // 
            // linhaQntMeses
            // 
            this.linhaQntMeses.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaQntMeses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaQntMeses.Location = new System.Drawing.Point(209, 173);
            this.linhaQntMeses.Name = "linhaQntMeses";
            this.linhaQntMeses.Size = new System.Drawing.Size(99, 2);
            this.linhaQntMeses.TabIndex = 104;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location = new System.Drawing.Point(41, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(396, 26);
            this.lblInfo.TabIndex = 129;
            this.lblInfo.Text = "Clique em Calcular para obter o resultado, e clique em alguma simulação\r\n da list" +
    "a abaixo, para visualizar seus detalhes. Se quiser deletá-la, clique em Remover." +
    " ";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Enabled = false;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.btnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimpar.Image = global::Granamiza.Properties.Resources.edit;
            this.btnLimpar.Location = new System.Drawing.Point(458, 255);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(45, 38);
            this.btnLimpar.TabIndex = 132;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Transparent;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Enabled = false;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.Location = new System.Drawing.Point(509, 255);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(45, 38);
            this.btnRemover.TabIndex = 131;
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // lblObr1
            // 
            this.lblObr1.AutoSize = true;
            this.lblObr1.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObr1.ForeColor = System.Drawing.Color.DarkRed;
            this.lblObr1.Location = new System.Drawing.Point(181, 84);
            this.lblObr1.Name = "lblObr1";
            this.lblObr1.Size = new System.Drawing.Size(13, 15);
            this.lblObr1.TabIndex = 133;
            this.lblObr1.Text = "*";
            this.toolTip1.SetToolTip(this.lblObr1, "Obrigatório valor maior que 0");
            // 
            // lblObr2
            // 
            this.lblObr2.AutoSize = true;
            this.lblObr2.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObr2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblObr2.Location = new System.Drawing.Point(312, 84);
            this.lblObr2.Name = "lblObr2";
            this.lblObr2.Size = new System.Drawing.Size(13, 15);
            this.lblObr2.TabIndex = 134;
            this.lblObr2.Text = "*";
            this.toolTip1.SetToolTip(this.lblObr2, "Obrigatório valor maior que 0");
            // 
            // lblObr3
            // 
            this.lblObr3.AutoSize = true;
            this.lblObr3.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObr3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblObr3.Location = new System.Drawing.Point(312, 152);
            this.lblObr3.Name = "lblObr3";
            this.lblObr3.Size = new System.Drawing.Size(13, 15);
            this.lblObr3.TabIndex = 135;
            this.lblObr3.Text = "*";
            this.toolTip1.SetToolTip(this.lblObr3, "Obrigatório valor inteiro maior que 0");
            // 
            // UcSimularInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblObr3);
            this.Controls.Add(this.lblObr2);
            this.Controls.Add(this.lblObr1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.linhaQntMeses);
            this.Controls.Add(this.lblAplicacoesMensaisRs);
            this.Controls.Add(this.lblJurosPorcentagem);
            this.Controls.Add(this.lblValorRs);
            this.Controls.Add(this.numQntMeses);
            this.Controls.Add(this.lblQntMeses);
            this.Controls.Add(this.numAplicacoesMensais);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.numJuros);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.lblRendimentoTotal);
            this.Controls.Add(this.lblTituloRendTotal);
            this.Controls.Add(this.dgvSimulacao);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.linhaAplicacoesMensais);
            this.Controls.Add(this.linhaHora);
            this.Controls.Add(this.lblAplicacoesMensais);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.linhaData);
            this.Controls.Add(this.linhaJuros);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.linhaValor);
            this.Controls.Add(this.lblValor);
            this.Name = "UcSimularInvestimento";
            this.Size = new System.Drawing.Size(572, 467);
            this.Load += new System.EventHandler(this.UserControlSimularInvestimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJuros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAplicacoesMensais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQntMeses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSimulacao;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel linhaAplicacoesMensais;
        private System.Windows.Forms.Panel linhaHora;
        private System.Windows.Forms.Label lblAplicacoesMensais;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel linhaData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Panel linhaValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel linhaJuros;
        private System.Windows.Forms.Label lblTituloRendTotal;
        private System.Windows.Forms.Label lblRendimentoTotal;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.NumericUpDown numJuros;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.NumericUpDown numAplicacoesMensais;
        private System.Windows.Forms.NumericUpDown numQntMeses;
        private System.Windows.Forms.Label lblQntMeses;
        private System.Windows.Forms.BindingSource simulacaoBindingSource;
        private System.Windows.Forms.Label lblValorRs;
        private System.Windows.Forms.Label lblJurosPorcentagem;
        private System.Windows.Forms.Label lblAplicacoesMensaisRs;
        private System.Windows.Forms.Panel linhaQntMeses;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorinseridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntmesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacoesmensaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendimentototalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblObr1;
        private System.Windows.Forms.Label lblObr2;
        private System.Windows.Forms.Label lblObr3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
