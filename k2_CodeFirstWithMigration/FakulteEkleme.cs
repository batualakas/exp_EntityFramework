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
    public partial class FakulteEkleme : Form
    {
        public FakulteEkleme()
        {
            InitializeComponent();
        }
        OBSDbContext db = new OBSDbContext();
        private void FakulteEkleme_Load(object sender, EventArgs e)
        {
            var bolumler = db.Departments.ToList();
            foreach (var bolum in bolumler)
            {
                cmbBolumler.Items.Add(bolum);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Faculty yeniFakulte = new Faculty()
            {
                FacultyName = txtFakulteAdi.Text,
                
            };
            db.Faculties.Add(yeniFakulte);
            int sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Fakülte Eklendi");
            }
        }

        private void cmbBolumler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
