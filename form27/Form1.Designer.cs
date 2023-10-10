namespace form27
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTek = new System.Windows.Forms.Label();
            this.lblCift = new System.Windows.Forms.Label();
            this.lbTek = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lbCift = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(169, 24);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(130, 30);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTek
            // 
            this.lblTek.AutoSize = true;
            this.lblTek.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTek.Location = new System.Drawing.Point(87, 80);
            this.lblTek.Name = "lblTek";
            this.lblTek.Size = new System.Drawing.Size(55, 16);
            this.lblTek.TabIndex = 1;
            this.lblTek.Text = "label1";
            // 
            // lblCift
            // 
            this.lblCift.AutoSize = true;
            this.lblCift.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCift.Location = new System.Drawing.Point(166, 80);
            this.lblCift.Name = "lblCift";
            this.lblCift.Size = new System.Drawing.Size(58, 16);
            this.lblCift.TabIndex = 2;
            this.lblCift.Text = "label2";
            // 
            // lbTek
            // 
            this.lbTek.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTek.FormattingEnabled = true;
            this.lbTek.ItemHeight = 16;
            this.lbTek.Location = new System.Drawing.Point(22, 138);
            this.lbTek.Name = "lbTek";
            this.lbTek.Size = new System.Drawing.Size(120, 212);
            this.lbTek.TabIndex = 3;
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSayi.Location = new System.Drawing.Point(22, 24);
            this.txtSayi.Multiline = true;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(120, 30);
            this.txtSayi.TabIndex = 4;
            // 
            // lbCift
            // 
            this.lbCift.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCift.FormattingEnabled = true;
            this.lbCift.ItemHeight = 16;
            this.lbCift.Location = new System.Drawing.Point(169, 138);
            this.lbCift.Name = "lbCift";
            this.lbCift.Size = new System.Drawing.Size(130, 212);
            this.lbCift.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(323, 435);
            this.Controls.Add(this.lbCift);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lbTek);
            this.Controls.Add(this.lblCift);
            this.Controls.Add(this.lblTek);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTek;
        private System.Windows.Forms.Label lblCift;
        private System.Windows.Forms.ListBox lbTek;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.ListBox lbCift;
    }
}

