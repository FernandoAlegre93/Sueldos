<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sueldos
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
        Me.btnPro = New System.Windows.Forms.Button()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbtnU = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbtnI = New System.Windows.Forms.RadioButton()
        Me.rdbtnH = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbtnC = New System.Windows.Forms.RadioButton()
        Me.rbtnA = New System.Windows.Forms.RadioButton()
        Me.rdbtnB = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSueldoBasic = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPro
        '
        Me.btnPro.Location = New System.Drawing.Point(191, 196)
        Me.btnPro.Name = "btnPro"
        Me.btnPro.Size = New System.Drawing.Size(75, 23)
        Me.btnPro.TabIndex = 0
        Me.btnPro.Text = "Procesar"
        Me.btnPro.UseVisualStyleBackColor = True
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(396, 196)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "El sueldo es"
        '
        'rdbtnU
        '
        Me.rdbtnU.AutoSize = True
        Me.rdbtnU.Location = New System.Drawing.Point(22, 19)
        Me.rdbtnU.Name = "rdbtnU"
        Me.rdbtnU.Size = New System.Drawing.Size(53, 17)
        Me.rdbtnU.TabIndex = 4
        Me.rdbtnU.TabStop = True
        Me.rdbtnU.Text = "Unión"
        Me.rdbtnU.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbtnI)
        Me.GroupBox1.Controls.Add(Me.rdbtnU)
        Me.GroupBox1.Controls.Add(Me.rdbtnH)
        Me.GroupBox1.Location = New System.Drawing.Point(493, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AFP"
        '
        'rdbtnI
        '
        Me.rdbtnI.AutoSize = True
        Me.rdbtnI.Location = New System.Drawing.Point(22, 65)
        Me.rdbtnI.Name = "rdbtnI"
        Me.rdbtnI.Size = New System.Drawing.Size(58, 17)
        Me.rdbtnI.TabIndex = 7
        Me.rdbtnI.TabStop = True
        Me.rdbtnI.Text = "Integra"
        Me.rdbtnI.UseVisualStyleBackColor = True
        '
        'rdbtnH
        '
        Me.rdbtnH.AutoSize = True
        Me.rdbtnH.Location = New System.Drawing.Point(22, 42)
        Me.rdbtnH.Name = "rdbtnH"
        Me.rdbtnH.Size = New System.Drawing.Size(70, 17)
        Me.rdbtnH.TabIndex = 6
        Me.rdbtnH.TabStop = True
        Me.rdbtnH.Text = "Horizonte"
        Me.rdbtnH.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBox1.Location = New System.Drawing.Point(320, 97)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdbtnC)
        Me.GroupBox2.Controls.Add(Me.rbtnA)
        Me.GroupBox2.Controls.Add(Me.rdbtnB)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categoria"
        '
        'rdbtnC
        '
        Me.rdbtnC.AutoSize = True
        Me.rdbtnC.Location = New System.Drawing.Point(22, 65)
        Me.rdbtnC.Name = "rdbtnC"
        Me.rdbtnC.Size = New System.Drawing.Size(32, 17)
        Me.rdbtnC.TabIndex = 7
        Me.rdbtnC.TabStop = True
        Me.rdbtnC.Text = "C"
        Me.rdbtnC.UseVisualStyleBackColor = True
        '
        'rbtnA
        '
        Me.rbtnA.AutoSize = True
        Me.rbtnA.Location = New System.Drawing.Point(22, 19)
        Me.rbtnA.Name = "rbtnA"
        Me.rbtnA.Size = New System.Drawing.Size(32, 17)
        Me.rbtnA.TabIndex = 4
        Me.rbtnA.TabStop = True
        Me.rbtnA.Text = "A"
        Me.rbtnA.UseVisualStyleBackColor = True
        '
        'rdbtnB
        '
        Me.rdbtnB.AutoSize = True
        Me.rdbtnB.Location = New System.Drawing.Point(22, 42)
        Me.rdbtnB.Name = "rdbtnB"
        Me.rdbtnB.Size = New System.Drawing.Size(32, 17)
        Me.rdbtnB.TabIndex = 6
        Me.rdbtnB.TabStop = True
        Me.rdbtnB.Text = "B"
        Me.rdbtnB.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Sueldo"
        '
        'txtSueldoBasic
        '
        Me.txtSueldoBasic.Location = New System.Drawing.Point(265, 48)
        Me.txtSueldoBasic.Name = "txtSueldoBasic"
        Me.txtSueldoBasic.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldoBasic.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cantidad de Hijos"
        '
        'Sueldos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 244)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSueldoBasic)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.btnPro)
        Me.Name = "Sueldos"
        Me.Text = "Sueldos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPro As System.Windows.Forms.Button
    Friend WithEvents txtSueldo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbtnU As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnI As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnH As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnC As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnA As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnB As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSueldoBasic As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
