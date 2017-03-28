Public Class pongMain

#Region "Globals"
    Dim speed As Single = 17 ' Ball Speed
    Dim rndInst As New Random() ' Random instance
    Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * speed
    Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * speed

    ' The player's scores.
    Dim compScore As Integer = 0
    Dim plrScore As Integer = 0

#End Region

    '#Region "Move the paddle according to the mouse"
    ' Move the paddle according to the mouse position.
    'Private Sub pongMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    'If e.Y > 5 And e.Y < Me.Height - 40 - paddlePlayer.Height Then _
    'paddlePlayer.Location = New Point(paddlePlayer.Location.X, e.Y)
    'End Sub
    '#End Region

#Region "Main Timer"
    Private Sub gameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameTimer.Tick
        If (compScore = 15 Or plrScore = 15) Then
            gameTimer.Stop()
            PlayWin()
            Dim msg As String = ""
            If compScore = 15 Then
                msg &= "Player 1 won!"
            Else
                msg &= "Player 2 won!"
            End If
            Dim result As Integer = MsgBox("Do you want to keep playing?", MsgBoxStyle.YesNo, msg)
            If result = DialogResult.No Then
                End
            ElseIf result = DialogResult.Yes Then
                Application.Restart()
            End If
        Else
            'Set the computer player to move according to the ball's position."
            'If gameBall.Location.Y > 5 And gameBall.Location.Y < Me.Height - 40 Then _
            '- paddlePlayer.Height Then _
            'paddleComputer.Location = New Point(paddleComputer.Location.X, gameBall.Location.Y)

            ' Move the game ball.
            gameBall.Location = New Point(gameBall.Location.X + xVel, gameBall.Location.Y + yVel)

            ' Check for top wall.
            If gameBall.Location.Y < 0 Then
                gameBall.Location = New Point(gameBall.Location.X, 0)
                yVel = -yVel
            End If

            ' Check for bottom wall.
            If gameBall.Location.Y > Me.Height - gameBall.Size.Height - 45 Then
                gameBall.Location = New Point(gameBall.Location.X, Me.Height - gameBall.Size.Height - 45)
                yVel = -yVel
            End If

            ' Check for left wall. If passes the paddle, add +1 to player 1.
            If gameBall.Location.X < 0 Then
                plrScore += 1
                gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
                plrScoreDraw.Text = Convert.ToString(plrScore)
                If (plrScore < 10) Then
                    plrScoreDraw.Text = "0" & plrScoreDraw.Text
                End If
                PlayBallOut()
            End If

            ' Check for right wall. If passes the paddle, add +1 to player 2.
            If gameBall.Location.X > Me.Width - gameBall.Size.Width - paddlePlayer.Width Then
                compScore += 1
                gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
                compScoreDraw.Text = Convert.ToString(compScore)
                If (compScore < 10) Then
                    compScoreDraw.Text = "0" & compScoreDraw.Text
                End If
                PlayBallOut()
            End If

            ' Check for player paddle.
            If gameBall.Bounds.IntersectsWith(paddlePlayer.Bounds) Then
                gameBall.Location = New Point(paddlePlayer.Location.X - gameBall.Size.Width, _
                gameBall.Location.Y)
                xVel = -xVel
                PlayBallPong()
            End If

            ' Check for computer paddle.
            If gameBall.Bounds.IntersectsWith(paddleComputer.Bounds) Then
                gameBall.Location = New Point(paddleComputer.Location.X + paddleComputer.Size.Width + 1, _
                gameBall.Location.Y)
                xVel = -xVel
                PlayBallPong()
            End If
        End If
    End Sub
#End Region

#Region "Play Sounds"
    Public Sub PlayBallOut()
        My.Computer.Audio.Play(My.Resources.ballout, _
            AudioPlayMode.Background)
    End Sub

    Public Sub PlayBallPong()
        My.Computer.Audio.Play(My.Resources.ballpong, _
            AudioPlayMode.Background)
    End Sub

    Public Sub PlayWin()
        My.Computer.Audio.Play(My.Resources.wincheer, _
            AudioPlayMode.Background)
    End Sub
#End Region

#Region "KeyCommands"
    Private Sub computeKey(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'For Q press
        If e.KeyCode = Keys.Q Then
            Dim newPos As Integer = paddleComputer.Location.Y - 30
            If newPos > 5 And newPos < Me.Height - 40 - paddleComputer.Height Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, newPos)
            End If
        End If

        'For A press
        If e.KeyCode = Keys.A Then
            Dim newPos As Integer = paddleComputer.Location.Y + 30
            If newPos > 5 And newPos < Me.Height - 40 - paddleComputer.Height Then
                paddleComputer.Location = New Point(paddleComputer.Location.X, newPos)
            End If
        End If

        'For P press
        If e.KeyCode = Keys.P Then
            Dim newPos As Integer = paddlePlayer.Location.Y - 30
            If newPos > 5 And newPos < Me.Height - 40 - paddlePlayer.Height Then
                paddlePlayer.Location = New Point(paddlePlayer.Location.X, newPos)
            End If
        End If

        'For L press
        If e.KeyCode = Keys.L Then
            Dim newPos As Integer = paddlePlayer.Location.Y + 30
            If newPos > 5 And newPos < Me.Height - 40 - paddlePlayer.Height Then
                paddlePlayer.Location = New Point(paddlePlayer.Location.X, newPos)
            End If
        End If
    End Sub
#End Region

End Class
