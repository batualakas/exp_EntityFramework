﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_CodeFirst.Entities
{
    public class Order
    {
        #region Properties

        
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        #endregion
        #region Releations

        public List<Order_Detail> Order_Details { get; set; }


        #endregion
    }
}
