﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimeraActividadFormularioMDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrimeraActividadFormularioMDI))
        Label1 = New Label()
        LabelMultiplicacion1 = New Label()
        InputNumeroTabla = New TextBox()
        InputRespuesta1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        InputRespuesta2 = New TextBox()
        LabelMultiplicacion2 = New Label()
        Label6 = New Label()
        InputRespuesta3 = New TextBox()
        LabelMultiplicacion3 = New Label()
        Label8 = New Label()
        InputRespuesta4 = New TextBox()
        LabelMultiplicacion4 = New Label()
        Label10 = New Label()
        InputRespuesta5 = New TextBox()
        LabelMultiplicacion5 = New Label()
        Label12 = New Label()
        InputRespuesta6 = New TextBox()
        LabelMultiplicacion6 = New Label()
        Label14 = New Label()
        InputRespuesta7 = New TextBox()
        LabelMultiplicacion7 = New Label()
        Label16 = New Label()
        InputRespuesta8 = New TextBox()
        LabelMultiplicacion8 = New Label()
        Label18 = New Label()
        InputRespuesta9 = New TextBox()
        LabelMultiplicacion9 = New Label()
        Label20 = New Label()
        InputRespuesta10 = New TextBox()
        LabelMultiplicacion10 = New Label()
        BtnComenzar = New Button()
        BtnEvaluar = New Button()
        BtnNuevaEvaluacion = New Button()
        BtnSalir = New Button()
        LabelTituloPuntaje = New Label()
        LabelTituloPuntaje2 = New Label()
        LabelPuntaje = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.Location = New Point(25, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 26)
        Label1.TabIndex = 0
        Label1.Text = "Número de Tabla a Aprender: "
        ' 
        ' LabelMultiplicacion1
        ' 
        LabelMultiplicacion1.AutoSize = True
        LabelMultiplicacion1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        LabelMultiplicacion1.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion1.Location = New Point(30, 109)
        LabelMultiplicacion1.Name = "LabelMultiplicacion1"
        LabelMultiplicacion1.Size = New Size(41, 26)
        LabelMultiplicacion1.TabIndex = 1
        LabelMultiplicacion1.Text = "1 X"
        ' 
        ' InputNumeroTabla
        ' 
        InputNumeroTabla.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        InputNumeroTabla.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        InputNumeroTabla.Location = New Point(319, 48)
        InputNumeroTabla.Margin = New Padding(3, 4, 3, 4)
        InputNumeroTabla.Name = "InputNumeroTabla"
        InputNumeroTabla.Size = New Size(100, 28)
        InputNumeroTabla.TabIndex = 11
        ' 
        ' InputRespuesta1
        ' 
        InputRespuesta1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        InputRespuesta1.Enabled = False
        InputRespuesta1.ForeColor = SystemColors.WindowText
        InputRespuesta1.Location = New Point(150, 112)
        InputRespuesta1.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta1.Name = "InputRespuesta1"
        InputRespuesta1.Size = New Size(58, 27)
        InputRespuesta1.TabIndex = 12
        InputRespuesta1.Tag = "InputRespuesta1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label3.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(114, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(22, 26)
        Label3.TabIndex = 13
        Label3.Text = "="
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label4.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(114, 160)
        Label4.Name = "Label4"
        Label4.Size = New Size(22, 26)
        Label4.TabIndex = 16
        Label4.Text = "="
        ' 
        ' InputRespuesta2
        ' 
        InputRespuesta2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        InputRespuesta2.Enabled = False
        InputRespuesta2.Location = New Point(150, 163)
        InputRespuesta2.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta2.Name = "InputRespuesta2"
        InputRespuesta2.Size = New Size(58, 27)
        InputRespuesta2.TabIndex = 15
        ' 
        ' LabelMultiplicacion2
        ' 
        LabelMultiplicacion2.AutoSize = True
        LabelMultiplicacion2.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LabelMultiplicacion2.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion2.Location = New Point(30, 160)
        LabelMultiplicacion2.Name = "LabelMultiplicacion2"
        LabelMultiplicacion2.Size = New Size(44, 26)
        LabelMultiplicacion2.TabIndex = 14
        LabelMultiplicacion2.Text = "2 X"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label6.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(114, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(22, 26)
        Label6.TabIndex = 19
        Label6.Text = "="
        ' 
        ' InputRespuesta3
        ' 
        InputRespuesta3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        InputRespuesta3.Enabled = False
        InputRespuesta3.Location = New Point(150, 216)
        InputRespuesta3.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta3.Name = "InputRespuesta3"
        InputRespuesta3.Size = New Size(58, 27)
        InputRespuesta3.TabIndex = 18
        ' 
        ' LabelMultiplicacion3
        ' 
        LabelMultiplicacion3.AutoSize = True
        LabelMultiplicacion3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        LabelMultiplicacion3.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion3.Location = New Point(30, 213)
        LabelMultiplicacion3.Name = "LabelMultiplicacion3"
        LabelMultiplicacion3.Size = New Size(44, 26)
        LabelMultiplicacion3.TabIndex = 17
        LabelMultiplicacion3.Text = "3 X"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label8.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(114, 267)
        Label8.Name = "Label8"
        Label8.Size = New Size(22, 26)
        Label8.TabIndex = 22
        Label8.Text = "="
        ' 
        ' InputRespuesta4
        ' 
        InputRespuesta4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        InputRespuesta4.Enabled = False
        InputRespuesta4.Location = New Point(150, 269)
        InputRespuesta4.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta4.Name = "InputRespuesta4"
        InputRespuesta4.Size = New Size(58, 27)
        InputRespuesta4.TabIndex = 21
        ' 
        ' LabelMultiplicacion4
        ' 
        LabelMultiplicacion4.AutoSize = True
        LabelMultiplicacion4.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LabelMultiplicacion4.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion4.Location = New Point(30, 267)
        LabelMultiplicacion4.Name = "LabelMultiplicacion4"
        LabelMultiplicacion4.Size = New Size(44, 26)
        LabelMultiplicacion4.TabIndex = 20
        LabelMultiplicacion4.Text = "4 X"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label10.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(114, 324)
        Label10.Name = "Label10"
        Label10.Size = New Size(22, 26)
        Label10.TabIndex = 25
        Label10.Text = "="
        ' 
        ' InputRespuesta5
        ' 
        InputRespuesta5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        InputRespuesta5.Enabled = False
        InputRespuesta5.Location = New Point(150, 327)
        InputRespuesta5.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta5.Name = "InputRespuesta5"
        InputRespuesta5.Size = New Size(58, 27)
        InputRespuesta5.TabIndex = 24
        ' 
        ' LabelMultiplicacion5
        ' 
        LabelMultiplicacion5.AutoSize = True
        LabelMultiplicacion5.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        LabelMultiplicacion5.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion5.Location = New Point(30, 324)
        LabelMultiplicacion5.Name = "LabelMultiplicacion5"
        LabelMultiplicacion5.Size = New Size(44, 26)
        LabelMultiplicacion5.TabIndex = 23
        LabelMultiplicacion5.Text = "5 X"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label12.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(114, 375)
        Label12.Name = "Label12"
        Label12.Size = New Size(22, 26)
        Label12.TabIndex = 28
        Label12.Text = "="
        ' 
        ' InputRespuesta6
        ' 
        InputRespuesta6.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        InputRespuesta6.Enabled = False
        InputRespuesta6.Location = New Point(150, 377)
        InputRespuesta6.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta6.Name = "InputRespuesta6"
        InputRespuesta6.Size = New Size(58, 27)
        InputRespuesta6.TabIndex = 27
        ' 
        ' LabelMultiplicacion6
        ' 
        LabelMultiplicacion6.AutoSize = True
        LabelMultiplicacion6.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LabelMultiplicacion6.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion6.Location = New Point(30, 375)
        LabelMultiplicacion6.Name = "LabelMultiplicacion6"
        LabelMultiplicacion6.Size = New Size(44, 26)
        LabelMultiplicacion6.TabIndex = 26
        LabelMultiplicacion6.Text = "6 X"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label14.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(114, 428)
        Label14.Name = "Label14"
        Label14.Size = New Size(22, 26)
        Label14.TabIndex = 31
        Label14.Text = "="
        ' 
        ' InputRespuesta7
        ' 
        InputRespuesta7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        InputRespuesta7.Enabled = False
        InputRespuesta7.Location = New Point(150, 431)
        InputRespuesta7.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta7.Name = "InputRespuesta7"
        InputRespuesta7.Size = New Size(58, 27)
        InputRespuesta7.TabIndex = 30
        ' 
        ' LabelMultiplicacion7
        ' 
        LabelMultiplicacion7.AutoSize = True
        LabelMultiplicacion7.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        LabelMultiplicacion7.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion7.Location = New Point(30, 428)
        LabelMultiplicacion7.Name = "LabelMultiplicacion7"
        LabelMultiplicacion7.Size = New Size(44, 26)
        LabelMultiplicacion7.TabIndex = 29
        LabelMultiplicacion7.Text = "7 X"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label16.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(114, 479)
        Label16.Name = "Label16"
        Label16.Size = New Size(22, 26)
        Label16.TabIndex = 34
        Label16.Text = "="
        ' 
        ' InputRespuesta8
        ' 
        InputRespuesta8.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        InputRespuesta8.Enabled = False
        InputRespuesta8.Location = New Point(150, 481)
        InputRespuesta8.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta8.Name = "InputRespuesta8"
        InputRespuesta8.Size = New Size(58, 27)
        InputRespuesta8.TabIndex = 33
        ' 
        ' LabelMultiplicacion8
        ' 
        LabelMultiplicacion8.AutoSize = True
        LabelMultiplicacion8.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LabelMultiplicacion8.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion8.Location = New Point(30, 479)
        LabelMultiplicacion8.Name = "LabelMultiplicacion8"
        LabelMultiplicacion8.Size = New Size(44, 26)
        LabelMultiplicacion8.TabIndex = 32
        LabelMultiplicacion8.Text = "8 X"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Label18.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(114, 535)
        Label18.Name = "Label18"
        Label18.Size = New Size(22, 26)
        Label18.TabIndex = 37
        Label18.Text = "="
        ' 
        ' InputRespuesta9
        ' 
        InputRespuesta9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        InputRespuesta9.Enabled = False
        InputRespuesta9.Location = New Point(150, 537)
        InputRespuesta9.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta9.Name = "InputRespuesta9"
        InputRespuesta9.Size = New Size(58, 27)
        InputRespuesta9.TabIndex = 36
        ' 
        ' LabelMultiplicacion9
        ' 
        LabelMultiplicacion9.AutoSize = True
        LabelMultiplicacion9.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        LabelMultiplicacion9.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion9.Location = New Point(30, 535)
        LabelMultiplicacion9.Name = "LabelMultiplicacion9"
        LabelMultiplicacion9.Size = New Size(44, 26)
        LabelMultiplicacion9.TabIndex = 35
        LabelMultiplicacion9.Text = "9 X"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        Label20.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(114, 587)
        Label20.Name = "Label20"
        Label20.Size = New Size(22, 26)
        Label20.TabIndex = 40
        Label20.Text = "="
        ' 
        ' InputRespuesta10
        ' 
        InputRespuesta10.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        InputRespuesta10.Enabled = False
        InputRespuesta10.Location = New Point(150, 589)
        InputRespuesta10.Margin = New Padding(3, 4, 3, 4)
        InputRespuesta10.Name = "InputRespuesta10"
        InputRespuesta10.Size = New Size(58, 27)
        InputRespuesta10.TabIndex = 39
        ' 
        ' LabelMultiplicacion10
        ' 
        LabelMultiplicacion10.AutoSize = True
        LabelMultiplicacion10.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        LabelMultiplicacion10.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelMultiplicacion10.Location = New Point(25, 587)
        LabelMultiplicacion10.Name = "LabelMultiplicacion10"
        LabelMultiplicacion10.Size = New Size(53, 26)
        LabelMultiplicacion10.TabIndex = 38
        LabelMultiplicacion10.Text = "10 X"
        ' 
        ' BtnComenzar
        ' 
        BtnComenzar.BackColor = SystemColors.ActiveCaptionText
        BtnComenzar.BackgroundImage = CType(resources.GetObject("BtnComenzar.BackgroundImage"), Image)
        BtnComenzar.Enabled = False
        BtnComenzar.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnComenzar.ForeColor = SystemColors.ControlText
        BtnComenzar.Location = New Point(319, 109)
        BtnComenzar.Margin = New Padding(3, 4, 3, 4)
        BtnComenzar.Name = "BtnComenzar"
        BtnComenzar.Size = New Size(165, 47)
        BtnComenzar.TabIndex = 41
        BtnComenzar.Text = "Comenzar"
        BtnComenzar.UseVisualStyleBackColor = False
        ' 
        ' BtnEvaluar
        ' 
        BtnEvaluar.BackColor = SystemColors.ActiveCaptionText
        BtnEvaluar.BackgroundImage = CType(resources.GetObject("BtnEvaluar.BackgroundImage"), Image)
        BtnEvaluar.Enabled = False
        BtnEvaluar.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnEvaluar.Location = New Point(319, 179)
        BtnEvaluar.Margin = New Padding(3, 4, 3, 4)
        BtnEvaluar.Name = "BtnEvaluar"
        BtnEvaluar.Size = New Size(165, 47)
        BtnEvaluar.TabIndex = 42
        BtnEvaluar.Tag = "BtnEvaluar"
        BtnEvaluar.Text = "Evaluar"
        BtnEvaluar.UseVisualStyleBackColor = False
        ' 
        ' BtnNuevaEvaluacion
        ' 
        BtnNuevaEvaluacion.BackColor = SystemColors.ActiveCaptionText
        BtnNuevaEvaluacion.BackgroundImage = CType(resources.GetObject("BtnNuevaEvaluacion.BackgroundImage"), Image)
        BtnNuevaEvaluacion.Enabled = False
        BtnNuevaEvaluacion.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnNuevaEvaluacion.Location = New Point(319, 253)
        BtnNuevaEvaluacion.Margin = New Padding(3, 4, 3, 4)
        BtnNuevaEvaluacion.Name = "BtnNuevaEvaluacion"
        BtnNuevaEvaluacion.Size = New Size(165, 47)
        BtnNuevaEvaluacion.TabIndex = 43
        BtnNuevaEvaluacion.Text = "Nueva Evaluación"
        BtnNuevaEvaluacion.UseVisualStyleBackColor = False
        ' 
        ' BtnSalir
        ' 
        BtnSalir.BackColor = SystemColors.ActiveCaptionText
        BtnSalir.BackgroundImage = CType(resources.GetObject("BtnSalir.BackgroundImage"), Image)
        BtnSalir.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnSalir.Location = New Point(319, 327)
        BtnSalir.Margin = New Padding(3, 4, 3, 4)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(165, 47)
        BtnSalir.TabIndex = 44
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = False
        ' 
        ' LabelTituloPuntaje
        ' 
        LabelTituloPuntaje.AutoSize = True
        LabelTituloPuntaje.BackColor = Color.Cyan
        LabelTituloPuntaje.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTituloPuntaje.Location = New Point(315, 399)
        LabelTituloPuntaje.Name = "LabelTituloPuntaje"
        LabelTituloPuntaje.Size = New Size(117, 23)
        LabelTituloPuntaje.TabIndex = 45
        LabelTituloPuntaje.Tag = "LabelTituloPuntaje"
        LabelTituloPuntaje.Text = "Usted obtuvo: "
        LabelTituloPuntaje.Visible = False
        ' 
        ' LabelTituloPuntaje2
        ' 
        LabelTituloPuntaje2.AutoSize = True
        LabelTituloPuntaje2.BackColor = Color.Yellow
        LabelTituloPuntaje2.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTituloPuntaje2.Location = New Point(361, 445)
        LabelTituloPuntaje2.Name = "LabelTituloPuntaje2"
        LabelTituloPuntaje2.Size = New Size(69, 26)
        LabelTituloPuntaje2.TabIndex = 47
        LabelTituloPuntaje2.Tag = "LabelTituloPuntaje2"
        LabelTituloPuntaje2.Text = "Puntos"
        LabelTituloPuntaje2.Visible = False
        ' 
        ' LabelPuntaje
        ' 
        LabelPuntaje.AutoSize = True
        LabelPuntaje.BackColor = Color.Yellow
        LabelPuntaje.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelPuntaje.Location = New Point(319, 445)
        LabelPuntaje.Name = "LabelPuntaje"
        LabelPuntaje.Size = New Size(24, 26)
        LabelPuntaje.TabIndex = 48
        LabelPuntaje.Tag = "LabelPuntaje"
        LabelPuntaje.Text = "0"
        LabelPuntaje.Visible = False
        ' 
        ' PrimeraActividadFormularioMDI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(593, 687)
        Controls.Add(LabelPuntaje)
        Controls.Add(LabelTituloPuntaje2)
        Controls.Add(LabelTituloPuntaje)
        Controls.Add(BtnSalir)
        Controls.Add(BtnNuevaEvaluacion)
        Controls.Add(BtnEvaluar)
        Controls.Add(BtnComenzar)
        Controls.Add(Label20)
        Controls.Add(InputRespuesta10)
        Controls.Add(LabelMultiplicacion10)
        Controls.Add(Label18)
        Controls.Add(InputRespuesta9)
        Controls.Add(LabelMultiplicacion9)
        Controls.Add(Label16)
        Controls.Add(InputRespuesta8)
        Controls.Add(LabelMultiplicacion8)
        Controls.Add(Label14)
        Controls.Add(InputRespuesta7)
        Controls.Add(LabelMultiplicacion7)
        Controls.Add(Label12)
        Controls.Add(InputRespuesta6)
        Controls.Add(LabelMultiplicacion6)
        Controls.Add(Label10)
        Controls.Add(InputRespuesta5)
        Controls.Add(LabelMultiplicacion5)
        Controls.Add(Label8)
        Controls.Add(InputRespuesta4)
        Controls.Add(LabelMultiplicacion4)
        Controls.Add(Label6)
        Controls.Add(InputRespuesta3)
        Controls.Add(LabelMultiplicacion3)
        Controls.Add(Label4)
        Controls.Add(InputRespuesta2)
        Controls.Add(LabelMultiplicacion2)
        Controls.Add(Label3)
        Controls.Add(InputRespuesta1)
        Controls.Add(InputNumeroTabla)
        Controls.Add(LabelMultiplicacion1)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "PrimeraActividadFormularioMDI"
        Text = "PrimeraActividadFormularioMDI"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelMultiplicacion1 As Label
    Friend WithEvents InputNumeroTabla As TextBox
    Friend WithEvents InputRespuesta1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InputRespuesta2 As TextBox
    Friend WithEvents LabelMultiplicacion2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents InputRespuesta3 As TextBox
    Friend WithEvents LabelMultiplicacion3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents InputRespuesta4 As TextBox
    Friend WithEvents LabelMultiplicacion4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents InputRespuesta5 As TextBox
    Friend WithEvents LabelMultiplicacion5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents InputRespuesta6 As TextBox
    Friend WithEvents LabelMultiplicacion6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents InputRespuesta7 As TextBox
    Friend WithEvents LabelMultiplicacion7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents InputRespuesta8 As TextBox
    Friend WithEvents LabelMultiplicacion8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents InputRespuesta9 As TextBox
    Friend WithEvents LabelMultiplicacion9 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents InputRespuesta10 As TextBox
    Friend WithEvents LabelMultiplicacion10 As Label
    Friend WithEvents BtnComenzar As Button
    Friend WithEvents BtnEvaluar As Button
    Friend WithEvents BtnNuevaEvaluacion As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LabelTituloPuntaje As Label
    Friend WithEvents LabelTituloPuntaje2 As Label
    Friend WithEvents LabelPuntaje As Label
End Class
