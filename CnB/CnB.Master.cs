using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace CnB
{
    public partial class CnB : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CurrentUser"] == null)
                {
                    lblWelcome.Text = "Guest!";
                    lbtnLogout.Visible = false;
                }
                else
                {
                    CnBBAL.AuthenticationService.EmployeeDetails emp =
                        (CnBBAL.AuthenticationService.EmployeeDetails)Session["CurrentUser"];

                    lblWelcome.Text = emp.FirstName + " " + emp.LastName + "!";
                    lbtnLogout.Visible = true;
                }
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            if (Session["CurrentUser"] != null)
            {
                Session.Clear();
                Response.Redirect("Login.aspx");
            }
        }
    }
}
