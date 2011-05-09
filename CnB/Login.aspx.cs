using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

using CnBBAL;

namespace CnB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetFocus(Login.Controls[0].FindControl("UserName"));
        }

        protected void Login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                string _Cim = Login.UserName.ToString();
                string _Password = Login.Password.ToString();

                if (CnBBAL.Factory.UserAuthenticationFactory.Instantiate().VerifyUser(_Cim, _Password))
                {
                    e.Authenticated = true;

                    CnBBAL.AuthenticationService.EmployeeDetails empDetails = CnBBAL.Factory.UserAuthenticationFactory.Instantiate().GetEmployeeDetails(int.Parse(_Cim));
                    Session.Add("CurrentUser", empDetails);

                    //Session.Add("CimNumber", empDetails.CimNumber);
                    //Session.Add("Email", empDetails.Email);
                    //Session.Add("EmployeeID", empDetails.EmployeeID);
                    //Session.Add("FirstName", empDetails.FirstName);
                    //Session.Add("LastName", empDetails.LastName);
                    //Session.Add("Role", empDetails.Role);
                    //Session.Add("RoleGroup", empDetails.RoleGroup);
                    //Session.Add("RoleGroupID", empDetails.RoleGroupID);
                    //Session.Add("RoleID", empDetails.RoleID);
                    //Session.Add("Site", empDetails.Site);

                    Response.Redirect("Default.aspx");
                }
                else
                    e.Authenticated = false;
            }
            catch (Exception ex)
            {
                Login.FailureText = ex.Message;
            }
        }
    }
}
