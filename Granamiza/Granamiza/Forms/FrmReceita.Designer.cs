namespace Granamiza.Forms
{
    partial class FrmReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReceita));
            this.pbIconeCategoria = new System.Windows.Forms.PictureBox();
            this.linhaCategoria = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.linhaValor = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linhaDesc = new System.Windows.Forms.Panel();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDsc = new System.Windows.Forms.Label();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconeCategoria)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIconeCategoria
            // 
            this.pbIconeCategoria.BackColor = System.Drawing.Color.White;
            this.pbIconeCategoria.Location = new System.Drawing.Point(213, 185);
            this.pbIconeCategoria.Name = "pbIconeCategoria";
            this.pbIconeCategoria.Size = new System.Drawing.Size(28, 27);
            this.pbIconeCategoria.TabIndex = 108;
            this.pbIconeCategoria.TabStop = false;
            // 
            // linhaCategoria
            // 
            this.linhaCategoria.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaCategoria.Location = new System.Drawing.Point(213, 212);
            this.linhaCategoria.Name = "linhaCategoria";
            this.linhaCategoria.Size = new System.Drawing.Size(161, 2);
            this.linhaCategoria.TabIndex = 101;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoria.Location = new System.Drawing.Point(210, 152);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 16);
            this.lblCategoria.TabIndex = 97;
            this.lblCategoria.Text = "Categoria";
            // 
            // linhaValor
            // 
            this.linhaValor.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaValor.Location = new System.Drawing.Point(32, 211);
            this.linhaValor.Name = "linhaValor";
            this.linhaValor.Size = new System.Drawing.Size(161, 2);
            this.linhaValor.TabIndex = 95;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.txtValor.Location = new System.Drawing.Point(51, 189);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(273, 18);
            this.txtValor.TabIndex = 94;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblValor.Location = new System.Drawing.Point(30, 155);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 16);
            this.lblValor.TabIndex = 93;
            this.lblValor.Text = "Valor";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTitulo.BackgroundImage")));
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTitulo.Controls.Add(this.lblDesc);
            this.pnlTitulo.Controls.Add(this.pbLogo);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, -1);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(392, 150);
            this.pnlTitulo.TabIndex = 109;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblDesc.Location = new System.Drawing.Point(131, 81);
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
            this.pbLogo.Location = new System.Drawing.Point(82, 33);
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
            this.lblTitulo.Location = new System.Drawing.Point(128, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 35);
            this.lblTitulo.TabIndex = 63;
            this.lblTitulo.Text = "Nova Receita";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.btnSalvar.FlatAppearance.BorderSize = 2;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Ivory;
            this.btnSalvar.Location = new System.Drawing.Point(112, 343);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(170, 45);
            this.btnSalvar.TabIndex = 83;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCategoria.DataSource = this.categoriaBindingSource;
            this.cbCategoria.DisplayMember = "nome";
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(241, 185);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbCategoria.Size = new System.Drawing.Size(133, 26);
            this.cbCategoria.TabIndex = 110;
            this.cbCategoria.ValueMember = "id";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Granamiza.Modelo.categoria);
            // 
            // linhaDesc
            // 
            this.linhaDesc.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaDesc.Location = new System.Drawing.Point(35, 307);
            this.linhaDesc.Name = "linhaDesc";
            this.linhaDesc.Size = new System.Drawing.Size(341, 2);
            this.linhaDesc.TabIndex = 113;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesc.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDesc.Location = new System.Drawing.Point(33, 261);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(341, 45);
            this.txtDesc.TabIndex = 112;
            this.txtDesc.WordWrap = false;
            // 
            // lblDsc
            // 
            this.lblDsc.AutoSize = true;
            this.lblDsc.Font = new System.Drawing.Font("SF Pro Display", 10.25F);
            this.lblDsc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDsc.Location = new System.Drawing.Point(32, 239);
            this.lblDsc.Name = "lblDsc";
            this.lblDsc.Size = new System.Drawing.Size(66, 16);
            this.lblDsc.TabIndex = 111;
            this.lblDsc.Text = "Descrição";
            // 
            // numValor
            // 
            this.numValor.BackColor = System.Drawing.Color.White;
            this.numValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numValor.DecimalPlaces = 2;
            this.numValor.Font = new System.Drawing.Font("SF Pro Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(160)))), ((int)(((byte)(112)))));
            this.numValor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numValor.Location = new System.Drawing.Point(31, 188);
            this.numValor.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(162, 21);
            this.numValor.TabIndex = 75;
            this.numValor.TabStop = false;
            this.numValor.Tag = "";
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numValor.ThousandsSeparator = true;
            // 
            // FrmReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 420);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.linhaDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDsc);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.pbIconeCategoria);
            this.Controls.Add(this.linhaCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.linhaValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.pnlTitulo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRemuneracao";
            this.Load += new System.EventHandler(this.FrmRemuneracao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconeCategoria)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIconeCategoria;
        private System.Windows.Forms.Panel linhaCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Panel linhaValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Panel linhaDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDsc;
        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}