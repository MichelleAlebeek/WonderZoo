<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Dierenarts.aspx.cs" Inherits="WonderZooWeb.Dierenarts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainInhoud" runat="server">
    &nbsp;
    <br />
&nbsp;
    <asp:Button ID="BtnMedicijnen" runat="server" Text="Medicijnen" OnClick="BtnMedicijnen_Click" />
    <asp:Button ID="BtnDuurMedicijn" runat="server" Text="Duur van medicijn" OnClick="BtnDuurMedicijn_Click" />
    <asp:Button ID="BtnZiektes" runat="server" Text="Veel voorkomende ziektes" OnClick="BtnZiektes_Click" />
    <br />
    &nbsp; Diernummer:
    <asp:TextBox ID="TxtDierNr" runat="server"></asp:TextBox>
&nbsp;Diernaam:
    <asp:TextBox ID="TxtDiernaam" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TxtDuurMedicijn" runat="server"></asp:TextBox>
    &nbsp;Diersoortnummer:
    <asp:TextBox ID="TxtDiersoortnaam" runat="server"></asp:TextBox>
    <asp:Label ID="LblFout" runat="server"></asp:Label>
    <br />
    &nbsp;
    <asp:GridView ID="GVArts" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="BtnUitloggen" runat="server" OnClick="BtnUitloggen_Click" Text="Uitloggen" />
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="MainImage">
                 <asp:Image ID="ImageDierenarts" runat="server" Height="124px" ImageAlign="Right" Width="385px" style="margin-left: 2px" ImageUrl="~/Images/ringstaartmaki.JPG" />                           
                 </asp:Content>

