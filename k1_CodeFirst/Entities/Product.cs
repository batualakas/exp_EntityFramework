using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        #region Releations
        
        // ürünlerin kategorisi olmak zorunda değilse (yani karşıdaki kısım null geçilebiliyorsa) "int?" yazarak içine "null" değer girilebilir olduğunu belirtmemiz gerekiyor. Aşşağıdaki örnekte products listesini ilk başta çekmek istediğimiz zaman aralarda null değerler olduğu için çekmedi. o yüzden int? şeklinde yaptık. 
        public int? CategoryID { get; set; } // fk = foreign key
        public Category Category { get; set; }
        public int? SupplierID { get; set; }

        public Supplier Supplier { get; set; }
        public List<Order_Detail> Order_Details { get; set; }
        #endregion
        
    }
}
