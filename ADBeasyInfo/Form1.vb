Imports Microsoft.Office.Interop

Public Class Form1


    Dim adbDirectory As String = "C:\AdbStrip"
    Dim storeInfo(0 To 2) As String
    Private Sub ConnectBTN_Click(sender As Object, e As EventArgs) Handles ConnectBTN.Click
        Try
            Dim adbStart As New Process
            adbStart.StartInfo.FileName = (adbDirectory + "\adb.exe")
            adbStart.StartInfo.Arguments = "devices"
            adbStart.StartInfo.UseShellExecute = False
            adbStart.StartInfo.RedirectStandardOutput = True
            adbStart.StartInfo.CreateNoWindow = True
            adbStart.Start()


            Dim readinfo1() As String = adbStart.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln1 As String In readinfo1
                TextInfoBox1.AppendText(vbNewLine & ln1)
                If ln1.Reverse(1) = "e" Then
                    TextInfoBox1.AppendText(vbNewLine & "****Device is Authenticated****")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error, Please Check ADB folder Location")
        End Try


    End Sub

    Private Sub KillADBbtn_Click(sender As Object, e As EventArgs) Handles KillADBbtn.Click
        Try
            Dim adbKill As New Process
            adbKill.StartInfo.FileName = (adbDirectory + "\adb.exe")
            adbKill.StartInfo.Arguments = "kill-server"
            adbKill.StartInfo.UseShellExecute = False
            adbKill.StartInfo.RedirectStandardOutput = True
            adbKill.StartInfo.CreateNoWindow = True
            adbKill.Start()

            TextInfoBox1.AppendText(vbNewLine & "ADB server Stopped")
        Catch ex As Exception
            MessageBox.Show("Error, Please Check ADB folder Location")
        End Try

    End Sub

    Private Sub GetInfoBTN_Click(sender As Object, e As EventArgs) Handles getInfoBTN.Click

        Dim dirtyIMEI As String
        Dim dirtySerialNum As String
        Dim dirtyMac As String

        'shell get prop will return a list of things and we can pull the IMEI and Serial Number from it
        Try
            Dim getProp As New Process
            getProp.StartInfo.FileName = (adbDirectory + "\adb.exe")
            getProp.StartInfo.Arguments = "shell getprop"
            getProp.StartInfo.UseShellExecute = False
            getProp.StartInfo.RedirectStandardOutput = True
            getProp.StartInfo.CreateNoWindow = True
            getProp.Start()

            Dim readinfo2() As String = getProp.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln2 As String In readinfo2
                If ln2.Contains("[gsm.baseband.imei]:") Then
                    dirtyIMEI = ln2
                ElseIf ln2.Contains("[ro.boot.serialno]:") Then
                    dirtySerialNum = ln2
                End If
            Next

            'this is where we pull the Mac Address
            Dim getMac As New Process
            getMac.StartInfo.FileName = (adbDirectory + "\adb.exe")
            getMac.StartInfo.Arguments = "shell ip addr show wlan0"
            getMac.StartInfo.UseShellExecute = False
            getMac.StartInfo.RedirectStandardOutput = True
            getMac.StartInfo.CreateNoWindow = True
            getMac.Start()

            Dim readinfo3() As String = getMac.StandardOutput.ReadToEnd.Split(CChar(vbLf))
            For Each ln3 As String In readinfo3
                If ln3.Reverse(1) = "f" Then
                    dirtyMac = ln3
                End If
            Next

            'Cleaning up Mac Address:
            dirtyMac = Trim(dirtyMac)
            Dim holderMac() As String = Split(dirtyMac)
            Dim cleanMac As String = holderMac(1)

            'Clean up IMEI:
            Trim(dirtyIMEI)
            Dim holderImei() As String = Split(dirtyIMEI)
            Dim badCharacter As Char = "["
            Dim cleanIMEI As String = holderImei(1)
            cleanIMEI = cleanIMEI.Trim(badCharacter)
            cleanIMEI = cleanIMEI.Remove(15)

            'Clean up Serial Number:
            dirtySerialNum = Trim(dirtySerialNum)
            Dim holderSerial() As String = Split(dirtySerialNum)
            Dim cleanSerialNum As String = holderSerial(1)

            'Storing the information to global so it can be exported
            storeInfo(0) = cleanSerialNum
            storeInfo(1) = cleanIMEI
            storeInfo(2) = cleanMac

            TextInfoBox1.AppendText(vbNewLine & cleanIMEI & vbNewLine & cleanSerialNum & vbNewLine & cleanMac)

        Catch ex As Exception
            MessageBox.Show("Error, Please Check ADB folder Location")
        End Try

    End Sub

    Private Sub ExportBTN_Click(sender As Object, e As EventArgs) Handles exportBTN.Click
        Try
            Dim excelApp As Excel.Application = New Excel.Application()
            Dim excelBook As Excel.Workbook
            Dim strPath As String = "C:\Users\Branden\Desktop\PhoneSheetLocal.xlsx"

            excelBook = excelApp.Workbooks.Open(strPath, 0, False, 5, System.Reflection.Missing.Value, System.Reflection.Missing.Value, False, System.Reflection.Missing.Value, System.Reflection.Missing.Value, True, False, System.Reflection.Missing.Value, False)

            Dim excelSheets As Excel.Sheets = excelBook.Sheets
            Dim excelSheet As Excel.Worksheet = excelSheets(1)
            Dim excelRange As Excel.Range = excelSheet.UsedRange

            excelRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Activate()
            Dim intNewRow As Int32 = excelApp.ActiveCell.Row + 1
            Dim strNewCellSerial As String = "A" & intNewRow
            Dim strNewCellIMEI As String = "B" & intNewRow
            Dim StrNewCellMAC As String = "C" & intNewRow

            excelSheet.Range(strNewCellSerial).Value = storeInfo(0)
            excelSheet.Range(strNewCellIMEI).Value = storeInfo(1)
            excelSheet.Range(StrNewCellMAC).Value = storeInfo(2)

            excelBook.Save()
            excelBook.Close()
            excelApp.Quit()

        Catch
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub ExportServerBTN_Click(sender As Object, e As EventArgs) Handles exportServerBTN.Click
        Try
            Dim excelApp As Excel.Application = New Excel.Application()
            Dim excelBook As Excel.Workbook
            Dim strPath As String = "\\10.0.3.155\CC1Share\PhoneSheetRemote.xlsx"

            excelBook = excelApp.Workbooks.Open(strPath, 0, False, 5, System.Reflection.Missing.Value, System.Reflection.Missing.Value, False, System.Reflection.Missing.Value, System.Reflection.Missing.Value, True, False, System.Reflection.Missing.Value, False)

            Dim excelSheets As Excel.Sheets = excelBook.Sheets
            Dim excelSheet As Excel.Worksheet = excelSheets(1)
            Dim excelRange As Excel.Range = excelSheet.UsedRange

            excelRange.SpecialCells(Excel.XlCellType.xlCellTypeLastCell).Activate()
            Dim intNewRow As Int32 = excelApp.ActiveCell.Row + 1
            Dim strNewCellSerial As String = "A" & intNewRow
            Dim strNewCellIMEI As String = "B" & intNewRow
            Dim StrNewCellMAC As String = "C" & intNewRow

            excelSheet.Range(strNewCellSerial).Value = storeInfo(0)
            excelSheet.Range(strNewCellIMEI).Value = storeInfo(1)
            excelSheet.Range(StrNewCellMAC).Value = storeInfo(2)

            excelBook.Save()
            excelBook.Close()
            excelApp.Quit()
        Catch
            MessageBox.Show("Error")
        End Try
    End Sub


    Private Sub FixAdbBtn_Click(sender As Object, e As EventArgs) Handles fixAdbBtn.Click

        Using browseThingy As New FolderBrowserDialog
            If browseThingy.ShowDialog() <> DialogResult.OK Then Return
            adbDirectory = browseThingy.SelectedPath
        End Using
        TextInfoBox1.AppendText(adbDirectory)
    End Sub

    Private Sub PathChngBTN1_Click(sender As Object, e As EventArgs) Handles pathChngBTN1.Click
        Try
            Dim getProp1 As New Process
            getProp1.StartInfo.FileName = (adbDirectory + "\adb.exe")
            getProp1.StartInfo.Arguments = "shell getprop"
            getProp1.StartInfo.UseShellExecute = False
            getProp1.StartInfo.RedirectStandardOutput = True
            getProp1.StartInfo.CreateNoWindow = False
            getProp1.Start()
        Catch
            MessageBox.Show("Error")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
