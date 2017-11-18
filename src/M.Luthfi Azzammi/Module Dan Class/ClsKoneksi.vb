Imports System.Data.SqlServerCe
Imports System.Data

Public Class ClsKoneksi

    Public Function ExecuteQuery(ByVal query As String) As DataTable
        Try
            If Not Con_Open() Then

            End If

            Perintah = New SqlCeCommand(query, Koneksi)
            Da = New SqlCeDataAdapter
            Da.SelectCommand = Perintah

            Ds = New DataSet
            Da.Fill(Ds)
            Dt = Ds.Tables(0)

            Return Dt

            Dt = Nothing
            Da = Nothing
            Ds = Nothing
            Perintah = Nothing

            Con_Close()

        Catch ex As Exception
            MsgBox("Error ExecuteQuery ! " + ex.Message())
            Return Nothing
        End Try
    End Function

    Public Sub ExecuteNonQuery(ByVal Query As String)
        Try
            Using Perintah As New SqlCeCommand(Query, Koneksi)
                Perintah.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox("Error Di ExecuteNonQuery ! " + ex.Message())
        End Try
    End Sub
End Class
