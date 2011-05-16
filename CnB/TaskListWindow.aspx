<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskListWindow.aspx.cs" Inherits="CnB.TaskListWindow" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="CSS/MyStyle.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
        </asp:ToolkitScriptManager>
        <div>
            <asp:DataGrid ID="dgTasks" runat="server" AutoGenerateColumns="false" OnEditCommand="DisplayView"
                 OnItemCommand="DisplayView">
                <HeaderStyle BackColor="dodgerblue" Font-Bold="true" Font-Names="Calibri" HorizontalAlign="Center" />
                <Columns>
                    <asp:ButtonColumn Text="&lt;img src=&quot;/Images/001_38.ico&quot; border=&quot;0&quot; /&gt;" />
                    <asp:BoundColumn DataField="TaskID" HeaderText="TaskID" Visible="false">
                        <ItemStyle HorizontalAlign="Center" Width="0px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ClientID" HeaderText="ClientID" Visible="false">
                        <ItemStyle HorizontalAlign="Center" Width="0px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ClientName" HeaderText="Client Name">
                        <ItemStyle HorizontalAlign="Center" Width="200px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ProgramName" HeaderText="Program Name">
                        <ItemStyle HorizontalAlign="Center" Width="200px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="ApplicationName" HeaderText="Application Name" >
                        <ItemStyle HorizontalAlign="Center" Width="200px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="Description" HeaderText="Description">
                        <ItemStyle HorizontalAlign="Center" Width="200px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="TandimNumber" HeaderText="Tandim/Ticket Number" Visible="false">
                        <ItemStyle HorizontalAlign="Center" Width="0px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="RequestTypeID" HeaderText="RequestTypeID" Visible="false">
                        <ItemStyle HorizontalAlign="Center" Width="0px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="RequestType" HeaderText="Request Type">
                        <ItemStyle HorizontalAlign="Center" Width="200px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="WorkTypeID" HeaderText="WorkTypeID" Visible="false">
                        <ItemStyle HorizontalAlign="Center" Width="0px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="WorkType" HeaderText="Work Type">
                        <ItemStyle HorizontalAlign="Center" Width="200px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="HoursEstimate" HeaderText="Estimated Hours">
                        <ItemStyle HorizontalAlign="Center" Width="130px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="HoursActual" HeaderText="Actual Hours">
                        <ItemStyle HorizontalAlign="Center" Width="130px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="Notes" HeaderText="Notes" Visible="false">
                        <ItemStyle HorizontalAlign="Center" Width="0px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="EmployeeID" HeaderText="EmployeeID" Visible="false">
                        <ItemStyle HorizontalAlign="Center" Width="0px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="Employee" HeaderText="Employee">
                        <ItemStyle HorizontalAlign="Center" Width="200px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                    <asp:BoundColumn DataField="DateTimeEntered" HeaderText="Date/Time Entered">
                        <ItemStyle HorizontalAlign="Center" Width="200px" Font-Names="Calibri" />
                    </asp:BoundColumn>
                </Columns>
            </asp:DataGrid>
        </div>
        <asp:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="pnlPopUpView"
             TargetControlID="btnSubmit" BackgroundCssClass="modalBackground" DropShadow="true" CancelControlID="btnCancel">
        </asp:ModalPopupExtender>
        <input type="hidden" id="btnSubmit" runat="server" />
        <div>
            <asp:Panel ID="pnlPopUpView" runat="server">
                <table cellpadding="5" cellspacing="5">
                    <tr>
                        <td colspan="2"><h3>Edit View:</h3></td>
                        <td style="font-size:small; vertical-align:bottom; text-align:right">Entered By:</td>
                        <td style="font-size:small; vertical-align:bottom"><asp:Label id="lblEmployee" runat="server" /></td>
                    </tr>
                    <tr><td colspan="4"><hr /></td></tr>
                    <tr>
                        <td>Client Name:<asp:CustomValidator ID="CustomValidator1" runat="server" 
                                ControlToValidate="ddlClient" Display="Dynamic" ErrorMessage="*" 
                                onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                        </td>
                        <td><asp:DropDownList ID="ddlClient" runat="server" /></td>
                        <td>Program Name:<asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                                runat="server" ControlToValidate="txtProgramName" Display="Dynamic" 
                                ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td><asp:TextBox ID="txtProgramName" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Application Name:</td>
                        <td><asp:TextBox ID="txtApplicationName" runat="server" /></td>
                        <td>Tandim/Ticket Name:</td>
                        <td><asp:TextBox ID="txtTandimNumber" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Request Type:<asp:CustomValidator ID="CustomValidator2" runat="server" 
                                ControlToValidate="ddlRequestType" Display="Dynamic" ErrorMessage="*" 
                                onservervalidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                        </td>
                        <td><asp:DropDownList ID="ddlRequestType" runat="server" /></td>
                        <td>Work Type:<asp:CustomValidator ID="CustomValidator3" runat="server" 
                                ControlToValidate="ddlWorkType" Display="Dynamic" ErrorMessage="*" 
                                onservervalidate="CustomValidator3_ServerValidate"></asp:CustomValidator>
                        </td>
                        <td><asp:DropDownList ID="ddlWorkType" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Estimated Hours:<asp:RegularExpressionValidator 
                                ID="RegularExpressionValidator1" runat="server" 
                                ControlToValidate="txtHoursEstimate" Display="Dynamic" ErrorMessage="*" 
                                ValidationExpression="[0-9]+\.[0-9]+"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                ControlToValidate="txtHoursEstimate" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td><asp:TextBox ID="txtHoursEstimate" runat="server" /></td>
                        <td>Actual Hours:<asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
                                runat="server" ControlToValidate="txtHoursActual" Display="Dynamic" 
                                ErrorMessage="*" ValidationExpression="[0-9]+\.[0-9]+"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                ControlToValidate="txtHoursActual" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td><asp:TextBox ID="txtHoursActual" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Description:<asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                                runat="server" ControlToValidate="txtDescription" Display="Dynamic" 
                                ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td colspan="3">
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="100%" />
                        </td>
                    </tr>
                    <tr>
                        <td>Notes:</td>
                        <td colspan="3">
                            <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Width="100%" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4" align="right"><hr />
                            <asp:ImageButton ID="btnSave" runat="server" ImageUrl="~/Images/001_06.ico" OnClick="UpdateTask" />
                            <asp:ImageButton ID="btnCancel" runat="server" ImageUrl="~/Images/001_29.ico" />
                        </td>
                    </tr>
                </table>
                <input type="hidden" id="hdnTaskID" runat="server" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
