﻿Imports System.Data
Imports System.Data.SqlClient

Public Class Form2
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click

        Dim connString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Users.mdf; Integrated Security=True;Connect Timeout=30"
        Dim ligacao As SqlConnection = New SqlConnection(connString)

        Try
            ligacao.Open()
            MsgBox("Foi estabelecida a conexão com a BD.")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM Utilizadores WHERE username ='" & txtLogin.Text & "' AND password = '" & txtSenha.Text & "'", ligacao)
        Dim dr As SqlDataReader = cmd.ExecuteReader

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
            Form1.Label1.Text = "Bem vindo(a)" & strNome & "" & strApelido
        Else
            Dim msg As String = "Nao encontrado" & vbNewLine & "Utilizador ou senha incorretos."
            Dim titulo As String = "Aviso!"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Exclamation
            MessageBox.Show(msg, titulo, botoes, icone)
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLogin.Select()
    End Sub
End Class
