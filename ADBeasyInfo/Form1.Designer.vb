﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TextInfoBox1 = New System.Windows.Forms.TextBox()
        Me.ConnectBTN = New System.Windows.Forms.Button()
        Me.KillADBbtn = New System.Windows.Forms.Button()
        Me.getInfoBTN = New System.Windows.Forms.Button()
        Me.exportBTN = New System.Windows.Forms.Button()
        Me.exportServerBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextInfoBox1
        '
        Me.TextInfoBox1.Location = New System.Drawing.Point(13, 13)
        Me.TextInfoBox1.Multiline = True
        Me.TextInfoBox1.Name = "TextInfoBox1"
        Me.TextInfoBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextInfoBox1.Size = New System.Drawing.Size(525, 184)
        Me.TextInfoBox1.TabIndex = 0
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
        Me.KillADBbtn.Size = New System.Drawing.Size(164, 23)
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
        Me.exportServerBTN.Location = New System.Drawing.Point(177, 263)
        Me.exportServerBTN.Name = "exportServerBTN"
        Me.exportServerBTN.Size = New System.Drawing.Size(164, 23)
        Me.exportServerBTN.TabIndex = 5
        Me.exportServerBTN.Text = "Export to Server"
        Me.exportServerBTN.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 450)
        Me.Controls.Add(Me.exportServerBTN)
        Me.Controls.Add(Me.exportBTN)
        Me.Controls.Add(Me.getInfoBTN)
        Me.Controls.Add(Me.KillADBbtn)
        Me.Controls.Add(Me.ConnectBTN)
        Me.Controls.Add(Me.TextInfoBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextInfoBox1 As TextBox
    Friend WithEvents ConnectBTN As Button
    Friend WithEvents KillADBbtn As Button
    Friend WithEvents getInfoBTN As Button
    Friend WithEvents exportBTN As Button
    Friend WithEvents exportServerBTN As Button
End Class
