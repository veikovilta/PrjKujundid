Imports System.Math
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formkujundid

    Private precision As Integer = 0
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
    Private Sub GroupBox1_TextChanged(sender As Object, e As EventArgs) Handles txtKylgB.TextChanged, txtKylgA.TextChanged, txtKorgus.TextChanged, GroupBox1.TextChanged

        Dim kylgA = String.IsNullOrEmpty(txtKylgA.Text)
        Dim kylgB = String.IsNullOrEmpty(txtKylgB.Text)
        Dim korgus = String.IsNullOrEmpty(txtKorgus.Text)

        btnRuut.Enabled = False
        btnKolmnurk.Enabled = False
        btnRistkylik.Enabled = False
        btnRomb.Enabled = False
        btnRoopkulik.Enabled = False

        'ruut
        If Not kylgA And kylgB And korgus Then

            If Double.Parse(txtKylgA.Text) Then
                btnRuut.Enabled = True
            End If

            'kolmnurk ristkulik
        ElseIf Not kylgA And Not kylgB And korgus Then

            If Double.Parse(txtKylgA.Text) And Double.Parse(txtKylgB.Text) Then
                btnKolmnurk.Enabled = True
                btnRistkylik.Enabled = True
            End If

            'kas kolmnurk eksiteerib
            If Double.Parse(txtKylgA.Text) > (2 * Double.Parse(txtKylgB.Text)) Then
                btnKolmnurk.Enabled = False
            End If
            'roopkulik
        ElseIf Not kylgA And Not kylgB And Not korgus Then

            If Double.Parse(txtKylgA.Text) And Double.Parse(txtKylgB.Text) And Double.Parse(txtKorgus.Text) Then
                btnRoopkulik.Enabled = True
            End If

            'romb
        ElseIf Not kylgA And kylgB And Not korgus Then

            If Double.Parse(txtKylgA.Text) And Double.Parse(txtKorgus.Text) Then
                btnRomb.Enabled = True
            End If

        End If
    End Sub

    Private Sub txtKylgB_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtKylgB.KeyPress, txtKylgA.KeyPress, txtKorgus.KeyPress, MyBase.KeyPress
        If (Not Char.IsDigit(e.KeyChar)) And (e.KeyChar <> ControlChars.Back) Then
            ' If not a digit or backspace, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub formkujundid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class
