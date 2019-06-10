namespace Granamiza.Forms.UControl
{
    partial class UserControlTransacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTransacao));
            this.dgvTransacao = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainsercaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwdespesaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwtransacaocategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.pbIconeCategoria = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.linhaDesc = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.linhaHora = new System.Windows.Forms.Panel();
            this.txtDsc = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.linhaData = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.linhaCategoria = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.linhaValor = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.vwreceitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwdespesaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwtransacaocategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconeCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwreceitaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransacao
            // 
            this.dgvTransacao.AllowUserToAddRows = false;
            this.dgvTransacao.AllowUserToDeleteRows = false;
            this.dgvTransacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransacao.AutoGenerateColumns = false;
            this.dgvTransacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransacao.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.horainsercaoDataGridViewTextBoxColumn});
            this.dgvTransacao.DataSource = this.vwdespesaBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransacao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransacao.EnableHeadersVisualStyles = false;
            this.dgvTransacao.GridColor = System.Drawing.Color.White;
            this.dgvTransacao.Location = new System.Drawing.Point(20, 309);
            this.dgvTransacao.Name = "dgvTransacao";
            this.dgvTransacao.ReadOnly = true;
            this.dgvTransacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransacao.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransacao.Size = new System.Drawing.Size(538, 149);
            this.dgvTransacao.TabIndex = 115;
            this.dgvTransacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTransacao_CellDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "valor";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_insercao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // horainsercaoDataGridViewTextBoxColumn
            // 
            this.horainsercaoDataGridViewTextBoxColumn.DataPropertyName = "hora_insercao";
            this.horainsercaoDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horainsercaoDataGridViewTextBoxColumn.Name = "horainsercaoDataGridViewTextBoxColumn";
            this.horainsercaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vwdespesaBindingSource
            // 
            this.vwdespesaBindingSource.DataSource = typeof(Granamiza.Modelo.vwdespesa);
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
            // pbIconeCategoria
            // 
            this.pbIconeCategoria.BackColor = System.Drawing.Color.White;
            this.pbIconeCategoria.Location = new System.Drawing.Point(150, 81);
            this.pbIconeCategoria.Name = "pbIconeCategoria";
            this.pbIconeCategoria.Size = new System.Drawing.Size(28, 26);
            this.pbIconeCategoria.TabIndex = 113;
            this.pbIconeCategoria.TabStop = false;
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
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Transparent;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.Enabled = false;
            this.btnPagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.Image")));
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(441, 254);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(116, 38);
            this.btnPagar.TabIndex = 111;
            this.btnPagar.Text = "      Definir como Paga";
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
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
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // linhaDesc
            // 
            this.linhaDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaDesc.Location = new System.Drawing.Point(22, 192);
            this.linhaDesc.Name = "linhaDesc";
            this.linhaDesc.Size = new System.Drawing.Size(526, 2);
            this.linhaDesc.TabIndex = 103;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesc.Location = new System.Drawing.Point(29, 148);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(526, 43);
            this.txtDesc.TabIndex = 101;
            this.txtDesc.WordWrap = false;
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
            // txtDsc
            // 
            this.txtDsc.AutoSize = true;
            this.txtDsc.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.txtDsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDsc.Location = new System.Drawing.Point(24, 127);
            this.txtDsc.Name = "txtDsc";
            this.txtDsc.Size = new System.Drawing.Size(57, 14);
            this.txtDsc.TabIndex = 99;
            this.txtDsc.Text = "Descrição";
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.White;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHora.Location = new System.Drawing.Point(456, 84);
            this.txtHora.Name = "txtHora";
            this.txtHora.ReadOnly = true;
            this.txtHora.Size = new System.Drawing.Size(99, 19);
            this.txtHora.TabIndex = 108;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.linhaData.Location = new System.Drawing.Point(334, 106);
            this.linhaData.Name = "linhaData";
            this.linhaData.Size = new System.Drawing.Size(99, 2);
            this.linhaData.TabIndex = 106;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtData.Location = new System.Drawing.Point(334, 85);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(99, 19);
            this.txtData.TabIndex = 105;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // linhaCategoria
            // 
            this.linhaCategoria.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCategoria.Location = new System.Drawing.Point(150, 106);
            this.linhaCategoria.Name = "linhaCategoria";
            this.linhaCategoria.Size = new System.Drawing.Size(149, 2);
            this.linhaCategoria.TabIndex = 102;
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
            // txtCategoria
            // 
            this.txtCategoria.BackColor = System.Drawing.Color.White;
            this.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCategoria.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCategoria.Location = new System.Drawing.Point(176, 85);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.ReadOnly = true;
            this.txtCategoria.Size = new System.Drawing.Size(123, 19);
            this.txtCategoria.TabIndex = 100;
            this.txtCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoria.Location = new System.Drawing.Point(150, 60);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(56, 14);
            this.lblCategoria.TabIndex = 98;
            this.lblCategoria.Text = "Categoria";
            // 
            // linhaValor
            // 
            this.linhaValor.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaValor.Location = new System.Drawing.Point(31, 106);
            this.linhaValor.Name = "linhaValor";
            this.linhaValor.Size = new System.Drawing.Size(99, 2);
            this.linhaValor.TabIndex = 97;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValor.Location = new System.Drawing.Point(31, 85);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(99, 19);
            this.txtValor.TabIndex = 96;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // vwreceitaBindingSource
            // 
            this.vwreceitaBindingSource.DataSource = typeof(Granamiza.Modelo.vwreceita);
            // 
            // UserControlTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvTransacao);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.pbIconeCategoria);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.linhaDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.linhaHora);
            this.Controls.Add(this.txtDsc);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.linhaData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.linhaCategoria);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.linhaValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Name = "UserControlTransacao";
            this.Size = new System.Drawing.Size(572, 467);
            this.Load += new System.EventHandler(this.UserControlTransacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwdespesaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwtransacaocategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconeCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwreceitaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransacao;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.PictureBox pbIconeCategoria;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Panel linhaDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Panel linhaHora;
        private System.Windows.Forms.Label txtDsc;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel linhaData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Panel linhaCategoria;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel linhaValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.BindingSource vwtransacaocategoriaBindingSource;
        private System.Windows.Forms.BindingSource vwreceitaBindingSource;
        private System.Windows.Forms.BindingSource vwdespesaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainsercaoDataGridViewTextBoxColumn;
    }
}
