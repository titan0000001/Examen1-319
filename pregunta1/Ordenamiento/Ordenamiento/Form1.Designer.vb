<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.A = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.B = New System.Windows.Forms.TextBox()
        Me.C = New System.Windows.Forms.TextBox()
        Me.RES = New System.Windows.Forms.TextBox()
        Me.ordenar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'A
        '
        Me.A.Location = New System.Drawing.Point(12, 12)
        Me.A.Multiline = True
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(90, 78)
        Me.A.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'B
        '
        Me.B.Location = New System.Drawing.Point(119, 12)
        Me.B.Multiline = True
        Me.B.Name = "B"
        Me.B.Size = New System.Drawing.Size(90, 78)
        Me.B.TabIndex = 2
        '
        'C
        '
        Me.C.Location = New System.Drawing.Point(230, 12)
        Me.C.Multiline = True
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(90, 78)
        Me.C.TabIndex = 3
        '
        'RES
        '
        Me.RES.Location = New System.Drawing.Point(12, 226)
        Me.RES.Multiline = True
        Me.RES.Name = "RES"
        Me.RES.Size = New System.Drawing.Size(308, 78)
        Me.RES.TabIndex = 5
        '
        'ordenar
        '
        Me.ordenar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.ordenar.Location = New System.Drawing.Point(12, 135)
        Me.ordenar.Name = "ordenar"
        Me.ordenar.Size = New System.Drawing.Size(308, 57)
        Me.ordenar.TabIndex = 6
        Me.ordenar.Text = "ORDENAR"
        Me.ordenar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 317)
        Me.Controls.Add(Me.ordenar)
        Me.Controls.Add(Me.RES)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.B)
        Me.Controls.Add(Me.A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents A As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents B As TextBox
    Friend WithEvents C As TextBox
    Friend WithEvents RES As TextBox
    Friend WithEvents ordenar As Button
End Class
