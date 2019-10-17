Public Class IncluirUsuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Try
            Dim objUsuario As New Usuario
            objUsuario.Nome = txtNome.Text
            objUsuario.DataNascimento = txtDtNascimento.Text
            objUsuario.Sexo = txtSexo.Text
            objUsuario.Cidade = txtCidade.Text
            objUsuario.Estado = txtEstado.Text
            objUsuario.Pais = txtPais.Text

            Session("Id") = objUsuario.Incluir(objUsuario)
            Response.Redirect("ListarUsuario.aspx")

        Catch ex As Exception

        End Try

    End Sub
End Class