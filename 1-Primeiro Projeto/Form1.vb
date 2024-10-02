Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_01.Click

        MsgBox("Ola Mundo!!!", MsgBoxStyle.AbortRetryIgnore
               )


    End Sub
End Class
