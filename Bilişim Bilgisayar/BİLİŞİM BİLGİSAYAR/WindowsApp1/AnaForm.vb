Public Class AnaForm



    Private Sub ÜrünGirişiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünGirişiToolStripMenuItem.Click
        Dim UrunChild As New Urun()
        UrunChild.MdiParent = Me
        UrunChild.StartPosition = FormStartPosition.CenterScreen
        UrunChild.Show()
    End Sub

    Private Sub MüşteriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MüşteriToolStripMenuItem.Click
        Dim UrunChild As New Musteri()
        UrunChild.MdiParent = Me
        UrunChild.StartPosition = FormStartPosition.CenterScreen
        UrunChild.Show()
    End Sub

    Private Sub PersonelKayıtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonelKayıtToolStripMenuItem.Click
        Dim UrunChild As New PersonelKayit()
        UrunChild.MdiParent = Me
        UrunChild.StartPosition = FormStartPosition.CenterScreen
        UrunChild.Show()
    End Sub

    Private Sub BakımOnarımToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BakımOnarımToolStripMenuItem.Click
        Dim UrunChild As New BakimFormu()
        UrunChild.MdiParent = Me
        UrunChild.StartPosition = FormStartPosition.CenterScreen
        UrunChild.Show()
    End Sub

    Private Sub ÜrünGruplarınıDüzenleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜrünGruplarınıDüzenleToolStripMenuItem.Click
        Dim UrunChild As New Form4()
        UrunChild.MdiParent = Me
        UrunChild.StartPosition = FormStartPosition.CenterScreen
        UrunChild.Show()
    End Sub

    Private Sub FaturaKayıtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaturaKayıtToolStripMenuItem.Click
        Dim UrunChild As New Fatura()
        UrunChild.MdiParent = Me
        UrunChild.StartPosition = FormStartPosition.CenterScreen
        UrunChild.Show()

    End Sub
End Class