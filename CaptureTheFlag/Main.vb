Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Public Class Main
    Dim strControl As String = ""
    Dim ExtraPoints As Boolean = False
    Dim ExtraPointTick As Integer = 0
    Dim ExtraPointColor As String = ""


    Private Sub tmrRunner_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRunner.Tick
        Try

            Dim oRead As System.IO.StreamReader
            oRead = IO.File.OpenText(My.Settings.server)
            Dim LineIn As String = ""
            Dim blnFound As Boolean = False


            While oRead.Peek <> -1
                LineIn = oRead.ReadLine()
                LineIn = DecryptString128Bit(LineIn, My.Settings.key).Trim()
            End While

            oRead.Close()


            If LineIn.Contains("Red") Then
                blnFound = True
                If Not strControl = "Red" Then
                    lblRed.Text = CDbl(lblRed.Text) + 50
                Else
                    lblRed.Text = CDbl(lblRed.Text) + 1
                End If
                If ExtraPoints And Not ExtraPointColor = "Red" Then
                    lblRed.Text = CDbl(lblRed.Text) + 700
                    ExtraPointColor = "Red"
                End If
                My.Settings.RedTeam = lblRed.Text
                My.Settings.Save()

                lblControl.Text = "The Red Team has control"
                lblControl.ForeColor = Color.Red
                strControl = "Red"
                ExtraPointColor = "Red"
                ExtraPointTick = 0
                ExtraPoints = False
            End If

            If LineIn.Contains("Green") Then
                blnFound = True
                If Not strControl = "Green" Then
                    lblGreen.Text = CDbl(lblGreen.Text) + 50
                Else
                    lblGreen.Text = CDbl(lblGreen.Text) + 1
                End If
                If ExtraPoints And Not ExtraPointColor = "Green" Then
                    lblGreen.Text = CDbl(lblGreen.Text) + 700
                    ExtraPointColor = "Green"
                End If
                My.Settings.GreenTeam = lblGreen.Text
                My.Settings.Save()
                lblControl.Text = "The Green Team has control"
                lblControl.ForeColor = Color.Green
                strControl = "Green"
                ExtraPointColor = "Green"
                ExtraPointTick = 0
                ExtraPoints = False
            End If


            If LineIn.Contains("Yellow") Then
                blnFound = True
                If Not strControl = "Yellow" Then
                    lblYellow.Text = CDbl(lblYellow.Text) + 50
                Else
                    lblYellow.Text = CDbl(lblYellow.Text) + 1
                End If
                If ExtraPoints And Not ExtraPointColor = "Yellow" Then
                    lblYellow.Text = CDbl(lblYellow.Text) + 700
                    ExtraPointColor = "Yellow"
                End If
                My.Settings.YellowTeam = lblYellow.Text
                My.Settings.Save()
                lblControl.Text = "The Yellow Team has control"
                lblControl.ForeColor = Color.Yellow
                strControl = "Yellow"
                ExtraPointColor = "Yellow"
                ExtraPointTick = 0
                ExtraPoints = False
            End If

            If LineIn.Contains("Blue") Then
                blnFound = True
                If Not strControl = "Blue" Then
                    lblBlue.Text = CDbl(lblBlue.Text) + 50
                Else
                    lblBlue.Text = CDbl(lblBlue.Text) + 1
                End If
                If ExtraPoints And Not ExtraPointColor = "Blue" Then
                    lblBlue.Text = CDbl(lblBlue.Text) + 700
                    ExtraPointColor = "Blue"
                End If
                My.Settings.BlueTeam = lblBlue.Text
                My.Settings.Save()
                lblControl.Text = "The Blue Team has control"
                lblControl.ForeColor = Color.Blue
                strControl = "Blue"
                ExtraPointColor = "Blue"
                ExtraPointTick = 0
                ExtraPoints = False
            End If

            If blnFound = False Then
                ExtraPointTick += 1
                If ExtraPointTick > 300 Then
                    ExtraPoints = True
                    lblControl.Text = "700 Bonus Points"
                    lblControl.ForeColor = Color.Cyan

                Else
                    lblControl.Text = "No one has current control"
                    lblControl.ForeColor = Color.Black
                End If
                
            End If

        Catch ex As Exception
            ExtraPointTick += 1
            If ExtraPointTick > 30 Then
                ExtraPoints = True
                lblControl.Text = "700 Bonus Points"
                lblControl.ForeColor = Color.Cyan

            Else
                lblControl.Text = "No one has current control"
                lblControl.ForeColor = Color.Black
            End If
        End Try
    End Sub


    Public Function DecryptString128Bit(ByVal vstrStringToBeDecrypted As String, _
                                        ByVal vstrDecryptionKey As String) As String

        Dim bytDataToBeDecrypted() As Byte
        Dim bytTemp() As Byte
        Dim bytIV() As Byte = {121, 241, 10, 1, 132, 74, 11, 39, 255, 91, 45, 78, 14, 211, 22, 62}
        Dim objRijndaelManaged As New RijndaelManaged()
        Dim objMemoryStream As MemoryStream
        Dim objCryptoStream As CryptoStream
        Dim bytDecryptionKey() As Byte

        Dim intLength As Integer
        Dim intRemaining As Integer
        Dim intCtr As Integer
        Dim strReturnString As String = String.Empty
        Dim achrCharacterArray() As Char
        Dim intIndex As Integer

        '   *****************************************************************
        '   ******   Convert base64 encrypted value to byte array      ******
        '   *****************************************************************

        bytDataToBeDecrypted = Convert.FromBase64String(vstrStringToBeDecrypted)

        '   ********************************************************************
        '   ******   Encryption Key must be 256 bits long (32 bytes)      ******
        '   ******   If it is longer than 32 bytes it will be truncated.  ******
        '   ******   If it is shorter than 32 bytes it will be padded     ******
        '   ******   with upper-case Xs.                                  ****** 
        '   ********************************************************************

        intLength = Len(vstrDecryptionKey)

        If intLength >= 32 Then
            vstrDecryptionKey = Strings.Left(vstrDecryptionKey, 32)
        Else
            intLength = Len(vstrDecryptionKey)
            intRemaining = 32 - intLength
            vstrDecryptionKey = vstrDecryptionKey & Strings.StrDup(intRemaining, "X")
        End If

        bytDecryptionKey = Encoding.ASCII.GetBytes(vstrDecryptionKey.ToCharArray)

        ReDim bytTemp(bytDataToBeDecrypted.Length)

        objMemoryStream = New MemoryStream(bytDataToBeDecrypted)

        '   ***********************************************************************
        '   ******  Create the decryptor and write value to it after it is   ******
        '   ******  converted into a byte array                              ******
        '   ***********************************************************************

        Try

            objCryptoStream = New CryptoStream(objMemoryStream, _
               objRijndaelManaged.CreateDecryptor(bytDecryptionKey, bytIV), _
               CryptoStreamMode.Read)

            objCryptoStream.Read(bytTemp, 0, bytTemp.Length)

            objCryptoStream.FlushFinalBlock()
            objMemoryStream.Close()
            objCryptoStream.Close()

        Catch

        End Try

        '   *****************************************
        '   ******   Return decypted value     ******
        '   *****************************************

        'Return StripNullCharacters(Encoding.ASCII.GetString(bytTemp))
        Return Encoding.ASCII.GetString(bytTemp)

    End Function

    Private Sub lblControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblControl.DoubleClick
        End
    End Sub

    Private Sub Main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblBlue.Text = My.Settings.BlueTeam
        lblRed.Text = My.Settings.RedTeam
        lblGreen.Text = My.Settings.GreenTeam
        lblYellow.Text = My.Settings.YellowTeam
    End Sub

End Class
