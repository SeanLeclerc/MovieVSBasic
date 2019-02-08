Imports System.Data.SqlClient

Public Class SQLTreeView
    'POUR SÉLECTIONNER TOUTES LES DONNÉES de la table CA_FILMS
    ' ======> Les champs FilmDuree, FilmAnneeProd, AcsCd et PrId sont des numériques (Integer)
    ' ======> Tous les autres champs sont des String.
    'SELECT FilmNo, FilmTitre, CatCd, ClassCd, FilmDuree, NatCd, FilmAnneeProd, 
    'LangCd, AcsCd, PrRangee, PrTablette, PrId
    'FROM dbo.CA_Films
    'ORDER BY NatCd, CatCd, FilmTitre

    'POUR POPULER LE TREEVIEW
    '======> Les 3 champs sont des String
    'SELECT NatCd, CatCd, FilmTitre
    'FROM dbo.CA_Films
    'ORDER BY NatCd, CatCd, FilmTitre

    'POUR POPULER LE COMBOBOX CATÉGORIE
    '======> Seul le CatCd est utilisé pour la collection des items du combobox, 
    '======> les 2 champs seront utilisés pour la Collection SortedList locale des catégories
    '======> ======> Les 2 champs sont des String
    'SELECT CatCd, CatDesc       
    'FROM dbo.CA_Categories
    'ORDER BY 1

    'POUR POPULER LE COMBOBOX CLASSIFICATION
    '======> Seul le ClassCd est utilisé pour la collection des items du combobox, 
    '======> les 2 champs seront utilisés pour la Collection SortedList locale des classifications
    '======> ======> Les 2 champs sont des String
    'SELECT ClassCd, ClassDesc
    'FROM dbo.CA_Classifications
    'ORDER BY 1

    'POUR POPULER LE COMBOBOX NATIONALITÉ
    '======> Seul le NatCd est utilisé pour la collection des items du combobox, 
    '======> les 2 champs seront utilisés pour la Collection SortedList locale des nationalités
    '======> ======> Les 2 champs sont des String
    'SELECT NatCd, NatDesc
    'FROM dbo.CA_Nationalites
    'ORDER BY 1

    'POUR POPULER LE COMBOBOX LANGAGE
    '======> Seul le LangCd est utilisé pour la collection des items du combobox, 
    '======> les 2 champs seront utilisés pour la Collection SortedList locale des langues
    '======> ======> Les 2 champs sont des String
    'SELECT LangCd, Langdesc
    'FROM dbo.CA_Langues
    'ORDER BY 1

    'POUR POPULER LE COMBOBOX CODE D'ACCESSIBILITÉ
    '======> Seul le AcsCd est utilisé pour la collection des items du combobox, 
    '======> les 2 champs seront utilisés pour la Collection SortedList locale des accessibilités
    '======> ======> Le champ AcsCd est numérique (integer) et le 2ième champs est un String
    'SELECT AcsCd, AcsDesc
    'FROM dbo.CA_Accessibilites
    'ORDER BY 1

    'POUR POPULER LE COMBOBOX PRODUCTEUR
    '======> Seul le PrId est utilisé pour la collection des items du combobox, 
    '======> les 3 champs seront utilisés pour la Collection SortedList locale des producteurs
    '======> ======> Le champ PrId est numérique (Integer), les 2 autres sont des String
    'SELECT PrId, PrNom, PrPrenom
    'FROM dbo.CA_Producteurs
    'ORDER BY 1

    'POUR INSÉRER UN NOUVEAU FILM
    'INSERT INTO [BdEtu50].[dbo].[CA_Films]
    '       ([FilmNo]
    '       ,[CatCd]
    '       ,[FilmTitre]
    '       ,[ClassCd]
    '       ,[FilmDuree]
    '       ,[NatCd]
    '       ,[FilmAnneeProd]
    '       ,[LangCd]
    '       ,[AcsCd]
    '       ,[PrRangee]
    '       ,[PrTablette]
    '       ,[PrId])
    ' VALUES
    '       (@FilmNo
    '       ,@CatCd
    '       ,@FilmTitre
    '       ,@ClassCd
    '       ,@FilmDuree
    '       ,@NatCd
    '       ,@FilmAnneeProd
    '       ,@LangCd
    '       ,@AcsCd
    '       ,@PrRangee
    '       ,@PrTablette
    '       ,@PrId)

    'POUR METTRE À JOUR UN FILM
    'UPDATE [dbo].[CA_Films]
    '   SET [CatCd] = <CatCd
    '     ,[FilmTitre] = @FilmTitre
    '     ,[ClassCd] = @ClassCd
    '     ,[FilmDuree] = @FilmDuree
    '     ,[NatCd] = @NatCd
    '     ,[FilmAnneeProd] = @FilmAnneeProd
    '     ,[LangCd] = @LangCd
    '     ,[AcsCd] = @AcsCd
    '     ,[PrRangee] = @PrRangee
    '     ,[PrTablette] = @PrTablette
    '     ,[PrId] = @PrId
    'WHERE [FilmNo] = @FilmNo

    'POUR SUPPRIMER UN FILM
    'DELETE FROM [dbo].[CA_Films]
    '  WHERE [FilmNo] = @FilmNo

    Dim connStr As String
    Dim SqlStr As String
    Dim ClConnection As SqlConnection
    Dim ClCommand As SqlCommand
    Dim motdepasse As String
    Public Champs As New ArrayList()
    Public FicheFilm As New SortedList(Of String, Films)
    Public FicheCategorie As New SortedList(Of String, Categorie)
    Public FicheClassification As New SortedList(Of String, Classification)
    Public FicheNationalite As New SortedList(Of String, Nationalite)
    Public FicheLangue As New SortedList(Of String, Langue)
    Public FicheAccessibilite As New SortedList(Of String, Accessibilite)
    Public FicheProducteur As New SortedList(Of String, Producteur)
    Public FicheFilmTreeView As New SortedList(Of String, Films)
    Public films As New Films
    Dim check As Boolean
    Public FicheMembre As New SortedList(Of String, Membres)

    Private Sub Charger(requete)
        ' Chaîne de connexion
        motdepasse = "c3po"
        connStr = "Data Source=ETU-SQL.lacitec.on.ca;Initial Catalog=BdEtu11;" &
          "Persist Security Info=True;User ID=etudiant11; Password=c3po"
        ' Commande SQL
        SqlStr = requete
        ' Création de l'objet Connection
        ClConnection = New SqlConnection(connStr)
        ' Ouverture de la connexion
        ClConnection.Open()
        ' Création de l'objet Command 
        ClCommand = New SqlCommand(SqlStr, ClConnection)
    End Sub

    Public Sub ChargerDansCollection1()
        ' Commande SQL
        Dim requete As String = "  SELECT FilmNo, FilmTitre, CatCd, ClassCd, FilmDuree, NatCd, FilmAnneeProd, 
                    LangCd, AcsCd, PrRangee, PrTablette, PrId
                    FROM dbo.CA_Films
                    ORDER BY NatCd, CatCd, FilmTitre"
        Charger(requete)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(1) & "\" & ClReader.Item(2) & "\" & ClReader.Item(0)
            Dim film As New Films
            film.FilmNo = ClReader.Item(0)
            film.CatCd = ClReader.Item(2)
            film.filmTitre = ClReader.Item(1)
            film.classCd = ClReader.Item(3)
            film.filmDuree = ClReader.Item(4)
            film.natCd = ClReader.Item(5)
            film.filmAnneeProd = ClReader.Item(6)
            film.langCd = ClReader.Item(7)
            film.acsCd = ClReader.Item(8)
            film.PrRangee = ClReader.Item(9)
            film.prTablette = ClReader.Item(10)
            film.prId = ClReader.Item(11)
            If Not FicheFilm.ContainsKey(cle) Then
                FicheFilm.Add(cle, film)
            End If
        Loop
        ClReader.Close()
        ClConnection.Close()
    End Sub

    Private Sub ListFilm()
        mtxtNumeroFilm.Text = FicheFilm.Values(0).FilmNo
        txtTitre.Text = FicheFilm.Values(0).FilmTitre
        cBoCategorie.Text = FicheFilm.Values(0).CatCd
        cBoClassification.Text = FicheFilm.Values(0).ClassCd
        mtxtDuree.Text = FicheFilm.Values(0).FilmDuree
        cBoNationalite.Text = FicheFilm.Values(0).NatCd
        mtxtAnnee.Text = FicheFilm.Values(0).FilmAnneeProd
        cBoLangue.Text = FicheFilm.Values(0).LangCd
        cBoAccessibilite.Text = FicheFilm.Values(0).AcsCd
        cBoRangee.Text = FicheFilm.Values(0).PrRangee
        numTablette.Text = FicheFilm.Values(0).PrTablette
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnNouveau.Click
        MsgBox("Afficher une fiche vide afin de la compléter et d'insérer un nouveau film.")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnInserer.Click
        MsgBox("Insérer le nouveau film dans la base de données et dans la collection SortedList.")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnMiseajour.Click
        MsgBox("Mettre à jour le film dans la base de données et dans la collection SortedList.")
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles btnSupprimer.Click
        MsgBox("Supprimer le film de la base de données et de la collection SortedList.")
    End Sub

    Private Sub ChargerDonnéesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChargerDonnéesToolStripMenuItem.Click
        ChargerDansCollection1()
        listFilm()
        chargerCategorie()
        chargerClassificatin()
        chargerNationalite()
        chargerLangue()
        chargerAccessibilite()
        chargerProducteur()

    End Sub

    Private Sub FermerApplicationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FermerApplicationToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AProposDeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AProposDeToolStripMenuItem.Click
        Dim msg As String
        msg = "Exercise029" & vbCrLf &
            "TreeView Dynamique" & vbCrLf &
            "Lecture d'une base de données" & vbCrLf &
            "Programmation effectuée par Michael Robidoux."
        MsgBox(msg)
    End Sub

    Private Sub ChargerCategorie()
        ' Commande SQL
        Dim requete As String = "   SELECT CatCd, CatDesc       
                     FROM dbo.CA_Categories
                     ORDER BY 1"
        Charger(requete)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0)
            Dim categories As New Categorie
            categories.CatCd = ClReader.Item(0)
            If Not FicheCategorie.ContainsKey(cle) Then
                FicheCategorie.Add(cle, categories)
            End If
        Loop
        ClReader.Close()
        ClConnection.Close()
        RafraichirItemsDansComboBox()
    End Sub

    Public Sub RafraichirItemsDansComboBox()
        cBoCategorie.Items.Clear()
        For Each element In FicheCategorie.Keys
            cBoCategorie.Items.Add(element)
        Next element
    End Sub

    Private Sub chargerClassificatin()
        ' Commande SQL
        Dim requete As String = "    SELECT ClassCd, ClassDesc
                      FROM dbo.CA_Classifications
                      ORDER BY 1"
        Charger(requete)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0)
            Dim classi As New Classification
            classi.ClassCd = ClReader.Item(0)
            If Not FicheCategorie.ContainsKey(cle) Then
                FicheClassification.Add(cle, classi)
            End If
        Loop
        ClReader.Close()
        ClConnection.Close()
        RafraichirItemsDansCombobox2()
    End Sub

    Public Sub RafraichirItemsDansCombobox2()
        cBoClassification.Items.Clear()
        For Each element In FicheClassification.Keys
            cBoClassification.Items.Add(element)
        Next element
    End Sub

    Private Sub chargerNationalite()
        ' Commande SQL
        Dim requete As String = "     SELECT NatCd, NatDesc
                                      FROM dbo.CA_Nationalites
                                      ORDER BY 1"
        Charger(requete)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0)
            Dim Nat As New Nationalite
            Nat.NatCd = ClReader.Item(0)
            If Not FicheNationalite.ContainsKey(cle) Then
                FicheNationalite.Add(cle, Nat)
            End If
        Loop
        ClReader.Close()
        ClConnection.Close()
        RafraichirItemsDansCombobox3()
    End Sub

    Public Sub RafraichirItemsDansCombobox3()
        cBoNationalite.Items.Clear()
        For Each element In FicheNationalite.Keys
            cBoNationalite.Items.Add(element)
        Next element
    End Sub

    Private Sub chargerLangue()
        ' Commande SQL
        Dim requete As String = " Select LangCd, Langdesc
                                  From dbo.CA_Langues
                                  Order By 1"
        Charger(requete)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0)
            Dim Lang As New Langue
            Lang.LangCd = ClReader.Item(0)
            If Not FicheLangue.ContainsKey(cle) Then
                FicheLangue.Add(cle, Lang)
            End If
        Loop
        ClReader.Close()
        ClConnection.Close()
        RafraichirItemsDansCombobox4()
    End Sub

    Public Sub RafraichirItemsDansCombobox4()
        cBoLangue.Items.Clear()
        For Each element In FicheLangue.Keys
            cBoLangue.Items.Add(element)
        Next element
    End Sub

    Private Sub chargerAccessibilite()
        ' Commande SQL
        Dim requete As String = "Select AcsCd, AcsDesc
                                 From dbo.CA_Accessibilites
                                 Order By 1"


        Charger(requete)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0)
            Dim Acs As New Accessibilite
            Acs.AcsCd = ClReader.Item(0)
            If Not FicheAccessibilite.ContainsKey(cle) Then
                FicheAccessibilite.Add(cle, Acs)
            End If
        Loop
        ClReader.Close()
        ClConnection.Close()
        RafraichirItemsDansCombobox5()
    End Sub

    Public Sub RafraichirItemsDansCombobox5()
        cBoAccessibilite.Items.Clear()
        For Each element In FicheAccessibilite.Keys
            cBoAccessibilite.Items.Add(element)
        Next element
    End Sub

    Private Sub chargerProducteur()
        ' Commande SQL
        Dim requete As String = "Select PrId, PrNom, PrPrenom
                                 From dbo.CA_Producteurs
                                 Order By 1"


        Charger(requete)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0)
            Dim Prod As New Producteur
            Prod.PrId = ClReader.Item(0)
            If Not FicheProducteur.ContainsKey(cle) Then
                FicheProducteur.Add(cle, Prod)
            End If
        Loop
        ClReader.Close()
        ClConnection.Close()
        RafraichirItemsDansCombobox6()
    End Sub

    Public Sub RafraichirItemsDansCombobox6()
        cBoProducteur.Items.Clear()
        For Each element In FicheProducteur.Keys
            cBoProducteur.Items.Add(element)
        Next element
    End Sub

    Public Sub ChargerDansCollectionCategorie()
        Dim cle As String
        Dim categories As New Categorie
        cle = Champs(0)
        ' ProvCd 
        ' ProvDesc 
        categories.CatCd = Champs(0)
        categories.CatDesc = Champs(1)
        If Not FicheCategorie.ContainsKey(cle) Then
            FicheCategorie.Add(cle, categories)
        End If
    End Sub

    Public Sub DecoderNodeKey(ByVal keynode As String)
        Champs.Clear()
        Dim positionDelimiteur As Integer
        Do
            positionDelimiteur = InStr(keynode, "\")
            Champs.Add(Microsoft.VisualBasic.Left(keynode, positionDelimiteur - 1))
            keynode = Microsoft.VisualBasic.Right(keynode, Len(keynode) - positionDelimiteur)
        Loop Until InStr(keynode, "\") = 0
        Champs.Add(keynode)
    End Sub

    Public Sub chargerDansUnTreeView()
        ' Commande SQL
        Dim requete As String = "  SELECT NatCd, CatCd, FilmTitre
                                   FROM dbo.CA_Films
                                   ORDER BY NatCd, CatCd, FilmTitre"
        Charger(requete)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0) & "\" & ClReader.Item(1) & "\" & ClReader.Item(2)
            Dim film As New Films
            film.natCd = ClReader.Item(0)
            film.CatCd = ClReader.Item(1)
            film.filmTitre = ClReader.Item(2)
            If Not FicheFilmTreeView.ContainsKey(cle) Then
                FicheFilmTreeView.Add(cle, film)
            End If
        Loop
        ClReader.Close()
        ClConnection.Close()
    End Sub
    Private Sub SQLTreeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chargerDansUnTreeView()
        Dim PreviousCodeNationalite As String = ""
        Dim PreviousCategorie As String = ""
        Dim NodeCodeNationalite As String = ""
        Dim NodeCategorie As String = ""
        Dim NodeTitre As String = ""
        Dim NationaliteIndex As Integer = 0
        Dim CategorieIndex As Integer = 0
        Dim titreIndex As Integer = 0
        Dim NodeKey As String
        TreeView2.ShowPlusMinus = True
        TreeView2.ShowLines = True
        For Each NodeKey In FicheFilmTreeView.Keys
            DecoderNodeKey(NodeKey)
            NodeCodeNationalite = Champs(0)
            NodeCategorie = Champs(1)
            NodeTitre = Champs(2)
            If NodeCodeNationalite <> PreviousCodeNationalite Then
                titreIndex = 0
                CategorieIndex = 0
                TreeView2.Nodes.Add(NodeCodeNationalite)
                TreeView2.Nodes(NationaliteIndex).Nodes.Add(NodeCategorie)
                TreeView2.Nodes(NationaliteIndex).Nodes(CategorieIndex).Nodes.Add(NodeTitre)
                TreeView2.Nodes(NationaliteIndex).Nodes(CategorieIndex).Nodes(0).Tag = NodeKey
                PreviousCodeNationalite = NodeCodeNationalite
                PreviousCategorie = NodeCategorie
                NationaliteIndex = NationaliteIndex + 1
                CategorieIndex = CategorieIndex + 1
                titreIndex = titreIndex + 1
            ElseIf NodeCodeNationalite = PreviousCodeNationalite And NodeCategorie <> PreviousCategorie Then
                titreIndex = 0
                TreeView2.Nodes(NationaliteIndex - 1).Nodes.Add(NodeCategorie)
                TreeView2.Nodes(NationaliteIndex - 1).Nodes(CategorieIndex).Nodes.Add(NodeTitre)
                TreeView2.Nodes(NationaliteIndex - 1).Nodes(CategorieIndex).Nodes(0).Tag = NodeKey
                PreviousCategorie = NodeCategorie
                CategorieIndex = CategorieIndex + 1
                titreIndex = titreIndex + 1
            Else
                TreeView2.Nodes(NationaliteIndex - 1).Nodes(CategorieIndex - 1).Nodes.Add(NodeTitre)
                TreeView2.Nodes(NationaliteIndex - 1).Nodes(CategorieIndex - 1).Nodes(titreIndex).Tag = NodeKey
                titreIndex = titreIndex + 1
            End If
        Next NodeKey
    End Sub

    Private Sub AfficherMembre(SelectedMember)
        Dim film As Films = FicheFilm(SelectedMember)
        Show()

        mtxtNumeroFilm.Text = film.FilmNo
        txtTitre.Text = film.FilmTitre
        cBoCategorie.Text = film.CatCd
        cBoClassification.Text = film.ClassCd
        mtxtDuree.Text = film.FilmDuree
        cBoNationalite.Text = film.NatCd
        mtxtAnnee.Text = film.FilmAnneeProd
        cBoLangue.Text = film.LangCd
        cBoAccessibilite.Text = film.AcsCd
        cBoRangee.Text = film.PrRangee
        numTablette.Text = film.PrTablette

    End Sub

    Private Sub TreeView2_DoubleClick(sender As Object, e As System.EventArgs) Handles TreeView2.DoubleClick
        If Not Me.TreeView2.SelectedNode.Tag Is Nothing Then
            AfficherMembre(Me.TreeView2.SelectedNode.Tag)
        End If
    End Sub

End Class