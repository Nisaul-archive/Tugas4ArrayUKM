Public Class Form1
    Dim arr(,) As String
    Dim i As Integer

    ' Array Semester
    Dim semester() As Integer = {1, 2, 3, 4, 5, 6, 7, 8}

    ' Array UKM
    Dim ukm() As String = {"E-sport", "Renang", "Basket", "Karate", "Pramuka", "Penalaran", "GLC", "UKKI"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tambah kolom ke-7 untuk UKM
        ReDim arr(20, 6)

        ' Isi ComboBox Semester dari array
        cbSemester.Items.Clear()
        For j As Integer = 0 To semester.Length - 1
            cbSemester.Items.Add(semester(j))
        Next

        ' Isi CheckedListBox UKM dari array
        UKMCheckedListBox.Items.Clear()
        For j As Integer = 0 To ukm.Length - 1
            UKMCheckedListBox.Items.Add(ukm(j))
        Next
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        ' Simpan data ke array
        arr(i, 0) = tbNPM.Text
        arr(i, 1) = tbName.Text
        arr(i, 2) = tbProdi.Text

        If RbLakilaki.Checked Then
            arr(i, 3) = "Laki-Laki"
        ElseIf RbPerempuan.Checked Then
            arr(i, 3) = "Perempuan"
        End If

        arr(i, 4) = cbSemester.Text
        arr(i, 5) = tbTelepon.Text

        ' Gabungkan pilihan UKM
        Dim selectedUKM As String = ""
        For Each item In UKMCheckedListBox.CheckedItems
            If selectedUKM <> "" Then
                selectedUKM &= ", "
            End If
            selectedUKM &= item.ToString()
        Next
        arr(i, 6) = selectedUKM

        i += 1
        MsgBox("Data sukses ditambah")

        ' Menampilkan data ke ListView
        lvDataMahasiswa.Items.Clear()
        For K As Integer = 0 To i - 1
            lvDataMahasiswa.Items.Add(arr(K, 0))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 1))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 2))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 3))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 4))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 5))
            lvDataMahasiswa.Items(lvDataMahasiswa.Items.Count - 1).SubItems.Add(arr(K, 6))
        Next

        ' Reset input
        tbNPM.Text = ""
        tbName.Text = ""
        tbProdi.Text = ""
        tbTelepon.Text = ""
        RbLakilaki.Checked = False
        RbPerempuan.Checked = False
        cbSemester.SelectedItem = Nothing
        For K As Integer = 0 To UKMCheckedListBox.Items.Count - 1
            UKMCheckedListBox.SetItemChecked(K, False)
        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim Str As String = ""
        For K As Integer = 0 To i - 1
            Str &= arr(K, 0) & " " &
                   arr(K, 1) & " " &
                   arr(K, 2) & " " &
                   arr(K, 3) & " " &
                   arr(K, 4) & " " &
                   arr(K, 5) & " " &
                   arr(K, 6) & vbCrLf
        Next
        MsgBox(Str)
    End Sub
End Class
