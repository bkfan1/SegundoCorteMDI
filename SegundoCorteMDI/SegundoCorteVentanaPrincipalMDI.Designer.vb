<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SegundoCorteVentanaPrincipalMDI
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
        components = New ComponentModel.Container()
        MenuStrip = New MenuStrip()
        ToolsMenu = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        OptionsToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        HelpMenu = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        ToolTip = New ToolTip(components)
        OpenFileDialog1 = New OpenFileDialog()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        MenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Items.AddRange(New ToolStripItem() {ToolsMenu, HelpMenu})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(7, 2, 0, 2)
        MenuStrip.Size = New Size(868, 28)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' ToolsMenu
        ' 
        ToolsMenu.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, OptionsToolStripMenuItem, SalirToolStripMenuItem})
        ToolsMenu.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ToolsMenu.Name = "ToolsMenu"
        ToolsMenu.Size = New Size(103, 24)
        ToolsMenu.Text = "&Actividades"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(183, 24)
        ToolStripMenuItem2.Text = "&Primera (10%)"
        ' 
        ' OptionsToolStripMenuItem
        ' 
        OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        OptionsToolStripMenuItem.Size = New Size(183, 24)
        OptionsToolStripMenuItem.Text = "&Segunda (20%)"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(183, 24)
        SalirToolStripMenuItem.Text = "Salir"
        ' 
        ' HelpMenu
        ' 
        HelpMenu.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem1, ToolStripSeparator8, ToolStripMenuItem3, AboutToolStripMenuItem})
        HelpMenu.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HelpMenu.Name = "HelpMenu"
        HelpMenu.Size = New Size(65, 24)
        HelpMenu.Text = "Ay&uda"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(180, 24)
        ToolStripMenuItem1.Text = "&Ayuda"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(177, 6)
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(232, 24)
        AboutToolStripMenuItem.Text = "Acerca del Estudiante"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(180, 24)
        ToolStripMenuItem3.Text = "&Acerca de..."
        ' 
        ' SegundoCorteVentanaPrincipalMDI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(868, 628)
        Controls.Add(MenuStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 3, 4, 3)
        Name = "SegundoCorteVentanaPrincipalMDI"
        Text = "SegundoCorteVentanaPrincipalMDI"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem

End Class
