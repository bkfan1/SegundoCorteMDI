Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AxAcroPDFLib

Public Class SegundoCorteVentanaPrincipalMDI

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Dim FileName = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Dim FileName = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm In MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ToolsMenu_Click(sender As Object, e As EventArgs) Handles ToolsMenu.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        PrimeraActividadFormularioMDI.MdiParent = Me
        PrimeraActividadFormularioMDI.Show()

    End Sub

    Private Sub SegundoCorteVentanaPrincipalMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'Codigo del componente de Adobe Acrobat Reader
        'Link al tutorial de como implementarlo: https://youtu.be/003NF5aRrhM?si=EGJTpWwj-jhai04x
        'If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
        'PdfReader.src = OpenFileDialog1.FileName
        'End If

        ' Codigo para abrir el PDF usando el objeto Process (navegador)
        'Dim URL As String = "https://drive.google.com/file/d/1N5DLisQhZCv3aou9-291aak7P1NHUBD2/view?usp=drive_link"

        'Puedes cambiar chrome.exe por el ejecutable de otro navegador (ej: firefox.exe, opera.exe)
        'Para probar con distintos navegadores
        'Dim browser As String = "chrome.exe"

        'Process.Start(browser, URL)

        ' Dim rutaDefault = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        'Dim fileDefault = "nombrearchivo.pdf"

        'Dim abrir As New OpenFileDialog
        'abrir.InitialDirectory = rutaDefault
        'abrir.Filter = "Archivos PDF|*.pdf"

        'If File.Exists(Path.Combine(rutaDefault, fileDefault)) Then
        'Nombre de archivo que se cargará por defecto, si existe en la ruta
        'abrir.FileName = fileDefault
        'End If

        'If abrir.ShowDialog = DialogResult.OK Then
        'AxAcropdf1.LoadFile(abrir.FileName)
        ' End If


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim iexit As DialogResult
        iexit = MessageBox.Show("¿Realmente desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iexit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        PdfEstudianteFormularioMDI.MdiParent = Me
        PdfEstudianteFormularioMDI.Show()
    End Sub
End Class
