Public Class UserInfo

    Public userID As String
    Public username As String
    Public verified As String
    Public buisness As String
    Public isPrivate As String

    Public Sub New(userID As String, username As String, verified As String, buisness As String, isPrivate As String)
        Me.userID = userID
        Me.username = username
        Me.verified = verified
        Me.buisness = buisness
        Me.isPrivate = isPrivate
    End Sub
End Class

Class UserFromJson

    Public Shared Function FromJson(json As Dictionary(Of String, Object)) As UserInfo
        Try
            Return New UserInfo(json("logged_in_user")("pk"), json("logged_in_user")("username"), json("logged_in_user")("is_verified"),
                           json("logged_in_user")("is_business"), json("logged_in_user")("is_private"))
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class

