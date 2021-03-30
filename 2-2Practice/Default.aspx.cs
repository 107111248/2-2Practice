using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_2Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            int year = 1996;
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Response.Write(year + "年是閏年");
            }
            else
            {
                Response.Write(year + "年不是閏年");
            }
        }
    }
}