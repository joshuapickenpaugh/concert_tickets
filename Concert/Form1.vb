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

        tixCalc.Clear()

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        tixCalc.BolBox = chkBox.Checked
        If chkBox.Checked = True Then
            txtNumBox.Visible = True
            Integer.TryParse(txtNumBox.Text, tixCalc.NumTixBox)
        End If

        tixCalc.BolPav = chkPavilion.Checked
        If chkPavilion.Checked = True Then
            txtNumPavilion.Visible = True
            Integer.TryParse(txtNumPavilion.Text, tixCalc.NumTixPav)
        End If

        tixCalc.BolLawn = chkLawn.Checked
        If chkLawn.Checked = True Then
            txtNumLawn.Visible = True
            Integer.TryParse(txtNumLawn.Text, tixCalc.NumTixLawn)
        End If

        lblTtlTickets.Text = tixCalc.GetTotalNumTix().ToString()


    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtNumBox.Visible = False
        txtNumPavilion.Visible = False
        txtNumLawn.Visible = False

    End Sub
End Class
