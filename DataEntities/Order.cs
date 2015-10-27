using System;
using System.Collections.Generic;
using System.Text;

namespace DataEntities
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public override string ToString()
        {
            return string.Format("OrderId:{0},OrderDate:{1},CustomerID:{2},EmployeeID:{3}", OrderID,OrderDate,Customer.CustomerID,Employee.EmployeeId);
        }

    }

}
