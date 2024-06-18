<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SegundaActividadOrdenarNumerosFormulario
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
        Label1 = New Label()
        InputNumero = New TextBox()
        BtnAgregarNumero = New Button()
        BtnNuevoProceso = New Button()
        BtnMenorIgualQueCincuenta = New Button()
        BtnMayorQueCincuenta = New Button()
        BtnCeroYveinte = New Button()
        RadioAsc = New RadioButton()
        RadioDesc = New RadioButton()
        Label2 = New Label()
        Label3 = New Label()
        ListaDestino = New ListView()
        ListaOrigen = New ListView()
        OrdenamientoGroupBox = New GroupBox()
        OrdenamientoGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(30, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 15)
        Label1.TabIndex = 0
        Label1.Text = "Numero:"
        ' 
        ' InputNumero
        ' 
        InputNumero.Location = New Point(116, 34)
        InputNumero.Name = "InputNumero"
        InputNumero.Size = New Size(100, 23)
        InputNumero.TabIndex = 1
        ' 
        ' BtnAgregarNumero
        ' 
        BtnAgregarNumero.Enabled = False
        BtnAgregarNumero.Location = New Point(261, 34)
        BtnAgregarNumero.Name = "BtnAgregarNumero"
        BtnAgregarNumero.Size = New Size(121, 49)
        BtnAgregarNumero.TabIndex = 2
        BtnAgregarNumero.Text = "Agregar a la Lista"
        BtnAgregarNumero.UseVisualStyleBackColor = True
        ' 
        ' BtnNuevoProceso
        ' 
        BtnNuevoProceso.Location = New Point(514, 34)
        BtnNuevoProceso.Name = "BtnNuevoProceso"
        BtnNuevoProceso.Size = New Size(121, 49)
        BtnNuevoProceso.TabIndex = 3
        BtnNuevoProceso.Text = "Nuevo Proceso"
        BtnNuevoProceso.UseVisualStyleBackColor = True
        ' 
        ' BtnMenorIgualQueCincuenta
        ' 
        BtnMenorIgualQueCincuenta.Enabled = False
        BtnMenorIgualQueCincuenta.Location = New Point(410, 128)
        BtnMenorIgualQueCincuenta.Name = "BtnMenorIgualQueCincuenta"
        BtnMenorIgualQueCincuenta.Size = New Size(75, 23)
        BtnMenorIgualQueCincuenta.TabIndex = 4
        BtnMenorIgualQueCincuenta.Text = "<= 50"
        BtnMenorIgualQueCincuenta.UseVisualStyleBackColor = True
        ' 
        ' BtnMayorQueCincuenta
        ' 
        BtnMayorQueCincuenta.Enabled = False
        BtnMayorQueCincuenta.Location = New Point(410, 172)
        BtnMayorQueCincuenta.Name = "BtnMayorQueCincuenta"
        BtnMayorQueCincuenta.Size = New Size(75, 23)
        BtnMayorQueCincuenta.TabIndex = 5
        BtnMayorQueCincuenta.Text = "> 50"
        BtnMayorQueCincuenta.UseVisualStyleBackColor = True
        ' 
        ' BtnCeroYveinte
        ' 
        BtnCeroYveinte.Enabled = False
        BtnCeroYveinte.Location = New Point(410, 222)
        BtnCeroYveinte.Name = "BtnCeroYveinte"
        BtnCeroYveinte.Size = New Size(75, 23)
        BtnCeroYveinte.TabIndex = 6
        BtnCeroYveinte.Text = ">0 y <20"
        BtnCeroYveinte.UseVisualStyleBackColor = True
        ' 
        ' RadioAsc
        ' 
        RadioAsc.AutoSize = True
        RadioAsc.Location = New Point(18, 31)
        RadioAsc.Name = "RadioAsc"
        RadioAsc.Size = New Size(87, 19)
        RadioAsc.TabIndex = 7
        RadioAsc.TabStop = True
        RadioAsc.Text = "Ascendente"
        RadioAsc.UseVisualStyleBackColor = True
        ' 
        ' RadioDesc
        ' 
        RadioDesc.AutoSize = True
        RadioDesc.Location = New Point(18, 63)
        RadioDesc.Name = "RadioDesc"
        RadioDesc.Size = New Size(93, 19)
        RadioDesc.TabIndex = 8
        RadioDesc.TabStop = True
        RadioDesc.Text = "Descendente"
        RadioDesc.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(261, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 15)
        Label2.TabIndex = 9
        Label2.Text = "Lista Origen:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(514, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 10
        Label3.Text = "Lista Destino:"
        ' 
        ' ListaDestino
        ' 
        ListaDestino.Enabled = False
        ListaDestino.Location = New Point(514, 128)
        ListaDestino.Name = "ListaDestino"
        ListaDestino.Size = New Size(121, 291)
        ListaDestino.TabIndex = 11
        ListaDestino.UseCompatibleStateImageBehavior = False
        ' 
        ' ListaOrigen
        ' 
        ListaOrigen.Enabled = False
        ListaOrigen.Location = New Point(261, 128)
        ListaOrigen.Name = "ListaOrigen"
        ListaOrigen.Size = New Size(121, 291)
        ListaOrigen.TabIndex = 12
        ListaOrigen.UseCompatibleStateImageBehavior = False
        ' 
        ' OrdenamientoGroupBox
        ' 
        OrdenamientoGroupBox.Controls.Add(RadioAsc)
        OrdenamientoGroupBox.Controls.Add(RadioDesc)
        OrdenamientoGroupBox.Enabled = False
        OrdenamientoGroupBox.Location = New Point(30, 108)
        OrdenamientoGroupBox.Name = "OrdenamientoGroupBox"
        OrdenamientoGroupBox.Size = New Size(200, 100)
        OrdenamientoGroupBox.TabIndex = 13
        OrdenamientoGroupBox.TabStop = False
        OrdenamientoGroupBox.Text = "Ordenamiento"
        ' 
        ' SegundaActividadOrdenarNumerosFormulario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(692, 450)
        Controls.Add(OrdenamientoGroupBox)
        Controls.Add(ListaOrigen)
        Controls.Add(ListaDestino)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnCeroYveinte)
        Controls.Add(BtnMayorQueCincuenta)
        Controls.Add(BtnMenorIgualQueCincuenta)
        Controls.Add(BtnNuevoProceso)
        Controls.Add(BtnAgregarNumero)
        Controls.Add(InputNumero)
        Controls.Add(Label1)
        Name = "SegundaActividadOrdenarNumerosFormulario"
        Text = "SegundaActividadOrdenarNumerosFormulario"
        OrdenamientoGroupBox.ResumeLayout(False)
        OrdenamientoGroupBox.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents InputNumero As TextBox
    Friend WithEvents BtnAgregarNumero As Button
    Friend WithEvents BtnNuevoProceso As Button
    Friend WithEvents BtnMenorIgualQueCincuenta As Button
    Friend WithEvents BtnMayorQueCincuenta As Button
    Friend WithEvents BtnCeroYveinte As Button
    Friend WithEvents RadioAsc As RadioButton
    Friend WithEvents RadioDesc As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListaDestino As ListView
    Friend WithEvents ListaOrigen As ListView
    Friend WithEvents OrdenamientoGroupBox As GroupBox
End Class
