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
    public partial class TaskListWindow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dgTasks.DataSource = CnBBAL.Factory.TaskCollectionFactory.Instantiate().GetTasks(System.DateTime.Now.Month);
            dgTasks.DataBind();

            if (!IsPostBack)
            {
                ddlRequestType.DataSource = CnBBAL.Factory.RequestTypeCollectionFactory.Instantiate().GetRequestTypes();
                ddlRequestType.DataTextField = "RequestTypeName";
                ddlRequestType.DataValueField = "RequestTypeID";
                ddlRequestType.DataBind();

                ddlWorkType.DataSource = CnBBAL.Factory.WorkTypeCollectionFactory.Instantiate().GetWorkTypes();
                ddlWorkType.DataTextField = "WorkTypeName";
                ddlWorkType.DataValueField = "WorkTypeID";
                ddlWorkType.DataBind();

                ddlClient.DataSource = CnBBAL.Factory.ClientCollectionFactory.Instantiate().GetClients();
                ddlClient.DataValueField = "ClientID";
                ddlClient.DataTextField = "ClientName";
                ddlClient.DataBind();
            }
        }

        protected void DisplayView(object sender, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            ddlClient.SelectedValue = e.Item.Cells[2].Text;
            txtProgramName.Text = e.Item.Cells[4].Text;
            txtApplicationName.Text = e.Item.Cells[5].Text;
            txtTandimNumber.Text = e.Item.Cells[6].Text;
            ddlRequestType.SelectedValue = e.Item.Cells[7].Text;
            ddlWorkType.SelectedValue = e.Item.Cells[9].Text;
            txtHoursEstimate.Text = e.Item.Cells[11].Text;
            txtHoursActual.Text = e.Item.Cells[12].Text;
            txtDescription.Text = e.Item.Cells[13].Text;
            txtNotes.Text = e.Item.Cells[14].Text;
            lblEmployee.Text = e.Item.Cells[16].Text;

            hdnTaskID.Value = e.Item.Cells[1].Text;

            if (ItemEnteredByCurrentUser(Convert.ToInt32(e.Item.Cells[15].Text)))
                btnSave.Visible = true;
            else
                btnSave.Visible = false;

            ModalPopupExtender1.Show();
        }

        protected void UpdateTask(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            CnBBAL.ITask _Task = CnBBAL.Factory.TaskFactory.Instantiate();
            _Task.TaskID = Convert.ToInt32(hdnTaskID.Value);
            _Task.ClientID = Convert.ToInt32(ddlClient.SelectedValue);
            _Task.ProgramName = txtProgramName.Text.Trim();
            _Task.ApplicationName = txtApplicationName.Text.Trim();
            _Task.TandimNumber = Convert.ToInt32(txtTandimNumber.Text.Trim());
            _Task.RequestTypeID = Convert.ToInt32(ddlRequestType.SelectedValue);
            _Task.WorkTypeID = Convert.ToInt32(ddlWorkType.SelectedValue);
            _Task.HoursEstimate = Convert.ToDouble(txtHoursEstimate.Text.Trim());
            _Task.HoursActual = Convert.ToDouble(txtHoursActual.Text.Trim());
            _Task.Description = txtDescription.Text.Trim();
            _Task.Notes = txtNotes.Text.Trim();

            if (!_Task.Update())
                Response.Write(_Task.Error);
            else
            {
                dgTasks.DataSource = CnBBAL.Factory.TaskCollectionFactory.Instantiate().GetTasks(System.DateTime.Now.Month);
                dgTasks.DataBind();
            }
        }

        private bool ItemEnteredByCurrentUser(int EmployeeID)
        {
            if (Session["CurrentUser"] != null)
            {
                CnBBAL.AuthenticationService.EmployeeDetails emp =
                    (CnBBAL.AuthenticationService.EmployeeDetails)Session["CurrentUser"];
                if (emp.EmployeeID == EmployeeID)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
    }
}
