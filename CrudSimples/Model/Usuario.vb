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


End Class
