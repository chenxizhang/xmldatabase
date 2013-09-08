using System;
using System.Collections.Generic;
using System.Text;

namespace DataEntities
{
    public class Product 
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return string.Format("ProductId:{0},Name:{1}", ProductId, ProductName);
        }

    }
}
