using k1_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_CodeFirst
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtInclude_Click(object sender, EventArgs e)
        {
            // HATA!
            // kategorileri tekrar listele
            NorthwindDbContext db = new NorthwindDbContext();
            var kategoriler = db.Categories.Include(x => x.Products).ToList();

            // urunler - kategoriler 1-n şeklinde.
            var urunler = db.Products.Include(y => y.Supplier).ToList();

            // 
            //var tedarikciler = db.Suppliers.Include(z => z.).ToList();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();
            var urunler = db.Products
                .Include(x => x.Category)
                .Include(x => x.Supplier).ToList();
            var tedarikciler = db.Suppliers.Include(x => x.Products).ToList();
        }
        // ORM : Object Releational Management

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            NorthwindDbContext db = new NorthwindDbContext();

            var siparisler = db.Orders.Include(x => x.Order_Details).ToList();

            var urunler = db.Products.Include(x => x.Order_Details).ToList();

            var siparisDetayleri = db.Order_Details
                .Include(x => x.Order)
                .Include(x => x.Product)
                .ToList(); 

        }
    }
}
