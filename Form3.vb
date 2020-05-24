Imports System.Data
Imports System.Data.OleDb

Public Class Form3
    Private Sub btnEntrar_Load(sender As Object, e As EventArgs)
        Dim provider As String = "provider=SQLOLEDB.1;"
        Dim ficheiro As String = "Data Source=aocalDBAMSSQLLocalDB;AttachDbFilename=1DataDirectoryl\Users.mdf; Integrated Security=True;Connect Timeout=30"
        Dim connString As String = provider & ficheiro
        Dim ligacao As OleDbConnection = New OleDbConnection(connString)
        Try
            ligacao.Open()
            MsgBox("Foi estabelecida a conexao com a BD.")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Utilizadores WHERE username ='" & txtLogin.Text & "' AND password = '" & txtSenha.Text & "'", ligacao)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        Dim encontrou As Boolean = False
        Dim strNome As String = ""
        Dim strApelido As String = ""
        If dr.HasRows Then
            While dr.Read
                encontrou = True
                strNome = dr("nome").ToString
                strApelido = dr("apelido").ToString
            End While
        End If
        ligacao.Close()
        If encontrou = True Then
            Me.Close()
            Form1.Show()
            Form1.Label1.Text = "Bem vindo(a) " & strNome & " " & strApelido
        Else
            Dim msg As String = "Nao encontrado." & vbNewLine & "Utilizador ou senha incorretos."
            Dim titulo As String = "Aviso!"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Exclamation
            MessageBox.Show(msg, titulo, botoes, icone)
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLogin.Select()
    End Sub
End Class