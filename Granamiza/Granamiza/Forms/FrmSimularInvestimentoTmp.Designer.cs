namespace Granamiza.Forms
{
    partial class FrmSimularInvestimentoTmp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.numJuros = new System.Windows.Forms.NumericUpDown();
            this.numAplicacoesMensais = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.numQntMeses = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.simulacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.valorinseridoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qntmesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplicacoesmensaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendimentototalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJuros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAplicacoesMensais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQntMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Juros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aplicações mensais: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(204, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numValor.Location = new System.Drawing.Point(204, 24);
            this.numValor.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numValor.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 7;
            this.numValor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numJuros
            // 
            this.numJuros.DecimalPlaces = 2;
            this.numJuros.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numJuros.Location = new System.Drawing.Point(204, 85);
            this.numJuros.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numJuros.Name = "numJuros";
            this.numJuros.Size = new System.Drawing.Size(120, 20);
            this.numJuros.TabIndex = 8;
            this.numJuros.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // numAplicacoesMensais
            // 
            this.numAplicacoesMensais.DecimalPlaces = 2;
            this.numAplicacoesMensais.Location = new System.Drawing.Point(204, 136);
            this.numAplicacoesMensais.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAplicacoesMensais.Name = "numAplicacoesMensais";
            this.numAplicacoesMensais.Size = new System.Drawing.Size(120, 20);
            this.numAplicacoesMensais.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rendimento total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(551, 31);
            this.lblTotal.MinimumSize = new System.Drawing.Size(80, 12);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(80, 13);
            this.lblTotal.TabIndex = 12;
            // 
            // numQntMeses
            // 
            this.numQntMeses.Location = new System.Drawing.Point(204, 184);
            this.numQntMeses.Maximum = new decimal(new int[] {
            840,
            0,
            0,
            0});
            this.numQntMeses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQntMeses.Name = "numQntMeses";
            this.numQntMeses.Size = new System.Drawing.Size(120, 20);
            this.numQntMeses.TabIndex = 14;
            this.numQntMeses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantidade de meses:";
            // 
            // simulacaoBindingSource
            // 
            this.simulacaoBindingSource.DataSource = typeof(Granamiza.Modelo.simulacao);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valorinseridoDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn,
            this.qntmesesDataGridViewTextBoxColumn,
            this.datacriacaoDataGridViewTextBoxColumn,
            this.aplicacoesmensaisDataGridViewTextBoxColumn,
            this.rendimentototalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.simulacaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(79, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // valorinseridoDataGridViewTextBoxColumn
            // 
            this.valorinseridoDataGridViewTextBoxColumn.DataPropertyName = "valor_inserido";
            dataGridViewCellStyle1.Format = "c2";
            this.valorinseridoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorinseridoDataGridViewTextBoxColumn.HeaderText = "valor_inserido";
            this.valorinseridoDataGridViewTextBoxColumn.Name = "valorinseridoDataGridViewTextBoxColumn";
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "juros";
            this.jurosDataGridViewTextBoxColumn.HeaderText = "juros";
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            // 
            // qntmesesDataGridViewTextBoxColumn
            // 
            this.qntmesesDataGridViewTextBoxColumn.DataPropertyName = "qnt_meses";
            this.qntmesesDataGridViewTextBoxColumn.HeaderText = "qnt_meses";
            this.qntmesesDataGridViewTextBoxColumn.Name = "qntmesesDataGridViewTextBoxColumn";
            // 
            // datacriacaoDataGridViewTextBoxColumn
            // 
            this.datacriacaoDataGridViewTextBoxColumn.DataPropertyName = "data_criacao";
            this.datacriacaoDataGridViewTextBoxColumn.HeaderText = "data_criacao";
            this.datacriacaoDataGridViewTextBoxColumn.Name = "datacriacaoDataGridViewTextBoxColumn";
            // 
            // aplicacoesmensaisDataGridViewTextBoxColumn
            // 
            this.aplicacoesmensaisDataGridViewTextBoxColumn.DataPropertyName = "aplicacoes_mensais";
            dataGridViewCellStyle2.Format = "c2";
            this.aplicacoesmensaisDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.aplicacoesmensaisDataGridViewTextBoxColumn.HeaderText = "aplicacoes_mensais";
            this.aplicacoesmensaisDataGridViewTextBoxColumn.Name = "aplicacoesmensaisDataGridViewTextBoxColumn";
            // 
            // rendimentototalDataGridViewTextBoxColumn
            // 
            this.rendimentototalDataGridViewTextBoxColumn.DataPropertyName = "rendimento_total";
            dataGridViewCellStyle3.Format = "c2";
            this.rendimentototalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.rendimentototalDataGridViewTextBoxColumn.HeaderText = "rendimento_total";
            this.rendimentototalDataGridViewTextBoxColumn.Name = "rendimentototalDataGridViewTextBoxColumn";
            // 
            // FrmSimularInvestimentoTmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numQntMeses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numAplicacoesMensais);
            this.Controls.Add(this.numJuros);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSimularInvestimentoTmp";
            this.Text = "FrmSimularInvestimentoTmp";
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJuros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAplicacoesMensais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQntMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.NumericUpDown numJuros;
        private System.Windows.Forms.NumericUpDown numAplicacoesMensais;
        private System.Windows.Forms.BindingSource simulacaoBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown numQntMeses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorinseridoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qntmesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplicacoesmensaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendimentototalDataGridViewTextBoxColumn;
    }
}