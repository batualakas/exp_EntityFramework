using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
   public class Category
    {
        public int CategoryID { get; set; }
        //[MaxLength(15, ErrorMessage = "Bu alana en fazla 15 karakter girilebilir")] bu maximum kaç değer girilebilir mesajı. 
        [StringLength(15, MinimumLength = 5, ErrorMessage = "En az 5 en fazla 15 Karakter Girilebilir")] // bu da hem max hem min girilebilecek değer mesajı.
        [Required(ErrorMessage = "Bu alanın Doldurulması zorunludur")] // null check'i işaretli olan yani içine boş veri giremeyeceğimiz yerleri belirtmek için Required kullanıyoruz.
        public string CategoryName { get; set; }

        public string Description { get; set; }
        // SQL PICTURE >> C # byte[]
        public List<Product> Products { get; set; }
        
    }
}
