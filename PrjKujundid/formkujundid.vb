Imports System.Math
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formkujundid

    Private precision As Integer = 0
    Private flag As Integer = 0
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged
        precision = cmb1.SelectedItem
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click

        tootleKuljund(New Romb(txtKylgA.Text, txtKorgus.Text))

    End Sub

    Private Sub btnRoopkulik_Click(sender As Object, e As EventArgs) Handles btnRoopkulik.Click

        tootleKuljund(New Roopkylik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text))

    End Sub
    Private Sub GroupBox1_TextChanged(sender As Object, e As EventArgs) Handles txtKylgB.TextChanged, txtKylgA.TextChanged, txtKorgus.TextChanged, GroupBox1.TextChanged

        Dim kylgA = String.IsNullOrEmpty(txtKylgA.Text)
        Dim kylgB = String.IsNullOrEmpty(txtKylgB.Text)
        Dim korgus = String.IsNullOrEmpty(txtKorgus.Text)

        btnRuut.Enabled = False
        btnKolmnurk.Enabled = False
        btnRistkylik.Enabled = False
        btnRomb.Enabled = False
        btnRoopkulik.Enabled = False

        If Not (txtKylgA.Text = "0" Or txtKylgA.Text = "0" Or txtKorgus.Text = "0") Then
            'ruut
            If Not kylgA And kylgB And korgus Then

                btnRuut.Enabled = True

                If IsNumeric(txtKylgA.Text) Then
                    btnRomb.Enabled = True
                Else
                    MessageBox.Show("is not numeric")
                End If

                'kolmnurk ristkulik
            ElseIf Not kylgA And Not kylgB And korgus Then

                'kas kolmnurk eksiteeri

                If IsNumeric(txtKylgA.Text) And IsNumeric(txtKylgB.Text) Then
                    btnKolmnurk.Enabled = True
                    btnRistkylik.Enabled = True

                    If Double.Parse(txtKylgA.Text) > (2 * Double.Parse(txtKylgB.Text)) Then
                        btnKolmnurk.Enabled = False
                    End If

                Else
                    MessageBox.Show("is not numeric")
                End If

                'roopkulik
            ElseIf Not kylgA And Not kylgB And Not korgus Then

                If IsNumeric(txtKylgA.Text) And IsNumeric(txtKylgB.Text) And IsNumeric(txtKorgus.Text) Then
                    btnRoopkulik.Enabled = True
                Else
                    MessageBox.Show("is not numeric")
                End If

                'romb
            ElseIf Not kylgA And kylgB And Not korgus Then

                If IsNumeric(txtKylgA.Text) And IsNumeric(txtKorgus.Text) Then
                    btnRomb.Enabled = True
                Else
                    MessageBox.Show("is not numeric")
                End If

            End If

        End If

    End Sub

    Private Sub formkujundid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb1.SelectedIndex = 0
    End Sub
End Class
