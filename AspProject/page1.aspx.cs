using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspProject
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextInput2.Text = TextInput1.Text;
        }

        protected void btngo_Click(object sender, EventArgs e)
        {
            Response.Redirect("page2.aspx");
        }
    }
}