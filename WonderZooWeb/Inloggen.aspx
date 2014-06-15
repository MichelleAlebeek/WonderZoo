<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Inloggen.aspx.cs" Inherits="WonderZooWeb.Inloggen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 23px;
        }
        .auto-style2 {
            width: 219px;
        }
    .auto-style3 {
        width: 23px;
        height: 23px;
    }
    .auto-style4 {
        width: 219px;
        height: 23px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainInhoud" runat="server">
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="LblFout" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Gebruikersnaam</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtGebruikersnaam" runat="server" Width="184px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Wachtwoord:</td>
                <td class="auto-style2"><asp:TextBox ID="TxtWachtwoord" runat="server" Width="187px"></asp:TextBox></td>
            </tr>
            <tr>
                <td class="auto-style3">
                </td>
                <td class="auto-style4">
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="BtnInloggen" runat="server" Text="Inloggen" Width="83px" OnClick="BtnInloggen_Click" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="BtnAnnuleren" runat="server" Text="Annuleren" Width="83px" OnClick="BtnAnnuleren_Click" />
                </td>
            </tr>
        </table>
        <br />
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="MainImage">
                 <asp:Image ID="IMInloggen" runat="server" Height="124px" ImageAlign="Right" Width="385px" style="margin-left: 2px" ImageUrl="~/Images/cheetah.JPG" />                           
                 </asp:Content>

