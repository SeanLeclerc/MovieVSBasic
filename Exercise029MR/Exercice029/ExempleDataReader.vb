Imports System.Data.SqlClient
Imports System.Data
Public Class ExempleDataReader
    'Déclaration de variables pour la chaîne de connexion et la commande SQL
    Dim connStr As String
    Dim SqlStr As String
    'Déclaration de la variable pour l'objet Connection
    Dim ClConnection As SqlConnection
    'Déclaration de la variable pour l'objet Command
    Dim ClCommand As SqlCommand
    Public Class ClFiche
        Public Property CustomerId As String
        Public Property CompanyName As String
        Public Property ContactName As String
        Public Property ContactTitle As String
        Public Property Address As String
        Public Property City As String
        Public Property Regions As String
        Public Property PostalCode As String
        Public Property Country As String
        Public Property Phone As String
        Public Property Fax As String
    End Class
    Public FicheClient As New SortedList(Of String, ClFiche)
    Public cle As String
    Public motdepasse As String

    Public Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Chaîne de connexion avec mot de passe, et avec sécurité intégrée (Trusted)
        motdepasse = InputBox("Mot de passe : ", "Inscrire votre mot de passe ")
        connStr = "Data Source=ETU-SQL.lacitec.on.ca;Initial Catalog=BdEtuXX;" &
                  "Persist Security Info=True;User ID=etudiantXX; Password=" &
        motdepasse

        ' Commande SQL
        SqlStr = "SELECT CustomerID, CompanyName, ContactName, " &
                  "ContactTitle, Address, City, Region, PostalCode, " &
                  "Country, Phone, Fax FROM Customers ORDER BY 1"
        ' Création de l'objet Connection
        ClConnection = New SqlConnection(connStr)
        ' Ouverture de la connexion
        ClConnection.Open()
        ' Création de l'objet Command 
        ClCommand = New SqlCommand(SqlStr, ClConnection)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0)
            ' CustomerId 
            ' CompanyName
            ' ContactName 
            ' ContactTitle
            ' Address 
            ' City 
            ' Regions 
            ' PostalCode 
            ' Country 
            ' Phone 
            ' Fax 
            Dim ClFiche As New ClFiche
            ClFiche.CustomerId = ClReader.Item(0)
            ClFiche.CompanyName = ClReader.Item(1)
            ClFiche.ContactName = ClReader.Item(2)
            ClFiche.ContactTitle = ClReader.Item(3)
            ClFiche.Address = ClReader.Item(4)
            ClFiche.City = ClReader.Item(5)
            If IsDBNull(ClReader.Item(6)) Then
                ClFiche.Regions = ""
            Else
                ClFiche.Regions = ClReader.Item(6)
            End If
            'WHERE (City = N'London') 
            If IsDBNull(ClReader.Item(7)) Then
                ClFiche.PostalCode = ""
            Else
                ClFiche.PostalCode = ClReader.Item(7)
            End If
            ClFiche.Country = ClReader.Item(8)
            ClFiche.Phone = ClReader.Item(9)
            If IsDBNull(ClReader.Item(10)) Then
                ClFiche.Fax = ""
            Else
                ClFiche.Fax = ClReader.Item(10)
            End If
            If Not FicheClient.ContainsKey(cle) Then
                FicheClient.Add(cle, ClFiche)
            End If
            'MsgBox(ClReader.Item(0) & "/" & _
            '        ClReader.Item(1) & "/" & _
            '        ClReader.Item(2) & "/" & _
            '        ClReader.Item(3) & "/" & _
            '        ClReader.Item(4) & "/" & _
            '        ClReader.Item(5) & "/" & _
            '        ClReader.Item(6) & "/" & _
            '        ClReader.Item(7) & "/" & _
            '        ClReader.Item(8) & "/" & _
            '        ClReader.Item(9) & "/" & _
            '        ClReader.Item(10))              ' & "/" & _
        Loop
        ' Fermeture de l'objet DataReader
        ClReader.Close()
        ' Fermeture de l'objet Connection
        ClConnection.Close()
        RafraichirItemsDansComboBox1()
    End Sub
    Private Sub RafraichirItemsDansComboBox1()
        SqlStr = "SELECT CustomerID FROM Customers ORDER BY 1"
        ' Création de l'objet Connection
        ClConnection = New SqlConnection(connStr)
        ' Ouverture de la connexion
        ClConnection.Open()
        ' Création de l'objet Command 
        ClCommand = New SqlCommand(SqlStr, ClConnection)
        ' Création de l'objet DataReader
        Dim ClReader As SqlDataReader = ClCommand.ExecuteReader()
        Dim cle As String
        Do While ClReader.Read()
            cle = ClReader.Item(0)
            ' CustomerId 
            ComboBox1.Items.Add(cle)
        Loop
        ' Fermeture de l'objet DataReader
        ClReader.Close()
        ' Fermeture de l'objet Connection
        ClConnection.Close()

        'Me.ComboBox1.Items.Clear()
        'For Each Me.cle In FicheClient.Keys
        '    Me.ComboBox1.Items.Add(cle)
        'Next cle
    End Sub
    Private Sub AfficherFicheClient(ByVal cle As String)
        If Not FicheClient.ContainsKey(cle) Then
            MsgBox("Le no de client ==> " & cle & " <== n'existe pas.", vbOKOnly + vbCritical, "Erreur")
        Else
            Dim Client As New ClFiche
            Client = FicheClient.Item(cle)
            ' CustomerId 
            ' CompanyName
            ' ContactName 
            ' ContactTitle
            ' Address 
            ' City 
            ' Regions 
            ' PostalCode 
            ' Country 
            ' Phone 
            ' Fax
            Me.TextBox1.Text = Client.CustomerId
            Me.TextBox2.Text = Client.CompanyName
            Me.TextBox3.Text = Client.ContactName
            Me.TextBox4.Text = Client.ContactTitle
            Me.TextBox5.Text = Client.Address
            Me.TextBox6.Text = Client.City
            Me.TextBox7.Text = Client.Regions
            Me.TextBox8.Text = Client.PostalCode
            Me.TextBox9.Text = Client.Country
            Me.TextBox10.Text = Client.Phone
            Me.TextBox11.Text = Client.Fax
        End If
    End Sub

    Public Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cle = Me.ComboBox1.Text
        AfficherFicheClient(cle)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        FicheVide()
    End Sub
    Private Sub FicheVide()
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.TextBox4.Text = ""
        Me.TextBox5.Text = ""
        Me.TextBox6.Text = ""
        Me.TextBox7.Text = ""
        Me.TextBox8.Text = ""
        Me.TextBox9.Text = ""
        Me.TextBox10.Text = ""
        Me.TextBox11.Text = ""
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ' Chaîne de connexion
        connStr = "Data Source=ETU-SQL.lacitec.on.ca;Initial Catalog=BdEtuXX;" &
                         "Persist Security Info=True;User ID=etudiantXX; Password=" &
               motdepasse
        ' Commande SQL
        SqlStr = "INSERT Customers (CustomerID, CompanyName, ContactName, ContactTitle, " &
                  "Address, City, Region, PostalCode, Country, Phone, Fax)  " &
                  "VALUES (@CustomerID, @CompanyName, @ContactName, @ContactTitle, " &
                  "@Address, @City, @Regions, @PostalCode, @Country, @Phone, @Fax)"
        ' Création de l'objet Connection
        ClConnection = New SqlConnection(connStr)
        ' Ouverture de la connexion
        ClConnection.Open()
        ' Création de l'objet Command 
        ClCommand = New SqlCommand(SqlStr, ClConnection)
        ClCommand.Parameters.Clear()
        ClCommand.Parameters.AddWithValue("@CustomerID", Me.TextBox1.Text)
        ClCommand.Parameters.AddWithValue("@CompanyName", Me.TextBox2.Text)
        ClCommand.Parameters.AddWithValue("@ContactName", Me.TextBox3.Text)
        ClCommand.Parameters.AddWithValue("@ContactTitle", Me.TextBox4.Text)
        ClCommand.Parameters.AddWithValue("@Address", Me.TextBox5.Text)
        ClCommand.Parameters.AddWithValue("@City", Me.TextBox6.Text)
        ClCommand.Parameters.AddWithValue("@Regions", Me.TextBox7.Text)
        ClCommand.Parameters.AddWithValue("@PostalCode", Me.TextBox8.Text)
        ClCommand.Parameters.AddWithValue("@Country", Me.TextBox9.Text)
        ClCommand.Parameters.AddWithValue("@Phone", Me.TextBox10.Text)
        ClCommand.Parameters.AddWithValue("@Fax", Me.TextBox11.Text)
        Try
            ClCommand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Échec de l'insertion dans la base de données" &
                                vbCrLf & "ERREUR: " & vbCrLf & ex.Message)
        Finally
            ClConnection.Close()
        End Try
        ClConnection.Close()
        INS_CollectionEtComboBox()
    End Sub
    Private Sub INS_CollectionEtComboBox()
        ' CustomerId 
        ' CompanyName
        ' ContactName 
        ' ContactTitle
        ' Address 
        ' City 
        ' Regions 
        ' PostalCode 
        ' Country 
        ' Phone 
        ' Fax 
        Dim ClFiche As New ClFiche
        cle = Me.TextBox1.Text
        ClFiche.CustomerId = Me.TextBox1.Text
        ClFiche.CompanyName = Me.TextBox2.Text
        ClFiche.ContactName = Me.TextBox3.Text
        ClFiche.ContactTitle = Me.TextBox4.Text
        ClFiche.Address = Me.TextBox5.Text
        ClFiche.City = Me.TextBox6.Text
        ClFiche.Regions = Me.TextBox7.Text
        ClFiche.PostalCode = Me.TextBox8.Text
        ClFiche.Country = Me.TextBox9.Text
        ClFiche.Phone = Me.TextBox10.Text
        ClFiche.Fax = Me.TextBox11.Text
        If Not FicheClient.ContainsKey(cle) Then
            FicheClient.Add(cle, ClFiche)
        End If
        RafraichirItemsDansComboBox1()
    End Sub
    Private Sub DEL_CollectionEtComboBox()
        ' CustomerId 
        ' CompanyName
        ' ContactName 
        ' ContactTitle
        ' Address 
        ' City 
        ' Regions 
        ' PostalCode 
        ' Country 
        ' Phone 
        ' Fax 
        cle = Me.TextBox1.Text
        If FicheClient.ContainsKey(cle) Then
            FicheClient.Remove(cle)
        End If
        RafraichirItemsDansComboBox1()
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        ' Chaîne de connexion
        connStr = "Data Source=ETU-SQL.lacitec.on.ca;Initial Catalog=BdEtuXX;" &
                         "Persist Security Info=True;User ID=etudiantXX; Password=" &
               motdepasse
        ' Commande SQL
        SqlStr = "DELETE FROM Customers " &
                  "WHERE CustomerID = @CustomerID"
        ' Création de l'objet Connection
        ClConnection = New SqlConnection(connStr)
        ' Ouverture de la connexion
        ClConnection.Open()
        ' Création de l'objet Command 
        ClCommand = New SqlCommand(SqlStr, ClConnection)
        ClCommand.Parameters.Clear()
        ClCommand.Parameters.AddWithValue("@CustomerID", Me.TextBox1.Text)
        Try
            ClCommand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Échec de la suppression dans la base de données" &
                                vbCrLf & "ERREUR: " & vbCrLf & ex.Message)
        Finally
            ClConnection.Close()
        End Try
        ClConnection.Close()
        DEL_CollectionEtComboBox()
        FicheVide()
        Me.ComboBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ' Chaîne de connexion
        connStr = "Data Source=ETU-SQL.lacitec.on.ca;Initial Catalog=BdEtuXX;" &
                         "Persist Security Info=True;User ID=etudiantXX; Password=" &
               motdepasse
        ' Commande SQL
        SqlStr = "UPDATE Customers SET CompanyName = @CompanyName, " &
                                       "ContactName = @ContactName, " &
                                        "ContactTitle = @ContactTitle, " &
                                        "Address = @Address, " &
                                        "City = @City, " &
                                        "Region = @Regions, " &
                                        "PostalCode = @PostalCode, " &
                                        "Country = @Country, " &
                                        "Phone = @Phone, " &
                                        "Fax  = @Fax " &
                                        "WHERE CustomerID = @CustomerID"
        ' Création de l'objet Connection
        ClConnection = New SqlConnection(connStr)
        ' Ouverture de la connexion
        ClConnection.Open()
        ' Création de l'objet Command 
        ClCommand = New SqlCommand(SqlStr, ClConnection)
        ClCommand.Parameters.Clear()
        ClCommand.Parameters.AddWithValue("@CustomerID", Me.TextBox1.Text)
        ClCommand.Parameters.AddWithValue("@CompanyName", Me.TextBox2.Text)
        ClCommand.Parameters.AddWithValue("@ContactName", Me.TextBox3.Text)
        ClCommand.Parameters.AddWithValue("@ContactTitle", Me.TextBox4.Text)
        ClCommand.Parameters.AddWithValue("@Address", Me.TextBox5.Text)
        ClCommand.Parameters.AddWithValue("@City", Me.TextBox6.Text)
        ClCommand.Parameters.AddWithValue("@Regions", Me.TextBox7.Text)
        ClCommand.Parameters.AddWithValue("@PostalCode", Me.TextBox8.Text)
        ClCommand.Parameters.AddWithValue("@Country", Me.TextBox9.Text)
        ClCommand.Parameters.AddWithValue("@Phone", Me.TextBox10.Text)
        ClCommand.Parameters.AddWithValue("@Fax", Me.TextBox11.Text)
        Try
            ClCommand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Échec de la mise à jour dans la base de données" &
                                vbCrLf & "ERREUR: " & vbCrLf & ex.Message)
        Finally
            ClConnection.Close()
        End Try
        ClConnection.Close()
        MAJ_Collection()
    End Sub
    Private Sub MAJ_Collection()
        ' CustomerId 
        ' CompanyName
        ' ContactName 
        ' ContactTitle
        ' Address 
        ' City 
        ' Regions 
        ' PostalCode 
        ' Country 
        ' Phone 
        ' Fax 
        If FicheClient.ContainsKey(cle) Then
            FicheClient.Remove(cle)
        End If
        Dim ClFiche As New ClFiche
        cle = Me.TextBox1.Text
        ClFiche.CustomerId = Me.TextBox1.Text
        ClFiche.CompanyName = Me.TextBox2.Text
        ClFiche.ContactName = Me.TextBox3.Text
        ClFiche.ContactTitle = Me.TextBox4.Text
        ClFiche.Address = Me.TextBox5.Text
        ClFiche.City = Me.TextBox6.Text
        ClFiche.Regions = Me.TextBox7.Text
        ClFiche.PostalCode = Me.TextBox8.Text
        ClFiche.Country = Me.TextBox9.Text
        ClFiche.Phone = Me.TextBox10.Text
        ClFiche.Fax = Me.TextBox11.Text
        If Not FicheClient.ContainsKey(cle) Then
            FicheClient.Add(cle, ClFiche)
        End If
    End Sub

    Private Sub FermerApplicationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FermerApplicationToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

