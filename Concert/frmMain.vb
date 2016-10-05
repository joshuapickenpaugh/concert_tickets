'Joshua Pickenpaugh
'October 4th, 2016
'Ticket calculater

Public Class frmMain

    Dim tixCalc As New TicketCalculator()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes the app:
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        chkBox.Checked = False
        chkPavilion.Checked = False
        chkLawn.Checked = False

        txtNumBox.Visible = False
        txtNumBox.Text = String.Empty
        txtNumPavilion.Visible = False
        txtNumPavilion.Text = String.Empty
        txtNumLawn.Visible = False
        txtNumLawn.Text = String.Empty

        lblTtlTickets.Text = String.Empty
        lblTtlDue.Text = String.Empty

        tixCalc.Clear()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        If chkBox.Checked = True Then
            tixCalc.BolBox = True
            txtNumBox.Visible = True
            Integer.TryParse(txtNumBox.Text, tixCalc.NumTixBox)
        End If

        If chkPavilion.Checked = True Then
            tixCalc.BolPav = True
            txtNumPavilion.Visible = True
            Integer.TryParse(txtNumPavilion.Text, tixCalc.NumTixPav)
        End If

        If chkLawn.Checked = True Then
            tixCalc.BolLawn = True
            txtNumLawn.Visible = True
            Integer.TryParse(txtNumLawn.Text, tixCalc.NumTixLawn)
        End If

        lblTtlTickets.Text = tixCalc.GetTotalNumTix().ToString("N0")
        lblTtlDue.Text = tixCalc.GetTotalPrice().ToString("C2")

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Hides the text boxes upon load:
        txtNumBox.Visible = False
        txtNumPavilion.Visible = False
        txtNumLawn.Visible = False

    End Sub

    Private Sub chkBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox.CheckedChanged

        'Shows the text box if the checkbox is checked:
        txtNumBox.Visible = True

    End Sub

    Private Sub chkPavilion_CheckedChanged(sender As Object, e As EventArgs) Handles chkPavilion.CheckedChanged

        txtNumPavilion.Visible = True

    End Sub

    Private Sub chkLawn_CheckedChanged(sender As Object, e As EventArgs) Handles chkLawn.CheckedChanged

        txtNumLawn.Visible = True

    End Sub

    Private Sub txtNumBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumBox.KeyPress

        'Allows only numbers, ".", and the backspace key in the text boxes:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumPavilion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumPavilion.KeyPress

        'Allows only numbers, ".", and the backspace key in the text boxes:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumLawn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumLawn.KeyPress

        'Allows only numbers, ".", and the backspace key in the text boxes:
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
