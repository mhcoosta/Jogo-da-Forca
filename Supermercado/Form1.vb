Public Class Form1

    Dim posicao As Integer = 1
    Dim quantprod As Integer = 5
    Dim codigo(quantprod) As String
    Dim descricao(quantprod) As String
    Dim preco(quantprod) As String
    Dim achou As Boolean

    Private Sub atualizatela()
        TBposicao.Text = posicao
        MTcodigo.Text = codigo(posicao)
        TBdescricao.Text = descricao(posicao)
        MTpreco.Text = preco(posicao)
    End Sub

    Private Sub trava()
        BTsalva.Enabled = False
        BTedita.Enabled = True
        BTdeleta.Enabled = True
        MTcodigo.Enabled = False
        TBdescricao.Enabled = False
        MTpreco.Enabled = False
        BTanterior.Enabled = True
        BTproximo.Enabled = True
        BTnovo.Enabled = True
    End Sub

    Private Sub destrava()
        MTcodigo.Enabled = True
        TBdescricao.Enabled = True
        MTpreco.Enabled = True
        BTsalva.Enabled = True
        BTedita.Enabled = False
        BTdeleta.Enabled = False
        BTanterior.Enabled = False
        BTproximo.Enabled = False
        BTnovo.Enabled = False
        MTcodigo.Focus()
    End Sub




    Private Sub BTnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTnovo.Click
        For cont As Integer = 1 To quantprod
            If achou = False Then
                If codigo(cont) = "" Then
                    achou = True
                    posicao = cont
                End If
            End If
        Next
        If achou = False Then
            MsgBox("Não há espaço em memória.", MsgBoxStyle.Critical)
        Else
            atualizatela()
            destrava()
        End If
        achou = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BTedita_Click(sender As Object, e As EventArgs) Handles BTedita.Click
        destrava()
    End Sub

    Private Sub BTsalva_Click(sender As Object, e As EventArgs) Handles BTsalva.Click

        If MTcodigo.Text = "" Or TBdescricao.Text = "" Or MTpreco.Text = "" Then
            MsgBox("Você NÃO preencheu o campo Código ou campo Descrição!", MsgBoxStyle.Critical)
        Else
            codigo(posicao) = MTcodigo.Text
            descricao(posicao) = TBdescricao.Text
            preco(posicao) = MTpreco.Text
            trava()
        End If
    End Sub

    Private Sub BTdeleta_Click(sender As Object, e As EventArgs) Handles BTdeleta.Click
        If MsgBox("Tem certeza que deseja DELETAR este produto?", MsgBoxStyle.YesNo) =
MsgBoxResult.Yes Then
            MTcodigo.Text = ""
            TBdescricao.Text = ""
            MTpreco.Text = ""
            codigo(posicao) = ""
            descricao(posicao) = ""
            preco(posicao) = ""
        End If

    End Sub

    Private Sub BTanterior_Click(sender As Object, e As EventArgs) Handles BTanterior.Click
        If posicao = 1 Then
            posicao = quantprod
        Else
            posicao = posicao - 1
        End If
        atualizatela()
    End Sub

    Private Sub BTproximo_Click(sender As Object, e As EventArgs) Handles BTproximo.Click
        If posicao = quantprod Then
            posicao = 1
        Else
            posicao = posicao + 1
        End If
        atualizatela()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MTcodProc_TextChanged(sender As Object, e As EventArgs) Handles MTcodProc.TextChanged
        If Len(MTcodProc.Text) = 13 Then
            For cont As Integer = 1 To quantprod
                If MTcodProc.Text = codigo(cont) Then
                    achou = True
                    TBdescricaoProc.Text = descricao(cont)
                    TBprecoProc.Text = preco(cont)
                End If
            Next
            If achou = False Then
                TBdescricaoProc.Text = "Produto não cadastrado"
                TBprecoProc.Text = ""
            End If
            achou = False
            MTcodProc.Text = ""
            MTcodProc.Focus()


        End If
    End Sub
End Class
