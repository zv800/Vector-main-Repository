Imports System.IO
Imports WeAreDevs_API
Imports System.Net
Public Class Form1

    Dim hax As ExploitAPI = New ExploitAPI
    Dim lastPoint As Point
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ''  If My.Settings.api = 0 Then
        hax.SendLuaScript(FastColoredTextBox1.Text)
        ' Else

        '  End If

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
        InjTest.Start()
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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        API.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        hax.DoBTools()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        hax.SetWalkSpeed()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        hax.RemoveArms(usr.Text)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        hax.AddFire(usr.Text)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        hax.AddForcefield(usr.Text)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        hax.AddSmoke(usr.Text)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        hax.AddSparkles(usr.Text)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        hax.DoBlockHead(usr.Text)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        hax.RemoveFire(usr.Text)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        hax.RemoveForceField(usr.Text)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        hax.RemoveLegs(usr.Text)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        hax.RemoveLimbs(usr.Text)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        hax.RemoveSmoke()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        hax.RemoveSparkles()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim fileReader As String
        Try
            fileReader = My.Computer.FileSystem.ReadAllText("Scripts\Dex Explorer V2.txt")
            hax.SendLuaScript(fileReader)
        Catch ex As Exception
            MsgBox("ERROR file not found")
        End Try

        '     MsgBox(fileReader)
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Try
            hax.SetWalkSpeed(usr.Text, TextBox1.Text)
        Catch ex As Exception
            MsgBox("error")
        End Try

    End Sub

    Private Sub InjTest_Tick(sender As Object, e As EventArgs) Handles InjTest.Tick
        If hax.isAPIAttached = True Then
            Dim wb As WebClient = New WebClient()
            Dim Script As String = wb.DownloadString("https://pastebin.com/raw/6M4GpD10")
            hax.SendLuaScript(Script)
            Label3.Text = "injected"
            InjTest2.Start()
            InjTest.Stop()
        Else
            Label3.Text = "not injected"
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'DONT FUCKING ASK
        RichTextBox1.Text = "exploit then the problem probably is that the if you are having trouble launching the  exploit is patched just wait for the devs to  release a new update this usually takes  around four hours to a day"
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        ScriptHub.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub InjTest2_Tick(sender As Object, e As EventArgs) Handles InjTest2.Tick
        If hax.isAPIAttached = False Then
            Label3.Text = "not injected"
            InjTest.Start()
            InjTest2.Stop()
        End If
    End Sub
End Class
