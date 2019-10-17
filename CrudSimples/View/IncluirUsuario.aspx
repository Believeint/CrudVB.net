<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="IncluirUsuario.aspx.vb" Inherits="CrudSimples.IncluirUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">   
        <asp:Label ID="Label1" runat="server" Text="Cadastrar Novo Usuário"></asp:Label>
        <br />
        <br />

        <div>
        <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
        </div>

        <div>
        <asp:Label ID="Label3" runat="server" Text="Data de Nascimento:"></asp:Label>
        <asp:TextBox ID="txtDtNascimento" runat="server"></asp:TextBox>
        </div>

        <div>
        <asp:Label ID="Label4" runat="server" Text="Sexo:"></asp:Label>
        <asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>
        </div>

        <div>
        <asp:Label ID="Label5" runat="server" Text="Cidade:"></asp:Label>
        <asp:TextBox ID="txtCidade" runat="server"></asp:TextBox>
        </div>

        <div>
        <asp:Label ID="Label6" runat="server" Text="Estado:"></asp:Label>
        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
        </div>

        <div>
        <asp:Label ID="Label7" runat="server" Text="País:"></asp:Label>
        <asp:TextBox ID="txtPais" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" />
    </form>
</body>
</html>
