Imports System.Text
Imports System.Xml
Imports System.Collections
Imports System.IO
Imports System.Net

Public Class Form1
    Dim Protection As Boolean = False
    Dim StopProtection As Boolean = False
    Dim StartProtection As Boolean = False
    Dim getIntervalUnProtect As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        protectBeforeCb.SelectedIndex = 0
        returnAfterCb.SelectedIndex = 0
        impactCb.SelectedIndex = 2
        GetNewsFromForexFactory()
    End Sub

    Private Sub GetNewsFromForexFactory()
        newsDataGridView.Rows.Clear()
        Dim xr As XmlReader = XmlReader.Create("https://cdn-nfs.forexfactory.net/ff_calendar_thisweek.xml")
        Dim title As New ArrayList
        Dim currency As New ArrayList
        Dim datetimeNews As New ArrayList
        Dim impact As New ArrayList
        Do While xr.Read()
            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "title" Then
                title.Add(xr.ReadElementString) 'Title
                currency.Add(xr.ReadElementString) 'Currency
                Dim dateNews = xr.ReadElementString 'Date
                Dim timeNews = xr.ReadElementString 'Time
                datetimeNews.Add(dateNews + " " + timeNews) 'Combine DateTime
                impact.Add(xr.ReadElementString) 'Impact
            Else
                xr.Read()
            End If
        Loop
        For i As Int32 = 0 To currency.Count - 1
            If currency(i) = "EUR" Or currency(i) = "USD" Then
                If impact(i) = impactCb.Text Then
                    Dim SEAsiaZoneInfo As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time")
                    Dim SEAsiaTime As Date = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, SEAsiaZoneInfo)
                    Dim datetimeNewsGMT = DateTime.Parse(datetimeNews(i)).AddHours(7)
                    If DateTime.Compare(SEAsiaTime, datetimeNewsGMT) < 0 Then
                        newsDataGridView.Rows.Add(title(i), currency(i), datetimeNewsGMT, impact(i))
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim SEAsiaZoneInfo As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time")
        Dim SEAsiaTime As Date = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, SEAsiaZoneInfo)
        localTimeLb.Text = "Local Time: " + DateTime.Now
        SEAsiaTimeLb.Text = "GMT+7 Time: " + SEAsiaTime
        Dim SEAsiaTimeAddTime As DateTime
        If protectBeforeCb.Text = "30 Minutes" Then
            SEAsiaTimeAddTime = SEAsiaTime.AddMinutes(30)
        ElseIf protectBeforeCb.Text = "1 Hour" Then
            SEAsiaTimeAddTime = SEAsiaTime.AddHours(1)
        End If
        Try
            Dim datetimeNewsGMT = DateTime.Parse(newsDataGridView.SelectedRows.Item(0).Cells(2).Value)
            Dim titleNews As String = newsDataGridView.SelectedRows.Item(0).Cells(0).Value
            TextBox1.Text = titleNews & " Protecting in : " & Decimal.Round((datetimeNewsGMT - SEAsiaTimeAddTime).TotalMinutes, 2, MidpointRounding.AwayFromZero) & " Minutes"
            If Protection = True And StartProtection = False Then
                If (datetimeNewsGMT - SEAsiaTimeAddTime).TotalSeconds <= 1 Then
                    startProtectionTimer.Enabled = True
                    StartProtection = True
                    If returnAfterCb.Text = "30 Minutes" Then
                        getIntervalUnProtect = 3600000 / 1000
                    ElseIf returnAfterCb.Text = "1 Hour" Then
                        getIntervalUnProtect = 7200000 / 1000
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        If getIntervalUnProtect > 0 Then
            getIntervalUnProtect = getIntervalUnProtect - 1
            Me.Text = "Trading Protection (Only EURUSD) : Unprotect in " & getIntervalUnProtect & " Seconds"
        Else
            Me.Text = "Trading Protection (Only EURUSD)"
        End If
    End Sub

    Private Sub protectionBtn_Click(sender As Object, e As EventArgs) Handles protectionBtn.Click
        If Protection = False Then
            protectionBtn.BackColor = Color.Red
            protectionBtn.Text = "Stop Protection"
            Protection = True
            Timer1.Enabled = True
        Else
            protectionBtn.BackColor = Color.Lime
            protectionBtn.Text = "Start Protection"
            Protection = False
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub getNewsBtn_Click(sender As Object, e As EventArgs)
        protectionBtn.Enabled = True
        GetNewsFromForexFactory()
    End Sub

    Private Sub startProtectionTimer_Tick(sender As Object, e As EventArgs) Handles startProtectionTimer.Tick
        If Protection = True Then
            If StartProtection = True Then
                If returnAfterCb.Text = "30 Minutes" Then
                    stopProtectionTimer.Interval = 3600000
                ElseIf returnAfterCb.Text = "1 Hour" Then
                    stopProtectionTimer.Interval = 7200000
                End If
                stopProtectionTimer.Enabled = True
                StopProtection = True

                StartProtection = False
                startProtectionTimer.Enabled = False

                'HTTP Request
                Dim webStream As Stream
                Dim webResponse = ""
                Dim req As HttpWebRequest = CType(WebRequest.Create("http://localhost/forex/process.php?command=freezeAfterTP&setValue=1"), HttpWebRequest)
                Dim res As HttpWebResponse
                req.Method = "GET"
                res = CType(req.GetResponse(), HttpWebResponse) ' Send Request
                webStream = res.GetResponseStream() ' Get Response
                Dim webStreamReader As New StreamReader(webStream)
                While webStreamReader.Peek >= 0
                    webResponse = webStreamReader.ReadToEnd()
                End While
                'MsgBox(webResponse.ToString)
                GetNewsFromForexFactory()
            End If
        End If

    End Sub

    Private Sub stopProtectionTimer_Tick(sender As Object, e As EventArgs) Handles stopProtectionTimer.Tick
        If Protection = True Then
            If StopProtection = True Then
                StopProtection = False
                stopProtectionTimer.Enabled = False
                'HTTP Request
                Dim webStream As Stream
                Dim webResponse = ""
                Dim req As HttpWebRequest = CType(WebRequest.Create("http://localhost/forex/process.php?command=freezeAfterTP&setValue=0"), HttpWebRequest)
                Dim res As HttpWebResponse
                req.Method = "GET"
                res = CType(req.GetResponse(), HttpWebResponse) ' Send Request
                webStream = res.GetResponseStream() ' Get Response
                Dim webStreamReader As New StreamReader(webStream)
                While webStreamReader.Peek >= 0
                    webResponse = webStreamReader.ReadToEnd()
                End While
                'MsgBox(webResponse.ToString)
                GetNewsFromForexFactory()
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Protection = True Then
            If (MessageBox.Show("Protection is running Do you want to exit ?", "Are you sure?", MessageBoxButtons.YesNo) = DialogResult.No) Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GetNewsFromForexFactory()
    End Sub
End Class
