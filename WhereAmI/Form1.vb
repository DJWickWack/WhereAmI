Public Class WhereAmINow
    Dim p As Integer = -1
    Dim pp As Integer = -1
    Dim quick As New List(Of String)
    Dim places As New List(Of String)
    Dim R As IO.StreamReader


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        reeed()
    End Sub

    Function fast_place_switch()

        If p = quick.Count - 1 Then p = -1
        p = p + 1
        Return quick.Item(p)
    End Function

    Function upswitch()
        If pp = places.Count - 1 Then pp = -1
        pp = pp + 1
        Return places.Item(pp)
    End Function

    Function downswitch()
        pp = pp - 1
        If pp <= -1 Then pp = places.Count - 1
        Return places.Item(pp)
    End Function

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "7" Then lb_User1_Place.Text = fast_place_switch()
        If e.KeyChar = "4" Then lb_User1_Place.Text = upswitch()
        If e.KeyChar = "1" Then lb_User1_Place.Text = downswitch()
        If e.KeyChar = "8" Then lb_User2_Place.Text = fast_place_switch()
        If e.KeyChar = "5" Then lb_User2_Place.Text = upswitch()
        If e.KeyChar = "2" Then lb_User2_Place.Text = downswitch()
        If e.KeyChar = "9" Then lb_User3_Place.Text = fast_place_switch()
        If e.KeyChar = "6" Then lb_User3_Place.Text = upswitch()
        If e.KeyChar = "3" Then lb_User3_Place.Text = downswitch()

    End Sub

    Function reeed()
        Dim locloc As String =
        IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "locations.txt")
        R = New IO.StreamReader(locloc)
        While (R.Peek() > -1)
            places.Add(R.ReadLine)
        End While
        R.Close()
        Dim quickloc As String =
        IO.Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "quick.txt")
        R = New IO.StreamReader(quickloc)
        While (R.Peek() > -1)
            quick.Add(R.ReadLine)
        End While
        R.Close()
    End Function

    Private Sub Lb_User1_Click(sender As Object, e As EventArgs) Handles lb_User1.Click

    End Sub

    Private Sub Lb_User1_Place_Click(sender As Object, e As EventArgs) Handles lb_User1_Place.Click

    End Sub

    Private Sub Lb_User2_Place_Click(sender As Object, e As EventArgs) Handles lb_User2_Place.Click

    End Sub

    Private Sub Lb_User3_Place_Click(sender As Object, e As EventArgs) Handles lb_User3_Place.Click

    End Sub
End Class
