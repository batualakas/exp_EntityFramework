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
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Department yeniBolum = new Department()
            {
                DepartmentName = txtBolum.Text,
                FacultyID = ((Faculty)cmbFakulte.SelectedItem).FacultyID,

            };
            db.Departments.Add(yeniBolum);
            int sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Bolum Eklendi");
            }
            
        }
        OBSDbContext db = new OBSDbContext();
        private void BolumEkle_Load(object sender, EventArgs e)
        {
            var faculties = db.Faculties.ToList();
            foreach (var faculty in faculties)
            {
                cmbFakulte.Items.Add(faculty);


            }
        }
    }
}
