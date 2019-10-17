Public Class ListarUsuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim objUsuario As New Usuario
            grvUsuarios.DataSource = objUsuario.Listar()
            grvUsuarios.DataBind()
        End If

    End Sub

    Protected Sub btnAddUsuario_Click(sender As Object, e As EventArgs) Handles btnAddUsuario.Click
        Response.Redirect("IncluirUsuario.aspx")
    End Sub

    Protected Sub grvUsuarios_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grvUsuarios.RowCommand
        Dim intLinha As Integer = e.CommandArgument
        Dim intId As Integer = grvUsuarios.Rows(intLinha).Cells(0).Text
        Dim objUsuario As New Usuario

        Session("Usuario") = intId
        Response.Redirect("ExibirUsuario.aspx")
    End Sub


End Class