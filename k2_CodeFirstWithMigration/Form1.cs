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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             -Öğrenci
            -Eğitmen
            -Bölüm
            -Ders
            -Fakülte

            -Öğrenci ile Eğitmen 1-n
            -Öğrenci ile Ders n-n
            -Fakülte ile Bölüm 1-n
            -Bölüm ile Öğrenci 1-n
            -Bölüm ile  ders 1-n
            -Eğitmen ile ders 1-n


             
             
             
             */
        }
        OBSDbContext db = new OBSDbContext();

        private void btnFakulteEkle_Click(object sender, EventArgs e)
        {
            Faculty yeniFakulte = new Faculty()
            {
                FacultyName = "Fen Fakültesi"
            };
            db.Faculties.Add(yeniFakulte);

            int sonuc = db.SaveChanges();

            if (sonuc > 0)
            {
                MessageBox.Show("Yeni Fakülte Eklendi");
            }

        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            Department yeniBolum = new Department()
            {
                DepartmentName = "İstatistik",
                FacultyID = 1,

            };
            db.Departments.Add(yeniBolum);
            int sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Yeni Bölüm Eklendi");
            }
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            Teacher yeniOgretmen = new Teacher()
            {

                Name = "Batu",
                Surname = "Alakaş",
            };
            db.Teachers.Add(yeniOgretmen);
            int sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Yeni Öğretmen Eklendi");
            }

        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Student yeniOgrenci = new Student()
            {
                StudentName = "Orkun",
                StudentSurname = "İnce",
                TeacherID = 1,
                DepartmentID =1,
                TCKN = "85659821100",
                

                 
            };
            db.Students.Add(yeniOgrenci);
            int sonuc = db.SaveChanges();
            if (sonuc>0)
            {
                MessageBox.Show("Yeni Öğrenci Eklendi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var silinecekKategori = db.Students.FirstOrDefault(x => x.StudentID == 1);
            if (silinecekKategori != null)
            {
                db.Students.Remove(silinecekKategori);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Silme işlemi başarılı");
                }
            }
        }
    }
}
