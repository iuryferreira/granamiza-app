namespace Granamiza.Forms.UControl
{
    partial class UcVisaoGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcVisaoGeral));
            this.gpVisaoGeral = new System.Windows.Forms.GroupBox();
            this.btnAdicionarDespesa = new System.Windows.Forms.Button();
            this.btnAdicionarReceita = new System.Windows.Forms.Button();
            this.lblValorDespesaTotal = new System.Windows.Forms.Label();
            this.lblValorReceitaTotal = new System.Windows.Forms.Label();
            this.linhaDivisao = new System.Windows.Forms.Panel();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.lblReceita = new System.Windows.Forms.Label();
            this.gpVisaoGeral.SuspendLayout();
            this.SuspendLayout();
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
            this.gpVisaoGeral.Location = new System.Drawing.Point(3, 3);
            this.gpVisaoGeral.Name = "gpVisaoGeral";
            this.gpVisaoGeral.Size = new System.Drawing.Size(567, 200);
            this.gpVisaoGeral.TabIndex = 1;
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
            // UcVisaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpVisaoGeral);
            this.Name = "UcVisaoGeral";
            this.Size = new System.Drawing.Size(574, 204);
            this.gpVisaoGeral.ResumeLayout(false);
            this.gpVisaoGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpVisaoGeral;
        private System.Windows.Forms.Button btnAdicionarDespesa;
        private System.Windows.Forms.Button btnAdicionarReceita;
        private System.Windows.Forms.Label lblValorDespesaTotal;
        private System.Windows.Forms.Label lblValorReceitaTotal;
        private System.Windows.Forms.Panel linhaDivisao;
        private System.Windows.Forms.Label lblDespesa;
        private System.Windows.Forms.Label lblReceita;
    }
}
