Public Class Form1
    Dim number As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        dot_seg.BackColor = Color.Gray
        a_seg.BackColor = Color.Gray
        b_seg.BackColor = Color.Gray
        c_seg.BackColor = Color.Gray
        d_seg.BackColor = Color.Gray
        e_seg.BackColor = Color.Gray
        f_seg.BackColor = Color.Gray
        g_seg.BackColor = Color.Gray
        Select Case Number
            Case 0
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Red
                b_seg.BackColor = Color.Red
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Red
                e_seg.BackColor = Color.Red
                f_seg.BackColor = Color.Red
                g_seg.BackColor = Color.Gray
            Case 1
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Gray
                b_seg.BackColor = Color.Red
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Gray
                e_seg.BackColor = Color.Gray
                f_seg.BackColor = Color.Gray
                g_seg.BackColor = Color.Gray
            Case 2
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Red
                b_seg.BackColor = Color.Red
                c_seg.BackColor = Color.Gray
                d_seg.BackColor = Color.Red
                e_seg.BackColor = Color.Red
                f_seg.BackColor = Color.Gray
                g_seg.BackColor = Color.Red
            Case 3
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Red
                b_seg.BackColor = Color.Red
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Red
                e_seg.BackColor = Color.Gray
                f_seg.BackColor = Color.Gray
                g_seg.BackColor = Color.Red
            Case 4
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Gray
                b_seg.BackColor = Color.Red
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Gray
                e_seg.BackColor = Color.Gray
                f_seg.BackColor = Color.Red
                g_seg.BackColor = Color.Red
            Case 5
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Red
                b_seg.BackColor = Color.Gray
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Red
                e_seg.BackColor = Color.Gray
                f_seg.BackColor = Color.Red
                g_seg.BackColor = Color.Red
            Case 6
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Red
                b_seg.BackColor = Color.Gray
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Red
                e_seg.BackColor = Color.Red
                f_seg.BackColor = Color.Red
                g_seg.BackColor = Color.Red
            Case 7
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Red
                b_seg.BackColor = Color.Red
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Gray
                e_seg.BackColor = Color.Gray
                f_seg.BackColor = Color.Gray
                g_seg.BackColor = Color.Gray
            Case 8
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Red
                b_seg.BackColor = Color.Red
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Red
                e_seg.BackColor = Color.Red
                f_seg.BackColor = Color.Red
                g_seg.BackColor = Color.Red
            Case 9
                dot_seg.BackColor = Color.Red
                a_seg.BackColor = Color.Red
                b_seg.BackColor = Color.Red
                c_seg.BackColor = Color.Red
                d_seg.BackColor = Color.Gray
                e_seg.BackColor = Color.Gray
                f_seg.BackColor = Color.Red
                g_seg.BackColor = Color.Red
            Case 10
                Timer1.Stop()
        End Select
        Number = Number + 1
    End Sub
End Class
