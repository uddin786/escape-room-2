Public Class Form1
    Public name1 As String
    Public difficulty As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Boolean = True
        If TextBox1.Text = String.Empty Or ComboBox1.Text = String.Empty Then
            If TextBox1.Text = String.Empty Then
                MessageBox.Show("please enter a name")
                x = False
            End If

            If ComboBox1.Text = String.Empty Then
                MessageBox.Show("please enter difficulty")
                x = False
            End If
        End If
        If x = True Then
            name1 = TextBox1.Text
            difficulty = ComboBox1.Text
            Me.Hide()
            Form2.Show()
            TextBox1.Clear()
        End If

    End Sub
End Class
