Public Sub pls()
    If Environ("username") = "v.doynov" Then
        tbl_main.Unprotect Password:= HERE_COMES_PASSWORD
        Debug.Print "ok :)"
    Else
        Debug.Print "Nonononononononnononononononono!"
    End If
End Sub
