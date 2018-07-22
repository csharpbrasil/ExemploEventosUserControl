<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginControl.ascx.cs" Inherits="LoginControl" %>
<asp:Panel ID="pnlLogin" runat="server" GroupingText="Login">
    <asp:Label ID="lblUsuario" runat="server" Text="Usuario" /><br />
    <asp:TextBox ID="txtUsuario" runat="server" /><br />
    <asp:Label ID="lblSenha" runat="server" Text="Senha" /><br />
    <asp:TextBox ID="txtSenha" runat="server" TextMode="Password" /><br />
    <br />
    <asp:LinkButton ID="lnkEsqueceuSenha" runat="server" Text="Lembrar senha" OnClick="lnkLembrarSenha_Click" />
    <br />
    <br />
    <asp:Button ID="btnAutenticar" Text="Autenticar" runat="server" OnClick="btnAutenticar_Click" />
    <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" OnClick="btnCadastrar_Click" />
</asp:Panel>
