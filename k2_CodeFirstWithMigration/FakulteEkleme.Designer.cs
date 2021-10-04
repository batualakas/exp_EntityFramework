
namespace k2_CodeFirstWithMigration
{
    partial class FakulteEkleme
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
            this.txtFakulteAdi = new System.Windows.Forms.TextBox();
            this.cmbBolumler = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fakülte Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bölümler";
            // 
            // txtFakulteAdi
            // 
            this.txtFakulteAdi.Location = new System.Drawing.Point(95, 17);
            this.txtFakulteAdi.Name = "txtFakulteAdi";
            this.txtFakulteAdi.Size = new System.Drawing.Size(100, 20);
            this.txtFakulteAdi.TabIndex = 2;
            // 
            // cmbBolumler
            // 
            this.cmbBolumler.FormattingEnabled = true;
            this.cmbBolumler.Location = new System.Drawing.Point(95, 50);
            this.cmbBolumler.Name = "cmbBolumler";
            this.cmbBolumler.Size = new System.Drawing.Size(100, 21);
            this.cmbBolumler.TabIndex = 3;
            this.cmbBolumler.SelectedIndexChanged += new System.EventHandler(this.cmbBolumler_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FakulteEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBolumler);
            this.Controls.Add(this.txtFakulteAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FakulteEkleme";
            this.Text = "FakulteEkleme";
            this.Load += new System.EventHandler(this.FakulteEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFakulteAdi;
        private System.Windows.Forms.ComboBox cmbBolumler;
        private System.Windows.Forms.Button button1;
    }
}