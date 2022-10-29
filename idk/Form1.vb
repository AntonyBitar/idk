Public Class Form1
    Public Function delta(A As Integer, B As Integer, C As Integer) As Integer
        Return (B * B) - 4 * A * C
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim deltaResult As String
        Dim a As Integer = txt_A.Text
        Dim b As Integer = txt_B.Text
        Dim c As Integer = txt_C.Text
        Dim x1 As Integer
        Dim x2 As Integer
        Dim ff As Integer
        Dim ff1 As Integer
        Dim ff2 As Integer
        Dim ff3 As Integer
        deltaResult = delta(a, b, c)
        If deltaResult = 0 Then
            x1 = -b / (2 * a)
            txt_x1.Text = x1
            txt_x2.Text = x2
        ElseIf deltaResult > 0 Then
            x1 = (-b - Math.Sqrt(deltaResult)) / (2 * a)
            x2 = (-b + Math.Sqrt(deltaResult)) / (2 * a)
            txt_x1.Text = x1
            txt_x2.Text = x2
        Else
            txt_x1.Text = "hii"
            txt_x2.Text = "hii"
            MsgBox("delta is negative")

        End If
        MsgBox("hello")
    End Sub

End Class

