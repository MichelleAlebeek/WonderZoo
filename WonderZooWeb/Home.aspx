<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WonderZooWeb.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
            width: 122px;
        }
    .auto-style2 {
            width: 401px;
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
            Vanaf nu ook zeehonden op het park te bezichtigen !<asp:Image ID="Image6" runat="server" Height="270px" ImageUrl="~/Images/zeehond.JPG" Width="362px" />
            <br />
            <br />
            Nu ook voedertijden voor beermarters !<br />
            <asp:Image ID="Image7" runat="server" Height="204px" ImageUrl="~/Images/beermarter (2).JPG" Width="359px" />
            <br />
            Kom om 12:00 of om 16:00 naar het beermarter verblijf.</td>
        <td class="auto-style1">&nbsp;</td>
        <td>
            <asp:Image ID="IMGeboren" runat="server" Height="202px" ImageUrl="~/Images/rendierjong (1).JPG" Width="311px" />
            <br />
            <asp:Image ID="Image4" runat="server" Height="165px" ImageUrl="~/Images/rendierjong (2).JPG" Width="311px" />
            <br />
            <asp:Image ID="Image5" runat="server" Height="159px" ImageUrl="~/Images/rendierjong (3).JPG" Width="311px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">
            &nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td>Te bezoeken vanaf:<br />
            10-06-2014</td>
    </tr>
</table>
    <br />

</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="MainImage">
                 <asp:Image ID="IMHome" runat="server" Height="124px" ImageAlign="Right" Width="385px" style="margin-left: 2px" ImageUrl="~/Images/kroeskoppelikaan.JPG" />                           
                 </asp:Content>

