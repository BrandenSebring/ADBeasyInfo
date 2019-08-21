<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextInfoBox1 = New System.Windows.Forms.TextBox()
        Me.ConnectBTN = New System.Windows.Forms.Button()
        Me.KillADBbtn = New System.Windows.Forms.Button()
        Me.getInfoBTN = New System.Windows.Forms.Button()
        Me.exportBTN = New System.Windows.Forms.Button()
        Me.exportServerBTN = New System.Windows.Forms.Button()
        Me.fixAdbBtn = New System.Windows.Forms.Button()
        Me.pathChngBTN1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextInfoBox1
        '
        Me.TextInfoBox1.Location = New System.Drawing.Point(15, 12)
        Me.TextInfoBox1.Multiline = True
        Me.TextInfoBox1.Name = "TextInfoBox1"
        Me.TextInfoBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextInfoBox1.Size = New System.Drawing.Size(328, 184)
        Me.TextInfoBox1.TabIndex = 0
        Me.TextInfoBox1.Text = "Welcome to the ProLogic Its ADB Tool!!!"
        '
        'ConnectBTN
        '
        Me.ConnectBTN.Location = New System.Drawing.Point(13, 204)
        Me.ConnectBTN.Name = "ConnectBTN"
        Me.ConnectBTN.Size = New System.Drawing.Size(157, 23)
        Me.ConnectBTN.TabIndex = 1
        Me.ConnectBTN.Text = "Check Connection"
        Me.ConnectBTN.UseVisualStyleBackColor = True
        '
        'KillADBbtn
        '
        Me.KillADBbtn.Location = New System.Drawing.Point(177, 204)
        Me.KillADBbtn.Name = "KillADBbtn"
        Me.KillADBbtn.Size = New System.Drawing.Size(141, 23)
        Me.KillADBbtn.TabIndex = 2
        Me.KillADBbtn.Text = "Kill ADB Server"
        Me.KillADBbtn.UseVisualStyleBackColor = True
        '
        'getInfoBTN
        '
        Me.getInfoBTN.Location = New System.Drawing.Point(13, 234)
        Me.getInfoBTN.Name = "getInfoBTN"
        Me.getInfoBTN.Size = New System.Drawing.Size(157, 23)
        Me.getInfoBTN.TabIndex = 3
        Me.getInfoBTN.Text = "Get Info"
        Me.getInfoBTN.UseVisualStyleBackColor = True
        '
        'exportBTN
        '
        Me.exportBTN.Location = New System.Drawing.Point(13, 264)
        Me.exportBTN.Name = "exportBTN"
        Me.exportBTN.Size = New System.Drawing.Size(157, 23)
        Me.exportBTN.TabIndex = 4
        Me.exportBTN.Text = "Export Data"
        Me.exportBTN.UseVisualStyleBackColor = True
        '
        'exportServerBTN
        '
        Me.exportServerBTN.Location = New System.Drawing.Point(15, 293)
        Me.exportServerBTN.Name = "exportServerBTN"
        Me.exportServerBTN.Size = New System.Drawing.Size(155, 23)
        Me.exportServerBTN.TabIndex = 5
        Me.exportServerBTN.Text = "Export to Server"
        Me.exportServerBTN.UseVisualStyleBackColor = True
        '
        'fixAdbBtn
        '
        Me.fixAdbBtn.Location = New System.Drawing.Point(176, 293)
        Me.fixAdbBtn.Name = "fixAdbBtn"
        Me.fixAdbBtn.Size = New System.Drawing.Size(142, 23)
        Me.fixAdbBtn.TabIndex = 6
        Me.fixAdbBtn.Text = "Fix ADB Location"
        Me.fixAdbBtn.UseVisualStyleBackColor = True
        '
        'pathChngBTN1
        '
        Me.pathChngBTN1.Location = New System.Drawing.Point(176, 264)
        Me.pathChngBTN1.Name = "pathChngBTN1"
        Me.pathChngBTN1.Size = New System.Drawing.Size(142, 23)
        Me.pathChngBTN1.TabIndex = 7
        Me.pathChngBTN1.Text = "Changed Path to ADB"
        Me.pathChngBTN1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(65, 340)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(220, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 388)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pathChngBTN1)
        Me.Controls.Add(Me.fixAdbBtn)
        Me.Controls.Add(Me.exportServerBTN)
        Me.Controls.Add(Me.exportBTN)
        Me.Controls.Add(Me.getInfoBTN)
        Me.Controls.Add(Me.KillADBbtn)
        Me.Controls.Add(Me.ConnectBTN)
        Me.Controls.Add(Me.TextInfoBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextInfoBox1 As TextBox
    Friend WithEvents ConnectBTN As Button
    Friend WithEvents KillADBbtn As Button
    Friend WithEvents getInfoBTN As Button
    Friend WithEvents exportBTN As Button
    Friend WithEvents exportServerBTN As Button
    Friend WithEvents fixAdbBtn As Button
    Friend WithEvents pathChngBTN1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
