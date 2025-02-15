Imports System.Data.SQLite

Public Class Koneksi
    Public Shared Function GetConnection() As SQLiteConnection
        Dim connectionString As String = "Data Source=PeminjamanAlatSteril.db;Version=3;"
        Return New SQLiteConnection(connectionString)
    End Function
End Class
