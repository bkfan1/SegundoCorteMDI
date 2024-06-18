Public Class SegundaActividadOrdenarNumerosFormulario

    ' Implementación de algoritmo de ordenamiento QuickSort:

    ' Función QuickSort
    Private Sub QuickSort(ByRef arr() As Integer, ByVal low As Integer, ByVal high As Integer, ByVal ascendente As Boolean)
        If low < high Then
            Dim pivotIndex As Integer = Partition(arr, low, high, ascendente)
            QuickSort(arr, low, pivotIndex - 1, ascendente)
            QuickSort(arr, pivotIndex + 1, high, ascendente)
        End If
    End Sub

    ' Función Partition
    Private Function Partition(ByRef arr() As Integer, ByVal low As Integer, ByVal high As Integer, ByVal ascendente As Boolean) As Integer
        Dim pivot As Integer = arr(high)
        Dim i As Integer = low - 1

        For j As Integer = low To high - 1
            If (ascendente AndAlso arr(j) < pivot) OrElse (Not ascendente AndAlso arr(j) > pivot) Then
                i += 1
                Swap(arr, i, j)
            End If
        Next

        Swap(arr, i + 1, high)
        Return i + 1
    End Function

    ' Función Swap
    Private Sub Swap(ByRef arr() As Integer, ByVal i As Integer, ByVal j As Integer)
        Dim temp As Integer = arr(i)
        arr(i) = arr(j)
        arr(j) = temp
    End Sub

    ' Funciones auxiliares:

    ' Función para verificar si un número ya existe en ListaOrigen
    Private Function ExisteEnListaOrigen(ByVal numero As Integer) As Boolean
        ' Verifica si el número ya está en ListaOrigen
        For Each item As ListViewItem In ListaOrigen.Items
            If Integer.Parse(item.Text) = numero Then
                Return True
            End If
        Next
        Return False
    End Function

    ' Función para verificar si un número ya existe en ListaDestino
    Private Function ExisteEnListaDestino(ByVal numero As Integer) As Boolean
        ' Verifica si el número ya está en ListaDestino
        For Each item As ListViewItem In ListaDestino.Items
            If Integer.Parse(item.Text) = numero Then
                Return True
            End If
        Next
        Return False
    End Function

    ' Función para ordenar la lista basada en el parámetro ascendente
    Private Sub OrdenarLista(ascendente As Boolean)
        ' Convertir los elementos de ListaOrigen a un array de enteros
        Dim numeros(ListaOrigen.Items.Count - 1) As Integer
        For i As Integer = 0 To ListaOrigen.Items.Count - 1
            numeros(i) = Integer.Parse(ListaOrigen.Items(i).Text)
        Next

        ' Ordenar el array usando QuickSort
        QuickSort(numeros, 0, numeros.Length - 1, ascendente)

        ' Mostrar el resultado en ListaDestino
        ListaDestino.Items.Clear()
        For Each numero As Integer In numeros
            ListaDestino.Items.Add(New ListViewItem(numero.ToString()))
        Next
    End Sub

    Private Sub ClearListas()
        ' Limpia lista de origen
        ListaOrigen.Items.Clear()
        ListaOrigen.Enabled = False

        ' Limpia lista de destino
        ListaDestino.Items.Clear()
        ListaDestino.Enabled = False
    End Sub

    Private Sub ToggleListas(ByVal enable As Boolean)

        ' Desactiva o activa las listas
        ListaOrigen.Enabled = enable
        ListaDestino.Enabled = enable
    End Sub


    Private Sub ToggleBotonesCondiciones(ByVal enable As Boolean)

        ' Desactiva o activa los botones para ordenar segun condiciones lógicas
        BtnCeroYveinte.Enabled = enable
        BtnMayorQueCincuenta.Enabled = enable
        BtnMenorIgualQueCincuenta.Enabled = enable
    End Sub

    Private Sub ToggleRadioBtns(ByVal enable As Boolean)
        RadioAsc.Enabled = enable
        RadioDesc.Enabled = enable
    End Sub

    Private Sub ToggleGroupBox()

        ' Desmarca el radio de ordenamiento ascendente si está checkado
        If RadioAsc.Checked Then
            RadioAsc.Checked = False
            RadioAsc.Enabled = False

            ' Desmarca el radio de ordenamiento descendente si está checkado
        ElseIf RadioDesc.Checked Then
            RadioDesc.Checked = False
            RadioDesc.Enabled = False
        End If

        ' Desactiva el GroupBox de los métodos de ordenamiento
        OrdenamientoGroupBox.Enabled = False
    End Sub

    ' Codigo de componentes formulario:
    Private Sub BtnAgregarNumero_Click(sender As Object, e As EventArgs) Handles BtnAgregarNumero.Click
        Dim NumeroAgregar As Integer

        ' Si el valor introducido en InputNumero es un entero, entonces...
        If Integer.TryParse(InputNumero.Text, NumeroAgregar) Then
            ' Si  el valor introducido en InputNumero no está en ListaOrigen, agregarlo
            If Not ExisteEnListaOrigen(NumeroAgregar) Then
                ListaOrigen.Items.Add(New ListViewItem(NumeroAgregar.ToString()))
            End If

            If ListaOrigen.Enabled = False Then

                ' Activa la lista de Origen y Destino
                ToggleListas(True)

                ' Activa el GroupBox de los métodos de ordenamiento (asc. y desc.)
                OrdenamientoGroupBox.Enabled = True

                ' Activa los radio btns de los métodos de ordenamiento (asc. y desc.)
                ToggleRadioBtns(True)

                ' Activa los botones para ordenar segun condiciones lógicas
                ToggleBotonesCondiciones(True)


            End If
        End If
    End Sub

    Private Sub BtnNuevoProceso_Click(sender As Object, e As EventArgs) Handles BtnNuevoProceso.Click
        ' Limpia el input para agregar un número
        InputNumero.Clear()

        ' Limpia lista de origen y destino
        ClearListas()

        'Desactiva botón para agregar un número
        BtnAgregarNumero.Enabled = False

        ' Desactiva botones de condiciones (>=50, <50, 0> y <20)
        ToggleBotonesCondiciones(False)

        ' Desactiva el GroupBox y los Radio Buttons relacionados con los metodos de ordenamiento (asc. y desc.)
        ToggleGroupBox()

    End Sub

    Private Sub InputNumero_TextChanged(sender As Object, e As EventArgs) Handles InputNumero.TextChanged
        Dim NumeroIngresado As Integer

        If Integer.TryParse(InputNumero.Text, NumeroIngresado) Then
            BtnAgregarNumero.Enabled = True
        Else
            BtnAgregarNumero.Enabled = False
        End If
    End Sub

    Private Sub BtnMenorIgualQueCincuenta_Click(sender As Object, e As EventArgs) Handles BtnMenorIgualQueCincuenta.Click
        For Each item As ListViewItem In ListaOrigen.Items
            Dim numero As Integer
            ' Intentar convertir el texto del item a entero
            If Integer.TryParse(item.Text, numero) Then
                ' Si el número es menor o igual que 50, añadirlo a ListaDestino
                If numero <= 50 AndAlso Not ExisteEnListaDestino(numero) Then
                    ListaDestino.Items.Add(New ListViewItem(numero.ToString()))
                End If
            End If
        Next
    End Sub

    Private Sub BtnMayorQueCincuenta_Click(sender As Object, e As EventArgs) Handles BtnMayorQueCincuenta.Click
        For Each item As ListViewItem In ListaOrigen.Items
            Dim numero As Integer
            ' Intentar convertir el texto del item a entero
            If Integer.TryParse(item.Text, numero) Then
                ' Si el número es mayor que 50, añadirlo a ListaDestino
                If numero > 50 AndAlso Not ExisteEnListaDestino(numero) Then
                    ListaDestino.Items.Add(New ListViewItem(numero.ToString()))
                End If
            End If
        Next
    End Sub

    Private Sub BtnCeroYveinte_Click(sender As Object, e As EventArgs) Handles BtnCeroYveinte.Click
        For Each item As ListViewItem In ListaOrigen.Items
            Dim numero As Integer
            ' Intentar convertir el texto del item a entero
            If Integer.TryParse(item.Text, numero) Then
                ' Si el número es mayor que 0 y menor que 20, añadirlo a ListaDestino
                If numero > 0 AndAlso numero < 20 AndAlso Not ExisteEnListaDestino(numero) Then
                    ListaDestino.Items.Add(New ListViewItem(numero.ToString()))
                End If
            End If
        Next
    End Sub

    Private Sub RadioAsc_CheckedChanged(sender As Object, e As EventArgs) Handles RadioAsc.CheckedChanged
        If RadioAsc.Checked Then
            OrdenarLista(True)
        End If
    End Sub

    Private Sub RadioDesc_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDesc.CheckedChanged
        If RadioDesc.Checked Then
            OrdenarLista(False)
        End If
    End Sub
End Class
