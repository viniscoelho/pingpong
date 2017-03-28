<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pongMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pongMain))
        Me.compScoreDraw = New System.Windows.Forms.Label()
        Me.plrScoreDraw = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.gameBall = New System.Windows.Forms.PictureBox()
        Me.paddleComputer = New System.Windows.Forms.PictureBox()
        Me.paddlePlayer = New System.Windows.Forms.PictureBox()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'compScoreDraw
        '
        Me.compScoreDraw.AutoSize = True
        Me.compScoreDraw.BackColor = System.Drawing.Color.Transparent
        Me.compScoreDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compScoreDraw.ForeColor = System.Drawing.Color.OrangeRed
        Me.compScoreDraw.Location = New System.Drawing.Point(245, 31)
        Me.compScoreDraw.Name = "compScoreDraw"
        Me.compScoreDraw.Size = New System.Drawing.Size(66, 46)
        Me.compScoreDraw.TabIndex = 3
        Me.compScoreDraw.Text = "00"
        '
        'plrScoreDraw
        '
        Me.plrScoreDraw.AutoSize = True
        Me.plrScoreDraw.BackColor = System.Drawing.Color.Transparent
        Me.plrScoreDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plrScoreDraw.ForeColor = System.Drawing.Color.LimeGreen
        Me.plrScoreDraw.Location = New System.Drawing.Point(326, 31)
        Me.plrScoreDraw.Name = "plrScoreDraw"
        Me.plrScoreDraw.Size = New System.Drawing.Size(66, 46)
        Me.plrScoreDraw.TabIndex = 4
        Me.plrScoreDraw.Text = "00"
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 25
        '
        'gameBall
        '
        Me.gameBall.BackColor = System.Drawing.Color.Transparent
        Me.gameBall.BackgroundImage = CType(resources.GetObject("gameBall.BackgroundImage"), System.Drawing.Image)
        Me.gameBall.Location = New System.Drawing.Point(290, 181)
        Me.gameBall.Name = "gameBall"
        Me.gameBall.Size = New System.Drawing.Size(60, 60)
        Me.gameBall.TabIndex = 2
        Me.gameBall.TabStop = False
        '
        'paddleComputer
        '
        Me.paddleComputer.BackColor = System.Drawing.Color.Gold
        Me.paddleComputer.Location = New System.Drawing.Point(40, 160)
        Me.paddleComputer.Name = "paddleComputer"
        Me.paddleComputer.Size = New System.Drawing.Size(20, 128)
        Me.paddleComputer.TabIndex = 1
        Me.paddleComputer.TabStop = False
        '
        'paddlePlayer
        '
        Me.paddlePlayer.BackColor = System.Drawing.Color.Purple
        Me.paddlePlayer.Location = New System.Drawing.Point(570, 160)
        Me.paddlePlayer.Name = "paddlePlayer"
        Me.paddlePlayer.Size = New System.Drawing.Size(20, 128)
        Me.paddlePlayer.TabIndex = 0
        Me.paddlePlayer.TabStop = False
        '
        'pongMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.plrScoreDraw)
        Me.Controls.Add(Me.compScoreDraw)
        Me.Controls.Add(Me.gameBall)
        Me.Controls.Add(Me.paddleComputer)
        Me.Controls.Add(Me.paddlePlayer)
        Me.Name = "pongMain"
        Me.Text = "Pong Game"
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents paddlePlayer As System.Windows.Forms.PictureBox
    Friend WithEvents paddleComputer As System.Windows.Forms.PictureBox
    Friend WithEvents gameBall As System.Windows.Forms.PictureBox
    Friend WithEvents compScoreDraw As System.Windows.Forms.Label
    Friend WithEvents plrScoreDraw As System.Windows.Forms.Label
    Friend WithEvents gameTimer As System.Windows.Forms.Timer

End Class
