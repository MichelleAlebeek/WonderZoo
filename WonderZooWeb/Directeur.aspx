<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Directeur.aspx.cs" Inherits="WonderZooWeb.Directeur" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainInhoud" runat="server">
    <asp:Button ID="BtnTotaalDieren" runat="server" OnClick="BtnTotaalDieren_Click" Text="Totaal aantal dieren" />
    <br />
    <asp:TextBox ID="TxtAantalTotaal" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="BtnVerblijf" runat="server" Text="Verblijf van dier" OnClick="BtnVerblijf_Click" />
    <br />
    Diernummer:
    <asp:TextBox ID="TxtDiersoortNr" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TxtVerblijf" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="BtnMedicijnen" runat="server" Text="Medicijnen" OnClick="BtnMedicijnen_Click" />
    <br />
    Diernummer:
    <asp:TextBox ID="TxtDierNr" runat="server"></asp:TextBox>
&nbsp;<br />
    <asp:GridView ID="GVMedicijnen" runat="server">
    </asp:GridView>
    <br />
    <asp:Button ID="BtnAantalVerblijf" runat="server" Text="Aantal dieren verblijf" OnClick="BtnAantalVerblijf_Click" />
    <br />
    <asp:TextBox ID="TxtHuisNr" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="TxtAantalVerblijf" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="BtnToevoegen" runat="server" Text="Dier toevoegen" OnClick="BtnToevoegen_Click" />   
    <br />
    <asp:TextBox ID="TxtDNr" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtDNaam" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtLengte" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtGewicht" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtNaamMoeder" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtNaamVader" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtLeeftijd" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtGeslacht" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtRasNr" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtSoortNr" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtHuisNrDier" runat="server"></asp:TextBox>
    <asp:CheckBox ID="CkNakomeling" runat="server" Text="Nakomeling" />
    <br />
    <asp:Button ID="BtnVerwijderen" runat="server" Text="Verwijder dier" OnClick="BtnVerwijderen_Click" />
    <br />
    <asp:TextBox ID="TxtNr" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtNaam" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="LblFout" runat="server"></asp:Label>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
