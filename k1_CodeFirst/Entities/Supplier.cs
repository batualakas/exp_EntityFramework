using k1_CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        [StringLength(40, ErrorMessage = "40 karakterden fazla girmeyiniz")]
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        #region Relations

       
      

        #endregion
        public List<Product> Products { get; set; }
    }
}
