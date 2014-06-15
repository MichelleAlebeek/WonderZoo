<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Inloggen.aspx.cs" Inherits="WonderZooWeb.Inloggen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 23px;
        }
        .auto-style2 {
            width: 219px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainInhoud" runat="server">
    <p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Gebruiker:</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DDGebruikers" runat="server" Height="16px" Width="193px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Wachtwoord:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TxtWachtwoord" runat="server" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="BtnInloggen" runat="server" Text="Inloggen" Width="83px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="BtnAnnuleren" runat="server" Text="Annuleren" Width="83px" />
                </td>
            </tr>
        </table>
        <br />
    </p>
</asp:Content>
