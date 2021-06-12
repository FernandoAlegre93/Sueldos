Public Class Sueldos

    Dim Sueldobasico As Integer
    Dim Descuento As Double
    Dim Bonifi As Double
    Dim Procesar As Double



    Private Sub rbtnA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnA.CheckedChanged
        Sueldobasico = 800
        txtSueldoBasic.Text = Sueldobasico

    End Sub

    Private Sub rdbtnB_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnB.CheckedChanged
        Sueldobasico = 1000
        txtSueldoBasic.Text = Sueldobasico

    End Sub

    Private Sub rdbtnC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnC.CheckedChanged
        Sueldobasico = 700
        txtSueldoBasic.Text = Sueldobasico
    End Sub

    Private Sub rdbtnU_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnU.CheckedChanged
        Descuento = 0.14
    End Sub

    Private Sub rdbtnH_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnH.CheckedChanged
        Descuento = 0.16
    End Sub

    Private Sub rdbtnI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnI.CheckedChanged
        Descuento = 0.15
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text >= 1 And ComboBox1.Text <= 3 Then
            Bonifi = 0.1
        End If

        If ComboBox1.Text = 4 And ComboBox1.Text <= 6 Then
            Bonifi = 0.12
        End If

        If ComboBox1.Text >= 7 Then
            Bonifi = 0.14
        End If

    End Sub

    Private Sub btnPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPro.Click
        Procesar = (Sueldobasico) + (Sueldobasico * Bonifi) - (Sueldobasico * Descuento)
        txtSueldo.Text = Procesar
    End Sub
End Class
