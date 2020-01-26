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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.a_seg = New System.Windows.Forms.Label()
        Me.g_seg = New System.Windows.Forms.Label()
        Me.d_seg = New System.Windows.Forms.Label()
        Me.b_seg = New System.Windows.Forms.Label()
        Me.c_seg = New System.Windows.Forms.Label()
        Me.e_seg = New System.Windows.Forms.Label()
        Me.f_seg = New System.Windows.Forms.Label()
        Me.dot_seg = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(320, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 268)
        Me.Label2.TabIndex = 0
        '
        'a_seg
        '
        Me.a_seg.Location = New System.Drawing.Point(372, 33)
        Me.a_seg.Name = "a_seg"
        Me.a_seg.Size = New System.Drawing.Size(98, 17)
        Me.a_seg.TabIndex = 0
        '
        'g_seg
        '
        Me.g_seg.Location = New System.Drawing.Point(372, 133)
        Me.g_seg.Name = "g_seg"
        Me.g_seg.Size = New System.Drawing.Size(98, 17)
        Me.g_seg.TabIndex = 0
        '
        'd_seg
        '
        Me.d_seg.Location = New System.Drawing.Point(372, 233)
        Me.d_seg.Name = "d_seg"
        Me.d_seg.Size = New System.Drawing.Size(98, 17)
        Me.d_seg.TabIndex = 0
        '
        'b_seg
        '
        Me.b_seg.Location = New System.Drawing.Point(476, 49)
        Me.b_seg.Name = "b_seg"
        Me.b_seg.Size = New System.Drawing.Size(16, 81)
        Me.b_seg.TabIndex = 0
        '
        'c_seg
        '
        Me.c_seg.Location = New System.Drawing.Point(476, 149)
        Me.c_seg.Name = "c_seg"
        Me.c_seg.Size = New System.Drawing.Size(16, 81)
        Me.c_seg.TabIndex = 0
        '
        'e_seg
        '
        Me.e_seg.Location = New System.Drawing.Point(350, 152)
        Me.e_seg.Name = "e_seg"
        Me.e_seg.Size = New System.Drawing.Size(16, 81)
        Me.e_seg.TabIndex = 0
        '
        'f_seg
        '
        Me.f_seg.Location = New System.Drawing.Point(350, 49)
        Me.f_seg.Name = "f_seg"
        Me.f_seg.Size = New System.Drawing.Size(16, 81)
        Me.f_seg.TabIndex = 0
        '
        'dot_seg
        '
        Me.dot_seg.Location = New System.Drawing.Point(501, 233)
        Me.dot_seg.Name = "dot_seg"
        Me.dot_seg.Size = New System.Drawing.Size(17, 17)
        Me.dot_seg.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(395, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dot_seg)
        Me.Controls.Add(Me.d_seg)
        Me.Controls.Add(Me.f_seg)
        Me.Controls.Add(Me.e_seg)
        Me.Controls.Add(Me.c_seg)
        Me.Controls.Add(Me.b_seg)
        Me.Controls.Add(Me.g_seg)
        Me.Controls.Add(Me.a_seg)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents a_seg As Label
    Friend WithEvents g_seg As Label
    Friend WithEvents d_seg As Label
    Friend WithEvents b_seg As Label
    Friend WithEvents c_seg As Label
    Friend WithEvents e_seg As Label
    Friend WithEvents f_seg As Label
    Friend WithEvents dot_seg As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
End Class
