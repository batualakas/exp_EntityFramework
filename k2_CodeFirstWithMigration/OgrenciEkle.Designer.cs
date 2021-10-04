
namespace k2_CodeFirstWithMigration
{
    partial class OgrenciEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciNo = new System.Windows.Forms.TextBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTCKN = new System.Windows.Forms.MaskedTextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danışman Hoca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Öğrenci No";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(113, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(113, 34);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtOgrenciNo
            // 
            this.txtOgrenciNo.Location = new System.Drawing.Point(113, 63);
            this.txtOgrenciNo.Name = "txtOgrenciNo";
            this.txtOgrenciNo.Size = new System.Drawing.Size(100, 20);
            this.txtOgrenciNo.TabIndex = 4;
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(113, 151);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(121, 21);
            this.cmbBolum.TabIndex = 5;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(113, 121);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(121, 21);
            this.cmbTeacher.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "TCKN";
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(113, 92);
            this.txtTCKN.Mask = "00000000000";
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(100, 20);
            this.txtTCKN.TabIndex = 6;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(113, 179);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(121, 23);
            this.btnOgrenciEkle.TabIndex = 7;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 349);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.txtTCKN);
            this.Controls.Add(this.cmbTeacher);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.txtOgrenciNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtOgrenciNo;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTCKN;
        private System.Windows.Forms.Button btnOgrenciEkle;
    }
}