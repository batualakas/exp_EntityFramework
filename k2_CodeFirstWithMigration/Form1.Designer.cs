
namespace k2_CodeFirstWithMigration
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
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnFakulteEkle = new System.Windows.Forms.Button();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.btnOgretmenEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(13, 110);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(132, 27);
            this.btnOgrenciEkle.TabIndex = 0;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnFakulteEkle
            // 
            this.btnFakulteEkle.Location = new System.Drawing.Point(12, 12);
            this.btnFakulteEkle.Name = "btnFakulteEkle";
            this.btnFakulteEkle.Size = new System.Drawing.Size(132, 27);
            this.btnFakulteEkle.TabIndex = 1;
            this.btnFakulteEkle.Text = "Fakülte Ekle";
            this.btnFakulteEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFakulteEkle.UseVisualStyleBackColor = true;
            this.btnFakulteEkle.Click += new System.EventHandler(this.btnFakulteEkle_Click);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(12, 45);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(132, 26);
            this.btnBolumEkle.TabIndex = 2;
            this.btnBolumEkle.Text = "Bölüm Ekle";
            this.btnBolumEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // btnOgretmenEkle
            // 
            this.btnOgretmenEkle.Location = new System.Drawing.Point(13, 77);
            this.btnOgretmenEkle.Name = "btnOgretmenEkle";
            this.btnOgretmenEkle.Size = new System.Drawing.Size(131, 27);
            this.btnOgretmenEkle.TabIndex = 3;
            this.btnOgretmenEkle.Text = "Öğretmen Ekle";
            this.btnOgretmenEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOgretmenEkle.UseVisualStyleBackColor = true;
            this.btnOgretmenEkle.Click += new System.EventHandler(this.btnOgretmenEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOgretmenEkle);
            this.Controls.Add(this.btnBolumEkle);
            this.Controls.Add(this.btnFakulteEkle);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnFakulteEkle;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.Button btnOgretmenEkle;
        private System.Windows.Forms.Button button1;
    }
}

