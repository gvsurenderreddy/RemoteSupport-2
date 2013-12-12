<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="View.ascx.cs" Inherits="LD2.TeamViewer.View" %>

<div id="wrapper">
    <table width="200px">
        <tr>
            <td>
                <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server" CssClass="txt"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblFOC" runat="server" Text="Form Of Contact: "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlFOC" runat="server" CssClass="ddl">
                    <asp:ListItem Text="Phone"></asp:ListItem>
                    <asp:ListItem Text="Email"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="lblContact" runat="server" Text="Contact: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtContact" runat="server" CssClass="txt"></asp:TextBox>
            </td>
        </tr>
    </table>

    <!-- TeamViewer Logo (generated at http://www.teamviewer.com) -->
    <div style="position: relative; width: 200px; height: 125px;">
        <asp:LinkButton ID="button" runat="server" OnClick="button_onclick">
                <img src="http://www.teamviewer.com/link/?url=246800&id=967076033" alt="Download TeamViewer QuickSupport" title="Download TeamViewer QuickSupport" border="0" width="200" height="125" />
                <span style="position: absolute; top: 83.5px; left: 5px; display: block; cursor: pointer; color: White; font-family: Arial; font-size: 15px; line-height: 1.2em; font-weight: bold; text-align: center; width: 190px;">Download TeamViewer</span>
        </asp:LinkButton>
    </div>
</div>

