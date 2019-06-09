namespace Granamiza.Forms.UControl
{
    partial class UserControlSimularInvestimento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSimularInvestimento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSimulacao = new System.Windows.Forms.DataGridView();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.numAplicacoesMensais = new System.Windows.Forms.NumericUpDown();
            this.numQntMeses = new System.Windows.Forms.NumericUpDown();
            this.lblQntMeses = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorinseridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntmesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacoesmensaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendimentototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simulacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJuros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAplicacoesMensais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQntMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSimulacao
            // 
            this.dgvSimulacao.AllowUserToAddRows = false;
            this.dgvSimulacao.AllowUserToDeleteRows = false;
            this.dgvSimulacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSimulacao.AutoGenerateColumns = false;
            this.dgvSimulacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSimulacao.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSimulacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSimulacao.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSimulacao.EnableHeadersVisualStyles = false;
            this.dgvSimulacao.GridColor = System.Drawing.Color.White;
            this.dgvSimulacao.Location = new System.Drawing.Point(20, 309);
            this.dgvSimulacao.Name = "dgvSimulacao";
            this.dgvSimulacao.ReadOnly = true;
            this.dgvSimulacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSimulacao.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSimulacao.Size = new System.Drawing.Size(538, 149);
            this.dgvSimulacao.TabIndex = 115;
            this.dgvSimulacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTransacao_CellDoubleClick);
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInfo.BackgroundImage")));
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picInfo.Location = new System.Drawing.Point(530, 3);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(28, 26);
            this.picInfo.TabIndex = 114;
            this.picInfo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(140, 3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(386, 26);
            this.lblInfo.TabIndex = 112;
            this.lblInfo.Text = "Clique em Adicionar para adicionar valores, e dê dois cliques em alguma transação" +
    "\r\n da lista abaixo, para visualizar seus detalhes.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Transparent;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Enabled = false;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemover.Image = ((System.Drawing.Image)(resources.GetObject("btnRemover.Image")));
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(454, 254);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(103, 38);
            this.btnRemover.TabIndex = 111;
            this.btnRemover.Text = "      Remover";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(452, 213);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 39);
            this.btnAdicionar.TabIndex = 110;
            this.btnAdicionar.Text = "Calcular";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // linhaAplicacoesMensais
            // 
            this.linhaAplicacoesMensais.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaAplicacoesMensais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaAplicacoesMensais.Location = new System.Drawing.Point(31, 173);
            this.linhaAplicacoesMensais.Name = "linhaAplicacoesMensais";
            this.linhaAplicacoesMensais.Size = new System.Drawing.Size(99, 2);
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
            this.lblAplicacoesMensais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblJuros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblTituloRendTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.lblRendimentoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRendimentoTotal.Location = new System.Drawing.Point(208, 213);
            this.lblRendimentoTotal.MinimumSize = new System.Drawing.Size(120, 23);
            this.lblRendimentoTotal.Name = "lblRendimentoTotal";
            this.lblRendimentoTotal.Size = new System.Drawing.Size(120, 23);
            this.lblRendimentoTotal.TabIndex = 118;
            // 
            // numValor
            // 
            this.numValor.Location = new System.Drawing.Point(31, 87);
            this.numValor.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(146, 20);
            this.numValor.TabIndex = 119;
            // 
            // numJuros
            // 
            this.numJuros.Location = new System.Drawing.Point(209, 87);
            this.numJuros.Name = "numJuros";
            this.numJuros.Size = new System.Drawing.Size(99, 20);
            this.numJuros.TabIndex = 120;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(332, 86);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 121;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(454, 86);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 122;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // numAplicacoesMensais
            // 
            this.numAplicacoesMensais.Location = new System.Drawing.Point(31, 154);
            this.numAplicacoesMensais.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAplicacoesMensais.Name = "numAplicacoesMensais";
            this.numAplicacoesMensais.Size = new System.Drawing.Size(99, 20);
            this.numAplicacoesMensais.TabIndex = 123;
            // 
            // numQntMeses
            // 
            this.numQntMeses.Location = new System.Drawing.Point(209, 154);
            this.numQntMeses.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numQntMeses.Name = "numQntMeses";
            this.numQntMeses.Size = new System.Drawing.Size(99, 20);
            this.numQntMeses.TabIndex = 125;
            // 
            // lblQntMeses
            // 
            this.lblQntMeses.AutoSize = true;
            this.lblQntMeses.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblQntMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQntMeses.Location = new System.Drawing.Point(202, 125);
            this.lblQntMeses.Name = "lblQntMeses";
            this.lblQntMeses.Size = new System.Drawing.Size(117, 14);
            this.lblQntMeses.TabIndex = 124;
            this.lblQntMeses.Text = "Quantidade de Meses";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorinseridoDataGridViewTextBoxColumn
            // 
            this.valorinseridoDataGridViewTextBoxColumn.DataPropertyName = "valor_inserido";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorinseridoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorinseridoDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorinseridoDataGridViewTextBoxColumn.Name = "valorinseridoDataGridViewTextBoxColumn";
            this.valorinseridoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "juros";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.jurosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            this.jurosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qntmesesDataGridViewTextBoxColumn
            // 
            this.qntmesesDataGridViewTextBoxColumn.DataPropertyName = "qnt_meses";
            this.qntmesesDataGridViewTextBoxColumn.HeaderText = "Meses";
            this.qntmesesDataGridViewTextBoxColumn.Name = "qntmesesDataGridViewTextBoxColumn";
            this.qntmesesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacriacaoDataGridViewTextBoxColumn
            // 
            this.datacriacaoDataGridViewTextBoxColumn.DataPropertyName = "data_criacao";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.datacriacaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.datacriacaoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.datacriacaoDataGridViewTextBoxColumn.Name = "datacriacaoDataGridViewTextBoxColumn";
            this.datacriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aplicacoesmensaisDataGridViewTextBoxColumn
            // 
            this.aplicacoesmensaisDataGridViewTextBoxColumn.DataPropertyName = "aplicacoes_mensais";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.aplicacoesmensaisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.aplicacoesmensaisDataGridViewTextBoxColumn.HeaderText = "Aplicações Mensais";
            this.aplicacoesmensaisDataGridViewTextBoxColumn.Name = "aplicacoesmensaisDataGridViewTextBoxColumn";
            this.aplicacoesmensaisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rendimentototalDataGridViewTextBoxColumn
            // 
            this.rendimentototalDataGridViewTextBoxColumn.DataPropertyName = "rendimento_total";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.rendimentototalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.rendimentototalDataGridViewTextBoxColumn.HeaderText = "Rendimento Total";
            this.rendimentototalDataGridViewTextBoxColumn.Name = "rendimentototalDataGridViewTextBoxColumn";
            this.rendimentototalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // simulacaoBindingSource
            // 
            this.simulacaoBindingSource.DataSource = typeof(Granamiza.Modelo.simulacao);
            // 
            // UserControlSimularInvestimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.numQntMeses);
            this.Controls.Add(this.lblQntMeses);
            this.Controls.Add(this.numAplicacoesMensais);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.numJuros);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.lblRendimentoTotal);
            this.Controls.Add(this.lblTituloRendTotal);
            this.Controls.Add(this.dgvSimulacao);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
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
            this.Name = "UserControlSimularInvestimento";
            this.Size = new System.Drawing.Size(572, 467);
            this.Load += new System.EventHandler(this.UserControlSimularInvestimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJuros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAplicacoesMensais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQntMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSimulacao;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel linhaAplicacoesMensais;
        private System.Windows.Forms.Panel linhaHora;
        private System.Windows.Forms.Label lblAplicacoesMensais;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel linhaData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Panel linhaValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainsercaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel linhaJuros;
        private System.Windows.Forms.Label lblTituloRendTotal;
        private System.Windows.Forms.Label lblRendimentoTotal;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.NumericUpDown numJuros;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.NumericUpDown numAplicacoesMensais;
        private System.Windows.Forms.NumericUpDown numQntMeses;
        private System.Windows.Forms.Label lblQntMeses;
        private System.Windows.Forms.BindingSource simulacaoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorinseridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntmesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacoesmensaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendimentototalDataGridViewTextBoxColumn;
    }
}
