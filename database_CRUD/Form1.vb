Imports System.Data.SqlClient

Public Class frmCRUD
    Dim myst As String
    Dim myConnection As SqlConnection = New SqlConnection(connectionString:="Data Source=(local)\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;database=test")
    Dim myCommand As SqlCommand
    Dim da As New SqlDataAdapter
    Dim myread As SqlDataReader
    Dim dse As New DataSet

    Dim st As String
    Dim count As Integer


    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        If txtName.Text = "" Then
            MsgBox("Enter Name!")
        End If

        If txtNumber.Text = "" Then
            MsgBox("Enter Number!")

        Else
            st = "INSERT INTO names1 (Name, Number) Values (@nme, @num)"


            myConnection.Open()
            myCommand = New SqlCommand(st, myConnection)
            da.SelectCommand = myCommand
            'da.Fill(dse)
            'da.Dispose()
            'myCommand.Dispose()

            myCommand.Parameters.Add("@nme", SqlDbType.NText).Value = txtName.Text
            myCommand.Parameters.Add("@num", SqlDbType.Int).Value = txtNumber.Text

            myCommand.ExecuteNonQuery()

            MsgBox("'" & txtName.Text.ToString & "' added to Database")

            myConnection.Close()
        End If
        '  myConnection = New SqlConnection("Data Source=(local)\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;database=test")

    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click

        accessdb()

        txtName.Text = dse.Tables(0).Rows(0).Item(0).ToString
        txtNumber.Text = dse.Tables(0).Rows(0).Item(1).ToString

        Names1TableAdapter.ClearBeforeFill = True
        Names1TableAdapter.Fill(Me.TestDataSet.names1)



    End Sub



    Public Sub accessdb()

        st = "Select * from names1"


        myConnection.Open()
        myCommand = New SqlCommand(st, myConnection)
        da.SelectCommand = myCommand
        da.Fill(dse)
        da.Dispose()
        myCommand.Dispose()
        myConnection.Close()
    End Sub

    Private Sub frmCRUD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.names1' table. You can move, or remove it, as needed.
        Me.Names1TableAdapter.Fill(Me.TestDataSet.names1)

    End Sub

   
  
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        st = "Update names1 SET Number=@num WHERE Name LIKE @nme"


        myConnection.Open()
        myCommand = New SqlCommand(st, myConnection)
        da.SelectCommand = myCommand
       


       
        myCommand.Parameters.AddWithValue("@nme", txtName.Text)
        myCommand.Parameters.AddWithValue("@num", txtNumber.Text)

        myCommand.ExecuteNonQuery()

        MsgBox("'" & txtName.Text.ToString & "' Updated.")
        myCommand.Dispose()
        da.Fill(dse)
        da.Dispose()
        myCommand.Dispose()
        myConnection.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click


        st = "CREATE PROCEDURE Del_Person (@name_person ntext) AS BEGIN DELETE FROM names1 WHERE Name LIKE @name_person"


        myConnection.Open()
        myCommand = New SqlCommand(st, myConnection)
        da.DeleteCommand = myCommand


        myCommand.Parameters.AddWithValue("EXEC Del_Person @name_person ", txtName.Text)
        myCommand.Parameters.AddWithValue("@num", txtNumber.Text)

        myCommand.ExecuteNonQuery()

        MsgBox("Selected Record Deleted!")
        myCommand.Dispose()

        da.Dispose()
        myConnection.Close()
    End Sub
End Class
