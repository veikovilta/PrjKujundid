Imports System.Math

Public Class formkujundid

    Public precision As Integer = 0

    Private Sub tootleKuljund(ByRef kujund As Kujund)

        lblTyyp.Text = kujund.annaTyyp

        Dim pindala As Double = Math.Round(kujund.leiaPindala, precision)
        Dim Ymbermoot As Double = Math.Round(kujund.leiaYmberMoot, precision)

        txtPindala.Text = pindala
        txtYmbermoot.Text = Ymbermoot

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        precision = ComboBox1.SelectedItem
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click

        tootleKuljund(New Romb(txtKylgA.Text, txtKorgus.Text))

    End Sub

    Private Sub btnRoopkulik_Click(sender As Object, e As EventArgs) Handles btnRoopkulik.Click

        tootleKuljund(New Roopkylik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text))

    End Sub
End Class
