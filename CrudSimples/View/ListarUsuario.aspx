<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ListarUsuario.aspx.vb" Inherits="CrudSimples.ListarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Usuarios Cadastrados</div>
        <asp:GridView ID="grvUsuarios" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField HeaderText="Nome" DataField="nome"/>
                <asp:BoundField HeaderText="Data de Nascimento" DataField="data_nascimento" DataFormatString="{0: dd/MM/yyyy}"/>
                <asp:BoundField HeaderText="Sexo" DataField="sexo"/>
                <asp:BoundField HeaderText="Cidade" DataField="cidade"/>
                <asp:BoundField HeaderText="Estado" DataField="estado"/>
                <asp:BoundField HeaderText="País" DataField="pais"/>
            </Columns>
        </asp:GridView>
        <asp:Button ID="btnAddUsuario" runat="server" Text="Adicionar Novo" />
    </form>
</body>
</html>
