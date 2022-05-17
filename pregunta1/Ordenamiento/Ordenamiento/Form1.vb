Public Class Form1
    'YURIKA MACUSAYA AGUILAR CI:13846755  PREGUNTA 1
    Private Sub ordenar_Click(sender As Object, e As EventArgs) Handles ordenar.Click
        Dim numero1, numero2, numero3 As Integer

        numero1 = Convert.ToInt32(A.Text)
        numero2 = Convert.ToInt32(B.Text)
        numero3 = Convert.ToInt32(C.Text)

        Dim li As New List(Of Byte)()
        li.Add(numero1)
        If numero2 < li(0) Then li.Insert(0, numero2) : GoTo 1
        li.Add(numero2)
1:
        If numero3 < li(0) Then li.Insert(0, numero3) : GoTo 2
        If numero3 < li(1) Then li.Insert(1, numero3) : GoTo 2
        li.Add(numero3)

2:
        RES.Text = " ASC " & li(0) & ", " & li(1) & ", " & li(2) & "   DESC " & li(2) & ", " & li(1) & ", " & li(0)

    End Sub


End Class
