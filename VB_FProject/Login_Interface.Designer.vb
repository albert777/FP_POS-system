﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Interface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Interface))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.user_icon = New System.Windows.Forms.Panel()
        Me.username = New System.Windows.Forms.TextBox()
        Me.pass_icon = New System.Windows.Forms.Panel()
        Me.user_name = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.register = New System.Windows.Forms.Button()
        Me.login_cancel = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.user_icon.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.user_icon)
        Me.Panel1.Controls.Add(Me.pass_icon)
        Me.Panel1.Controls.Add(Me.user_name)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(418, 205)
        Me.Panel1.TabIndex = 3
        '
        'user_icon
        '
        Me.user_icon.BackgroundImage = CType(resources.GetObject("user_icon.BackgroundImage"), System.Drawing.Image)
        Me.user_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.user_icon.Controls.Add(Me.username)
        Me.user_icon.Location = New System.Drawing.Point(71, 50)
        Me.user_icon.Name = "user_icon"
        Me.user_icon.Size = New System.Drawing.Size(29, 27)
        Me.user_icon.TabIndex = 7
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(35, 0)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(249, 26)
        Me.username.TabIndex = 0
        '
        'pass_icon
        '
        Me.pass_icon.BackgroundImage = CType(resources.GetObject("pass_icon.BackgroundImage"), System.Drawing.Image)
        Me.pass_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pass_icon.Location = New System.Drawing.Point(71, 108)
        Me.pass_icon.Name = "pass_icon"
        Me.pass_icon.Size = New System.Drawing.Size(29, 27)
        Me.pass_icon.TabIndex = 6
        '
        'user_name
        '
        Me.user_name.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_name.Location = New System.Drawing.Point(106, 50)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(241, 26)
        Me.user_name.TabIndex = 1
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(106, 108)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(241, 26)
        Me.password.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(68, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(68, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.register)
        Me.Panel2.Controls.Add(Me.login_cancel)
        Me.Panel2.Controls.Add(Me.login)
        Me.Panel2.Location = New System.Drawing.Point(-46, 288)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 176)
        Me.Panel2.TabIndex = 4
        '
        'register
        '
        Me.register.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.register.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.register.Location = New System.Drawing.Point(141, 69)
        Me.register.Name = "register"
        Me.register.Size = New System.Drawing.Size(229, 45)
        Me.register.TabIndex = 2
        Me.register.Text = "Register"
        Me.register.UseVisualStyleBackColor = False
        '
        'login_cancel
        '
        Me.login_cancel.BackColor = System.Drawing.Color.White
        Me.login_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.login_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_cancel.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.login_cancel.Location = New System.Drawing.Point(141, 120)
        Me.login_cancel.Name = "login_cancel"
        Me.login_cancel.Size = New System.Drawing.Size(229, 26)
        Me.login_cancel.TabIndex = 1
        Me.login_cancel.Text = "Cancel"
        Me.login_cancel.UseVisualStyleBackColor = False
        '
        'login
        '
        Me.login.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.login.Location = New System.Drawing.Point(141, 18)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(229, 45)
        Me.login.TabIndex = 0
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(-46, -20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(464, 76)
        Me.Panel3.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(96, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 32)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Login Here"
        '
        'Login_Interface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(415, 471)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Login_Interface"
        Me.Text = "Login Interface"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.user_icon.ResumeLayout(False)
        Me.user_icon.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents username As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents login_cancel As Button
    Friend WithEvents login As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents register As Button
    Friend WithEvents pass_icon As Panel
    Friend WithEvents password As TextBox
    Friend WithEvents user_icon As Panel
    Friend WithEvents user_name As TextBox
End Class
