Public Class ExempleTreeView
    Public Champs As New ArrayList()
    Public currentNode As String
    Public Structure Membre
        Dim Province As String
        Dim ville As String
        Dim NoMembre As Integer
        Dim Nom As String
        Dim Prenom As String
        Dim Adresse As String
        Dim CodePostal As String
        Dim Notelephone As String
        Dim Courriel As String
        Dim Langue As String
        Dim DateNaissance As String
        Dim Marque As String
        Dim Modele As String
    End Structure

    'Avec la collection Dictionary, les clés ne sont pas triées
    'Public FicheMembre As New Dictionary(Of Integer, Membre)
    'Avec la collection SortedList, les clés sont triées automatiquement
    'Public FicheMembre As New SortedList(Of Integer, Membre)
    Public FicheMembre As New SortedList(Of String, Membre)

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim PreviousNodeProvince As String = ""
        Dim PreviousNodeVille As String = ""
        Dim NodeProvince As String = ""
        Dim NodeVille As String = ""
        Dim NodeMembre As String = ""
        Dim ProvinceIndex As Integer = 0
        Dim VilleIndex As Integer = 0
        Dim MembreIndex As Integer = 0
        Dim NodeKey As String
        TreeView2.ShowPlusMinus = True
        TreeView2.ShowLines = True
        Button4_Click(sender, e)
        TreeView2.Nodes.Add("Membres")
        TreeView2.Nodes(0).Tag = "Membres"
        For Each NodeKey In FicheMembre.Keys
            'MsgBox(NodeKey)
            ' On décode la clé dans ses trois éléments (Province, ville et no de membre)
            DecoderNodeKey(NodeKey)
            NodeProvince = Champs(0)
            NodeVille = Champs(1)
            NodeMembre = Champs(2)
            ' si le code de province est différent du précédent, on crée 
            '                       un node de province
            '                       un node de ville et 
            '                       un node de membre
            ' et on augmente son index pour la prochaine fois. 
            ' On réinitialise aussi la valeur précédente du code de province et 
            '                                            du nom de la ville.
            If NodeProvince <> PreviousNodeProvince Then
                VilleIndex = 0
                MembreIndex = 0
                TreeView2.Nodes(0).Nodes.Add(NodeProvince)
                TreeView2.Nodes(0).Nodes(ProvinceIndex).Nodes.Add(NodeVille)
                TreeView2.Nodes(0).Nodes(ProvinceIndex).Nodes(0).Nodes.Add(NodeMembre)
                TreeView2.Nodes(0).Nodes(ProvinceIndex).Nodes(0).Nodes(0).Tag = NodeKey
                PreviousNodeProvince = NodeProvince
                ProvinceIndex = ProvinceIndex + 1
                PreviousNodeVille = NodeVille
                VilleIndex = 1
                MembreIndex = 1
                ' si le code de province n'a pas changé, mais que le nom de la ville est changé
                ' on crée un node de ville et
                '         un node de membre.
                ' et on augmente son index pour la prochaine fois. 
                ' On réinitialise aussi la valeur précédente du nom de la ville. 
            ElseIf NodeVille <> PreviousNodeVille Then
                TreeView2.Nodes(0).Nodes(ProvinceIndex - 1).Nodes.Add(NodeVille)
                TreeView2.Nodes(0).Nodes(ProvinceIndex - 1).Nodes(VilleIndex).Nodes.Add(NodeMembre)
                TreeView2.Nodes(0).Nodes(ProvinceIndex - 1).Nodes(VilleIndex).Nodes(0).Tag = NodeKey
                PreviousNodeVille = NodeVille
                VilleIndex = VilleIndex + 1
                MembreIndex = 1
            Else
                ' Si le code de province et le nom de la ville n'ont pas changé, alors 
                ' on ajoute un node de membre.
                TreeView2.Nodes(0).Nodes(ProvinceIndex - 1).Nodes(VilleIndex - 1).Nodes.Add(NodeMembre)
                TreeView2.Nodes(0).Nodes(ProvinceIndex - 1).Nodes(VilleIndex - 1).Nodes(MembreIndex).Tag = NodeKey
                MembreIndex = MembreIndex + 1
            End If
        Next NodeKey
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

    Private Sub TreeView2_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView2.AfterSelect
        'Dim msg As String = ""
        'msg = "Vous êtes ici --->" & " " & e.Node.FullPath & vbCrLf
        'msg = msg & "Le node sélectionné est :" & " " & e.Node.Text & vbCrLf
        'msg = msg & "L'index de ce node est :" & " " & CStr(e.Node.Index) & vbCrLf
        'msg = msg & "La propriété Tag est :" & " " & CStr(e.Node.Tag) & vbCrLf
        'MsgBox(msg)
        currentNode = CStr(e.Node.Tag)
        'MsgBox(currentNode)
    End Sub

    Public Sub RafraichirItemsDansComboBox()
        'Enlève la collection de la propriété Items de la ComboBox
        Me.ComboBox1.Items.Clear()
        'Et on recrée la collection de la propriété Items de la ComboBox (.Keys retourne un objet tableau)
        For Each element In FicheMembre.Keys
            Me.ComboBox1.Items.Add(element)
        Next element
    End Sub
    Public Sub ChargerDansCollection()
        Dim cle As String
        Dim Membres As New Membre
        cle = Champs(0) & "\" & Champs(1) & "\" & CStr(Champs(2))
        Membres.Province = Champs(0)
        Membres.ville = Champs(1)
        Membres.NoMembre = Champs(2)
        Membres.Nom = Champs(3)
        Membres.Prenom = Champs(4)
        Membres.Adresse = Champs(5)
        Membres.CodePostal = Champs(6)
        Membres.Notelephone = Champs(7)
        Membres.Courriel = Champs(8)
        Membres.Langue = Champs(9)
        Membres.DateNaissance = Champs(10)
        Membres.Marque = Champs(11)
        Membres.Modele = Champs(12)
        ' si la clé existe, message d'erreur
        'If FicheMembre.ContainsKey(cle) Then
        '    MsgBox("ERREUR : La clé (no de Membre) ==> " & CStr(cle) & " <== existe déjà.")
        'Else
        '    ' on ajoute la clé et les données dans la collection Dictionary ou SortedList
        '    FicheMembre.Add(cle, Membres)
        '    'MsgBox("La fiche Membre ==> " & CStr(cle) & " <== a été sauvegardée.")
        'End If
        If Not FicheMembre.ContainsKey(cle) Then
            FicheMembre.Add(cle, Membres)
        End If
    End Sub
    Private Sub ExtraireChampsDunEnregistrementFichierdelimite(ByVal chaine As String)
        Champs.Clear()
        Dim positionDelimiteur As Integer
        Do
            positionDelimiteur = InStr(chaine, "|")
            Champs.Add(Microsoft.VisualBasic.Left(chaine, positionDelimiteur - 1))
            chaine = Microsoft.VisualBasic.Right(chaine, Len(chaine) - positionDelimiteur)
        Loop Until InStr(chaine, "|") = 0
        Champs.Add(chaine)
        'Dim msg As String = ""
        'Dim FieldNo As Integer = 0
        'For Each champ As String In Champs
        '    FieldNo = FieldNo + 1
        '    msg = msg & CStr(FieldNo) & " : " & champ & vbCrLf
        'Next
        'MsgBox(msg)
    End Sub

    Public Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim lineNo As Integer = 0
        Dim fileReader As System.IO.StreamReader
        Dim stringReader As String
        fileReader = My.Computer.FileSystem.OpenTextFileReader("..\..\..\Exercice018.txt")
        While Not fileReader.EndOfStream
            stringReader = fileReader.ReadLine()
            lineNo = lineNo + 1
            'MsgBox(CStr(lineNo) & " : " & stringReader)
            ExtraireChampsDunEnregistrementFichierdelimite(stringReader)
            ChargerDansCollection()
        End While
        fileReader.Close()
        RafraichirItemsDansComboBox()
    End Sub

    Private Sub TreeView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeView2.DoubleClick
        Dim DonneesList As New Membre
        If (currentNode <> "" Or currentNode = Nothing) And FicheMembre.ContainsKey(currentNode) Then
            DonneesList.Province = FicheMembre(currentNode).Province
            DonneesList.ville = FicheMembre(currentNode).ville
            DonneesList.NoMembre = FicheMembre(currentNode).NoMembre
            DonneesList.Nom = FicheMembre(currentNode).Nom
            DonneesList.Prenom = FicheMembre(currentNode).Prenom
            DonneesList.Adresse = FicheMembre(currentNode).Adresse
            DonneesList.CodePostal = FicheMembre(currentNode).CodePostal
            DonneesList.Notelephone = FicheMembre(currentNode).Notelephone
            DonneesList.Courriel = FicheMembre(currentNode).Courriel
            DonneesList.DateNaissance = FicheMembre(currentNode).DateNaissance
            DonneesList.Langue = FicheMembre(currentNode).Langue
            DonneesList.Marque = FicheMembre(currentNode).Marque
            DonneesList.Modele = FicheMembre(currentNode).Modele
            Me.TextBox1.Text = DonneesList.NoMembre
            Me.TextBox2.Text = DonneesList.Nom
            Me.TextBox3.Text = DonneesList.Prenom
            Me.TextBox4.Text = DonneesList.Adresse
            Me.TextBox5.Text = DonneesList.ville
            Me.TextBox6.Text = DonneesList.Province
            Me.TextBox7.Text = DonneesList.CodePostal
            Me.TextBox8.Text = DonneesList.Notelephone
            Me.TextBox9.Text = DonneesList.Courriel
            Me.TextBox10.Text = DonneesList.DateNaissance
            Me.TextBox11.Text = DonneesList.Langue
            Me.TextBox12.Text = DonneesList.Marque
            Me.TextBox13.Text = DonneesList.Modele
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

