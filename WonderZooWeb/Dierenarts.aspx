<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Dierenarts.aspx.cs" Inherits="WonderZooWeb.Dierenarts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 191px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainInhoud" runat="server">
    &nbsp;
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
    <asp:Label ID="LblFout" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
    <asp:Button ID="BtnMedicijnen" runat="server" Text="Medicijnen" OnClick="BtnMedicijnen_Click" Width="186px" />
            </td>
            <td>&nbsp;Diernummer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtDierNr" runat="server"></asp:TextBox>
                &nbsp;&nbsp;</td>
            <td>
    <asp:GridView ID="GVMedicijnen" runat="server">
    </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
    <asp:Button ID="BtnDuurMedicijn" runat="server" Text="Duur van medicijn" OnClick="BtnDuurMedicijn_Click" Width="186px" />
            </td>
            <td>Diernaam:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TxtDiernaam" runat="server"></asp:TextBox>
&nbsp;&nbsp;</td>
            <td><asp:TextBox ID="TxtDuurMedicijn" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
    <asp:Button ID="BtnZiektes" runat="server" Text="Veel voorkomende ziektes" OnClick="BtnZiektes_Click" Width="186px" />
            </td>
            <td>Diersoortnummer: <asp:TextBox ID="TxtDiersoortnaam" runat="server"></asp:TextBox>
            </td>
            <td>
    <asp:GridView ID="GVZiektes" runat="server">
    </asp:GridView>
            </td>
        </tr>
    </table>
    <br />
&nbsp;
    <br />
    &nbsp;<br />
    &nbsp;
    <br />
    <asp:Button ID="BtnUitloggen" runat="server" OnClick="BtnUitloggen_Click" Text="Uitloggen" />
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="MainImage">
                 <asp:Image ID="ImageDierenarts" runat="server" Height="124px" ImageAlign="Right" Width="385px" style="margin-left: 2px" ImageUrl="~/Images/ringstaartmaki.JPG" />                           
                 </asp:Content>

