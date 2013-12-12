<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Edit.ascx.cs" Inherits="LD2.TeamViewer.Edit" %>

<asp:Label ID="lblEmail2" runat="server" Text="Email Address: "></asp:Label>
<asp:TextBox ID="txtEmail2" runat="server" ></asp:TextBox>
<br /><br />

<asp:Label ID="lblFile" runat="server" Text="File: "></asp:Label>
<asp:FileUpload ID="fuFile" runat="server" />

<br /><br /><br />
<asp:LinkButton ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" resourcekey="btnSubmit" CssClass="dnnPrimaryAction" />
<asp:LinkButton ID="btnCancel" runat="server" OnClick="btnCancel_Click" resourcekey="btnCancel" CssClass="dnnSecondaryAction" />