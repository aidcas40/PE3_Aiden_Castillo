'----------------------------------------------------------------------------------
'Program Title: 		Allegro
'Program Author: 		Aiden Castillo
'Date Created:  		25 March, 2023
'School:			    Corozal Junior College
'Course Number/Name:	CS206 - Programming II
'Program Description:	This program demonstrates various database entry functionalities and controls using MS SQL (Individual Work).
'                       My program is also based around a manga (Japanese comic books) cataloging application.
'----------------------------------------------------------------------------------
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Public Class frmFujiMain

    'Saves changes made to the database by validating and updating it
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
        dgvProduct.Columns(12).HeaderText = "Deluxe Edition"

        'Add Image label starts off with visible being false when the form loads
        lblAddImage.Visible = False
    End Sub

    'Public function that binds data from a the database to the DataGridView control named dgvProduct
    Public Sub BindData()
        Dim query As String = "SELECT * FROM Product"
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbFuji.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        dgvProduct.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
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
        lblAddImage.Visible = True 'Makes Add Image label visible when Add Button is clicked

        BindingNavigatorAddNewItem.PerformClick()

        'Makes the checkboxes unchecked for new item when the add item button is clicked
        chkProdDeluxe.Checked = False
        chkProdInStock.Checked = False

        'Clears values for these fields
        nudProdVolume.Value = Nothing
        nudProdChapter.Value = Nothing
        nudProdVolume.Text = ""
        nudProdChapter.Text = ""

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

            'lbl.Text &= " *"
            'Label1.ForeColor = Color.Red ' set the color of the asterisk to red
            'Timer1.Interval = 5000 ' set the interval to 5000 milliseconds (5 seconds)
            'Timer1.Start()
        Else

            ' Saves the image by connecting to the database (Image is saved as byte)
            If Not IsNothing(pctProdImage.Image) Then
                Dim ms As New MemoryStream()
                If OpenFileDialog1.FileName.ToLower().EndsWith(".jpg") Then
                    pctProdImage.Image.Save(ms, ImageFormat.Jpeg)
                ElseIf OpenFileDialog1.FileName.ToLower().EndsWith(".png") Then
                    pctProdImage.Image.Save(ms, ImageFormat.Png)
                End If
                Dim imageData As Byte() = ms.GetBuffer()
                ms.Close()
                Dim conn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbFuji.mdf;Integrated Security=True")
                Dim cmd As New SqlCommand("UPDATE Product SET prodImage = @ImageData WHERE prodID = @prodID", conn)
                cmd.Parameters.AddWithValue("@ImageData", imageData)
                cmd.Parameters.AddWithValue("@prodID", txtProdID.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End If

            ProductBindingNavigatorSaveItem.PerformClick()

            'Re-bind the data source to refresh the DataGridView
            dgvProduct.DataSource = Nothing 'Clear the current data source
            dgvProduct.DataSource = search1() 'Re-bind the DataGridView to the updated search results
        End If
    End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Label1.Text = Label1.Text.Replace(" *", "")
    '    Label1.ForeColor = Color.Black ' reset the color of the label to black
    '    Timer1.Stop()
    'End Sub

    'Deletes an item
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'Declaring and Defining variable to be used n the delete 
        Dim ID As Integer = txtProdID.Text

        'Messae Box to confirm deletion of an item from the database
        Dim msgDelete = MessageBox.Show("Are you sure you want to delete this item?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgDelete = Windows.Forms.DialogResult.Yes Then

            BindingNavigatorDeleteItem.PerformClick()

            'Connects to the database in order to delete an item
            Dim query As String = "Delete Product where prodID = @prodId"
            Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbFuji.mdf;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@prodId", ID)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    BindData()
                End Using
            End Using
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
        Dim msgClose = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgClose = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub

    'Opens up Windows File Manager whenever the picture box is clicked, so that the user can insert a picture
    Private Sub pctProdImage_Click(sender As Object, e As EventArgs) Handles pctProdImage.Click
        Try
            With OpenFileDialog1
                'Filtering file type
                .Filter = ("Image Files| *.png; *.Jpeg; *.jpg")
                .FilterIndex = 1
            End With

            OpenFileDialog1.FileName = "" 'clear the file name'
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pctProdImage.Image = Image.FromFile(OpenFileDialog1.FileName)
                lblAddImage.Visible = False 'Add Image label visiblility is set to false as an Image is chosen
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Function that suppresses/ignores Data Grid View error message when updating (commented out as the update button seems to function now)
    'Private Sub dgvProduct_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvProduct.DataError
    '    ' Suppress the error message
    '    e.ThrowException = False
    'End Sub
End Class
