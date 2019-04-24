Public Class Form1

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        MetroFramework.MetroMessageBox.Show(Me, "Hello World!!Metro UI!", "Notification", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
    End Sub
End Class
