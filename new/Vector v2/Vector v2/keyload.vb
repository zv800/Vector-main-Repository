Imports System.Net
Public Class keyload
    Dim lastPoint As Point
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://sites.google.com/view/vector-exploit/register") 'give key
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Dim wb As WebClient = New WebClient()
            Dim key As String = wb.DownloadString("https://pastebin.com/raw/SjW4FhkL") ' registration key
            ' TextBox1.Text = key
            ' Dim check As String = TextBox1.Text

            If key = TextBox1.Text Then
                My.Settings.activated = True
                Form1.Show()
                Me.Hide()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        ' TextBox1.Text = TextBox2.Text
    End Sub

    Private Sub keyload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  If My.Settings.activated = True Then


        '  Timer1.Start()
        ' Else
        wheresmyholywater()
        '  End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://sites.google.com/view/vector-exploit/home")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left += e.X - lastPoint.X
            Me.Top += e.Y - lastPoint.Y

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        lastPoint = New Point(e.X, e.Y)
    End Sub
    Function wtf()
        Try
            Return My.Computer.Network.Ping("www.pastebin.com")

        Catch
            MsgBox("failed to connect to the server", 0 + 16, "ERROR")
            '  MsgBox("what the hell are you doing with no internet", 0 + 16, "bruh")
            ' MsgBox("what the hell are you doing with no internet")
            Me.Close()
            Return False
        End Try

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Form1.Show()
        Me.Hide()
        Timer1.Stop()
    End Sub

    Public Function wheresmyholywater() As Boolean

        Try
            Return My.Computer.Network.Ping("www.google.com")
            wtf()
        Catch
            MsgBox("ERROR:failed to load please connect to the internet", 0 + 16, "ERROR")
            '  MsgBox("what the hell are you doing with no internet", 0 + 16, "bruh")
            ' MsgBox("what the hell are you doing with no internet")
            Me.Close()
            Return False
        End Try

    End Function
End Class