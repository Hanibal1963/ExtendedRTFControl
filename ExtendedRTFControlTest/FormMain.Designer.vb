<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ExtendedRTF = New SchlumpfSoft.Controls.ExtendedRTFControl.ExtendedRTF()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExtendedRTF
        '
        Me.ExtendedRTF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExtendedRTF.Location = New System.Drawing.Point(3, 28)
        Me.ExtendedRTF.Name = "ExtendedRTF"
        Me.ExtendedRTF.SelectionBold = False
        Me.ExtendedRTF.SelectionFontSize = 8.25!
        Me.ExtendedRTF.SelectionForeColor = System.Drawing.Color.Black
        Me.ExtendedRTF.SelectionItalic = False
        Me.ExtendedRTF.SelectionLeftIndent = 0
        Me.ExtendedRTF.SelectionStrikeout = False
        Me.ExtendedRTF.SelectionUnderline = False
        Me.ExtendedRTF.Size = New System.Drawing.Size(671, 358)
        Me.ExtendedRTF.TabIndex = 0
        Me.ExtendedRTF.Text = ""
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 1
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.Controls.Add(Me.ToolStrip, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ExtendedRTF, 0, 2)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 3
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(677, 389)
        Me.TableLayoutPanel.TabIndex = 1
        '
        'ToolStrip
        '
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(677, 25)
        Me.ToolStrip.TabIndex = 1
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 389)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ExtendedRTF As SchlumpfSoft.Controls.ExtendedRTFControl.ExtendedRTF
    Private WithEvents TableLayoutPanel As TableLayoutPanel
    Private WithEvents ToolStrip As ToolStrip
End Class
