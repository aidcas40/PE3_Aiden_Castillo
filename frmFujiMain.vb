'----------------------------------------------------------------------------------
'Program Title: 		Allegro
'Program Author: 		Aiden Castillo
'Date Created:  		25 March, 2023
'School:			    Corozal Junior College
'Course Number/Name:	CS206 - Programming II
'Program Description:	This program demonstrates various database entry functionalities and controls using MS SQL (Individual Work).
'----------------------------------------------------------------------------------
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class frmFujiMain

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbFujiDataSet)

    End Sub

    Private Sub frmFujiMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbFujiDataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DbFujiDataSet.Product)

        'Changing text in header columns
        dgvProduct.Columns(0).HeaderText = "Product ID"
        dgvProduct.Columns(1).HeaderText = "Name"
        dgvProduct.Columns(2).HeaderText = "Image"
        dgvProduct.Columns(3).HeaderText = "Author"
        dgvProduct.Columns(4).HeaderText = "Serialization"
        dgvProduct.Columns(5).HeaderText = "Status"
        dgvProduct.Columns(6).HeaderText = "Volume"
        dgvProduct.Columns(7).HeaderText = "Chapter"
        dgvProduct.Columns(8).HeaderText = "Date Published"
        dgvProduct.Columns(9).HeaderText = "Genre"
        dgvProduct.Columns(10).HeaderText = "Demographic"
        dgvProduct.Columns(11).HeaderText = "In Stock"
        dgvProduct.Columns(12).HeaderText = "Deluxe"

    End Sub

    'Goes to the previous item
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        BindingNavigatorMovePreviousItem.PerformClick()
    End Sub

    'Goes to the next item
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingNavigatorMoveNextItem.PerformClick()
    End Sub

    'Adds new item
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        BindingNavigatorAddNewItem.PerformClick()

        chkProdDeluxe.Checked = False
        chkProdInStock.Checked = False
        'Re-bind the data source to refresh the DataGridView
        dgvProduct.DataSource = Nothing 'Clear the current data source
        dgvProduct.DataSource = search1() 'Re-bind the DataGridView to the updated search results
    End Sub

    'Saves new item or update previous ones
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtProdName.Text) OrElse String.IsNullOrEmpty(txtProdAuthor.Text) OrElse String.IsNullOrEmpty(cbxProdSerial.Text) OrElse String.IsNullOrEmpty(cbxProdStatus.Text) OrElse
            String.IsNullOrEmpty(nudProdVolume.Text) OrElse String.IsNullOrEmpty(nudProdChapter.Text) OrElse dtpProdPublish.Value = Nothing OrElse String.IsNullOrEmpty(cbxProdGenre.Text) OrElse
            String.IsNullOrEmpty(cbxProdDemograph.Text) Then
            MessageBox.Show("Please enter a value in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            'Try
            '    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbFuji.mdf;Integrated Security=True")
            '    con.Open()
            '    Dim que As String = "insert into Product (prodName,prodImage,prodAuthor,prodSerial,prodStatus,prodVolume,prodChapter,prodPublish,prodGenre,prodDemograph,prodInStock,prodDeluxe) 
            '                        values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13)"
            '    Dim cmd = New SqlConnection(que, con)
            '    cmd.parameters.AddValue()
            'Catch ex As Exception

            'End Try

            ProductBindingNavigatorSaveItem.PerformClick()

            'Re-bind the data source to refresh the DataGridView
            dgvProduct.DataSource = Nothing 'Clear the current data source
            dgvProduct.DataSource = search1() 'Re-bind the DataGridView to the updated search results
        End If
    End Sub

    'Deletes an item
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Messae Box to confirm deletion of an item from the database
        Dim msgDelete = MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If msgDelete = Windows.Forms.DialogResult.Yes Then
            BindingNavigatorDeleteItem.PerformClick()

            'Re-bind the data source to refresh the DataGridView
            dgvProduct.DataSource = Nothing 'Clear the current data source
            dgvProduct.DataSource = search1() 'Re-bind the DataGridView to the updated search results
        Else
            Exit Sub
        End If
    End Sub

    'Creating search function for Product datagridview table. Connects to the database to accomplish this
    Private Function search1() As DataTable
        Dim query1 As String = "SELECT * From Product"
        query1 &= " Where prodName Like '%' +@parm1+ '%' "
        query1 &= " or prodAuthor Like '%' +@parm1+ '%' "
        query1 &= " or prodSerial Like '%' +@parm1+ '%' "
        query1 &= " or prodStatus Like '%' +@parm1+ '%' "
        query1 &= " or prodGenre Like '%' +@parm1+ '%' "
        query1 &= " or prodDemograph Like '%' +@parm1+ '%' Order by ProdId"
        Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbFuji.mdf;Integrated Security=True")
        Dim cmd As New SqlCommand(query1, conn)
        cmd.Parameters.AddWithValue("parm1", txtSearch.Text.Trim)
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        dgvProduct.DataSource = dt
        Return dt
    End Function

    'Using search1() on a textbox. Search is active when the text in the textbox is changed/typed
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Focused Then
            search1()
        End If
    End Sub

    'Closes the entire application. Message box ask for confirmation to close application
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim msgClose = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgClose = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub pctProdImage_Click(sender As Object, e As EventArgs) Handles pctProdImage.Click
        Try
            With OpenFileDialog1
                .Filter = ("Image Files| *.png; *.Jpeg; *.jpg")
                .FilterIndex = 1
            End With

            OpenFileDialog1.FileName = "" 'clear the file name'
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pctProdImage.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
