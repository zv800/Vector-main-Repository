Imports System.IO
Imports WeAreDevs_API
Public Class Form1
    Dim hax As ExploitAPI = New ExploitAPI
    Dim lastPoint As Point
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        hax.SendLuaScript(FastColoredTextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FastColoredTextBox1.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveFileDialog1.Filter = "lua Files (*.lua*)|*.lua"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
         Then
            My.Computer.FileSystem.WriteAllText _
            (SaveFileDialog1.FileName, FastColoredTextBox1.Text, True)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            FastColoredTextBox1.Text = fileReader
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        hax.LaunchExploit()
    End Sub

    Private Sub FastColoredTextBox1_Load(sender As Object, e As EventArgs) Handles FastColoredTextBox1.Load
        FastColoredTextBox1.Language = FastColoredTextBox1.Language.Lua
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.[Exit]()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        lastPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Left += e.X - lastPoint.X
            Me.Top += e.Y - lastPoint.Y

        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        FastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{ListBox1.SelectedItem}") ';

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear() 'Clear Items In the LuaScriptList
        Functions.PopulateListBox(ListBox1, "./Scripts", "*.txt") ';
        Functions.PopulateListBox(ListBox1, "./Scripts", "*.lua") ';
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox1.Items.Clear() 'Clear Items In the LuaScriptList
        Functions.PopulateListBox(ListBox1, "./Scripts", "*.txt") ';
        Functions.PopulateListBox(ListBox1, "./Scripts", "*.lua") ';
    End Sub
End Class
