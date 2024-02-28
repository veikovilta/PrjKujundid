Public Class formkujundid

    Private Sub tootleKuljund(ByRef kujund As Kujund)

        lblTyyp.Text = kujund.annaTyyp

        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmberMoot
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click

        Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
        tootleKuljund(objektKolmnurk)

    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click

        Dim objektRuut As New Ruut(txtKylgA.Text)
        tootleKuljund(objektRuut)

    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click

        tootleKuljund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))

    End Sub

End Class
