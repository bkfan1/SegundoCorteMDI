Public Class PrimeraActividadFormularioMDI

    Private inputRespuestas() As TextBox

    Private labelMultiplicaciones() As Label

    Private Sub PrimeraActividadFormularioMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputRespuestas = New TextBox() {
            InputRespuesta1,
            InputRespuesta2,
            InputRespuesta3,
            InputRespuesta4,
            InputRespuesta5,
            InputRespuesta6,
            InputRespuesta7,
            InputRespuesta8,
            InputRespuesta9,
            InputRespuesta10
        }

        labelMultiplicaciones = New Label() {
            LabelMultiplicacion1,
            LabelMultiplicacion2,
            LabelMultiplicacion3,
            LabelMultiplicacion4,
            LabelMultiplicacion5,
            LabelMultiplicacion6,
            LabelMultiplicacion7,
            LabelMultiplicacion8,
            LabelMultiplicacion9,
            LabelMultiplicacion10}

    End Sub

    Private Sub BtnComenzar_Click(sender As Object, e As EventArgs) Handles BtnComenzar.Click

        InputNumeroTabla.Enabled = False
        BtnComenzar.Enabled = False

        For i As Integer = 0 To 9
            labelMultiplicaciones(i).Text = (i + 1) & " X " & InputNumeroTabla.Text

            inputRespuestas(i).Enabled = True

        Next

        BtnNuevaEvaluacion.Enabled = True
        BtnEvaluar.Enabled = True


    End Sub

    Private Sub BtnNuevaEvaluacion_Click(sender As Object, e As EventArgs) Handles BtnNuevaEvaluacion.Click
        BtnEvaluar.Enabled = False
        InputNumeroTabla.Text = ""

        ' Resetear todos los campos InputRespuesta
        For i As Integer = 0 To inputRespuestas.Length - 1
            labelMultiplicaciones(i).Text = (i + 1) & " X " & InputNumeroTabla.Text
            inputRespuestas(i).BackColor = SystemColors.Window
            inputRespuestas(i).Enabled = False
            inputRespuestas(i).Text = ""
        Next

        ' Resetear la variable puntaje (si es necesaria para otros usos)
        ' puntaje = 0
        LabelTituloPuntaje.Visible = False
        LabelPuntaje.Visible = False
        LabelTituloPuntaje2.Visible = False

        LabelPuntaje.Text = ""

        InputNumeroTabla.Enabled = True


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("¿Realmente desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iexit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub InputNumeroTabla_TextChanged(sender As Object, e As EventArgs) Handles InputNumeroTabla.TextChanged
        Dim numeroTabla As Integer
        If Integer.TryParse(InputNumeroTabla.Text, numeroTabla) Then
            BtnComenzar.Enabled = True
        Else
            BtnComenzar.Enabled = False

        End If
    End Sub

    Private Sub BtnEvaluar_Click(sender As Object, e As EventArgs) Handles BtnEvaluar.Click
        Dim numeroTabla As Integer
        Dim puntaje As Integer = 0

        ' Intentar convertir el texto de InputNumeroTabla a un entero
        If Integer.TryParse(InputNumeroTabla.Text, numeroTabla) Then
            Console.WriteLine("Número de tabla: " & numeroTabla)
        Else
            MessageBox.Show("Por favor, ingresa un número válido en InputNumeroTabla.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Declarar un array para almacenar las respuestas de los TextBox
        Dim respuestasUsuario(9) As Integer
        Dim respuestasCorrectas(9) As Integer

        ' Llenar respuestasCorrectas con los valores correctos (ejemplo)
        For i As Integer = 1 To 10
            respuestasCorrectas(i - 1) = numeroTabla * i
        Next

        ' Intentar convertir cada respuesta del usuario a entero y comparar con la correcta
        For i As Integer = 0 To 9
            If Integer.TryParse(inputRespuestas(i).Text, respuestasUsuario(i)) Then
                If respuestasUsuario(i) = respuestasCorrectas(i) Then
                    puntaje += 1
                    inputRespuestas(i).BackColor = Color.LightGreen ' Cambiar color a verde si la respuesta es correcta
                Else
                    inputRespuestas(i).BackColor = Color.LightCoral ' Cambiar color a rojo si la respuesta es incorrecta
                End If
            Else
                MessageBox.Show("Por favor, ingresa un número válido en InputRespuesta" & (i + 1) & ".", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        LabelPuntaje.Text = puntaje
        LabelTituloPuntaje.Visible = True
        LabelPuntaje.Visible = True
        LabelTituloPuntaje2.Visible = True
    End Sub


    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles LabelMultiplicacion8.Click

    End Sub
End Class