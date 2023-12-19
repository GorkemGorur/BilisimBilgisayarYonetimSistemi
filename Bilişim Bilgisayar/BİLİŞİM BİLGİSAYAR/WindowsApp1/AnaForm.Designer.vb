<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KAYITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünGirişiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BakımOnarımToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KAYITToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MüşteriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonelKayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruplamaFaturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜrünGruplarınıDüzenleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturaKayıtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(392, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(369, 36)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Bilişim Bilgisayar Yönetim Sistemi    "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KAYITToolStripMenuItem, Me.KAYITToolStripMenuItem1, Me.GruplamaFaturaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1196, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KAYITToolStripMenuItem
        '
        Me.KAYITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜrünGirişiToolStripMenuItem, Me.BakımOnarımToolStripMenuItem})
        Me.KAYITToolStripMenuItem.Name = "KAYITToolStripMenuItem"
        Me.KAYITToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.KAYITToolStripMenuItem.Text = "Ürün"
        '
        'ÜrünGirişiToolStripMenuItem
        '
        Me.ÜrünGirişiToolStripMenuItem.Name = "ÜrünGirişiToolStripMenuItem"
        Me.ÜrünGirişiToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ÜrünGirişiToolStripMenuItem.Text = "Ürün Girişi"
        '
        'BakımOnarımToolStripMenuItem
        '
        Me.BakımOnarımToolStripMenuItem.Name = "BakımOnarımToolStripMenuItem"
        Me.BakımOnarımToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.BakımOnarımToolStripMenuItem.Text = "Bakım Onarım"
        '
        'KAYITToolStripMenuItem1
        '
        Me.KAYITToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MüşteriToolStripMenuItem, Me.PersonelKayıtToolStripMenuItem})
        Me.KAYITToolStripMenuItem1.Name = "KAYITToolStripMenuItem1"
        Me.KAYITToolStripMenuItem1.Size = New System.Drawing.Size(58, 20)
        Me.KAYITToolStripMenuItem1.Text = "Kayıtlar"
        '
        'MüşteriToolStripMenuItem
        '
        Me.MüşteriToolStripMenuItem.Name = "MüşteriToolStripMenuItem"
        Me.MüşteriToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.MüşteriToolStripMenuItem.Text = "Müşteri Kayıt"
        '
        'PersonelKayıtToolStripMenuItem
        '
        Me.PersonelKayıtToolStripMenuItem.Name = "PersonelKayıtToolStripMenuItem"
        Me.PersonelKayıtToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PersonelKayıtToolStripMenuItem.Text = "Personel Kayıt"
        '
        'GruplamaFaturaToolStripMenuItem
        '
        Me.GruplamaFaturaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜrünGruplarınıDüzenleToolStripMenuItem, Me.FaturaKayıtToolStripMenuItem})
        Me.GruplamaFaturaToolStripMenuItem.Name = "GruplamaFaturaToolStripMenuItem"
        Me.GruplamaFaturaToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.GruplamaFaturaToolStripMenuItem.Text = "Gruplama/Fatura"
        '
        'ÜrünGruplarınıDüzenleToolStripMenuItem
        '
        Me.ÜrünGruplarınıDüzenleToolStripMenuItem.Name = "ÜrünGruplarınıDüzenleToolStripMenuItem"
        Me.ÜrünGruplarınıDüzenleToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.ÜrünGruplarınıDüzenleToolStripMenuItem.Text = "Ürün Gruplarını Düzenle"
        '
        'FaturaKayıtToolStripMenuItem
        '
        Me.FaturaKayıtToolStripMenuItem.Name = "FaturaKayıtToolStripMenuItem"
        Me.FaturaKayıtToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.FaturaKayıtToolStripMenuItem.Text = "Fatura Kayıt"
        '
        'AnaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1196, 622)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AnaForm"
        Me.Text = "Ana Menü"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KAYITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KAYITToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ÜrünGirişiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MüşteriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonelKayıtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GruplamaFaturaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÜrünGruplarınıDüzenleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaturaKayıtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BakımOnarımToolStripMenuItem As ToolStripMenuItem
End Class
