﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFujiMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblProdImage As System.Windows.Forms.Label
        Dim lblProdID As System.Windows.Forms.Label
        Dim lblProdName As System.Windows.Forms.Label
        Dim lblProdAuthor As System.Windows.Forms.Label
        Dim lblProdSerial As System.Windows.Forms.Label
        Dim lblProdDemograph As System.Windows.Forms.Label
        Dim lblProdVolume As System.Windows.Forms.Label
        Dim lblProdChapter As System.Windows.Forms.Label
        Dim lblProdStatus As System.Windows.Forms.Label
        Dim lblProdPublish As System.Windows.Forms.Label
        Dim lblProdGenre As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFujiMain))
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbFujiDataSet = New PE3_Aiden_Castillo.dbFujiDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pctProdImage = New System.Windows.Forms.PictureBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.txtProdAuthor = New System.Windows.Forms.TextBox()
        Me.cbxProdSerial = New System.Windows.Forms.ComboBox()
        Me.cbxProdDemograph = New System.Windows.Forms.ComboBox()
        Me.nudProdVolume = New System.Windows.Forms.NumericUpDown()
        Me.nudProdChapter = New System.Windows.Forms.NumericUpDown()
        Me.cbxProdStatus = New System.Windows.Forms.ComboBox()
        Me.dtpProdPublish = New System.Windows.Forms.DateTimePicker()
        Me.chkProdInStock = New System.Windows.Forms.CheckBox()
        Me.chkProdDeluxe = New System.Windows.Forms.CheckBox()
        Me.chklstProdGenre = New System.Windows.Forms.CheckedListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ProductTableAdapter = New PE3_Aiden_Castillo.dbFujiDataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New PE3_Aiden_Castillo.dbFujiDataSetTableAdapters.TableAdapterManager()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        lblProdImage = New System.Windows.Forms.Label()
        lblProdID = New System.Windows.Forms.Label()
        lblProdName = New System.Windows.Forms.Label()
        lblProdAuthor = New System.Windows.Forms.Label()
        lblProdSerial = New System.Windows.Forms.Label()
        lblProdDemograph = New System.Windows.Forms.Label()
        lblProdVolume = New System.Windows.Forms.Label()
        lblProdChapter = New System.Windows.Forms.Label()
        lblProdStatus = New System.Windows.Forms.Label()
        lblProdPublish = New System.Windows.Forms.Label()
        lblProdGenre = New System.Windows.Forms.Label()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbFujiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pctProdImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudProdVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudProdChapter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProdImage
        '
        lblProdImage.AutoSize = True
        lblProdImage.Location = New System.Drawing.Point(91, 292)
        lblProdImage.Name = "lblProdImage"
        lblProdImage.Size = New System.Drawing.Size(74, 16)
        lblProdImage.TabIndex = 3
        lblProdImage.Text = "Add Image"
        '
        'lblProdID
        '
        lblProdID.AutoSize = True
        lblProdID.Location = New System.Drawing.Point(232, 79)
        lblProdID.Name = "lblProdID"
        lblProdID.Size = New System.Drawing.Size(77, 16)
        lblProdID.TabIndex = 5
        lblProdID.Text = "Product ID:"
        '
        'lblProdName
        '
        lblProdName.AutoSize = True
        lblProdName.Location = New System.Drawing.Point(232, 117)
        lblProdName.Name = "lblProdName"
        lblProdName.Size = New System.Drawing.Size(48, 16)
        lblProdName.TabIndex = 7
        lblProdName.Text = "Name:"
        '
        'lblProdAuthor
        '
        lblProdAuthor.AutoSize = True
        lblProdAuthor.Location = New System.Drawing.Point(232, 155)
        lblProdAuthor.Name = "lblProdAuthor"
        lblProdAuthor.Size = New System.Drawing.Size(55, 16)
        lblProdAuthor.TabIndex = 11
        lblProdAuthor.Text = "Author:"
        '
        'lblProdSerial
        '
        lblProdSerial.AutoSize = True
        lblProdSerial.Location = New System.Drawing.Point(232, 193)
        lblProdSerial.Name = "lblProdSerial"
        lblProdSerial.Size = New System.Drawing.Size(87, 16)
        lblProdSerial.TabIndex = 13
        lblProdSerial.Text = "Serialization:"
        '
        'lblProdDemograph
        '
        lblProdDemograph.AutoSize = True
        lblProdDemograph.Location = New System.Drawing.Point(232, 231)
        lblProdDemograph.Name = "lblProdDemograph"
        lblProdDemograph.Size = New System.Drawing.Size(94, 16)
        lblProdDemograph.TabIndex = 15
        lblProdDemograph.Text = "Demographic:"
        '
        'lblProdVolume
        '
        lblProdVolume.AutoSize = True
        lblProdVolume.Location = New System.Drawing.Point(232, 269)
        lblProdVolume.Name = "lblProdVolume"
        lblProdVolume.Size = New System.Drawing.Size(58, 16)
        lblProdVolume.TabIndex = 17
        lblProdVolume.Text = "Volume:"
        '
        'lblProdChapter
        '
        lblProdChapter.AutoSize = True
        lblProdChapter.Location = New System.Drawing.Point(564, 79)
        lblProdChapter.Name = "lblProdChapter"
        lblProdChapter.Size = New System.Drawing.Size(62, 16)
        lblProdChapter.TabIndex = 19
        lblProdChapter.Text = "Chapter:"
        '
        'lblProdStatus
        '
        lblProdStatus.AutoSize = True
        lblProdStatus.Location = New System.Drawing.Point(564, 117)
        lblProdStatus.Name = "lblProdStatus"
        lblProdStatus.Size = New System.Drawing.Size(52, 16)
        lblProdStatus.TabIndex = 21
        lblProdStatus.Text = "Status:"
        '
        'lblProdPublish
        '
        lblProdPublish.AutoSize = True
        lblProdPublish.Location = New System.Drawing.Point(564, 155)
        lblProdPublish.Name = "lblProdPublish"
        lblProdPublish.Size = New System.Drawing.Size(73, 16)
        lblProdPublish.TabIndex = 23
        lblProdPublish.Text = "Published:"
        '
        'lblProdGenre
        '
        lblProdGenre.AutoSize = True
        lblProdGenre.Location = New System.Drawing.Point(564, 231)
        lblProdGenre.Name = "lblProdGenre"
        lblProdGenre.Size = New System.Drawing.Size(51, 16)
        lblProdGenre.TabIndex = 28
        lblProdGenre.Text = "Genre:"
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductBindingNavigatorSaveItem})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(914, 25)
        Me.ProductBindingNavigator.TabIndex = 0
        Me.ProductBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.DbFujiDataSet
        '
        'DbFujiDataSet
        '
        Me.DbFujiDataSet.DataSetName = "dbFujiDataSet"
        Me.DbFujiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProductBindingNavigatorSaveItem
        '
        Me.ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductBindingNavigatorSaveItem.Name = "ProductBindingNavigatorSaveItem"
        Me.ProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProductBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 40)
        Me.Panel1.TabIndex = 2
        '
        'pctProdImage
        '
        Me.pctProdImage.BackColor = System.Drawing.Color.White
        Me.pctProdImage.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductBindingSource, "prodImage", True))
        Me.pctProdImage.Image = CType(resources.GetObject("pctProdImage.Image"), System.Drawing.Image)
        Me.pctProdImage.Location = New System.Drawing.Point(60, 79)
        Me.pctProdImage.Name = "pctProdImage"
        Me.pctProdImage.Size = New System.Drawing.Size(140, 210)
        Me.pctProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pctProdImage.TabIndex = 4
        Me.pctProdImage.TabStop = False
        '
        'txtProdID
        '
        Me.txtProdID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "prodID", True))
        Me.txtProdID.Location = New System.Drawing.Point(326, 76)
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(200, 23)
        Me.txtProdID.TabIndex = 6
        '
        'txtProdName
        '
        Me.txtProdName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "prodName", True))
        Me.txtProdName.Location = New System.Drawing.Point(326, 114)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(200, 23)
        Me.txtProdName.TabIndex = 8
        '
        'txtProdAuthor
        '
        Me.txtProdAuthor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "prodAuthor", True))
        Me.txtProdAuthor.Location = New System.Drawing.Point(326, 152)
        Me.txtProdAuthor.Name = "txtProdAuthor"
        Me.txtProdAuthor.Size = New System.Drawing.Size(200, 23)
        Me.txtProdAuthor.TabIndex = 12
        '
        'cbxProdSerial
        '
        Me.cbxProdSerial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "prodSerial", True))
        Me.cbxProdSerial.FormattingEnabled = True
        Me.cbxProdSerial.Items.AddRange(New Object() {"Afternoon", "Bessatsu Shounen", "Big Comic Original", "Big Comic Spirits", "Gessan", "Jump SQ", "Manga Time Kirara MAX", "Morning", "Shounen Jump+", "Shounen Sunday", "Young Animal", "Young King", "Young Jump"})
        Me.cbxProdSerial.Location = New System.Drawing.Point(326, 189)
        Me.cbxProdSerial.Name = "cbxProdSerial"
        Me.cbxProdSerial.Size = New System.Drawing.Size(200, 24)
        Me.cbxProdSerial.TabIndex = 14
        '
        'cbxProdDemograph
        '
        Me.cbxProdDemograph.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "prodDemograph", True))
        Me.cbxProdDemograph.FormattingEnabled = True
        Me.cbxProdDemograph.Items.AddRange(New Object() {"Shounen", "Kodomo", "Seinen", "Shojo", "Josei", "Dojinshi", "Gekiga", "Silver & Golden"})
        Me.cbxProdDemograph.Location = New System.Drawing.Point(326, 227)
        Me.cbxProdDemograph.Name = "cbxProdDemograph"
        Me.cbxProdDemograph.Size = New System.Drawing.Size(200, 24)
        Me.cbxProdDemograph.TabIndex = 16
        '
        'nudProdVolume
        '
        Me.nudProdVolume.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "prodVolume", True))
        Me.nudProdVolume.Location = New System.Drawing.Point(326, 266)
        Me.nudProdVolume.Name = "nudProdVolume"
        Me.nudProdVolume.Size = New System.Drawing.Size(200, 23)
        Me.nudProdVolume.TabIndex = 18
        '
        'nudProdChapter
        '
        Me.nudProdChapter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudProdChapter.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "prodChapter", True))
        Me.nudProdChapter.Location = New System.Drawing.Point(643, 76)
        Me.nudProdChapter.Name = "nudProdChapter"
        Me.nudProdChapter.Size = New System.Drawing.Size(200, 23)
        Me.nudProdChapter.TabIndex = 20
        '
        'cbxProdStatus
        '
        Me.cbxProdStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "prodStatus", True))
        Me.cbxProdStatus.FormattingEnabled = True
        Me.cbxProdStatus.Items.AddRange(New Object() {"Releasing", "Finished", "On Hiatus", "Cancelled", "Unknown"})
        Me.cbxProdStatus.Location = New System.Drawing.Point(643, 113)
        Me.cbxProdStatus.Name = "cbxProdStatus"
        Me.cbxProdStatus.Size = New System.Drawing.Size(200, 24)
        Me.cbxProdStatus.TabIndex = 22
        '
        'dtpProdPublish
        '
        Me.dtpProdPublish.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ProductBindingSource, "prodPublish", True))
        Me.dtpProdPublish.Location = New System.Drawing.Point(643, 152)
        Me.dtpProdPublish.Name = "dtpProdPublish"
        Me.dtpProdPublish.Size = New System.Drawing.Size(200, 23)
        Me.dtpProdPublish.TabIndex = 24
        '
        'chkProdInStock
        '
        Me.chkProdInStock.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductBindingSource, "prodInStock", True))
        Me.chkProdInStock.Location = New System.Drawing.Point(762, 189)
        Me.chkProdInStock.Name = "chkProdInStock"
        Me.chkProdInStock.Size = New System.Drawing.Size(81, 24)
        Me.chkProdInStock.TabIndex = 26
        Me.chkProdInStock.Text = "In Stock"
        Me.chkProdInStock.UseVisualStyleBackColor = True
        '
        'chkProdDeluxe
        '
        Me.chkProdDeluxe.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductBindingSource, "prodDeluxe", True))
        Me.chkProdDeluxe.Location = New System.Drawing.Point(643, 189)
        Me.chkProdDeluxe.Name = "chkProdDeluxe"
        Me.chkProdDeluxe.Size = New System.Drawing.Size(118, 24)
        Me.chkProdDeluxe.TabIndex = 28
        Me.chkProdDeluxe.Text = "Deluxe Edition"
        Me.chkProdDeluxe.UseVisualStyleBackColor = True
        '
        'chklstProdGenre
        '
        Me.chklstProdGenre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.chklstProdGenre.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ProductBindingSource, "prodGenre", True))
        Me.chklstProdGenre.FormattingEnabled = True
        Me.chklstProdGenre.Items.AddRange(New Object() {"Action", "Adventure", "Adult", "Comedy", "Cyberpunk", "Drama", "Fantasy", "Historical", "Horror", "Martial Arts", "Mecha", "Psychological", "Romance", "Samurai", "Slice of Life", "Supernatural", "Thriller"})
        Me.chklstProdGenre.Location = New System.Drawing.Point(643, 231)
        Me.chklstProdGenre.Name = "chklstProdGenre"
        Me.chklstProdGenre.Size = New System.Drawing.Size(200, 72)
        Me.chklstProdGenre.TabIndex = 29
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(60, 338)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(115, 31)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNext.Location = New System.Drawing.Point(181, 338)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(115, 31)
        Me.btnNext.TabIndex = 31
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(501, 338)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(115, 31)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(623, 338)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(115, 31)
        Me.btnUpdate.TabIndex = 33
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(745, 338)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(115, 31)
        Me.btnDelete.TabIndex = 34
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = PE3_Aiden_Castillo.dbFujiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.AllowUserToResizeRows = False
        Me.dgvProduct.AutoGenerateColumns = False
        Me.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2})
        Me.dgvProduct.DataSource = Me.ProductBindingSource
        Me.dgvProduct.Location = New System.Drawing.Point(38, 458)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.Size = New System.Drawing.Size(842, 220)
        Me.dgvProduct.TabIndex = 34
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "prodID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "prodID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "prodName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "prodName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "prodImage"
        Me.DataGridViewImageColumn1.HeaderText = "prodImage"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "prodAuthor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "prodAuthor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "prodSerial"
        Me.DataGridViewTextBoxColumn4.HeaderText = "prodSerial"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "prodStatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "prodStatus"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "prodVolume"
        Me.DataGridViewTextBoxColumn6.HeaderText = "prodVolume"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "prodChapter"
        Me.DataGridViewTextBoxColumn7.HeaderText = "prodChapter"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "prodPublish"
        Me.DataGridViewTextBoxColumn8.HeaderText = "prodPublish"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "prodGenre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "prodGenre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "prodDemograph"
        Me.DataGridViewTextBoxColumn10.HeaderText = "prodDemograph"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "prodInStock"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "prodInStock"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "prodDeluxe"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "prodDeluxe"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Inter", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHeader.Location = New System.Drawing.Point(6, 8)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(172, 23)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Manga Catalogue"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(500, 375)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(115, 31)
        Me.btnSearch.TabIndex = 35
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(623, 377)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(237, 27)
        Me.txtSearch.TabIndex = 36
        '
        'frmFujiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(914, 700)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.dgvProduct)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(lblProdGenre)
        Me.Controls.Add(Me.chklstProdGenre)
        Me.Controls.Add(Me.chkProdDeluxe)
        Me.Controls.Add(Me.chkProdInStock)
        Me.Controls.Add(lblProdPublish)
        Me.Controls.Add(Me.dtpProdPublish)
        Me.Controls.Add(lblProdStatus)
        Me.Controls.Add(Me.cbxProdStatus)
        Me.Controls.Add(lblProdChapter)
        Me.Controls.Add(Me.nudProdChapter)
        Me.Controls.Add(lblProdVolume)
        Me.Controls.Add(Me.nudProdVolume)
        Me.Controls.Add(lblProdDemograph)
        Me.Controls.Add(Me.cbxProdDemograph)
        Me.Controls.Add(lblProdSerial)
        Me.Controls.Add(Me.cbxProdSerial)
        Me.Controls.Add(lblProdAuthor)
        Me.Controls.Add(Me.txtProdAuthor)
        Me.Controls.Add(lblProdName)
        Me.Controls.Add(Me.txtProdName)
        Me.Controls.Add(lblProdID)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(lblProdImage)
        Me.Controls.Add(Me.pctProdImage)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmFujiMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fuji"
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbFujiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pctProdImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudProdVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudProdChapter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbFujiDataSet As dbFujiDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As dbFujiDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As dbFujiDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pctProdImage As PictureBox
    Friend WithEvents txtProdID As TextBox
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtProdAuthor As TextBox
    Friend WithEvents cbxProdSerial As ComboBox
    Friend WithEvents cbxProdDemograph As ComboBox
    Friend WithEvents nudProdVolume As NumericUpDown
    Friend WithEvents nudProdChapter As NumericUpDown
    Friend WithEvents cbxProdStatus As ComboBox
    Friend WithEvents dtpProdPublish As DateTimePicker
    Friend WithEvents chkProdInStock As CheckBox
    Friend WithEvents chkProdDeluxe As CheckBox
    Friend WithEvents chklstProdGenre As CheckedListBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
End Class
