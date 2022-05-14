namespace AracSatısOtomasyonuOracle
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
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.btnAracKayit = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.btnSozlesme = new System.Windows.Forms.Button();
            this.btnSatislar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(7, 7);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(131, 119);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Müşteri Ekleme";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.Location = new System.Drawing.Point(161, 7);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(131, 119);
            this.btnMusteriListele.TabIndex = 1;
            this.btnMusteriListele.Text = "Müşteri Listeleme";
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            // 
            // btnAracKayit
            // 
            this.btnAracKayit.Location = new System.Drawing.Point(315, 7);
            this.btnAracKayit.Name = "btnAracKayit";
            this.btnAracKayit.Size = new System.Drawing.Size(131, 119);
            this.btnAracKayit.TabIndex = 2;
            this.btnAracKayit.Text = "Araç Kayıt";
            this.btnAracKayit.UseVisualStyleBackColor = true;
            // 
            // btnAracListele
            // 
            this.btnAracListele.Location = new System.Drawing.Point(469, 7);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(131, 119);
            this.btnAracListele.TabIndex = 3;
            this.btnAracListele.Text = "Araç Listeleme";
            this.btnAracListele.UseVisualStyleBackColor = true;
            // 
            // btnSozlesme
            // 
            this.btnSozlesme.Location = new System.Drawing.Point(623, 7);
            this.btnSozlesme.Name = "btnSozlesme";
            this.btnSozlesme.Size = new System.Drawing.Size(131, 119);
            this.btnSozlesme.TabIndex = 4;
            this.btnSozlesme.Text = "Sözleşme";
            this.btnSozlesme.UseVisualStyleBackColor = true;
            // 
            // btnSatislar
            // 
            this.btnSatislar.Location = new System.Drawing.Point(777, 7);
            this.btnSatislar.Name = "btnSatislar";
            this.btnSatislar.Size = new System.Drawing.Size(131, 119);
            this.btnSatislar.TabIndex = 5;
            this.btnSatislar.Text = "Satışlar";
            this.btnSatislar.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(931, 7);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(131, 119);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnSatislar);
            this.panel1.Controls.Add(this.btnSozlesme);
            this.panel1.Controls.Add(this.btnAracListele);
            this.panel1.Controls.Add(this.btnAracKayit);
            this.panel1.Controls.Add(this.btnMusteriListele);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Location = new System.Drawing.Point(18, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 136);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 548);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.Button btnAracKayit;
        private System.Windows.Forms.Button btnAracListele;
        private System.Windows.Forms.Button btnSozlesme;
        private System.Windows.Forms.Button btnSatislar;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel1;
    }
}

