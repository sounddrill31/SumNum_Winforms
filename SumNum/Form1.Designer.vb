<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        LimitN = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PositiveSum = New TextBox()
        NegativeSum = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(195, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 15)
        Label1.TabIndex = 0
        Label1.Text = "Enter the Limit of Numbers"
        ' 
        ' LimitN
        ' 
        LimitN.Location = New Point(425, 129)
        LimitN.Name = "LimitN"
        LimitN.Size = New Size(100, 23)
        LimitN.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(555, 134)
        Button1.Name = "Button1"
        Button1.Size = New Size(91, 90)
        Button1.TabIndex = 2
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(195, 277)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 3
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(555, 277)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 4
        Button3.Text = "Exit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PositiveSum
        ' 
        PositiveSum.Location = New Point(425, 172)
        PositiveSum.Name = "PositiveSum"
        PositiveSum.Size = New Size(100, 23)
        PositiveSum.TabIndex = 5
        ' 
        ' NegativeSum
        ' 
        NegativeSum.Location = New Point(425, 201)
        NegativeSum.Name = "NegativeSum"
        NegativeSum.Size = New Size(100, 23)
        NegativeSum.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(195, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 15)
        Label2.TabIndex = 7
        Label2.Text = "Sum of Positive Numbers:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(195, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 15)
        Label3.TabIndex = 8
        Label3.Text = "Sum of Positive Numbers:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(NegativeSum)
        Controls.Add(PositiveSum)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(LimitN)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LimitN As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PositiveSum As TextBox
    Friend WithEvents NegativeSum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
