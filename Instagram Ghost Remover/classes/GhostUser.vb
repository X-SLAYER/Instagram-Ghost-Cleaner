Public Class GhostUser

    Public media_count As String
    Public anonymousPic As String
    Public following As String
    Public followers As String

    Public Sub New(json As Dictionary(Of String, Object))
        following = json("user")("following_count")
        followers = json("user")("follower_count")
        media_count = json("user")("media_count")
        anonymousPic = json("user")("has_anonymous_profile_picture")
    End Sub

End Class
