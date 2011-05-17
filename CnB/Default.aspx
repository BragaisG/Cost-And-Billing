<%@ Page Language="C#" MasterPageFile="~/CnB.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CnB._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPannel" runat="server">
    <asp:Panel ID="pnlHolder" runat="server" DefaultButton="btnSave">
        <table cellpadding="5" width="100%">
            <tr>
                <td>
                    Client Name: 
                    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="*" 
                        onservervalidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                </td>
                <td><asp:DropDownList ID="ddlClient" runat="server" /></td>
                <td>
                    Program Name: 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="*" ControlToValidate="txtProgram" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
                <td><asp:TextBox ID="txtProgram" runat="server" /></td>
                <td>Application Name: </td>
                <td><asp:TextBox ID="txtApplication" runat="server" /></td>
                <td>
                    Reference Tandim<br />/SD Ticket
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
                        ErrorMessage="*" ControlToValidate="txtTandimNumber" 
                        ValidationExpression="[0-9]+"></asp:RegularExpressionValidator>
                </td>
                <td><asp:TextBox ID="txtTandimNumber" runat="server" >0</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Request Type: 
                    <asp:CustomValidator ID="CustomValidator2" runat="server" 
                        ControlToValidate="ddlRequestType" Display="Dynamic" ErrorMessage="*" 
                        onservervalidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                </td>
                <td><asp:DropDownList ID="ddlRequestType" runat="server" /></td>
                <td>Work Type: 
                    <asp:CustomValidator ID="CustomValidator3" runat="server" 
                        ControlToValidate="ddlWorkType" Display="Dynamic" ErrorMessage="*" 
                        onservervalidate="CustomValidator3_ServerValidate"></asp:CustomValidator>
                </td>
                <td><asp:DropDownList ID="ddlWorkType" runat="server" /></td>
                <td>Hours Estimate: 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtHoursEstimate" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtHoursEstimate" ErrorMessage="*" 
                        ValidationExpression="[0-9]+\.[0-9]+|[0-9]+"></asp:RegularExpressionValidator>
                </td>
                <td><asp:TextBox ID="txtHoursEstimate" runat="server" /></td>
                <td>Actual Hours Worked: 
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="txtHoursActual" Display="Dynamic" ErrorMessage="*" 
                        ValidationExpression="[0-9]+\.[0-9]+|[0-9]+"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtHoursActual" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td><asp:TextBox ID="txtHoursActual" runat="server" /></td>
            </tr>
            <tr>
                <td>Description: 
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtDescription" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                <td colspan="3"><asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="100%" /></td>
                <td>Notes: </td>
                <td colspan="3"><asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Width="100%" /></td>
            </tr>
            <tr>
                <td colspan="7"><asp:Label runat="server" ID="lblMessage" ForeColor="Red" Text="" /></td>
                <td align="right"><asp:Button ID="btnSave" runat="server" Text="Save" 
                        onclick="btnSave_Click" /></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>