using System;
using System.Collections.Generic;
using System.Text;

namespace DataEntities
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ContactName { get; set; }

        /// <summary>
        /// 所有的业务实体类，虽然不要求重写ToString方法，但仍然建议这样做。因为在数据库引擎内部可能需要用到这个信息作为日志记录的一部分。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("CustomerID:{0},CompanyName:{1}", CustomerID, CompanyName);
        }
    }
}
