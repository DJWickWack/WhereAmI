﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WhereAmINow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WhereAmINow))
        Me.lb_User1_Place = New System.Windows.Forms.Label()
        Me.lb_User1 = New System.Windows.Forms.Label()
        Me.lb_User2_Place = New System.Windows.Forms.Label()
        Me.lb_User2 = New System.Windows.Forms.Label()
        Me.lb_User3_Place = New System.Windows.Forms.Label()
        Me.lb_User3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lb_User1_Place
        '
        Me.lb_User1_Place.BackColor = System.Drawing.Color.Silver
        Me.lb_User1_Place.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_User1_Place.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_User1_Place.Location = New System.Drawing.Point(29, 50)
        Me.lb_User1_Place.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_User1_Place.Name = "lb_User1_Place"
        Me.lb_User1_Place.Size = New System.Drawing.Size(353, 43)
        Me.lb_User1_Place.TabIndex = 0
        Me.lb_User1_Place.Text = "MicroSpec"
        Me.lb_User1_Place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_User1
        '
        Me.lb_User1.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_User1.Location = New System.Drawing.Point(29, 7)
        Me.lb_User1.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_User1.Name = "lb_User1"
        Me.lb_User1.Size = New System.Drawing.Size(353, 43)
        Me.lb_User1.TabIndex = 1
        Me.lb_User1.Text = "Derek"
        Me.lb_User1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_User2_Place
        '
        Me.lb_User2_Place.BackColor = System.Drawing.Color.Silver
        Me.lb_User2_Place.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_User2_Place.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_User2_Place.Location = New System.Drawing.Point(817, 50)
        Me.lb_User2_Place.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_User2_Place.Name = "lb_User2_Place"
        Me.lb_User2_Place.Size = New System.Drawing.Size(353, 43)
        Me.lb_User2_Place.TabIndex = 2
        Me.lb_User2_Place.Text = "Information Technology"
        Me.lb_User2_Place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_User2
        '
        Me.lb_User2.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_User2.Location = New System.Drawing.Point(817, 7)
        Me.lb_User2.Name = "lb_User2"
        Me.lb_User2.Size = New System.Drawing.Size(353, 43)
        Me.lb_User2.TabIndex = 3
        Me.lb_User2.Text = "Ben"
        Me.lb_User2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_User3_Place
        '
        Me.lb_User3_Place.BackColor = System.Drawing.Color.Silver
        Me.lb_User3_Place.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lb_User3_Place.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_User3_Place.Location = New System.Drawing.Point(1524, 50)
        Me.lb_User3_Place.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_User3_Place.Name = "lb_User3_Place"
        Me.lb_User3_Place.Size = New System.Drawing.Size(353, 43)
        Me.lb_User3_Place.TabIndex = 4
        Me.lb_User3_Place.Text = "Department"
        Me.lb_User3_Place.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lb_User3
        '
        Me.lb_User3.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_User3.Location = New System.Drawing.Point(1524, 7)
        Me.lb_User3.Name = "lb_User3"
        Me.lb_User3.Size = New System.Drawing.Size(353, 43)
        Me.lb_User3.TabIndex = 5
        Me.lb_User3.Text = "Bruce"
        Me.lb_User3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WhereAmINow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 110)
        Me.Controls.Add(Me.lb_User3)
        Me.Controls.Add(Me.lb_User3_Place)
        Me.Controls.Add(Me.lb_User2)
        Me.Controls.Add(Me.lb_User2_Place)
        Me.Controls.Add(Me.lb_User1)
        Me.Controls.Add(Me.lb_User1_Place)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "WhereAmINow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "WhereAmINow"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lb_User1_Place As Label
    Friend WithEvents lb_User1 As Label
    Friend WithEvents lb_User2_Place As Label
    Friend WithEvents lb_User3_Place As Label
    Friend WithEvents lb_User3 As Label
    Private WithEvents lb_User2 As Label
End Class
