namespace Granamiza.Forms.UControl
{
    partial class UcPreferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPreferencias));
            this.lblNome = new System.Windows.Forms.Label();
            this.linhaNome = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLigarDarkMode = new System.Windows.Forms.Button();
            this.btnDesligarDarkMode = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnAlterarSenha = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(80, 87);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // linhaNome
            // 
            this.linhaNome.BackColor = System.Drawing.Color.Gainsboro;
            this.linhaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linhaNome.Location = new System.Drawing.Point(83, 127);
            this.linhaNome.Name = "linhaNome";
            this.linhaNome.Size = new System.Drawing.Size(300, 2);
            this.linhaNome.TabIndex = 105;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("SF Pro Display", 11.75F, System.Drawing.FontStyle.Bold);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(83, 106);
            this.txtNome.Name = "txtNome";
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNome.Size = new System.Drawing.Size(300, 19);
            this.txtNome.TabIndex = 104;
            this.txtNome.WordWrap = false;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNome_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLigarDarkMode);
            this.panel1.Controls.Add(this.btnDesligarDarkMode);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(83, 231);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(218, 48);
            this.panel1.TabIndex = 114;
            this.panel1.Visible = false;
            // 
            // btnLigarDarkMode
            // 
            this.btnLigarDarkMode.BackColor = System.Drawing.Color.Black;
            this.btnLigarDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLigarDarkMode.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnLigarDarkMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLigarDarkMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLigarDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigarDarkMode.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigarDarkMode.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnLigarDarkMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLigarDarkMode.Location = new System.Drawing.Point(3, 4);
            this.btnLigarDarkMode.Name = "btnLigarDarkMode";
            this.btnLigarDarkMode.Size = new System.Drawing.Size(105, 39);
            this.btnLigarDarkMode.TabIndex = 124;
            this.btnLigarDarkMode.Text = "Ligar";
            this.btnLigarDarkMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLigarDarkMode.UseVisualStyleBackColor = false;
            this.btnLigarDarkMode.Click += new System.EventHandler(this.BtnLigarDarkMode_Click);
            // 
            // btnDesligarDarkMode
            // 
            this.btnDesligarDarkMode.BackColor = System.Drawing.Color.White;
            this.btnDesligarDarkMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesligarDarkMode.Enabled = false;
            this.btnDesligarDarkMode.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnDesligarDarkMode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDesligarDarkMode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDesligarDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesligarDarkMode.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligarDarkMode.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDesligarDarkMode.Location = new System.Drawing.Point(107, 4);
            this.btnDesligarDarkMode.Name = "btnDesligarDarkMode";
            this.btnDesligarDarkMode.Size = new System.Drawing.Size(105, 39);
            this.btnDesligarDarkMode.TabIndex = 123;
            this.btnDesligarDarkMode.Text = "Desligar";
            this.btnDesligarDarkMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesligarDarkMode.UseVisualStyleBackColor = false;
            this.btnDesligarDarkMode.Click += new System.EventHandler(this.BtnDesligarDarkMode_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(80, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 121;
            this.label3.Text = "Dark Mode";
            this.label3.Visible = false;
            // 
            // picInfo
            // 
            this.picInfo.BackColor = System.Drawing.Color.Transparent;
            this.picInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picInfo.BackgroundImage")));
            this.picInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picInfo.Location = new System.Drawing.Point(7, 10);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(28, 26);
            this.picInfo.TabIndex = 123;
            this.picInfo.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("SF Pro Display", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(41, 10);
            this.lblInfo.MaximumSize = new System.Drawing.Size(396, 26);
            this.lblInfo.MinimumSize = new System.Drawing.Size(100, 26);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(395, 26);
            this.lblInfo.TabIndex = 122;
            this.lblInfo.Text = "Clique em Ok para salvar suas novas preferências, ou em Cancelar para manter suas" +
    " preferências atuais. Obs.: O evento de cancelar não se aplica a alteração de se" +
    "nha.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAlterarSenha
            // 
            this.btnAlterarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterarSenha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlterarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlterarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAlterarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarSenha.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlterarSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterarSenha.Location = new System.Drawing.Point(83, 156);
            this.btnAlterarSenha.Name = "btnAlterarSenha";
            this.btnAlterarSenha.Size = new System.Drawing.Size(105, 39);
            this.btnAlterarSenha.TabIndex = 124;
            this.btnAlterarSenha.Text = "Alterar Senha";
            this.btnAlterarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarSenha.UseVisualStyleBackColor = false;
            this.btnAlterarSenha.Click += new System.EventHandler(this.btnAlterarSenha_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(433, 405);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 38);
            this.btnCancelar.TabIndex = 126;
            this.btnCancelar.Text = "      Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("SF Pro Display", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(433, 364);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(105, 39);
            this.btnOk.TabIndex = 125;
            this.btnOk.Text = "    OK";
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // UcPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAlterarSenha);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linhaNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "UcPreferencias";
            this.Size = new System.Drawing.Size(572, 467);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel linhaNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnDesligarDarkMode;
        private System.Windows.Forms.Button btnLigarDarkMode;
        private System.Windows.Forms.Button btnAlterarSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
    }
}
