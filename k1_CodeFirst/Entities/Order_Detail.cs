using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    [Table("Order Details")] // Order Details tablosu boşluklu olduğu için SQL' de Table komutunu ekledik.
    public class Order_Detail
    {
        // tintint -> byte
        // smallint -> short
        // int -> int
        // bigint-> long
        // money-> decimal
        #region Properties
        // composite key oldukları için KEY ve Columnda kaçıncı sırada olduğunu belirtmemiz gerekiyor.
        [Key]
        [Column(Order = 0)]
        public int OrderID { get; set; }
        public Order Order { get; set; }
        [Key]
        [Column(Order =1)]
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        #endregion


    }
}
