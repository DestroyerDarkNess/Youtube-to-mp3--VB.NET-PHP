Imports Microsoft.Win32
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Web.Script.Serialization
Imports System.Collections.Specialized
Imports System.Text

Public Class Form1
    Public temp As String = Path.GetTempPath()
    Public mp3 As String = String.Empty

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        alert("alert", "Converting to mp3 file")
        Domain()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "" Then
            Label2.Visible = True
            FlatButton1.Enabled = False
        Else
            Label2.Visible = False
            FlatButton1.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(455, 180)
    End Sub

#Region "Downloadmp3"

    Dim WithEvents client As New WebClient

    Private Sub client_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles client.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub client_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles client.DownloadFileCompleted
        alert("suc", "Mp3 File Downloaded Correctly.")
        blockcontrol()
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        ProgressBar1.Visible = True
        alert("alert", "Download...")
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                client.DownloadFileAsync(New Uri(mp3), SaveFileDialog1.FileName)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub blockcontrol()
        Me.Size = New Size(455, 180)
        mp3 = String.Empty
        ProgressBar1.Visible = False
        FlatButton1.Enabled = False
        FlatButton2.Enabled = False
        SaveFileDialog1.FileName = String.Empty
    End Sub

#End Region

#Region "downInfo"

    <Serializable()>
    Public NotInheritable Class MyType
        Public Property [Error] As Boolean
        Public Property Title As String
        Public Property Duration As Integer
        Public Property File As String

        Public Sub New()
        End Sub

        Public Overrides Function ToString() As String
            Return New JavaScriptSerializer().Serialize(Me).ToString
        End Function
    End Class


    Private Sub webClient_DownloadStringCompleted(ByVal sender As Object, ByVal e As DownloadStringCompletedEventArgs)
        Try
            TextBox2.Text = e.Result
            If TextBox2.Text = "" Then
                alert("error", "No response was obtained from the server.")
            Else
                Me.Size = New Size(455, 432)
                alert("suc", "Data Obtained")
                Dim obj As MyType = New JavaScriptSerializer().Deserialize(Of MyType)(e.Result)
                Label1.Text = "Title > " & obj.Title
                SaveFileDialog1.FileName = obj.Title
                Label3.Text = "Duration > " & obj.Duration & "Second"
                obtenerminiatura()
                mp3 = obj.File
                FlatButton2.Enabled = True
            End If
        Catch ex As Exception
            alert("error", ex.Message)
        End Try

    End Sub

    Private Sub descarga(ByVal url As String)
        Try
            alert("alert", "Getting Data... Please wait!")
            Dim WebClient = New WebClient
            AddHandler WebClient.DownloadStringCompleted, AddressOf webClient_DownloadStringCompleted
            WebClient.DownloadStringAsync(New Uri(url))
        Catch ex As Exception
            alert("error", ex.Message)
        End Try
    End Sub

#End Region

#Region "miniatura"

    Dim Miniatura As String

    Private Sub obtenerminiatura()
        Miniatura = "http://img.youtube.com/vi/" & getID(TextBox1.Text).ToString & "/0.jpg"
        Me.MiniaturaPequena.Load(Miniatura)
    End Sub


#End Region

#Region "Validate API , Aincrad"

    Public Sub alert(ByVal opcion As String, ByVal texto As String)
        If opcion = "alert" Then
            FlatAlertBox1.kind = FlatAlertBox._Kind.Info
        ElseIf opcion = "suc" Then
            FlatAlertBox1.kind = FlatAlertBox._Kind.Success
        ElseIf opcion = "error" Then
            FlatAlertBox1.kind = FlatAlertBox._Kind.Error
        End If
        FlatAlertBox1.Text = texto
        FlatAlertBox1.Visible = True
    End Sub

    Private Sub Domain()
        Try
            Dim uri As New Uri(TextBox1.Text)
            Dim dominio As String = uri.Host
            If dominio = "www.youtube.com" Then
                alert("suc", "Link Verified!")
                descarga("http://michaelbelgium.me/ytconverter/convert.php?youtubelink=" & TextBox1.Text)
            ElseIf dominio = "youtu.be" Then
                alert("alert", "Invalid Link Format, Converting !!")
                Dim urlvalid As String = "https://www.youtube.com/watch?v=" & getID(TextBox1.Text).ToString
                alert("suc", "Link successfully converted to .com format!")
                descarga("http://michaelbelgium.me/ytconverter/convert.php?youtubelink=" & urlvalid)
            Else
                alert("error", "It is not recognized as a YouTube link.")
            End If
        Catch ex As Exception
            alert("error", "No It is a URL format.")
        End Try



    End Sub


    Private Function getID(ByVal url As String) As String 'Function by Stack Overflow Forum. 
        Try
            Dim myMatches As System.Text.RegularExpressions.Match
            Dim MyRegEx As New System.Text.RegularExpressions.Regex("youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase) 'This is where the magic happens/SHOULD work on all normal youtube links including youtu.be
            myMatches = MyRegEx.Match(url)
            If myMatches.Success = True Then
                Return myMatches.Groups(1).Value
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

#End Region

End Class
