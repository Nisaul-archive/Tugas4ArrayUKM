<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblNPM = New System.Windows.Forms.Label()
        Me.lblProdi = New System.Windows.Forms.Label()
        Me.tbNPM = New System.Windows.Forms.TextBox()
        Me.tbProdi = New System.Windows.Forms.TextBox()
        Me.tbTelepon = New System.Windows.Forms.TextBox()
        Me.lblTelepon = New System.Windows.Forms.Label()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.lblJenisKelamin = New System.Windows.Forms.Label()
        Me.RbLakilaki = New System.Windows.Forms.RadioButton()
        Me.RbPerempuan = New System.Windows.Forms.RadioButton()
        Me.cbSemester = New System.Windows.Forms.ComboBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lvDataMahasiswa = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.UKMCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(47, 52)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(64, 25)
        Me.lblNama.TabIndex = 0
        Me.lblNama.Text = "Nama"
        '
        'lblNPM
        '
        Me.lblNPM.AutoSize = True
        Me.lblNPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPM.Location = New System.Drawing.Point(47, 110)
        Me.lblNPM.Name = "lblNPM"
        Me.lblNPM.Size = New System.Drawing.Size(56, 25)
        Me.lblNPM.TabIndex = 1
        Me.lblNPM.Text = "NPM"
        '
        'lblProdi
        '
        Me.lblProdi.AutoSize = True
        Me.lblProdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdi.Location = New System.Drawing.Point(47, 172)
        Me.lblProdi.Name = "lblProdi"
        Me.lblProdi.Size = New System.Drawing.Size(57, 25)
        Me.lblProdi.TabIndex = 2
        Me.lblProdi.Text = "Prodi"
        '
        'tbNPM
        '
        Me.tbNPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNPM.Location = New System.Drawing.Point(155, 108)
        Me.tbNPM.Name = "tbNPM"
        Me.tbNPM.Size = New System.Drawing.Size(218, 30)
        Me.tbNPM.TabIndex = 4
        '
        'tbProdi
        '
        Me.tbProdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProdi.Location = New System.Drawing.Point(155, 167)
        Me.tbProdi.Name = "tbProdi"
        Me.tbProdi.Size = New System.Drawing.Size(218, 30)
        Me.tbProdi.TabIndex = 5
        '
        'tbTelepon
        '
        Me.tbTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelepon.Location = New System.Drawing.Point(624, 168)
        Me.tbTelepon.Name = "tbTelepon"
        Me.tbTelepon.Size = New System.Drawing.Size(218, 30)
        Me.tbTelepon.TabIndex = 11
        '
        'lblTelepon
        '
        Me.lblTelepon.AutoSize = True
        Me.lblTelepon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelepon.Location = New System.Drawing.Point(435, 170)
        Me.lblTelepon.Name = "lblTelepon"
        Me.lblTelepon.Size = New System.Drawing.Size(147, 25)
        Me.lblTelepon.TabIndex = 8
        Me.lblTelepon.Text = "Nomor Telepon"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(436, 113)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(96, 25)
        Me.lblSemester.TabIndex = 7
        Me.lblSemester.Text = "Semester"
        '
        'lblJenisKelamin
        '
        Me.lblJenisKelamin.AutoSize = True
        Me.lblJenisKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenisKelamin.Location = New System.Drawing.Point(435, 52)
        Me.lblJenisKelamin.Name = "lblJenisKelamin"
        Me.lblJenisKelamin.Size = New System.Drawing.Size(135, 25)
        Me.lblJenisKelamin.TabIndex = 6
        Me.lblJenisKelamin.Text = "Jenis Kelamin"
        '
        'RbLakilaki
        '
        Me.RbLakilaki.AutoSize = True
        Me.RbLakilaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbLakilaki.Location = New System.Drawing.Point(624, 45)
        Me.RbLakilaki.Name = "RbLakilaki"
        Me.RbLakilaki.Size = New System.Drawing.Size(97, 24)
        Me.RbLakilaki.TabIndex = 12
        Me.RbLakilaki.TabStop = True
        Me.RbLakilaki.Text = "Laki-Laki"
        Me.RbLakilaki.UseVisualStyleBackColor = True
        '
        'RbPerempuan
        '
        Me.RbPerempuan.AutoSize = True
        Me.RbPerempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbPerempuan.Location = New System.Drawing.Point(624, 76)
        Me.RbPerempuan.Name = "RbPerempuan"
        Me.RbPerempuan.Size = New System.Drawing.Size(116, 24)
        Me.RbPerempuan.TabIndex = 13
        Me.RbPerempuan.TabStop = True
        Me.RbPerempuan.Text = "Perempuan"
        Me.RbPerempuan.UseVisualStyleBackColor = True
        '
        'cbSemester
        '
        Me.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Location = New System.Drawing.Point(624, 109)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(218, 33)
        Me.cbSemester.TabIndex = 14
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(155, 221)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(686, 44)
        Me.btnOk.TabIndex = 15
        Me.btnOk.Text = "Save"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lvDataMahasiswa
        '
        Me.lvDataMahasiswa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvDataMahasiswa.HideSelection = False
        Me.lvDataMahasiswa.Location = New System.Drawing.Point(155, 287)
        Me.lvDataMahasiswa.Name = "lvDataMahasiswa"
        Me.lvDataMahasiswa.Size = New System.Drawing.Size(986, 387)
        Me.lvDataMahasiswa.TabIndex = 16
        Me.lvDataMahasiswa.UseCompatibleStateImageBehavior = False
        Me.lvDataMahasiswa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NPM"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Prodi"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Jenis Kelamin"
        Me.ColumnHeader4.Width = 90
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Semester"
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "No Telepon"
        Me.ColumnHeader6.Width = 100
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(961, 697)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(180, 47)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "Tampilkan"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(155, 52)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(218, 30)
        Me.tbName.TabIndex = 3
        '
        'UKMCheckedListBox
        '
        Me.UKMCheckedListBox.FormattingEnabled = True
        Me.UKMCheckedListBox.Location = New System.Drawing.Point(881, 77)
        Me.UKMCheckedListBox.Name = "UKMCheckedListBox"
        Me.UKMCheckedListBox.Size = New System.Drawing.Size(260, 188)
        Me.UKMCheckedListBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(876, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "UKM"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "UKM"
        Me.ColumnHeader7.Width = 100
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1242, 782)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UKMCheckedListBox)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lvDataMahasiswa)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbSemester)
        Me.Controls.Add(Me.RbPerempuan)
        Me.Controls.Add(Me.RbLakilaki)
        Me.Controls.Add(Me.tbTelepon)
        Me.Controls.Add(Me.lblTelepon)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblJenisKelamin)
        Me.Controls.Add(Me.tbProdi)
        Me.Controls.Add(Me.tbNPM)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.lblProdi)
        Me.Controls.Add(Me.lblNPM)
        Me.Controls.Add(Me.lblNama)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents lblNPM As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents tbNPM As TextBox
    Friend WithEvents tbProdi As TextBox
    Friend WithEvents tbTelepon As TextBox
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents RbLakilaki As RadioButton
    Friend WithEvents RbPerempuan As RadioButton
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents btnOk As Button
    Friend WithEvents lvDataMahasiswa As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnPrint As Button
    Friend WithEvents tbName As TextBox
    Friend WithEvents UKMCheckedListBox As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
