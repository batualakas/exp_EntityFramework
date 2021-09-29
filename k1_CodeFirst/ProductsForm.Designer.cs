
namespace k1_CodeFirst
{
    partial class ProductsForm
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
            this.btnListele = new System.Windows.Forms.Button();
            this.btnUrunEkleme = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(50, 23);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(153, 23);
            this.btnListele.TabIndex = 0;
            this.btnListele.Text = "Listeleme";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnUrunEkleme
            // 
            this.btnUrunEkleme.Location = new System.Drawing.Point(50, 52);
            this.btnUrunEkleme.Name = "btnUrunEkleme";
            this.btnUrunEkleme.Size = new System.Drawing.Size(153, 23);
            this.btnUrunEkleme.TabIndex = 0;
            this.btnUrunEkleme.Text = "Ürün Ekleme";
            this.btnUrunEkleme.UseVisualStyleBackColor = true;
            this.btnUrunEkleme.Click += new System.EventHandler(this.btnUrunEkleme_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(50, 81);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(153, 23);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelleme";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(50, 110);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(153, 23);
            this.btnUrunSil.TabIndex = 0;
            this.btnUrunSil.Text = "Ürün Silme";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 304);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnUrunEkleme);
            this.Controls.Add(this.btnListele);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnUrunEkleme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
    }
}