Imports System.Data.SQLite
Public Class Form1
    Private connString As String = "Data Source=C:\Users\bravo\source\repos\PeminjamanAlatSteril\PeminjamanAlatSteril.db;Version=3;"

    Private Sub SimpanData()
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim query As String = "INSERT INTO Peminjaman (NamaAlat, Jumlah, NamaPetugasRuangan, NamaPetugasMenyerahkan, NamaRuangan, TanggalJam) VALUES (@NamaAlat, @Jumlah, @NamaPetugasRuangan, @NamaPetugasMenyerahkan, @NamaRuangan, @TanggalJam)"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@NamaAlat", txtNamaAlat.Text)
                cmd.Parameters.AddWithValue("@Jumlah", txtJumlah.Text)
                cmd.Parameters.AddWithValue("@NamaPetugasRuangan", txtNamaPetugasRuangan.Text)
                cmd.Parameters.AddWithValue("@NamaPetugasMenyerahkan", txtNamaPetugasMenyerahkan.Text)
                cmd.Parameters.AddWithValue("@NamaRuangan", txtNamaRuangan.Text)
                cmd.Parameters.AddWithValue("@TanggalJam", dtpTanggalJam.Value)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
        MessageBox.Show("Data berhasil disimpan!")
        TampilkanData()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If String.IsNullOrEmpty(txtNamaAlat.Text) OrElse String.IsNullOrEmpty(txtJumlah.Text) OrElse String.IsNullOrEmpty(txtNamaPetugasRuangan.Text) OrElse String.IsNullOrEmpty(txtNamaPetugasMenyerahkan.Text) OrElse String.IsNullOrEmpty(txtNamaRuangan.Text) Then
            MessageBox.Show("Semua field harus diisi!")
            Return
        End If
        SimpanData()
    End Sub

    Private Sub TampilkanData()
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim query As String = "SELECT * FROM Peminjaman"
            Using cmd As New SQLiteCommand(query, conn)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    DataGridView1.DataSource = dt
                End Using
            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilkanData()
    End Sub

    Private Sub LoadToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem1.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        openFileDialog.Title = "Select a Text File"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim lines() As String = System.IO.File.ReadAllLines(openFileDialog.FileName)
                If lines.Length > 0 Then
                    Dim data As String() = lines(0).Split(","c)
                    If data.Length = 5 Then
                        txtNamaAlat.Text = data(0).Trim()
                        txtJumlah.Text = data(1).Trim()
                        txtNamaPetugasRuangan.Text = data(2).Trim()
                        txtNamaPetugasMenyerahkan.Text = data(3).Trim()
                        txtNamaRuangan.Text = data(4).Trim()
                    Else
                        MessageBox.Show("Format file tidak sesuai. Pastikan ada 5 kolom.")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat memuat file: " & ex.Message)
            End Try
        End If
    End Sub
End Class
