<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formkujundid
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblKylgB = New System.Windows.Forms.Label()
        Me.lblKylgA = New System.Windows.Forms.Label()
        Me.txtKylgB = New System.Windows.Forms.TextBox()
        Me.txtKylgA = New System.Windows.Forms.TextBox()
        Me.grpbKujundid = New System.Windows.Forms.GroupBox()
        Me.btnRistkylik = New System.Windows.Forms.Button()
        Me.btnRuut = New System.Windows.Forms.Button()
        Me.btnKolmnurk = New System.Windows.Forms.Button()
        Me.txtPindala = New System.Windows.Forms.TextBox()
        Me.txtYmbermoot = New System.Windows.Forms.TextBox()
        Me.lblTyyp = New System.Windows.Forms.Label()
        Me.lblKujundiTyyp = New System.Windows.Forms.Label()
        Me.lblUmbermoot = New System.Windows.Forms.Label()
        Me.lblPindala = New System.Windows.Forms.Label()
        Me.lblTulemused = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grpbKujundid.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblKylgB)
        Me.GroupBox1.Controls.Add(Me.lblKylgA)
        Me.GroupBox1.Controls.Add(Me.txtKylgB)
        Me.GroupBox1.Controls.Add(Me.txtKylgA)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Algandmed"
        '
        'lblKylgB
        '
        Me.lblKylgB.AutoSize = True
        Me.lblKylgB.Location = New System.Drawing.Point(67, 93)
        Me.lblKylgB.Name = "lblKylgB"
        Me.lblKylgB.Size = New System.Drawing.Size(35, 20)
        Me.lblKylgB.TabIndex = 3
        Me.lblKylgB.Text = "b = "
        '
        'lblKylgA
        '
        Me.lblKylgA.AutoSize = True
        Me.lblKylgA.Location = New System.Drawing.Point(63, 47)
        Me.lblKylgA.Name = "lblKylgA"
        Me.lblKylgA.Size = New System.Drawing.Size(31, 20)
        Me.lblKylgA.TabIndex = 2
        Me.lblKylgA.Text = "a ="
        '
        'txtKylgB
        '
        Me.txtKylgB.Location = New System.Drawing.Point(100, 93)
        Me.txtKylgB.Name = "txtKylgB"
        Me.txtKylgB.Size = New System.Drawing.Size(135, 26)
        Me.txtKylgB.TabIndex = 1
        '
        'txtKylgA
        '
        Me.txtKylgA.Location = New System.Drawing.Point(100, 41)
        Me.txtKylgA.Name = "txtKylgA"
        Me.txtKylgA.Size = New System.Drawing.Size(135, 26)
        Me.txtKylgA.TabIndex = 0
        '
        'grpbKujundid
        '
        Me.grpbKujundid.Controls.Add(Me.btnRistkylik)
        Me.grpbKujundid.Controls.Add(Me.btnRuut)
        Me.grpbKujundid.Controls.Add(Me.btnKolmnurk)
        Me.grpbKujundid.Location = New System.Drawing.Point(534, 70)
        Me.grpbKujundid.Name = "grpbKujundid"
        Me.grpbKujundid.Size = New System.Drawing.Size(306, 239)
        Me.grpbKujundid.TabIndex = 1
        Me.grpbKujundid.TabStop = False
        Me.grpbKujundid.Text = "Kujundid"
        '
        'btnRistkylik
        '
        Me.btnRistkylik.Location = New System.Drawing.Point(105, 155)
        Me.btnRistkylik.Name = "btnRistkylik"
        Me.btnRistkylik.Size = New System.Drawing.Size(120, 34)
        Me.btnRistkylik.TabIndex = 2
        Me.btnRistkylik.Text = "Ristkülik"
        Me.btnRistkylik.UseVisualStyleBackColor = True
        '
        'btnRuut
        '
        Me.btnRuut.Location = New System.Drawing.Point(105, 98)
        Me.btnRuut.Name = "btnRuut"
        Me.btnRuut.Size = New System.Drawing.Size(120, 34)
        Me.btnRuut.TabIndex = 1
        Me.btnRuut.Text = "Ruut"
        Me.btnRuut.UseVisualStyleBackColor = True
        '
        'btnKolmnurk
        '
        Me.btnKolmnurk.Location = New System.Drawing.Point(105, 47)
        Me.btnKolmnurk.Name = "btnKolmnurk"
        Me.btnKolmnurk.Size = New System.Drawing.Size(120, 34)
        Me.btnKolmnurk.TabIndex = 0
        Me.btnKolmnurk.Text = "Kolmnurk"
        Me.btnKolmnurk.UseVisualStyleBackColor = True
        '
        'txtPindala
        '
        Me.txtPindala.Enabled = False
        Me.txtPindala.Location = New System.Drawing.Point(384, 528)
        Me.txtPindala.Name = "txtPindala"
        Me.txtPindala.Size = New System.Drawing.Size(124, 26)
        Me.txtPindala.TabIndex = 3
        '
        'txtYmbermoot
        '
        Me.txtYmbermoot.Enabled = False
        Me.txtYmbermoot.Location = New System.Drawing.Point(384, 476)
        Me.txtYmbermoot.Name = "txtYmbermoot"
        Me.txtYmbermoot.Size = New System.Drawing.Size(124, 26)
        Me.txtYmbermoot.TabIndex = 4
        '
        'lblTyyp
        '
        Me.lblTyyp.AutoSize = True
        Me.lblTyyp.Location = New System.Drawing.Point(380, 410)
        Me.lblTyyp.Name = "lblTyyp"
        Me.lblTyyp.Size = New System.Drawing.Size(90, 20)
        Me.lblTyyp.TabIndex = 6
        Me.lblTyyp.Text = "määramata"
        '
        'lblKujundiTyyp
        '
        Me.lblKujundiTyyp.AutoSize = True
        Me.lblKujundiTyyp.Location = New System.Drawing.Point(251, 410)
        Me.lblKujundiTyyp.Name = "lblKujundiTyyp"
        Me.lblKujundiTyyp.Size = New System.Drawing.Size(101, 20)
        Me.lblKujundiTyyp.TabIndex = 7
        Me.lblKujundiTyyp.Text = "Kujundi tüüp:"
        '
        'lblUmbermoot
        '
        Me.lblUmbermoot.AutoSize = True
        Me.lblUmbermoot.Location = New System.Drawing.Point(252, 482)
        Me.lblUmbermoot.Name = "lblUmbermoot"
        Me.lblUmbermoot.Size = New System.Drawing.Size(93, 20)
        Me.lblUmbermoot.TabIndex = 8
        Me.lblUmbermoot.Text = "Ümbermõõt"
        '
        'lblPindala
        '
        Me.lblPindala.AutoSize = True
        Me.lblPindala.Location = New System.Drawing.Point(284, 534)
        Me.lblPindala.Name = "lblPindala"
        Me.lblPindala.Size = New System.Drawing.Size(61, 20)
        Me.lblPindala.TabIndex = 9
        Me.lblPindala.Text = "Pindala"
        '
        'lblTulemused
        '
        Me.lblTulemused.AutoSize = True
        Me.lblTulemused.Location = New System.Drawing.Point(121, 375)
        Me.lblTulemused.Name = "lblTulemused"
        Me.lblTulemused.Size = New System.Drawing.Size(91, 20)
        Me.lblTulemused.TabIndex = 10
        Me.lblTulemused.Text = "Tulemused:"
        '
        'formkujundid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 708)
        Me.Controls.Add(Me.lblTulemused)
        Me.Controls.Add(Me.lblPindala)
        Me.Controls.Add(Me.lblUmbermoot)
        Me.Controls.Add(Me.lblKujundiTyyp)
        Me.Controls.Add(Me.lblTyyp)
        Me.Controls.Add(Me.txtYmbermoot)
        Me.Controls.Add(Me.txtPindala)
        Me.Controls.Add(Me.grpbKujundid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "formkujundid"
        Me.Text = "Kujundid"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbKujundid.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKylgB As TextBox
    Friend WithEvents txtKylgA As TextBox
    Friend WithEvents lblKylgB As Label
    Friend WithEvents lblKylgA As Label
    Friend WithEvents grpbKujundid As GroupBox
    Friend WithEvents btnRistkylik As Button
    Friend WithEvents btnRuut As Button
    Friend WithEvents btnKolmnurk As Button
    Friend WithEvents txtPindala As TextBox
    Friend WithEvents txtYmbermoot As TextBox
    Friend WithEvents lblTyyp As Label
    Friend WithEvents lblKujundiTyyp As Label
    Friend WithEvents lblUmbermoot As Label
    Friend WithEvents lblPindala As Label
    Friend WithEvents lblTulemused As Label
End Class
