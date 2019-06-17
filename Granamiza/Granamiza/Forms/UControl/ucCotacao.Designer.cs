namespace Granamiza.Forms.UControl
{
    partial class UcCotacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCotacao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTituloDolar = new System.Windows.Forms.Label();
            this.txtUltimaAtualização = new System.Windows.Forms.TextBox();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.lblTituloBitcoin = new System.Windows.Forms.Label();
            this.btnDolarBaixa = new System.Windows.Forms.Button();
            this.btnDolarAlta = new System.Windows.Forms.Button();
            this.btnBitcoinBaixa = new System.Windows.Forms.Button();
            this.btnBitcoinAlta = new System.Windows.Forms.Button();
            this.lblTituloEuro = new System.Windows.Forms.Label();
            this.btnEuroBaixa = new System.Windows.Forms.Button();
            this.btnEuroAlta = new System.Windows.Forms.Button();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvCotacao = new System.Windows.Forms.DataGridView();
            this.cotacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTituloGridView = new System.Windows.Forms.Label();
            this.picSetaLblTituloGridView = new System.Windows.Forms.PictureBox();
            this.lblSetaBaixaEuro = new System.Windows.Forms.Label();
            this.lblSetaAltaEuro = new System.Windows.Forms.Label();
            this.lblSetaAltaDolar = new System.Windows.Forms.Label();
            this.lblSetaBaixaDolar = new System.Windows.Forms.Label();
            this.lblSetaAltaBitcoin = new System.Windows.Forms.Label();
            this.lblSetaBaixaBitcoin = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_dolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_euro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_bitcoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetaLblTituloGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloDolar
            // 
            this.lblTituloDolar.AutoSize = true;
            this.lblTituloDolar.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblTituloDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloDolar.Location = new System.Drawing.Point(119, 84);
            this.lblTituloDolar.Name = "lblTituloDolar";
            this.lblTituloDolar.Size = new System.Drawing.Size(66, 14);
            this.lblTituloDolar.TabIndex = 151;
            this.lblTituloDolar.Text = "Dolar (USD)";
            // 
            // txtUltimaAtualização
            // 
            this.txtUltimaAtualização.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUltimaAtualização.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUltimaAtualização.Font = new System.Drawing.Font("SF Pro Display", 10.75F);
            this.txtUltimaAtualização.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUltimaAtualização.Location = new System.Drawing.Point(403, 49);
            this.txtUltimaAtualização.Name = "txtUltimaAtualização";
            this.txtUltimaAtualização.ReadOnly = true;
            this.txtUltimaAtualização.Size = new System.Drawing.Size(159, 18);
            this.txtUltimaAtualização.TabIndex = 148;
            this.txtUltimaAtualização.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAjuda
            // 
            this.lblAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAjuda.AutoSize = true;
            this.lblAjuda.BackColor = System.Drawing.Color.White;
            this.lblAjuda.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.ForeColor = System.Drawing.Color.DimGray;
            this.lblAjuda.Location = new System.Drawing.Point(36, 5);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(544, 28);
            this.lblAjuda.TabIndex = 160;
            this.lblAjuda.Text = "Esta é uma visão do valor do Real R$ em comparação com outras moedas. Em compras " +
    "no exterior considere \r\nesses valores para evitar gastos excedidos e manter-se s" +
    "empre atualizado dos preços das moedas.";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTituloBitcoin
            // 
            this.lblTituloBitcoin.AutoSize = true;
            this.lblTituloBitcoin.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblTituloBitcoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloBitcoin.Location = new System.Drawing.Point(262, 192);
            this.lblTituloBitcoin.Name = "lblTituloBitcoin";
            this.lblTituloBitcoin.Size = new System.Drawing.Size(73, 14);
            this.lblTituloBitcoin.TabIndex = 151;
            this.lblTituloBitcoin.Text = "BitCoin (BTC)";
            // 
            // btnDolarBaixa
            // 
            this.btnDolarBaixa.BackColor = System.Drawing.Color.White;
            this.btnDolarBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDolarBaixa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDolarBaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDolarBaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDolarBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDolarBaixa.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnDolarBaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.btnDolarBaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDolarBaixa.Location = new System.Drawing.Point(19, 140);
            this.btnDolarBaixa.Name = "btnDolarBaixa";
            this.btnDolarBaixa.Size = new System.Drawing.Size(263, 32);
            this.btnDolarBaixa.TabIndex = 152;
            this.btnDolarBaixa.Text = "R$ 12.452,00";
            this.btnDolarBaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDolarBaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDolarBaixa.UseVisualStyleBackColor = false;
            // 
            // btnDolarAlta
            // 
            this.btnDolarAlta.BackColor = System.Drawing.SystemColors.Window;
            this.btnDolarAlta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDolarAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDolarAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDolarAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDolarAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDolarAlta.Font = new System.Drawing.Font("SF Pro Display", 16.75F, System.Drawing.FontStyle.Bold);
            this.btnDolarAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.btnDolarAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDolarAlta.Location = new System.Drawing.Point(19, 92);
            this.btnDolarAlta.Name = "btnDolarAlta";
            this.btnDolarAlta.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnDolarAlta.Size = new System.Drawing.Size(263, 51);
            this.btnDolarAlta.TabIndex = 153;
            this.btnDolarAlta.Text = "R$ 12.452,00";
            this.btnDolarAlta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDolarAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDolarAlta.UseVisualStyleBackColor = false;
            // 
            // btnBitcoinBaixa
            // 
            this.btnBitcoinBaixa.BackColor = System.Drawing.Color.White;
            this.btnBitcoinBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBitcoinBaixa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBitcoinBaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBitcoinBaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBitcoinBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitcoinBaixa.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnBitcoinBaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.btnBitcoinBaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBitcoinBaixa.Location = new System.Drawing.Point(18, 244);
            this.btnBitcoinBaixa.Name = "btnBitcoinBaixa";
            this.btnBitcoinBaixa.Size = new System.Drawing.Size(542, 32);
            this.btnBitcoinBaixa.TabIndex = 167;
            this.btnBitcoinBaixa.Text = "R$ 12.452,00";
            this.btnBitcoinBaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBitcoinBaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBitcoinBaixa.UseVisualStyleBackColor = false;
            // 
            // btnBitcoinAlta
            // 
            this.btnBitcoinAlta.BackColor = System.Drawing.SystemColors.Window;
            this.btnBitcoinAlta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnBitcoinAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBitcoinAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBitcoinAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBitcoinAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitcoinAlta.Font = new System.Drawing.Font("SF Pro Display", 16.75F, System.Drawing.FontStyle.Bold);
            this.btnBitcoinAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.btnBitcoinAlta.Location = new System.Drawing.Point(18, 197);
            this.btnBitcoinAlta.Name = "btnBitcoinAlta";
            this.btnBitcoinAlta.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnBitcoinAlta.Size = new System.Drawing.Size(542, 48);
            this.btnBitcoinAlta.TabIndex = 168;
            this.btnBitcoinAlta.Text = "R$ 12.452,00";
            this.btnBitcoinAlta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBitcoinAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBitcoinAlta.UseVisualStyleBackColor = false;
            // 
            // lblTituloEuro
            // 
            this.lblTituloEuro.AutoSize = true;
            this.lblTituloEuro.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblTituloEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloEuro.Location = new System.Drawing.Point(412, 84);
            this.lblTituloEuro.Name = "lblTituloEuro";
            this.lblTituloEuro.Size = new System.Drawing.Size(62, 14);
            this.lblTituloEuro.TabIndex = 171;
            this.lblTituloEuro.Text = "Euro (EUR)";
            // 
            // btnEuroBaixa
            // 
            this.btnEuroBaixa.BackColor = System.Drawing.Color.White;
            this.btnEuroBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEuroBaixa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEuroBaixa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEuroBaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEuroBaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuroBaixa.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnEuroBaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.btnEuroBaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEuroBaixa.Location = new System.Drawing.Point(310, 140);
            this.btnEuroBaixa.Name = "btnEuroBaixa";
            this.btnEuroBaixa.Size = new System.Drawing.Size(252, 32);
            this.btnEuroBaixa.TabIndex = 172;
            this.btnEuroBaixa.Text = "R$ 12.452,00";
            this.btnEuroBaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEuroBaixa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEuroBaixa.UseVisualStyleBackColor = false;
            // 
            // btnEuroAlta
            // 
            this.btnEuroAlta.BackColor = System.Drawing.SystemColors.Window;
            this.btnEuroAlta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnEuroAlta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEuroAlta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEuroAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEuroAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuroAlta.Font = new System.Drawing.Font("SF Pro Display", 16.75F, System.Drawing.FontStyle.Bold);
            this.btnEuroAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.btnEuroAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEuroAlta.Location = new System.Drawing.Point(310, 92);
            this.btnEuroAlta.Name = "btnEuroAlta";
            this.btnEuroAlta.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btnEuroAlta.Size = new System.Drawing.Size(252, 51);
            this.btnEuroAlta.TabIndex = 173;
            this.btnEuroAlta.Text = "R$ 12.452,00";
            this.btnEuroAlta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEuroAlta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEuroAlta.UseVisualStyleBackColor = false;
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInfo.BackgroundImage")));
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picInfo.Location = new System.Drawing.Point(3, 3);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(28, 26);
            this.picInfo.TabIndex = 174;
            this.picInfo.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(482, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(41, 38);
            this.btnSalvar.TabIndex = 175;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // dgvCotacao
            // 
            this.dgvCotacao.AllowUserToAddRows = false;
            this.dgvCotacao.AllowUserToDeleteRows = false;
            this.dgvCotacao.AllowUserToOrderColumns = true;
            this.dgvCotacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCotacao.AutoGenerateColumns = false;
            this.dgvCotacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCotacao.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCotacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCotacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.data_consulta,
            this.valor_dolar,
            this.valor_euro,
            this.valor_bitcoin});
            this.dgvCotacao.DataSource = this.cotacaoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCotacao.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCotacao.EnableHeadersVisualStyles = false;
            this.dgvCotacao.GridColor = System.Drawing.Color.White;
            this.dgvCotacao.Location = new System.Drawing.Point(19, 335);
            this.dgvCotacao.Name = "dgvCotacao";
            this.dgvCotacao.ReadOnly = true;
            this.dgvCotacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCotacao.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCotacao.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCotacao.Size = new System.Drawing.Size(545, 120);
            this.dgvCotacao.TabIndex = 176;
            this.dgvCotacao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCotacao_CellClick);
            // 
            // cotacaoBindingSource
            // 
            this.cotacaoBindingSource.DataSource = typeof(Granamiza.Modelo.cotacao);
            // 
            // lblTituloGridView
            // 
            this.lblTituloGridView.AutoSize = true;
            this.lblTituloGridView.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblTituloGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloGridView.Location = new System.Drawing.Point(34, 310);
            this.lblTituloGridView.Name = "lblTituloGridView";
            this.lblTituloGridView.Size = new System.Drawing.Size(122, 18);
            this.lblTituloGridView.TabIndex = 177;
            this.lblTituloGridView.Text = "Cotações Salvas";
            // 
            // picSetaLblTituloGridView
            // 
            this.picSetaLblTituloGridView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSetaLblTituloGridView.BackgroundImage")));
            this.picSetaLblTituloGridView.Location = new System.Drawing.Point(19, 310);
            this.picSetaLblTituloGridView.Name = "picSetaLblTituloGridView";
            this.picSetaLblTituloGridView.Size = new System.Drawing.Size(18, 17);
            this.picSetaLblTituloGridView.TabIndex = 178;
            this.picSetaLblTituloGridView.TabStop = false;
            // 
            // lblSetaBaixaEuro
            // 
            this.lblSetaBaixaEuro.AutoSize = true;
            this.lblSetaBaixaEuro.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblSetaBaixaEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.lblSetaBaixaEuro.Location = new System.Drawing.Point(533, 149);
            this.lblSetaBaixaEuro.Name = "lblSetaBaixaEuro";
            this.lblSetaBaixaEuro.Size = new System.Drawing.Size(20, 18);
            this.lblSetaBaixaEuro.TabIndex = 180;
            this.lblSetaBaixaEuro.Text = "↓";
            // 
            // lblSetaAltaEuro
            // 
            this.lblSetaAltaEuro.AutoSize = true;
            this.lblSetaAltaEuro.Font = new System.Drawing.Font("SF Pro Display", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblSetaAltaEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.lblSetaAltaEuro.Location = new System.Drawing.Point(317, 106);
            this.lblSetaAltaEuro.Name = "lblSetaAltaEuro";
            this.lblSetaAltaEuro.Size = new System.Drawing.Size(30, 26);
            this.lblSetaAltaEuro.TabIndex = 179;
            this.lblSetaAltaEuro.Text = "↑";
            // 
            // lblSetaAltaDolar
            // 
            this.lblSetaAltaDolar.AutoSize = true;
            this.lblSetaAltaDolar.Font = new System.Drawing.Font("SF Pro Display", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblSetaAltaDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.lblSetaAltaDolar.Location = new System.Drawing.Point(26, 106);
            this.lblSetaAltaDolar.Name = "lblSetaAltaDolar";
            this.lblSetaAltaDolar.Size = new System.Drawing.Size(30, 26);
            this.lblSetaAltaDolar.TabIndex = 181;
            this.lblSetaAltaDolar.Text = "↑";
            // 
            // lblSetaBaixaDolar
            // 
            this.lblSetaBaixaDolar.AutoSize = true;
            this.lblSetaBaixaDolar.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblSetaBaixaDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.lblSetaBaixaDolar.Location = new System.Drawing.Point(255, 147);
            this.lblSetaBaixaDolar.Name = "lblSetaBaixaDolar";
            this.lblSetaBaixaDolar.Size = new System.Drawing.Size(20, 18);
            this.lblSetaBaixaDolar.TabIndex = 182;
            this.lblSetaBaixaDolar.Text = "↓";
            // 
            // lblSetaAltaBitcoin
            // 
            this.lblSetaAltaBitcoin.AutoSize = true;
            this.lblSetaAltaBitcoin.Font = new System.Drawing.Font("SF Pro Display", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblSetaAltaBitcoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.lblSetaAltaBitcoin.Location = new System.Drawing.Point(26, 212);
            this.lblSetaAltaBitcoin.Name = "lblSetaAltaBitcoin";
            this.lblSetaAltaBitcoin.Size = new System.Drawing.Size(30, 26);
            this.lblSetaAltaBitcoin.TabIndex = 183;
            this.lblSetaAltaBitcoin.Text = "↑";
            // 
            // lblSetaBaixaBitcoin
            // 
            this.lblSetaBaixaBitcoin.AutoSize = true;
            this.lblSetaBaixaBitcoin.Font = new System.Drawing.Font("SF Pro Display", 10.75F, System.Drawing.FontStyle.Bold);
            this.lblSetaBaixaBitcoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.lblSetaBaixaBitcoin.Location = new System.Drawing.Point(533, 250);
            this.lblSetaBaixaBitcoin.Name = "lblSetaBaixaBitcoin";
            this.lblSetaBaixaBitcoin.Size = new System.Drawing.Size(20, 18);
            this.lblSetaBaixaBitcoin.TabIndex = 184;
            this.lblSetaBaixaBitcoin.Text = "↓";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(529, 291);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(35, 38);
            this.btnExcluir.TabIndex = 185;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // data_consulta
            // 
            this.data_consulta.DataPropertyName = "data_consulta";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.data_consulta.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_consulta.HeaderText = "Data";
            this.data_consulta.Name = "data_consulta";
            this.data_consulta.ReadOnly = true;
            // 
            // valor_dolar
            // 
            this.valor_dolar.DataPropertyName = "valor_dolar";
            dataGridViewCellStyle3.Format = "C3";
            dataGridViewCellStyle3.NullValue = null;
            this.valor_dolar.DefaultCellStyle = dataGridViewCellStyle3;
            this.valor_dolar.HeaderText = "Dolar (USD)";
            this.valor_dolar.Name = "valor_dolar";
            this.valor_dolar.ReadOnly = true;
            // 
            // valor_euro
            // 
            this.valor_euro.DataPropertyName = "valor_euro";
            dataGridViewCellStyle4.Format = "C3";
            dataGridViewCellStyle4.NullValue = null;
            this.valor_euro.DefaultCellStyle = dataGridViewCellStyle4;
            this.valor_euro.HeaderText = "Euro (EUR)";
            this.valor_euro.Name = "valor_euro";
            this.valor_euro.ReadOnly = true;
            // 
            // valor_bitcoin
            // 
            this.valor_bitcoin.DataPropertyName = "valor_bitcoin";
            dataGridViewCellStyle5.Format = "C3";
            dataGridViewCellStyle5.NullValue = null;
            this.valor_bitcoin.DefaultCellStyle = dataGridViewCellStyle5;
            this.valor_bitcoin.HeaderText = "Bitcoin (BTC)";
            this.valor_bitcoin.Name = "valor_bitcoin";
            this.valor_bitcoin.ReadOnly = true;
            // 
            // UcCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblSetaBaixaBitcoin);
            this.Controls.Add(this.lblSetaAltaBitcoin);
            this.Controls.Add(this.lblSetaBaixaDolar);
            this.Controls.Add(this.lblSetaAltaDolar);
            this.Controls.Add(this.lblSetaBaixaEuro);
            this.Controls.Add(this.lblSetaAltaEuro);
            this.Controls.Add(this.lblTituloGridView);
            this.Controls.Add(this.dgvCotacao);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.lblTituloEuro);
            this.Controls.Add(this.btnEuroBaixa);
            this.Controls.Add(this.btnEuroAlta);
            this.Controls.Add(this.lblTituloBitcoin);
            this.Controls.Add(this.btnBitcoinBaixa);
            this.Controls.Add(this.btnBitcoinAlta);
            this.Controls.Add(this.lblTituloDolar);
            this.Controls.Add(this.btnDolarBaixa);
            this.Controls.Add(this.btnDolarAlta);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.txtUltimaAtualização);
            this.Controls.Add(this.picSetaLblTituloGridView);
            this.Name = "UcCotacao";
            this.Size = new System.Drawing.Size(591, 467);
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetaLblTituloGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUltimaAtualização;
        private System.Windows.Forms.Label lblTituloDolar;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.Label lblTituloBitcoin;
        private System.Windows.Forms.Button btnDolarBaixa;
        private System.Windows.Forms.Button btnDolarAlta;
        private System.Windows.Forms.Button btnBitcoinBaixa;
        private System.Windows.Forms.Button btnBitcoinAlta;
        private System.Windows.Forms.Label lblTituloEuro;
        private System.Windows.Forms.Button btnEuroBaixa;
        private System.Windows.Forms.Button btnEuroAlta;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvCotacao;
        private System.Windows.Forms.BindingSource cotacaoBindingSource;
        private System.Windows.Forms.Label lblTituloGridView;
        private System.Windows.Forms.PictureBox picSetaLblTituloGridView;
        private System.Windows.Forms.Label lblSetaBaixaEuro;
        private System.Windows.Forms.Label lblSetaAltaEuro;
        private System.Windows.Forms.Label lblSetaAltaDolar;
        private System.Windows.Forms.Label lblSetaBaixaDolar;
        private System.Windows.Forms.Label lblSetaAltaBitcoin;
        private System.Windows.Forms.Label lblSetaBaixaBitcoin;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_dolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_euro;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_bitcoin;
    }
}
