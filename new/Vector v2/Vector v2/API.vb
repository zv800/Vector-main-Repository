Public Class API

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
        ' CheckBox1.Checked = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        'CheckBox2.Checked = False
    End Sub

    Private Sub API_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            My.Settings.api = 0
        Else
            My.Settings.api = 1
        End If
        Me.Close()
    End Sub
End Class