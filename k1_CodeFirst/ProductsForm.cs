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


    public partial class ProductsForm : Form
    {
        
        NorthwindDbContext db = new NorthwindDbContext();
        public ProductsForm()
        {
            InitializeComponent();
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            List<Product> urunler = db.Products.ToList();
        }

        private void btnUrunEkleme_Click(object sender, EventArgs e)
        {
            Product yeniEklenenUrun = new Product()
            {
                ProductName = "Baklava",
                UnitPrice = 49.90m,
                UnitsInStock = 50,
                Discontinued = false
            };
            db.Products.Add(yeniEklenenUrun);
            var sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                MessageBox.Show("Ürün Eklendi");
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Product guncellenenUrun = db.Products.FirstOrDefault(x => x.ProductName == "Baklava");
            if (guncellenenUrun != null)
            {
                guncellenenUrun.ProductName = "Kaymaklava";
                guncellenenUrun.UnitsInStock = 49;
                guncellenenUrun.UnitPrice = 39.90m;
                var sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    MessageBox.Show("Ürün Güncellendi");
                }
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            Product silinenUrun = db.Products.FirstOrDefault(x => x.ProductName == "Kaymaklava");
            if (silinenUrun != null)
            {
                db.Products.Remove(silinenUrun);
                var sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Ürün Silindi");
                }
            }
            
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
