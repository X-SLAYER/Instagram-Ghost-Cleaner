Imports xNet
Imports System.Web.Script.Serialization
Imports System.Threading

Public Class Form1

    Public userId As String
    Public CurrentUser As UserInfo
    Dim jss As New JavaScriptSerializer()
    Dim csrfToken As String = ""
    Dim cookies As String = ""
    Dim cursorEnd As String
    Dim sleepTime As Integer = 1000

    Public Sub New()
        InitializeComponent()
        CheckForIllegalCrossThreadCalls = False
    End Sub

    Public Sub Login(user As String, pass As String)
        Try
            Using request As New HttpRequest
                request.ClearAllHeaders()
                request.Proxy = Nothing
                request.UserAgent = Http.ChromeUserAgent()
                request.KeepAlive = True
                request.Cookies = New CookieDictionary(False)
                request.IgnoreProtocolErrors = True
                request.ConnectTimeout = &H1388

                request.AddHeader("Accept", "*/*")
                request.AddHeader("User-Agent", "Instagram 134.0.0.25.116 (iPhone10,2; iOS 13_3_1; en_US; en-US; scale")
                request.AddHeader("Accept-Language", "en-US;q")
                request.AddHeader("X-IG-Capabilities", "36r/Fw")
                request.AddHeader("X-IG-App-ID", "1099655813402622")
                request.AddHeader("X-IG-Connection-Type", "WiFi")
                request.AddHeader("X-IG-Connection-Speed", "174kbps")
                request.AddHeader("X-IG-ABR-Connection-Speed-KBPS", "0")

                Dim str As String = String.Concat(New String() {"ig_sig_key_version=5&signed_body=d19e37605ed48b42e495bf082d06a906663ac2a75ebbdd9acbc5c4bd2e5e8107.{""reg_login"":""0"",""login_attempt_count"":""0"",""device_id"":""", Guid.NewGuid.ToString(), """,""phone_id"":""", Guid.NewGuid.ToString(), """,""password"":""", pass, """,""username"":""", user, """}"})

                Dim response As String = ""
                Dim rep As HttpResponse = request.Post("https://i.instagram.com/api/v1/accounts/login/", str, "application/x-www-form-urlencoded; charset=UTF-8")

                If rep.HasRedirect = True Then
                    response = request.Get(rep.RedirectAddress.ToString(), Nothing).ToString()
                Else
                    response = rep.ToString() '
                End If

                If response.Contains("logged_in_user") Then

                    cookies = rep.Cookies.ToString()
                    csrfToken = rep.Cookies.Item("csrftoken")

                    status.LinkColor = Color.Green
                    status.Text = "Connected "

                    logOut.Enabled = True
                    bLogin.Enabled = False
                    TUser.Enabled = False
                    TPass.Enabled = False

                    Dim jss As New JavaScriptSerializer()
                    Dim dict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(response)

                    CurrentUser = UserFromJson.FromJson(dict)

                    allStatus.Text = "Getting User Info ..."
                    Dim ghost = getUserInfo(request, CurrentUser.userID)

                    '-----------------
                    lfollowers.Text = ghost.followers
                    lfollowing.Text = FormatNumber(ghost.following, 0, TriState.True)
                    lmediaCount.Text = ghost.media_count
                    buinessAcc.Text = CurrentUser.buisness
                    '-----------------

                    allStatus.Text = "Getting Friends You Follow ..."
                    GetFollowing(request, CurrentUser.userID, rep.Cookies.ToString())
                    If (Lv1.Items.Count > 0) Then
                        UnFollowBtn.Enabled = True
                    End If

                ElseIf response.Contains("challenge_required") Then
                        status.LinkColor = Color.Orange
                        status.Text = "Challange Locked"
                    Else
                        status.LinkColor = Color.Red
                    status.Text = "Login or pass is wrong"
                End If

            End Using
        Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Function getUserInfo(request As HttpRequest, userId As String) As GhostUser

        request.AddHeader("Accept", "*/*")
        request.AddHeader("User-Agent", "Instagram 134.0.0.25.116 (iPhone10,2; iOS 13_3_1; en_US; en-US; scale")
        request.AddHeader("Accept-Language", "en-US;q")
        request.AddHeader("X-IG-Capabilities", "36r/Fw")
        request.AddHeader("X-IG-App-ID", "1099655813402622")
        request.AddHeader("X-IG-Connection-Type", "WiFi")
        request.AddHeader("X-IG-Connection-Speed", "370kbps")
        request.AddHeader("X-IG-ABR-Connection-Speed-KBPS", "1")

        Dim info As String = request.Get("https://i.instagram.com/api/v1/users/" & userId & "/info/?device_id=" & Guid.NewGuid.ToString(), Nothing).ToString()
        Dim dict = jss.Deserialize(Of Dictionary(Of String, Object))(info)
        Return New GhostUser(dict)

    End Function

    Public Sub GetFollowing(request As HttpRequest, userId As String, Cookies As String)
        request.AddHeader("X-Instagram-AJAX", "1")
        request.AddHeader("x-requested-with", "XMLHttpRequest")
        request.AddHeader("Cookie", Cookies)

        Dim result As String = ""

        If String.IsNullOrEmpty(cursorEnd) Then
            result = request.Get("https://www.instagram.com/graphql/query/?query_hash=d04b0a864b4b54837c0d870b0e77e076&variables={""id"":""" & userId & """,""include_reel"":true,""fetch_mutual"":false,""first"":50}").ToString()
        Else
            result = request.Get("https://www.instagram.com/graphql/query/?query_hash=d04b0a864b4b54837c0d870b0e77e076&variables={""id"":""" & userId & """,""include_reel"":true,""fetch_mutual"":false,""first"":50,""after"":""" & cursorEnd & """}").ToString()
        End If

        Dim edgesMap As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(result)

        Dim edges = edgesMap("data")("user")("edge_follow")("edges")
        cursorEnd = edgesMap("data")("user")("edge_follow")("page_info")("end_cursor")

        If String.IsNullOrEmpty(cursorEnd) Then
            more.Enabled = False
        End If

        allStatus.Text = "Getting Inactive Friends ..."

        For Each node As Dictionary(Of String, Object) In edges
            Dim IsGhostuser = getUserInfo(request, node("node")("id"))
            If IsGhostuser.media_count = 0 Or IsGhostuser.anonymousPic.ToLower = "true" Then
                Dim it As New ListViewItem With {
                .Text = node("node")("username"),
                .Tag = node("node")("id"),
                .UseItemStyleForSubItems = False,
                .Checked = True,
                .ToolTipText = String.Format("Followers: {0}" & vbCrLf & "Following: {1}", IsGhostuser.followers, IsGhostuser.following)
            }
                it.SubItems.Add(FormatNumber(IsGhostuser.media_count, 0, TriState.True))
                it.SubItems.Add(IsGhostuser.anonymousPic).ForeColor = Color.Blue
                it.SubItems.Add("Idle").ForeColor = Color.Blue
                Lv1.Items.Add(it)
            End If
        Next

        allStatus.Text = "Ghost Useres [" & Lv1.Items.Count & "]"

    End Sub

    Public Function Unfollow(userId As String) As Boolean
        Try

            Using request As New HttpRequest
                request.Proxy = Nothing
                request.UserAgent = Http.ChromeUserAgent()
                request.KeepAlive = True
                request.Cookies = New CookieDictionary(False)
                request.IgnoreProtocolErrors = True
                request.ConnectTimeout = &H1388
                request.AddHeader("x-csrftoken", csrfToken)
                request.AddHeader("X-Instagram-AJAX", "1")
                request.AddHeader("x-requested-with", "XMLHttpRequest")
                request.AddHeader("Cookie", cookies)

                Dim res As String = request.Post("https://www.instagram.com/web/friendships/" & userId & "/unfollow/").ToString()

                If res.Contains("{""status"": ""ok""}") Then
                    Return True
                End If
                Return False
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub logOut_Click(sender As Object, e As EventArgs) Handles logOut.Click
        logOut.Enabled = False
        bLogin.Enabled = True
        TUser.Enabled = True
        TPass.Enabled = True

        Lv1.Items.Clear()

        lfollowers.Text = "0"
        lfollowing.Text = "0"
        lmediaCount.Text = "0"
        buinessAcc.Text = "0"

    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Dim thread As New Thread(New ThreadStart(Sub() Login(TUser.Text, TPass.Text))) With {
            .IsBackground = True
        }
        thread.Start()
    End Sub
    Public Sub UnfollowAll()
        For Each item As ListViewItem In Lv1.Items
            If item.Checked Then
                If Not item.SubItems(3).Text = "Done !" Then
                    Dim status As Boolean = Unfollow(item.Tag)
                    If (status) Then
                        item.SubItems(3).ForeColor = Color.Green
                        item.SubItems(3).Text = "Done !"
                    Else
                        item.SubItems(3).ForeColor = Color.Red
                        item.SubItems(3).Text = "Error In Rmoving!"
                    End If
                    sleepTime += 500
                    Thread.Sleep(sleepTime)
                End If
            End If
        Next
    End Sub

    Private Sub UnFollowBtn_Click(sender As Object, e As EventArgs) Handles UnFollowBtn.Click
        Dim removeGhosts As New Thread(New ThreadStart(AddressOf UnfollowAll))
        removeGhosts.Start()
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click
        Process.Start("https://github.com/X-SLAYER")
    End Sub

    Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel5.Click
        Process.Start("https://t.me/SLAYERS404")
    End Sub
End Class
