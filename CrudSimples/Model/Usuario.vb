﻿Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading

Public Class Usuario

#Region "Variáveis"
    Private _id As Integer
    Private _nome As String
    Private _dtNascimento As Date
    Private _sexo As String
    Private _email As String
    Private _cidade As String
    Private _estado As String
    Private _pais As String
    Private _dtCadastro As Date
#End Region

#Region "Propriedades"

    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Public Property DataNascimento() As Date
        Get
            Return _dtNascimento
        End Get
        Set(ByVal value As Date)
            _dtNascimento = value
        End Set
    End Property

    Public Property Sexo() As String
        Get
            Return _sexo
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Public Property Cidade() As String
        Get
            Return _cidade
        End Get
        Set(ByVal value As String)
            _cidade = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Public Property Pais() As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            _pais = value
        End Set
    End Property

    Public Property DtCadastro() As Date
        Get
            Return _dtCadastro
        End Get
        Set(ByVal value As Date)
            _dtCadastro = value
        End Set
    End Property
#End Region

#Region "Metodos"

    Public Function Incluir(objUsuario As Usuario) As String
        'escalar / nonquery
        Try
            'Conexão com o banco de dados
            Dim strConexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\elias.santos\source\repos\CrudSimples\CrudSimples\App_Data\Usuarios.mdf;Integrated Security=True"
            Dim conexaoDB As New SqlConnection(strConexao)

            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US", False)

            Dim strSql As String = "INSERT INTO Usuario(nome, data_nascimento, sexo, email, cidade, estado, pais, data_cadastro)
                                    VALUES ('" & objUsuario.Nome & "', '" & objUsuario.DataNascimento & "', '" & objUsuario.Sexo & "', '" & objUsuario.Email & "',
                                            '" & objUsuario.Cidade & "', '" & objUsuario.Estado & "', '" & objUsuario.Pais & "', '" & objUsuario.DtCadastro & "')"

            Dim Cmd As New SqlCommand(strSql, conexaoDB)
            conexaoDB.Open()

            objUsuario.ID = Cmd.ExecuteScalar
            Return objUsuario.ID

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Exibir(intId As Integer) As Usuario
        'DataReader
        Try
            Dim strConexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\elias.santos\source\repos\CrudSimples\CrudSimples\App_Data\Usuarios.mdf;Integrated Security=True"
            Dim conexaoDB As New SqlConnection(strConexao)
            Dim strSql As String = "SELECT * FROM Usuario where id =" & intId

            Dim Cmd As New SqlCommand(strSql, conexaoDB)
            conexaoDB.Open()

            Dim drUsuario As SqlDataReader

            drUsuario = Cmd.ExecuteReader
            Dim objUsuario As New Usuario
            objUsuario.ID = intId

            objUsuario.Nome = drUsuario("nome")
            objUsuario.DataNascimento = drUsuario("data_nascimento")
            objUsuario.Sexo = drUsuario("sexo")
            objUsuario.Email = drUsuario("email")
            objUsuario.Cidade = drUsuario("cidade")
            objUsuario.Estado = drUsuario("estado")
            objUsuario.Pais = drUsuario("usuario")
            objUsuario.DtCadastro = drUsuario("data_cadastro")

            Return objUsuario
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function Editar(objUsuario As Usuario) As Boolean
        Try
            Dim strConexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\elias.santos\source\repos\CrudSimples\CrudSimples\App_Data\Usuarios.mdf;Integrated Security=True"
            Dim conexaoDB As New SqlConnection(strConexao)

            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Dim strSql As String = "UPDATE Usuario SET  nome='" & objUsuario.Nome & "',
                                                        data_nascimento='" & objUsuario.DataNascimento & "',
                                                        sexo='" & objUsuario.Sexo & "',
                                                        email='" & objUsuario.Email & "',
                                                        cidade='" & objUsuario.Cidade & "',
                                                        estado='" & objUsuario.Estado & "',
                                                        pais='" & objUsuario.Pais & "' WHERE id=" & objUsuario.ID
            Dim Cmd As New SqlCommand(strSql)
            conexaoDB.Open()
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Listar() As DataSet
        'DataAdapter
        Try
            Dim StrConexao As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\elias.santos\source\repos\CrudSimples\CrudSimples\App_Data\Usuarios.mdf;Integrated Security=True"
            Dim conexaoDB As New SqlConnection(StrConexao)
            Dim strSql As String = "SELECT nome, data_nascimento, sexo, cidade, estado, pais FROM Usuario"

            Dim Cmd As New SqlDataAdapter(strSql, conexaoDB)
            conexaoDB.Open()

            Dim dsUsuario As New DataSet
            Cmd.Fill(dsUsuario, "Usuario")

            Return dsUsuario
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function Excluir(intId As Integer) As Boolean
        'nonquery
        Try
            Dim strConexao = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\elias.santos\source\repos\CrudSimples\CrudSimples\App_Data\Usuarios.mdf;Integrated Security=True"
            Dim conexaoDB As New SqlConnection(strConexao)
            Dim strSql As String = "DELETE Usuario WHERE id=" & intId

            Dim Cmd As New SqlCommand(strSql, conexaoDB)
            conexaoDB.Open()
            Cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region


End Class
