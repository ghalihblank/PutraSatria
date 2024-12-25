Public Class f_setting
    Private Sub f_setting_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txt_server.Text = My.Settings.server
        txt_db.Text = My.Settings.database
        txt_user.Text = My.Settings.user
        txt_pass.Text = My.Settings.pass
        txt_report1.Text = My.Settings.sql_report1
        txt_report2.Text = My.Settings.sql_report2
        txt_report3.Text = My.Settings.sql_report3
        txt_report4.Text = My.Settings.sql_report4
    End Sub

    Private Sub b_simpan_Click(sender As Object, e As EventArgs) Handles b_simpan.Click
        My.Settings.server = txt_server.Text
        My.Settings.database = txt_db.Text
        My.Settings.user = txt_user.Text
        My.Settings.pass = txt_pass.Text
        My.Settings.sql_report1 = txt_report1.Text
        My.Settings.sql_report2 = txt_report2.Text
        My.Settings.sql_report3 = txt_report3.Text
        My.Settings.sql_report4 = txt_report4.Text
        My.Settings.Save()
        Me.Close()
    End Sub
End Class