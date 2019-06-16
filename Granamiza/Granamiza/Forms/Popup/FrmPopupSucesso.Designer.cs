namespace Granamiza.Forms.Popup
{
    partial class FrmPopupSucesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopupSucesso));
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.pnlComponentes = new System.Windows.Forms.Panel();
            this.pbIcone = new System.Windows.Forms.PictureBox();
            this.lblTextoSucesso = new System.Windows.Forms.Label();
            this.pnlBarra.SuspendLayout();
            this.pnlComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(303, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 30);
            this.btnClose.TabIndex = 78;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlBarra.Controls.Add(this.label1);
            this.pnlBarra.Controls.Add(this.btnClose);
            this.pnlBarra.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.pnlBarra.Location = new System.Drawing.Point(-1, 1);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(352, 30);
            this.pnlBarra.TabIndex = 80;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlBarra_MouseDown);
            this.pnlBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBarra_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 14);
            this.label1.TabIndex = 81;
            this.label1.Text = "Granamiza";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(135, 128);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(85, 32);
            this.btnConfirmar.TabIndex = 79;
            this.btnConfirmar.Text = "OK";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // pnlComponentes
            // 
            this.pnlComponentes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlComponentes.Controls.Add(this.pbIcone);
            this.pnlComponentes.Controls.Add(this.lblTextoSucesso);
            this.pnlComponentes.Controls.Add(this.btnConfirmar);
            this.pnlComponentes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlComponentes.Location = new System.Drawing.Point(0, 30);
            this.pnlComponentes.Name = "pnlComponentes";
            this.pnlComponentes.Size = new System.Drawing.Size(352, 181);
            this.pnlComponentes.TabIndex = 81;
            // 
            // pbIcone
            // 
            this.pbIcone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbIcone.BackgroundImage")));
            this.pbIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIcone.Location = new System.Drawing.Point(132, 10);
            this.pbIcone.Name = "pbIcone";
            this.pbIcone.Size = new System.Drawing.Size(92, 63);
            this.pbIcone.TabIndex = 80;
            this.pbIcone.TabStop = false;
            // 
            // lblTextoSucesso
            // 
            this.lblTextoSucesso.AutoSize = true;
            this.lblTextoSucesso.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSucesso.ForeColor = System.Drawing.Color.DimGray;
            this.lblTextoSucesso.Location = new System.Drawing.Point(15, 90);
            this.lblTextoSucesso.MaximumSize = new System.Drawing.Size(340, 19);
            this.lblTextoSucesso.MinimumSize = new System.Drawing.Size(320, 19);
            this.lblTextoSucesso.Name = "lblTextoSucesso";
            this.lblTextoSucesso.Size = new System.Drawing.Size(320, 19);
            this.lblTextoSucesso.TabIndex = 79;
            this.lblTextoSucesso.Text = "Cadastro efetuado com sucesso!";
            this.lblTextoSucesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPopupSucesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(352, 211);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlComponentes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPopupSucesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpSucesso";
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            this.pnlComponentes.ResumeLayout(false);
            this.pnlComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel pnlComponentes;
        private System.Windows.Forms.Label lblTextoSucesso;
        private System.Windows.Forms.PictureBox pbIcone;
        private System.Windows.Forms.Label label1;
    }
}