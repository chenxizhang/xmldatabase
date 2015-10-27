using System;
using System.Collections.Generic;
using System.Text;

namespace DataEntities
{
    public class OrderItem 
    {
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }


        public override string ToString()
        {
            return string.Format("Product:{0},Total:{1}", Product.ProductName, UnitPrice * Quantity);
        }
    }
}
