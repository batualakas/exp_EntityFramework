using k2_CodeFirstWithMigration.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_CodeFirstWithMigration
{
    public partial class Egitmen : Form
    {
        public Egitmen()
        {
            InitializeComponent();
        }
        OBSDbContext db = new OBSDbContext();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Teacher yeniOgretmen = new Teacher()
            {
                Name = txtAd.Text,
                Surname = txtSoyad.Text,

            };
            db.Teachers.Add(yeniOgretmen);
            int sonuc = db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Öğretmen Eklendi");
            }
        }
    }
}
