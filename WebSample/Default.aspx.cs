using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using XmlDatabase.Core;
using DataEntities;

namespace WebSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = XDatabase.Open(Server.MapPath("~/test")))
            {
                var data = new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "ares",
                    LastName = "chen",
                    Title = "CEO"
                };

                db.Store(data);


                gd.DataSource = db.Query<Employee>();
                gd.DataBind();
                
            }
        }
    }
}