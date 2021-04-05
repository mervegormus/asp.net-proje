<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YazOkuluProje.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat ="server">
        <div class="form-group">
            <div>
                <asp:Label for="TextAd" runat="server" Text="Öğrenci Ad:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TextAd" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div>
                <asp:Label for="TextSoyad" runat="server" Text="Öğrenci Soyad:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TextSoyad" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div>
                <asp:Label for="TextNumara" runat="server" Text="Öğrenci Numara:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TextNumara" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div>
                <asp:Label for="TextMail" runat="server" Text="Öğrenci Mail:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TextMail" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div>
                <asp:Label for="TextSifre" runat="server" Text="Öğrenci Şifre:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TextSifre" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
            <div>
                <asp:Label for="TextFoto" runat="server" Text="Öğrenci Fotograf:" style="font-weight: bold"></asp:Label>
            <asp:TextBox ID="TextFoto" runat="server" CssClass="form-control"></asp:TextBox>

            </div>
        </div>
<asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" CssClass="btn btn-info"/>
    </form>
</asp:Content>
