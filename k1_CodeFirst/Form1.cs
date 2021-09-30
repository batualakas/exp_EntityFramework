using k1_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_CodeFirst
{
    public partial class Form1 : Form
    {/*
      * EntityFramework : Kodlar ile veri tabanı arasındaki kütüphane.
      EntityFramework Code First
        SQL  > C#;
      Table  > Class;
      Colums > Property;
        SQL' DEN VERİ ÇEKME

        Nuget Package Manager>EntityFramework  6 yükle

        Dbcontext'Den miras alan veritabanı contextini oluştur. (class aç miras aldır ': DbContext'den)
        connection string belirle
      
      */
        NorthwindDbContext db = new NorthwindDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //
            
            List<Category> kategoriler = db.Categories.ToList();
            // Product tablosunu bağlayınız. adını fiyatını stok
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Category yeniKategori = new Category()
            //{
            //    CategoryName = "Meşrubat",
            //    Description = "İçiçek Ürünlerinin bulunacağı bir kategori",

            //};
            //db.Categories.Add(yeniKategori);
            //var sonuc = db.SaveChanges();
            //if (sonuc>0)
            //{
            //    MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi");
            //}
            Category yeniKategori = new Category();
            yeniKategori.CategoryName = txtAd.Text;
            yeniKategori.Description = txtAciklama.Text;
            db.Categories.Add(yeniKategori);
            var sonuc = db.SaveChanges();
            if (sonuc > 0 )
            {
                MessageBox.Show("Kategori Başarılı Bir Şekilde Eklendi");
            }
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            // kullanıcıdan alınan değerin uzunluğunun 15' den uzun olmasını engellemeniz gerekir.
            //Category guncellenenKategori = db.Categories.FirstOrDefault(x => x.CategoryID == 5);
            //if (guncellenenKategori !=null)
            //{
            //    guncellenenKategori.CategoryName = "Grains/Meat";
            //    guncellenenKategori.Description = "yeni güncelledik";

            /*  int sonuc = db.SaveChanges();*/ // veri tabanından kaç satır etkilendi ise o kadar değer döner.
                                                //if (sonuc > 0)
                                                //{
                                                //    MessageBox.Show("Kategori Güncellendi");
                                                //}

            //guncellenenKategori.CategoryID = Convert.ToInt32(txtId.Text);
            //guncellenenKategori.CategoryName = txtGuncellenenAd.Text;
            //guncellenenKategori.Description = txtGuncellenAciklama.Text;


            var id = Convert.ToInt32(txtId.Text);
            Category degisenKategori = db.Categories.FirstOrDefault(x => x.CategoryID == id );

            degisenKategori.CategoryName = txtGuncellenenAd.Text;
            degisenKategori.Description = txtGuncellenAciklama.Text;
            int sonuc = db.SaveChanges();
            if (degisenKategori == null)
            {
                MessageBox.Show("Bu kategoride değer yoktur.");
            }
            if (sonuc > 0)

            {
                MessageBox.Show("Kategori Başarılı Şekilde Güncellendi");
            }
        }
        

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            // 16 id'li yeri sil.
            var id = Convert.ToInt32(txtSilinecekId.Text);
            var silinecekKategori = db.Categories.FirstOrDefault(x => x.CategoryID == id);
            if (silinecekKategori!=null)
            {
                db.Categories.Remove(silinecekKategori);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Silme işlemi başarılı");
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
