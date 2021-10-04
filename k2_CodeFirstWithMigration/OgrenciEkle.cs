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
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }
        OBSDbContext db = new OBSDbContext();
        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            // db'den bölüm ve eğitmen combo boxları dolduralım
            var egitmenler = db.Teachers.ToList();
            foreach (var egitmen in egitmenler)
            {
                cmbTeacher.Items.Add(egitmen);
            }
            var bolumler = db.Departments.ToList();
            foreach (var bolum in bolumler)
            {
                cmbBolum.Items.Add(bolum);
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Student yeniOgrenci = new Student();
            yeniOgrenci.TCKN = txtTCKN.Text;
            yeniOgrenci.StudentName = txtAd.Text;
            yeniOgrenci.StudentSurname = txtSoyad.Text;
            yeniOgrenci.StudentNo = Convert.ToInt32(txtOgrenciNo.Text);
            yeniOgrenci.DepartmentID = ((Department)cmbBolum.SelectedItem).DepartmentID;
            yeniOgrenci.TeacherID = ((Teacher)cmbTeacher.SelectedItem).TeacherID;
            if (!db.Students.Any(x => x.TCKN == yeniOgrenci.TCKN))
            {


                db.Students.Add(yeniOgrenci);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("oldu");
                }
                else
                {
                    MessageBox.Show("Bu TCKN daha önce eklenmiş");
                }
            }
        }

    }
}
