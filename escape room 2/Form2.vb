Public Class Form2
    Public stopwatch As New Stopwatch
    Public time As TimeSpan = stopwatch.Elapsed
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
        stopwatch.Start()
    End Sub
    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}", Math.Floor(elapsed.TotalMinutes), elapsed.Seconds)
    End Sub
    Private Sub Form1_keydown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down Then
            If yoda.Top < 400 Then
                yoda.Top += 10
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If yoda.Top > 0 Then
                yoda.Top -= 10
            End If
        ElseIf e.KeyCode = Keys.Left Then
            If yoda.Left > 0 Then
                yoda.Left -= 10
            End If
        ElseIf e.KeyCode = Keys.Right Then
            If yoda.Left < 725 Then
                yoda.Left += 10
            End If
        End If
    End Sub
    Private Sub collisionCheck()
        If yoda.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            Me.Hide()
            Form3.Show()
            yoda.Location = New Point(326, 119)
        End If
        If Form3.room3unlock = True Then
            If yoda.Bounds.IntersectsWith(PictureBox2.Bounds) Then
                Me.Hide()
                Form4.Show()
                yoda.Location = New Point(326, 119)
            End If
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        collisionCheck()
    End Sub
End Class