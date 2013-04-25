<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.tmrRunner = New System.Windows.Forms.Timer(Me.components)
        Me.lblControl = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.SplitBottom = New System.Windows.Forms.SplitContainer()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblYellow = New System.Windows.Forms.Label()
        Me.lblRed = New System.Windows.Forms.Label()
        CType(Me.SplitBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitBottom.Panel1.SuspendLayout()
        Me.SplitBottom.Panel2.SuspendLayout()
        Me.SplitBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrRunner
        '
        Me.tmrRunner.Enabled = True
        Me.tmrRunner.Interval = 10000
        '
        'lblControl
        '
        Me.lblControl.BackColor = System.Drawing.Color.Gray
        Me.lblControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControl.Location = New System.Drawing.Point(0, 0)
        Me.lblControl.Name = "lblControl"
        Me.lblControl.Size = New System.Drawing.Size(902, 408)
        Me.lblControl.TabIndex = 0
        Me.lblControl.Text = "No one has current control"
        Me.lblControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBlue
        '
        Me.lblBlue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBlue.BackColor = System.Drawing.Color.Gray
        Me.lblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlue.ForeColor = System.Drawing.Color.Blue
        Me.lblBlue.Location = New System.Drawing.Point(534, 0)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(368, 76)
        Me.lblBlue.TabIndex = 0
        Me.lblBlue.Text = "0"
        Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SplitBottom
        '
        Me.SplitBottom.BackColor = System.Drawing.Color.Gray
        Me.SplitBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitBottom.Location = New System.Drawing.Point(0, 314)
        Me.SplitBottom.Name = "SplitBottom"
        '
        'SplitBottom.Panel1
        '
        Me.SplitBottom.Panel1.Controls.Add(Me.lblGreen)
        '
        'SplitBottom.Panel2
        '
        Me.SplitBottom.Panel2.Controls.Add(Me.lblYellow)
        Me.SplitBottom.Size = New System.Drawing.Size(902, 94)
        Me.SplitBottom.SplitterDistance = 447
        Me.SplitBottom.TabIndex = 2
        Me.SplitBottom.TabStop = False
        '
        'lblGreen
        '
        Me.lblGreen.BackColor = System.Drawing.Color.Gray
        Me.lblGreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGreen.Location = New System.Drawing.Point(0, 0)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(447, 94)
        Me.lblGreen.TabIndex = 0
        Me.lblGreen.Text = "0"
        Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblYellow
        '
        Me.lblYellow.BackColor = System.Drawing.Color.Gray
        Me.lblYellow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblYellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYellow.ForeColor = System.Drawing.Color.Yellow
        Me.lblYellow.Location = New System.Drawing.Point(0, 0)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(451, 94)
        Me.lblYellow.TabIndex = 0
        Me.lblYellow.Text = "0"
        Me.lblYellow.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.BackColor = System.Drawing.Color.Gray
        Me.lblRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRed.ForeColor = System.Drawing.Color.Red
        Me.lblRed.Location = New System.Drawing.Point(0, 0)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(70, 76)
        Me.lblRed.TabIndex = 3
        Me.lblRed.Text = "0"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 408)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.SplitBottom)
        Me.Controls.Add(Me.lblControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitBottom.Panel1.ResumeLayout(False)
        Me.SplitBottom.Panel2.ResumeLayout(False)
        CType(Me.SplitBottom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrRunner As System.Windows.Forms.Timer
    Friend WithEvents lblControl As System.Windows.Forms.Label
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents SplitBottom As System.Windows.Forms.SplitContainer
    Friend WithEvents lblGreen As System.Windows.Forms.Label
    Friend WithEvents lblYellow As System.Windows.Forms.Label
    Friend WithEvents lblRed As System.Windows.Forms.Label

End Class
