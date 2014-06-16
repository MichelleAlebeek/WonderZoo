<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Dierverzorger.aspx.cs" Inherits="WonderZooWeb.Dierverzorger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 246px;
        }
        .auto-style4 {
            width: 246px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            height: 23px;
        }
        .auto-style8 {
            width: 52px;
        }
        .auto-style9 {
            width: 52px;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainInhoud" runat="server">
    <br />
    <table style="width:100%;">
        <tr>
            <td class="auto-style7" colspan="2" style="font-weight:bold">Dieren</td>
        </tr>
        <tr>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnInfoDier" runat="server" OnClick="BtnInfoDier_Click" Text="Info dier" />
            </td>
            <td class="auto-style4">Diernaam:
    <asp:TextBox ID="TxtDiernaam" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblDier" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
    <asp:TextBox ID="TxtDier" runat="server" Width="404px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnRas" runat="server" OnClick="BtnRas_Click" Text="Ras" />
            </td>
            <td class="auto-style4">Diernummer:
    <asp:TextBox ID="TxtDierNummer" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblRas" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
    <asp:TextBox ID="TxtRas" runat="server" Width="404px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">    <asp:Button ID="BtnMedicijnen" runat="server" OnClick="BtnMedicijnen_Click" Text="Medicijnen" />
            </td>
            <td class="auto-style4">Diernummer:
    <asp:TextBox ID="TxtDierNr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblMedicijn" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
    <asp:GridView ID="GVMedicijnen" runat="server">
    </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnVerblijfDier" runat="server" OnClick="BtnVerblijfDier_Click" Text="Verblijf" />
            </td>
            <td class="auto-style4">Diernummer:
    <asp:TextBox ID="TxtDNr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblVerblijf" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
    <asp:TextBox ID="TxtVerblijf" runat="server" Width="404px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnDierenTotaal" runat="server" OnClick="BtnDierenTotaal_Click" Text="Totaal aantal dieren" />
            </td>
            <td class="auto-style4">
    <asp:TextBox ID="TxtTotaalDieren" runat="server" Width="404px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblTotaal" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2" style="font-weight:bold">Huisvesting</td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnAantalVerblijf" runat="server" OnClick="BtnAantalVerblijf_Click" Text="Aantal dieren verblijf" />
            </td>
            <td class="auto-style4">Huisvestingnummer:
    <asp:TextBox ID="TxtHuisNr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblHuisvesting" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
    <asp:TextBox ID="TxtAantal" runat="server" Width="404px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style9">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6" colspan="2" style="font-weight:bold">Diersoort</td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnDiersoortInfo" runat="server" OnClick="BtnDiersoortInfo_Click" Text="Info diersoort" />
            </td>
            <td class="auto-style4">Diersoortnummer:
    <asp:TextBox ID="TxtDiersoortNr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblDiersoort" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="TxtDiersoort" runat="server" Width="404px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnZiektes" runat="server" OnClick="BtnZiektes_Click" Text="Veel voorkomende ziektes" />
            </td>
            <td class="auto-style4">Diersoortnummer:
    <asp:TextBox ID="TxtDiersoortNummer" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblZiektes" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
    <asp:GridView ID="GVZiektes" runat="server">
    </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnVoedingDiersoort" runat="server" OnClick="BtnVoedingDiersoort_Click" Text="Voeding diersoort" />
            </td>
            <td class="auto-style4">Diersoortnummer:
    <asp:TextBox ID="TxtDSoortNr" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblVoeding" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
    <asp:TextBox ID="TxtVoeding" runat="server" Width="404px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
    <asp:Button ID="BtnHuisvestingDiersoort" runat="server" OnClick="BtnHuisvestingDiersoort_Click" Text="Huisvesting diersoort" />
            </td>
            <td class="auto-style4">Diersoortnummer:
    <asp:TextBox ID="TxtDSoortNummer" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                <asp:Label ID="LblHuisDiersoort" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">
    <asp:TextBox ID="TxtHuisvesting" runat="server" Width="404px"></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <br />
    <asp:Button ID="BtnUitloggen" runat="server" OnClick="BtnUitloggen_Click" Text="Uitloggen" />
    <br />
    <br />
    <br />
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="MainImage">
                 <asp:Image ID="IMDierverzorger" runat="server" Height="124px" ImageAlign="Right" Width="385px" style="margin-left: 2px" ImageUrl="~/Images/blauwgeleara.JPG" />                           
                 </asp:Content>

