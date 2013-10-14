Option Strict On

Public Class Form1

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        ' Read the input from the user
        Dim st As String
        st = InputBox("Please type the initial string")

        ' Compute the result
        Dim result As String = ""

        Dim i As Integer
        For i = st.Length - 1 To 0 Step -1
            Dim c As Char
            c = st.Chars(i)
            result = result & c

        Next



        ' Report the output to the user
        MessageBox.Show(result, "Result")

    End Sub
End Class
