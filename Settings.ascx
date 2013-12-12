<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings.ascx.cs" Inherits="LD2.TeamViewer.Settings" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.UI.WebControls" Assembly="DotNetNuke.Web" %>
<%@ Register TagPrefix="dnn" TagName="FileUpload" Src="~/controls/FilePickerUploader.ascx" %>

<div>
    <asp:Label ID="lblEmail2" runat="server" Text="Email Address: "></asp:Label>
    <asp:TextBox ID="txtEmail2" runat="server"></asp:TextBox>
</div>

<div>
    <asp:Label ID="lblFile" runat="server" Text="File: "></asp:Label>
    <asp:Label ID="lblFile2" runat="server" ></asp:Label>
    <div>
        <dnn:FileUpload ID="fuFile" runat="server" />
    </div>
</div>
