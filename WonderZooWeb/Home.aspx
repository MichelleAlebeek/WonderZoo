<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WonderZooWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 175px;
    }
    .auto-style2 {
        width: 352px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainInhoud" runat="server">
    <table style="width: 100%;">
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2" style="font-weight:bold">Nieuws:</td>
        <td class="auto-style1">&nbsp;</td>
        <td style="font-weight:bold">Pas geboren:</td>
            
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Image ID="IMGeboren" runat="server" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Image ID="Image3" runat="server" />
        </td>
        <td class="auto-style1">&nbsp;</td>
        <td>Te bezoeken vanaf:</td>
    </tr>
</table>
    <br />

</asp:Content>
