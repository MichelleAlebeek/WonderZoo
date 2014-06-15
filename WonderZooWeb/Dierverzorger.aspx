<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Dierverzorger.aspx.cs" Inherits="WonderZooWeb.Dierverzorger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainInhoud" runat="server">
    <asp:Button ID="BtnMedicijnen" runat="server" OnClick="BtnMedicijnen_Click" Text="Medicijnen" />
    <br />
    Diernummer:
    <asp:TextBox ID="TxtDierNr" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:GridView ID="GVMedicijnen" runat="server">
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="BtnDiersoortInfo" runat="server" OnClick="BtnDiersoortInfo_Click" Text="Info diersoort" />
    <br />
    Diersoortnummer:
    <asp:TextBox ID="TxtDiersoortNr" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtDiersoort" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnInfoDier" runat="server" OnClick="BtnInfoDier_Click" Text="Info dier" />
    <br />
    Diernaam:
    <asp:TextBox ID="TxtDiernaam" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtDier" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnRas" runat="server" OnClick="BtnRas_Click" Text="Ras" />
    <br />
    Diernummer:
    <asp:TextBox ID="TxtDierNummer" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtRas" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnZiektes" runat="server" OnClick="BtnZiektes_Click" Text="Veel voorkomende ziektes" />
    <br />
    Diersoortnummer:
    <asp:TextBox ID="TxtDiersoortNummer" runat="server"></asp:TextBox>
    <br />
    <asp:GridView ID="GVZiektes" runat="server">
    </asp:GridView>
    <br />
    <br />
    <asp:Button ID="BtnVerblijfDier" runat="server" OnClick="BtnVerblijfDier_Click" Text="Verblijf" />
    <br />
    Diernummer:
    <asp:TextBox ID="TxtDNr" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtVerblijf" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnAantalVerblijf" runat="server" OnClick="BtnAantalVerblijf_Click" Text="Aantal dieren verblijf" />
    <br />
    Huisvestingnummer:
    <asp:TextBox ID="TxtHuisNr" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtAantal" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnVoedingDiersoort" runat="server" OnClick="BtnVoedingDiersoort_Click" Text="Voeding diersoort" />
    <br />
    Diersoortnummer:
    <asp:TextBox ID="TxtDSoortNr" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtVoeding" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnHuisvestingDiersoort" runat="server" OnClick="BtnHuisvestingDiersoort_Click" Text="Huisvesting diersoort" />
    <br />
    Diersoortnummer:
    <asp:TextBox ID="TxtDSoortNummer" runat="server"></asp:TextBox>
    <asp:TextBox ID="TxtHuisvesting" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnDierenTotaal" runat="server" OnClick="BtnDierenTotaal_Click" Text="Totaal aantal dieren" />
    <br />
    <asp:TextBox ID="TxtTotaalDieren" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="BtnUitloggen" runat="server" OnClick="BtnUitloggen_Click" Text="Uitloggen" />
    <br />
</asp:Content>
