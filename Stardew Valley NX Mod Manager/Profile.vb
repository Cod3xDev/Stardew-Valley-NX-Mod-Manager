Imports System.IO
Imports System.Xml.Serialization

Public Class Profile
    Public Property Name As String
    Public Property OutputDirectory As String
    Public Property Files As List(Of String)

    Public Sub New()
        Files = New List(Of String)
    End Sub

    Public Sub Save(fileName As String)
        Dim serializer As New XmlSerializer(GetType(Profile))
        Using writer As New StreamWriter(fileName)
            serializer.Serialize(writer, Me)
        End Using
    End Sub

    Public Shared Function Load(fileName As String) As Profile
        Dim serializer As New XmlSerializer(GetType(Profile))
        Using reader As New StreamReader(fileName)
            Return DirectCast(serializer.Deserialize(reader), Profile)
        End Using
    End Function
End Class
