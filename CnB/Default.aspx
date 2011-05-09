<%@ Page Language="C#" MasterPageFile="~/CnB.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CnB._Default" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPannel" runat="server">
    <asp:Panel ID="pnlHolder" runat="server" DefaultButton="btnSave">
        <table cellpadding="5">
            <tr>
                <td>Client Name: </td>
                <td><asp:DropDownList ID="ddlClient" runat="server" /></td>
                <td>Program Name: </td>
                <td><asp:TextBox ID="txtProgram" runat="server" /></td>
                <td>Application Name: </td>
                <td><asp:TextBox ID="txtApplication" runat="server" /></td>
                <td>Reference Tandim<br />/SD Ticket</td>
                <td><asp:TextBox ID="txtTandimNumber" runat="server" /></td>
            </tr>
            <tr>
                <td>Request Type: </td>
                <td><asp:DropDownList ID="ddlRequestType" runat="server" /></td>
                <td>Work Type: </td>
                <td><asp:DropDownList ID="ddlWorkType" runat="server" /></td>
                <td>Hours Estimate: </td>
                <td><asp:TextBox ID="txtHoursEstimate" runat="server" /></td>
                <td>Actual Hours Worked: </td>
                <td><asp:TextBox ID="txtHoursActual" runat="server" /></td>
            </tr>
            <tr>
                <td>Description: </td>
                <td colspan="3"><asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="100%" /></td>
                <td>Notes: </td>
                <td colspan="3"><asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Width="100%" /></td>
            </tr>
            <tr>
                <td colspan="8" align="right"><asp:Button ID="btnSave" runat="server" Text="Save" 
                        onclick="btnSave_Click" /></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>