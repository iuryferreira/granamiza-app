namespace Granamiza.Forms
{
    partial class FrmDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDespesa));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.linhaDesc = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDsc = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.pbIconeCategoria = new System.Windows.Forms.PictureBox();
            this.linhaCategoria = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.linhaNome = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconeCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitulo.BackgroundImage")));
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitulo.Controls.Add(this.lblDesc);
            this.pnlTitulo.Controls.Add(this.pbLogo);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(-1, -1);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(394, 150);
            this.pnlTitulo.TabIndex = 122;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDesc.Location = new System.Drawing.Point(132, 82);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(144, 13);
            this.lblDesc.TabIndex = 74;
            this.lblDesc.Text = "Preencha todos os campos.";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(78, 29);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(40, 32);
            this.pbLogo.TabIndex = 73;
            this.pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(115, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(210, 35);
            this.lblTitulo.TabIndex = 63;
            this.lblTitulo.Text = "Nova Despesa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Ivory;
            this.btnSalvar.Location = new System.Drawing.Point(105, 345);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 45);
            this.btnSalvar.TabIndex = 115;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // numValor
            // 
            this.numValor.BackColor = System.Drawing.Color.White;
            this.numValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(93)))), ((int)(((byte)(101)))));
            this.numValor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numValor.Location = new System.Drawing.Point(31, 181);
            this.numValor.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(162, 21);
            this.numValor.TabIndex = 114;
            this.numValor.TabStop = false;
            this.numValor.Tag = "";
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numValor.ThousandsSeparator = true;
            // 
            // linhaDesc
            // 
            this.linhaDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaDesc.Location = new System.Drawing.Point(35, 300);
            this.linhaDesc.Name = "linhaDesc";
            this.linhaDesc.Size = new System.Drawing.Size(341, 2);
            this.linhaDesc.TabIndex = 124;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesc.Location = new System.Drawing.Point(33, 254);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(341, 45);
            this.txtDesc.TabIndex = 123;
            this.txtDesc.WordWrap = false;
            // 
            // lblDsc
            // 
            this.lblDsc.AutoSize = true;
            this.lblDsc.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblDsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDsc.Location = new System.Drawing.Point(32, 232);
            this.lblDsc.Name = "lblDsc";
            this.lblDsc.Size = new System.Drawing.Size(66, 16);
            this.lblDsc.TabIndex = 122;
            this.lblDsc.Text = "Descrição";
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.DisplayMember = "nome";
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(241, 178);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategoria.Size = new System.Drawing.Size(133, 26);
            this.cbCategoria.TabIndex = 121;
            this.cbCategoria.ValueMember = "id";
            // 
            // pbIconeCategoria
            // 
            this.pbIconeCategoria.BackColor = System.Drawing.Color.White;
            this.pbIconeCategoria.Location = new System.Drawing.Point(213, 178);
            this.pbIconeCategoria.Name = "pbIconeCategoria";
            this.pbIconeCategoria.Size = new System.Drawing.Size(28, 27);
            this.pbIconeCategoria.TabIndex = 120;
            this.pbIconeCategoria.TabStop = false;
            // 
            // linhaCategoria
            // 
            this.linhaCategoria.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCategoria.Location = new System.Drawing.Point(213, 205);
            this.linhaCategoria.Name = "linhaCategoria";
            this.linhaCategoria.Size = new System.Drawing.Size(161, 2);
            this.linhaCategoria.TabIndex = 119;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoria.Location = new System.Drawing.Point(210, 148);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 16);
            this.lblCategoria.TabIndex = 118;
            this.lblCategoria.Text = "Categoria";
            // 
            // linhaNome
            // 
            this.linhaNome.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaNome.Location = new System.Drawing.Point(32, 204);
            this.linhaNome.Name = "linhaNome";
            this.linhaNome.Size = new System.Drawing.Size(161, 2);
            this.linhaNome.TabIndex = 117;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.txtValor.Location = new System.Drawing.Point(51, 182);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(273, 18);
            this.txtValor.TabIndex = 116;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValor.Location = new System.Drawing.Point(30, 148);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 16);
            this.lblValor.TabIndex = 115;
            this.lblValor.Text = "Valor";
            // 
            // FrmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 420);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.linhaDesc);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDsc);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.pbIconeCategoria);
            this.Controls.Add(this.linhaNome);
            this.Controls.Add(this.linhaCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Despesa";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconeCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Panel linhaDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDsc;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.PictureBox pbIconeCategoria;
        private System.Windows.Forms.Panel linhaCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel linhaNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
    }
}