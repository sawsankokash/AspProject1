using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspProject
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncheck_Click(object sender, EventArgs e)
        {
            Checkenter.Checked = true;
        }

        protected void btngo_Click(object sender, EventArgs e)
        {
            Response.Redirect("page1.aspx");
        }
    }
}