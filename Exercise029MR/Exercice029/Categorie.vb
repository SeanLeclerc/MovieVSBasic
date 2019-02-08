Public Class Categorie
    Public CatCd As String

    Public CatDesc As String
    Public Property CatDescs() As String
        Get
            Return (CatDesc)
        End Get
        Set(ByVal value As String)
            CatDesc = value
        End Set
    End Property

    Public Sub AfficherCategorie()
        SQLTreeView.txtCategorie.Text = CatDescs()
    End Sub
End Class
