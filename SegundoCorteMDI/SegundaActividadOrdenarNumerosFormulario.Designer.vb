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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SegundaActividadOrdenarNumerosFormulario))
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
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(30, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 27)
        Label1.TabIndex = 0
        Label1.Text = "Numero:"
        ' 
        ' InputNumero
        ' 
        InputNumero.BackColor = SystemColors.ActiveCaption
        InputNumero.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InputNumero.Location = New Point(126, 41)
        InputNumero.Name = "InputNumero"
        InputNumero.Size = New Size(100, 29)
        InputNumero.TabIndex = 1
        ' 
        ' BtnAgregarNumero
        ' 
        BtnAgregarNumero.BackColor = Color.FromArgb(CByte(55), CByte(181), CByte(81))
        BtnAgregarNumero.Enabled = False
        BtnAgregarNumero.Font = New Font("Comic Sans MS", 12F)
        BtnAgregarNumero.ForeColor = Color.White
        BtnAgregarNumero.Location = New Point(261, 34)
        BtnAgregarNumero.Name = "BtnAgregarNumero"
        BtnAgregarNumero.Size = New Size(121, 71)
        BtnAgregarNumero.TabIndex = 2
        BtnAgregarNumero.Text = "Agregar a la Lista"
        BtnAgregarNumero.UseVisualStyleBackColor = False
        ' 
        ' BtnNuevoProceso
        ' 
        BtnNuevoProceso.BackColor = Color.FromArgb(CByte(255), CByte(100), CByte(3))
        BtnNuevoProceso.Font = New Font("Comic Sans MS", 12F)
        BtnNuevoProceso.ForeColor = Color.White
        BtnNuevoProceso.Location = New Point(514, 34)
        BtnNuevoProceso.Name = "BtnNuevoProceso"
        BtnNuevoProceso.Size = New Size(121, 71)
        BtnNuevoProceso.TabIndex = 3
        BtnNuevoProceso.Text = "Nuevo Proceso"
        BtnNuevoProceso.UseVisualStyleBackColor = False
        ' 
        ' BtnMenorIgualQueCincuenta
        ' 
        BtnMenorIgualQueCincuenta.BackColor = Color.Yellow
        BtnMenorIgualQueCincuenta.Enabled = False
        BtnMenorIgualQueCincuenta.Font = New Font("Comic Sans MS", 12F)
        BtnMenorIgualQueCincuenta.Location = New Point(399, 144)
        BtnMenorIgualQueCincuenta.Name = "BtnMenorIgualQueCincuenta"
        BtnMenorIgualQueCincuenta.Size = New Size(98, 38)
        BtnMenorIgualQueCincuenta.TabIndex = 4
        BtnMenorIgualQueCincuenta.Text = "<= 50"
        BtnMenorIgualQueCincuenta.UseVisualStyleBackColor = False
        ' 
        ' BtnMayorQueCincuenta
        ' 
        BtnMayorQueCincuenta.BackColor = Color.FromArgb(CByte(255), CByte(142), CByte(28))
        BtnMayorQueCincuenta.Enabled = False
        BtnMayorQueCincuenta.Font = New Font("Comic Sans MS", 12F)
        BtnMayorQueCincuenta.Location = New Point(399, 197)
        BtnMayorQueCincuenta.Name = "BtnMayorQueCincuenta"
        BtnMayorQueCincuenta.Size = New Size(98, 36)
        BtnMayorQueCincuenta.TabIndex = 5
        BtnMayorQueCincuenta.Text = "> 50"
        BtnMayorQueCincuenta.UseVisualStyleBackColor = False
        ' 
        ' BtnCeroYveinte
        ' 
        BtnCeroYveinte.BackColor = Color.DarkTurquoise
        BtnCeroYveinte.Enabled = False
        BtnCeroYveinte.Font = New Font("Comic Sans MS", 12F)
        BtnCeroYveinte.Location = New Point(399, 248)
        BtnCeroYveinte.Name = "BtnCeroYveinte"
        BtnCeroYveinte.Size = New Size(98, 56)
        BtnCeroYveinte.TabIndex = 6
        BtnCeroYveinte.Text = ">0 y <20"
        BtnCeroYveinte.UseVisualStyleBackColor = False
        ' 
        ' RadioAsc
        ' 
        RadioAsc.AutoSize = True
        RadioAsc.Font = New Font("Comic Sans MS", 12F)
        RadioAsc.Location = New Point(18, 31)
        RadioAsc.Name = "RadioAsc"
        RadioAsc.Size = New Size(111, 27)
        RadioAsc.TabIndex = 7
        RadioAsc.TabStop = True
        RadioAsc.Text = "Ascendente"
        RadioAsc.UseVisualStyleBackColor = True
        ' 
        ' RadioDesc
        ' 
        RadioDesc.AutoSize = True
        RadioDesc.Font = New Font("Comic Sans MS", 12F)
        RadioDesc.Location = New Point(18, 63)
        RadioDesc.Name = "RadioDesc"
        RadioDesc.Size = New Size(119, 27)
        RadioDesc.TabIndex = 8
        RadioDesc.TabStop = True
        RadioDesc.Text = "Descendente"
        RadioDesc.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(261, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 23)
        Label2.TabIndex = 9
        Label2.Text = "Lista Origen:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Comic Sans MS", 12F, FontStyle.Bold)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(514, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 23)
        Label3.TabIndex = 10
        Label3.Text = "Lista Destino:"
        ' 
        ' ListaDestino
        ' 
        ListaDestino.BackColor = SystemColors.ControlLightLight
        ListaDestino.Enabled = False
        ListaDestino.Font = New Font("Comic Sans MS", 9F)
        ListaDestino.Location = New Point(514, 155)
        ListaDestino.Name = "ListaDestino"
        ListaDestino.Size = New Size(121, 292)
        ListaDestino.TabIndex = 11
        ListaDestino.UseCompatibleStateImageBehavior = False
        ' 
        ' ListaOrigen
        ' 
        ListaOrigen.BackColor = SystemColors.ButtonFace
        ListaOrigen.Enabled = False
        ListaOrigen.Font = New Font("Comic Sans MS", 9F)
        ListaOrigen.Location = New Point(261, 155)
        ListaOrigen.Name = "ListaOrigen"
        ListaOrigen.Size = New Size(121, 292)
        ListaOrigen.TabIndex = 12
        ListaOrigen.UseCompatibleStateImageBehavior = False
        ' 
        ' OrdenamientoGroupBox
        ' 
        OrdenamientoGroupBox.BackColor = Color.Transparent
        OrdenamientoGroupBox.Controls.Add(RadioAsc)
        OrdenamientoGroupBox.Controls.Add(RadioDesc)
        OrdenamientoGroupBox.Enabled = False
        OrdenamientoGroupBox.Font = New Font("Comic Sans MS", 12F)
        OrdenamientoGroupBox.ForeColor = Color.White
        OrdenamientoGroupBox.Location = New Point(30, 124)
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
        BackColor = SystemColors.HotTrack
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(692, 461)
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
        DoubleBuffered = True
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
