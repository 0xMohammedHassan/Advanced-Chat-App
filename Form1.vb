Imports System
Imports System.IO
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Public Class Form1
    Public listenthread As New Thread(AddressOf listen)
    ' Public server As New TcpListener(25444)
    Public client As New TcpClient
    Public stream As NetworkStream

    Public connected As Boolean




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        connected = False
        CheckForIllegalCrossThreadCalls = False

    End Sub
    'Close Technique By Mohammed G. Abo Hassan
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If connected = True Then
            client.Client.Close() 'Release associated resources from sockets
            client.Close() ' end tcp con.


        End If
    End Sub


    ' Connection Process

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Cant be empty!")
        End If
        Try
            client.Connect(TextBox1.Text, TextBox2.Text)
            connected = True
            stream = client.GetStream
            listenthread.Start()
            Label3.Text = ("Connected to: ") & TextBox1.Text
            If client.Connected = False Then
                MsgBox("Connection has been lost!")
                Application.Exit()


            End If
        Catch ex As Exception
            connected = False
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        On Error Resume Next



        Application.Exit()
        End


    End Sub
    'Make me Host
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        If TextBox2.Text = "" Or TextBox1.Text = "" Then
            MsgBox("Port cant be null!")
            Exit Sub


        End If
        Dim server As New TcpListener(TextBox2.Text)
        server.Start()
        MsgBox("Start Listen now")

        client = server.AcceptTcpClient

        stream = client.GetStream
        listenthread.Start()
        Label1.Text = ("Status: Hosting Server Running!")


    End Sub
    Sub listen()
        Dim rec(client.ReceiveBufferSize) As Byte '' converting to byte
        Do

            If Label1.Text = ("Status: Hosting Server Running!") Then

            End If
            Try

                stream.Read(rec, 0, client.ReceiveBufferSize)
                Dim rectext As String = Encoding.ASCII.GetString(rec)
                Dim result As String = rectext + vbNewLine

                'RichTextBox1.Text = rectext + vbNewLine
                ListBox1.Items.Add(result)



            Catch ex As Exception
            End Try



        Loop
    End Sub


    'Send Button

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        On Error Resume Next

        If Label3.Text <> "" Then

            RichTextBox2.Text = "User :" + RichTextBox2.Text
        Else
            RichTextBox2.Text = "Master :" + RichTextBox2.Text

        End If
        Dim sendtext() As Byte = Encoding.ASCII.GetBytes(RichTextBox2.Text) ' convert into sequence of bytes
        stream.Write(sendtext, 0, sendtext.Length)
        ListBox1.Items.Add(RichTextBox2.Text)
        RichTextBox2.Clear()







    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Set Button
        MessageBox.Show("Port " + TextBox2.Text + " Has been opend !")
        TextBox2.ReadOnly = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Clipboard.SetText(ListBox1.SelectedItem.ToString)
            MsgBox("Done!")


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("Coded by Mohammed Abo Hassan")
    End Sub
End Class
