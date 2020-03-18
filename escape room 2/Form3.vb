Public Class Form3
    Public room3unlock As Boolean = False
    Public rni As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        If Form1.difficulty = "easy" Then
            easyq()
        ElseIf Form1.difficulty = "medium" Then
            mediumq()
        Else
            hardq()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Form2.stopwatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}", Math.Floor(elapsed.TotalMinutes), elapsed.Seconds)
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    room3unlock = True
    '    Me.Hide()
    '    Form2.Show()
    'End Sub
    Sub easyq()
        Dim rn As New Random
        rni = rn.Next(1, 3)
        If rni = 1 Then
            Label2.Text = ("what is the hexadecimal value A in binary?")
        ElseIf rni = 2 Then
            Label2.Text = ("what is the hexadecimal value B in binary?")
        ElseIf rni = 3 Then
            Label2.Text = ("what is the hexadecimal value C in binary?")
        End If
    End Sub
    Sub mediumq()
        Dim rn As New Random
        rni = rn.Next(4, 6)
        If rni = 4 Then
            Label2.Text = ("what is the hexadecimal value A1 in binary?")
        ElseIf rni = 5 Then
            Label2.Text = ("what is the hexadecimal value B1 in binary?")
        ElseIf rni = 6 Then
            Label2.Text = ("what is the hexadecimal value C1 in binary?")
        End If
    End Sub
    Sub hardq()
        Dim rn As New Random
        rni = rn.Next(7, 9)
        If rni = 7 Then
            Label2.Text = ("what is the hexadecimal value 3F in binary?")
        ElseIf rni = 8 Then
            Label2.Text = ("what is the hexadecimal value 41 in binary?")
        ElseIf rni = 9 Then
            Label2.Text = ("what is the hexadecimal value 2D in binary?")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rni = 1 Then
            If TextBox1.Text = 1010 Then
                welldone()

            Else
                MessageBox.Show("wrong")
            End If
        ElseIf rni = 2 Then
            If TextBox1.Text = 1011 Then
                welldone()
            Else
                MessageBox.Show("wrong")
            End If
        ElseIf rni = 3 Then
            If TextBox1.Text = 1100 Then
                welldone()
            Else
                MessageBox.Show("wrong")
            End If
        ElseIf rni = 4 Then
            If TextBox1.Text = 10100001 Then
                welldone()
            Else
                MessageBox.Show("wrong")
            End If
        ElseIf rni = 5 Then
            If TextBox1.Text = 10110001 Then
                welldone()
            Else
                MessageBox.Show("wrong")
            End If
        ElseIf rni = 6 Then
            If TextBox1.Text = 11000001 Then
                welldone()
            Else
                MessageBox.Show("wrong")
            End If
        ElseIf rni = 7 Then
            If TextBox1.Text = 111111 Then
                welldone()
            Else
                MessageBox.Show("wrong")
            End If
        ElseIf rni = 8 Then
            If TextBox1.Text = 1000001 Then
                welldone()
            Else
                MessageBox.Show("wrong")
            End If
        ElseIf rni = 9 Then
            If TextBox1.Text = 101101 Then
                welldone()
            Else
                MessageBox.Show("wrong")
            End If

        End If
    End Sub

    Sub welldone()
        MessageBox.Show("well done")
        TextBox1.Clear()
        Me.Hide()
        Form2.Show()
        Form2.PictureBox2.BackColor = Color.FromArgb(255, 255, 0)
        room3unlock = True
    End Sub
End Class