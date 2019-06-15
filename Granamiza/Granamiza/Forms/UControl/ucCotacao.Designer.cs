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
            this.gpDolar = new System.Windows.Forms.GroupBox();
            this.lblBaixaDolarValor = new System.Windows.Forms.Label();
            this.lblAltaDolarValor = new System.Windows.Forms.Label();
            this.linhaDivisao = new System.Windows.Forms.Panel();
            this.lblBaixaDolar = new System.Windows.Forms.Label();
            this.lblAltaDolar = new System.Windows.Forms.Label();
            this.linhaData = new System.Windows.Forms.Panel();
            this.txtDataDolar = new System.Windows.Forms.TextBox();
            this.lblDataDolar = new System.Windows.Forms.Label();
            this.gpEuro = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDataEuro = new System.Windows.Forms.TextBox();
            this.lblDataEuro = new System.Windows.Forms.Label();
            this.lblBaixaValorEuro = new System.Windows.Forms.Label();
            this.lblAltaValorEuro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBaixaEuro = new System.Windows.Forms.Label();
            this.lblAltaEuro = new System.Windows.Forms.Label();
            this.gpDolar.SuspendLayout();
            this.gpEuro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDolar
            // 
            this.gpDolar.Controls.Add(this.linhaData);
            this.gpDolar.Controls.Add(this.txtDataDolar);
            this.gpDolar.Controls.Add(this.lblDataDolar);
            this.gpDolar.Controls.Add(this.lblBaixaDolarValor);
            this.gpDolar.Controls.Add(this.lblAltaDolarValor);
            this.gpDolar.Controls.Add(this.linhaDivisao);
            this.gpDolar.Controls.Add(this.lblBaixaDolar);
            this.gpDolar.Controls.Add(this.lblAltaDolar);
            this.gpDolar.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpDolar.Location = new System.Drawing.Point(9, -1);
            this.gpDolar.Name = "gpDolar";
            this.gpDolar.Size = new System.Drawing.Size(560, 189);
            this.gpDolar.TabIndex = 127;
            this.gpDolar.TabStop = false;
            this.gpDolar.Text = "Valor do Dólar ($)  em Reais (R$)";
            // 
            // lblBaixaDolarValor
            // 
            this.lblBaixaDolarValor.AutoSize = true;
            this.lblBaixaDolarValor.Font = new System.Drawing.Font("SF Pro Display", 19F);
            this.lblBaixaDolarValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.lblBaixaDolarValor.Location = new System.Drawing.Point(368, 90);
            this.lblBaixaDolarValor.Name = "lblBaixaDolarValor";
            this.lblBaixaDolarValor.Size = new System.Drawing.Size(105, 31);
            this.lblBaixaDolarValor.TabIndex = 3;
            this.lblBaixaDolarValor.Text = "0,00 R$";
            // 
            // lblAltaDolarValor
            // 
            this.lblAltaDolarValor.AutoSize = true;
            this.lblAltaDolarValor.Font = new System.Drawing.Font("SF Pro Display", 19F);
            this.lblAltaDolarValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.lblAltaDolarValor.Location = new System.Drawing.Point(87, 90);
            this.lblAltaDolarValor.Name = "lblAltaDolarValor";
            this.lblAltaDolarValor.Size = new System.Drawing.Size(105, 31);
            this.lblAltaDolarValor.TabIndex = 2;
            this.lblAltaDolarValor.Text = "0,00 R$";
            // 
            // linhaDivisao
            // 
            this.linhaDivisao.BackColor = System.Drawing.Color.DarkGray;
            this.linhaDivisao.Location = new System.Drawing.Point(276, 32);
            this.linhaDivisao.Name = "linhaDivisao";
            this.linhaDivisao.Size = new System.Drawing.Size(2, 100);
            this.linhaDivisao.TabIndex = 1;
            // 
            // lblBaixaDolar
            // 
            this.lblBaixaDolar.AutoSize = true;
            this.lblBaixaDolar.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaixaDolar.ForeColor = System.Drawing.Color.DimGray;
            this.lblBaixaDolar.Location = new System.Drawing.Point(389, 48);
            this.lblBaixaDolar.Name = "lblBaixaDolar";
            this.lblBaixaDolar.Size = new System.Drawing.Size(59, 23);
            this.lblBaixaDolar.TabIndex = 1;
            this.lblBaixaDolar.Text = "Baixa:";
            // 
            // lblAltaDolar
            // 
            this.lblAltaDolar.AutoSize = true;
            this.lblAltaDolar.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaDolar.ForeColor = System.Drawing.Color.DimGray;
            this.lblAltaDolar.Location = new System.Drawing.Point(113, 48);
            this.lblAltaDolar.Name = "lblAltaDolar";
            this.lblAltaDolar.Size = new System.Drawing.Size(47, 23);
            this.lblAltaDolar.TabIndex = 0;
            this.lblAltaDolar.Text = "Alta:";
            // 
            // linhaData
            // 
            this.linhaData.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaData.Location = new System.Drawing.Point(16, 178);
            this.linhaData.Name = "linhaData";
            this.linhaData.Size = new System.Drawing.Size(192, 2);
            this.linhaData.TabIndex = 149;
            // 
            // txtDataDolar
            // 
            this.txtDataDolar.BackColor = System.Drawing.Color.White;
            this.txtDataDolar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataDolar.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtDataDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataDolar.Location = new System.Drawing.Point(16, 159);
            this.txtDataDolar.Name = "txtDataDolar";
            this.txtDataDolar.ReadOnly = true;
            this.txtDataDolar.Size = new System.Drawing.Size(192, 19);
            this.txtDataDolar.TabIndex = 148;
            this.txtDataDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataDolar
            // 
            this.lblDataDolar.AutoSize = true;
            this.lblDataDolar.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblDataDolar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataDolar.Location = new System.Drawing.Point(17, 138);
            this.lblDataDolar.Name = "lblDataDolar";
            this.lblDataDolar.Size = new System.Drawing.Size(31, 14);
            this.lblDataDolar.TabIndex = 147;
            this.lblDataDolar.Text = "Data";
            // 
            // gpEuro
            // 
            this.gpEuro.Controls.Add(this.panel1);
            this.gpEuro.Controls.Add(this.txtDataEuro);
            this.gpEuro.Controls.Add(this.lblDataEuro);
            this.gpEuro.Controls.Add(this.lblBaixaValorEuro);
            this.gpEuro.Controls.Add(this.lblAltaValorEuro);
            this.gpEuro.Controls.Add(this.panel2);
            this.gpEuro.Controls.Add(this.lblBaixaEuro);
            this.gpEuro.Controls.Add(this.lblAltaEuro);
            this.gpEuro.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpEuro.Location = new System.Drawing.Point(9, 238);
            this.gpEuro.Name = "gpEuro";
            this.gpEuro.Size = new System.Drawing.Size(560, 189);
            this.gpEuro.TabIndex = 150;
            this.gpEuro.TabStop = false;
            this.gpEuro.Text = "Valor do Euro (E) em Reais (R$)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 2);
            this.panel1.TabIndex = 149;
            // 
            // txtDataEuro
            // 
            this.txtDataEuro.BackColor = System.Drawing.Color.White;
            this.txtDataEuro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataEuro.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtDataEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataEuro.Location = new System.Drawing.Point(16, 159);
            this.txtDataEuro.Name = "txtDataEuro";
            this.txtDataEuro.ReadOnly = true;
            this.txtDataEuro.Size = new System.Drawing.Size(192, 19);
            this.txtDataEuro.TabIndex = 148;
            this.txtDataEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataEuro
            // 
            this.lblDataEuro.AutoSize = true;
            this.lblDataEuro.Font = new System.Drawing.Font("SF Pro Display", 8.75F);
            this.lblDataEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDataEuro.Location = new System.Drawing.Point(17, 138);
            this.lblDataEuro.Name = "lblDataEuro";
            this.lblDataEuro.Size = new System.Drawing.Size(31, 14);
            this.lblDataEuro.TabIndex = 147;
            this.lblDataEuro.Text = "Data";
            // 
            // lblBaixaValorEuro
            // 
            this.lblBaixaValorEuro.AutoSize = true;
            this.lblBaixaValorEuro.Font = new System.Drawing.Font("SF Pro Display", 19F);
            this.lblBaixaValorEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.lblBaixaValorEuro.Location = new System.Drawing.Point(368, 90);
            this.lblBaixaValorEuro.Name = "lblBaixaValorEuro";
            this.lblBaixaValorEuro.Size = new System.Drawing.Size(105, 31);
            this.lblBaixaValorEuro.TabIndex = 3;
            this.lblBaixaValorEuro.Text = "0,00 R$";
            // 
            // lblAltaValorEuro
            // 
            this.lblAltaValorEuro.AutoSize = true;
            this.lblAltaValorEuro.Font = new System.Drawing.Font("SF Pro Display", 19F);
            this.lblAltaValorEuro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.lblAltaValorEuro.Location = new System.Drawing.Point(87, 90);
            this.lblAltaValorEuro.Name = "lblAltaValorEuro";
            this.lblAltaValorEuro.Size = new System.Drawing.Size(105, 31);
            this.lblAltaValorEuro.TabIndex = 2;
            this.lblAltaValorEuro.Text = "0,00 R$";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(276, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 100);
            this.panel2.TabIndex = 1;
            // 
            // lblBaixaEuro
            // 
            this.lblBaixaEuro.AutoSize = true;
            this.lblBaixaEuro.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaixaEuro.ForeColor = System.Drawing.Color.DimGray;
            this.lblBaixaEuro.Location = new System.Drawing.Point(389, 48);
            this.lblBaixaEuro.Name = "lblBaixaEuro";
            this.lblBaixaEuro.Size = new System.Drawing.Size(59, 23);
            this.lblBaixaEuro.TabIndex = 1;
            this.lblBaixaEuro.Text = "Baixa:";
            // 
            // lblAltaEuro
            // 
            this.lblAltaEuro.AutoSize = true;
            this.lblAltaEuro.Font = new System.Drawing.Font("SF Pro Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltaEuro.ForeColor = System.Drawing.Color.DimGray;
            this.lblAltaEuro.Location = new System.Drawing.Point(113, 48);
            this.lblAltaEuro.Name = "lblAltaEuro";
            this.lblAltaEuro.Size = new System.Drawing.Size(47, 23);
            this.lblAltaEuro.TabIndex = 0;
            this.lblAltaEuro.Text = "Alta:";
            // 
            // UserControlCotacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gpEuro);
            this.Controls.Add(this.gpDolar);
            this.Name = "UserControlCotacao";
            this.Size = new System.Drawing.Size(572, 467);
            this.gpDolar.ResumeLayout(false);
            this.gpDolar.PerformLayout();
            this.gpEuro.ResumeLayout(false);
            this.gpEuro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDolar;
        private System.Windows.Forms.Panel linhaData;
        private System.Windows.Forms.TextBox txtDataDolar;
        private System.Windows.Forms.Label lblDataDolar;
        private System.Windows.Forms.Label lblBaixaDolarValor;
        private System.Windows.Forms.Label lblAltaDolarValor;
        private System.Windows.Forms.Panel linhaDivisao;
        private System.Windows.Forms.Label lblBaixaDolar;
        private System.Windows.Forms.Label lblAltaDolar;
        private System.Windows.Forms.GroupBox gpEuro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDataEuro;
        private System.Windows.Forms.Label lblDataEuro;
        private System.Windows.Forms.Label lblBaixaValorEuro;
        private System.Windows.Forms.Label lblAltaValorEuro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBaixaEuro;
        private System.Windows.Forms.Label lblAltaEuro;
    }
}
