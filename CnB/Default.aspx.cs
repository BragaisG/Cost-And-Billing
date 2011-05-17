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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentUser"] == null)
                Response.Redirect("Login.aspx");

            if (!IsPostBack)
            {
                ddlClient.DataSource = CnBBAL.Factory.ClientCollectionFactory.Instantiate().GetClients();
                ddlClient.DataValueField = "ClientID";
                ddlClient.DataTextField = "ClientName";
                ddlClient.DataBind();

                ddlRequestType.DataSource = CnBBAL.Factory.RequestTypeCollectionFactory.Instantiate().GetRequestTypes();
                ddlRequestType.DataValueField = "RequestTypeID";
                ddlRequestType.DataTextField = "RequestTypeName";
                ddlRequestType.DataBind();

                ddlWorkType.DataSource = CnBBAL.Factory.WorkTypeCollectionFactory.Instantiate().GetWorkTypes();
                ddlWorkType.DataValueField = "WorkTypeID";
                ddlWorkType.DataTextField = "WorkTypeName";
                ddlWorkType.DataBind();
            }
            SetFocus(ddlClient);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Session["CurrentUser"] != null)
            {
                if (Page.IsValid)
                {
                    CnBBAL.AuthenticationService.EmployeeDetails emp =
                        (CnBBAL.AuthenticationService.EmployeeDetails)Session["CurrentUser"];

                    CnBBAL.ITask _Task = CnBBAL.Factory.TaskFactory.Instantiate();
                    _Task.ClientID = Convert.ToInt32(ddlClient.SelectedValue);
                    _Task.ProgramName = txtProgram.Text.Trim();
                    _Task.ApplicationName = txtApplication.Text.Trim();

                    int result;
                    if (Int32.TryParse(txtTandimNumber.Text.Trim(), out result))
                        _Task.TandimNumber = result;
                    else
                        _Task.TandimNumber = 0;

                    _Task.RequestTypeID = Convert.ToInt32(ddlRequestType.SelectedValue);
                    _Task.WorkTypeID = Convert.ToInt32(ddlWorkType.SelectedValue);
                    _Task.HoursEstimate = Convert.ToDouble(txtHoursEstimate.Text.Trim());
                    _Task.HoursActual = Convert.ToDouble(txtHoursActual.Text.Trim());
                    _Task.Description = txtDescription.Text.Trim();
                    _Task.Notes = txtNotes.Text.Trim();
                    _Task.EmployeeID = emp.EmployeeID;

                    if (_Task.Save())
                    {
                        lblMessage.Text = "Transaction Saved!";
                        ddlClient.SelectedValue = "0";
                        txtProgram.Text = "";
                        txtApplication.Text = "";
                        txtTandimNumber.Text = "0";
                        ddlRequestType.SelectedValue = "0";
                        ddlWorkType.SelectedValue = "0";
                        txtHoursEstimate.Text = "";
                        txtHoursActual.Text = "";
                        txtDescription.Text = "";
                        txtNotes.Text = "";
                    }
                    else
                        Response.Write(_Task.Error);
                }
                else
                    lblMessage.Text = "Please enter required information and make sure they are valid!";
            }
            else
                Response.Redirect("Login.aspx");
        }

        #region Custom Validation Codes
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (ddlClient.SelectedIndex > 0)
                args.IsValid = true;
            else
                args.IsValid = false;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (ddlRequestType.SelectedIndex > 0)
                args.IsValid = true;
            else
                args.IsValid = false;
        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (ddlWorkType.SelectedIndex > 0)
                args.IsValid = true;
            else
                args.IsValid = false;
        }
        #endregion
    }
}
