Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports System.Linq
Imports System.Data.Linq
Imports Excel = Microsoft.Office.Interop.Excel

Public Class execl_to_text
    'Dim PLNDLL As New planning_cfg.planning_fn
    Dim data6 As New DataSet
    Dim B As New BindingSource
    Dim dtv As New DataView
    Dim q As New DataTable
    Dim drr As New DataTable
    Dim ljoin_condition As Object
    Dim constr_excel As String = ""

    Private Sub training_main1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pn_not_show.Hide()
    End Sub
    'Private Sub check_excel()
    '    If File.Exists(excel_old.Text) = False Then 'ตรวจสอบว่า ติดต่อ Excel ต้นฉบับได้มั้ย
    '        MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
    '        Exit Sub
    '    End If
    '    Try
    '        'copy Excel มาไว้ที่ local
    '        Dim new_path As String = System.IO.Path.Combine(Application.StartupPath, System.IO.Path.GetFileName(excel_old.Text))
    '        If File.Exists(new_path) Then
    '            File.Delete(new_path)
    '        End If
    '        File.Copy(System.IO.Path.GetFullPath(excel_old.Text), new_path, True)
    '        excel_new.Text = new_path
    '    Catch ex As Exception
    '        MessageBox.Show("Failed to connect..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Private Sub cal()
    End Sub

    Private Sub NEW_CALL()
        'data6.Clear()
        'result_amt.Clear() 'เคลียร์ ข้อมูล export
        'Dim EXCEL As String = excel_old.Text
        'Try
        '    'IMEX=1 สำคัญมาก ถ้า column เดียวกัน type ไม่เหมือนกัน จะแสดงเป็นค่าว่าง เช่น cell ส่วนใหญ่ในคอลัมภ์ เป็นตัวเลข แล้วมีบาง cell เป็น string มันจะส่งออก เป็นค่าว่าง ให้ใส่ IMEX=1 ใน connection
        '    Dim constr_excel As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + EXCEL + ";Extended Properties='Excel 12.0 Xml;HDR=NO;IMEX=1'"
        '    Dim conn_excel As New OleDbConnection(constr_excel)

        '    Dim xl As New Excel.Application
        '    Dim xlwbook As Excel.Workbook
        '    Dim xlsheet As Excel.Worksheet
        '    'xlwbook = xl.Workbooks.Open(excel_old.Text)
        '    xlwbook = xl.Workbooks.Add(excel_old.Text)
        '    'xlsheet = xlwbook.Sheets.Item(1) 'ใช้ได้ หมายถึง sheet แรก
        '    xlsheet = xlwbook.ActiveSheet 'อ่านค่า sheet ที่ active

        '    'ป้องกันค่า null linq จะ error
        '    'แสดงทั้งหมด
        '    Dim sql_excel As String = "SELECT"
        '    sql_excel &= " IIF(F1 IS NULL,'',F1) AS F1,IIF(F3 IS NULL,'',F3) AS F3,IIF(F8 IS NULL,'',F8) AS F8,IIF(F13 IS NULL,'',F13) AS F13"
        '    'sql_excel &= " F1,F3,F8,F13"
        '    sql_excel &= " FROM [" & xlsheet.Name.ToString & "$]"
        '    'sql_excel &= " FROM [{0}$]{1}"
        '    'sql_excel &= " FROM [" & excel_sheet.Text & "$]"
        '    sql_excel &= " WHERE (F1 IS NOT NULL)"
        '    Dim cmd_excel As New OleDbCommand(sql_excel, conn_excel)
        '    Dim adapter_excel As New OleDbDataAdapter(cmd_excel)
        '    adapter_excel.Fill(data6, "EXCEL_DT")

        '    'แสดงเฉพาะผลลัพท์
        '    Dim sql_result As String = "SELECT"
        '    sql_result &= " IIF(F1 IS NULL,'',F1) AS F1,IIF(F3 IS NULL,'',F3) AS F3,IIF(F8 IS NULL,'',F8) AS F8,IIF(F13 IS NULL,'',F13) AS F13"
        '    sql_result &= " FROM [" & xlsheet.Name.ToString & "$]"
        '    'sql_result &= " FROM [" & "sheet1" & "$]"
        '    sql_result &= " WHERE (F1 IS NOT NULL AND F1='รวม')"
        '    Dim cmd_result As New OleDbCommand(sql_result, conn_excel)
        '    Dim adapter_result As New OleDbDataAdapter(cmd_result)
        '    adapter_result.Fill(data6, "EXCEL_RESULT")

        '    'ปิด Excel
        '    xl.ActiveWorkbook.Close(False, excel_old.Text)
        '    xl.Quit()
        '    xlwbook = Nothing
        '    xl = Nothing

        '    If data6.Tables("EXCEL_DT").Rows.Count = 0 Then
        '        dtv = Nothing
        '        grw.DataSource = dtv
        '    Else
        '        dtv = data6.Tables("EXCEL_DT").AsDataView 'PLNDLL.EQLT(ljoin_condition).AsDataView 'PLNDLL.EQLT(ljoin).AsDataView  'dt.AsDataView
        '        grw.DataSource = dtv
        '        grw.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '        grw.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        '        grw.ClearSelection()
        '    End If

        '    If data6.Tables("EXCEL_RESULT").Rows.Count = 0 Then
        '        result_amt.Text = 0
        '    Else
        '        If IsNumeric(data6.Tables("EXCEL_RESULT").Rows(0).Item("F13")) Then
        '            result_amt.Text = Format(Decimal.Parse(data6.Tables("EXCEL_RESULT").Rows(0).Item("F13")), "#.########")
        '            result_amt.Text = Format(Decimal.Parse(data6.Tables("EXCEL_RESULT").Rows(0).Item("F13")), "#.########")
        '        Else
        '            result_amt.Text = 0
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Disable to connect..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub ENTER_KEY()
        'If dtv IsNot Nothing Then
        'dtv.RowFilter = "[F1] ='รวม'"
        'result_amt.Text = dtv.Table.Rows(0).Item(0).ToString
        'Else
        'dtv.RowFilter = Nothing
        'End If
        'cal()
        ''color_cancel()
        'grw.ClearSelection()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ENTER_KEY()
    End Sub
    Private Sub return_lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles return_lnk.LinkClicked
        'dtv.RowFilter = "[F35] = '' "
        'dtv.RowFilter = Nothing
        'dtv.Sort = String.Empty
        'cal()
    End Sub

    Private Sub stk_film_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        grw.ClearSelection()
    End Sub

    Private Sub grw_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grw.ColumnHeaderMouseClick
        'color_cancel()
    End Sub
    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        MyBase.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim a As String
        If excel_old.Text.Trim.Length = 0 Then
            a = ""
        Else
            If Directory.Exists(System.IO.Path.GetDirectoryName(excel_old.Text)) Then
                a = System.IO.Path.GetDirectoryName(excel_old.Text)
            Else
                a = ""
            End If
        End If
        With OpenFileDialog1
            .Title = "เลือกไฟล์"
            '.Filter = "All Files (*.*)|*.*"
            .Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            .FileName = ""
            .FilterIndex = 2
            .InitialDirectory = a 'System.IO.Path.GetDirectoryName(doc_path.Text) 'doc_path.Text
        End With
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            excel_old.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            NEW_CALL()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles export_txt.LinkClicked
        If result_amt.Text = "0" Then
            MsgBox("ยอดเงินเป็น 0 หรือเป็นค่าว่าง โปรดตรวจสอบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        ElseIf Len(result_amt.Text) = 0 Then
            MsgBox("ไม่พบข้อมูล โปรดตรวจสอบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            Exit Sub
        End If

        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim str3 As String = ""
        Dim file_name As String = ""
        With SaveFileDialog1
            .Filter = "TXT Files (*.txt*)|*.txt"
            .FileName = ""
        End With
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try

                'ไม่ต้องเช็ค Exists เพราะ savedialog จะเช็คเอง
                'If File.Exists(SaveFileDialog1.FileName) Then
                '    text_path.Text = "FILE EXISTS"
                'Else
                '    text_path.Text = SaveFileDialog1.FileName 'System.IO.Path.GetFullPath(SaveFileDialog1.FileName)
                'End If

                If text1.Text.Contains(",") Then
                    str1 = """" + text1.Text.Trim + """"
                Else
                    str1 = text1.Text.Trim
                End If

                If text2.Text.Contains(",") Then
                    str2 = """" + text2.Text.Trim + """"
                Else
                    str2 = text2.Text.Trim
                End If

                If text3.Text.Contains(",") Then
                    str3 = """" + text3.Text.Trim + """"
                Else
                    str3 = text3.Text.Trim
                End If
                result_text.Text = str1 & "," & str2 & "," & str3 & "," & result_amt.Text

                file_name = SaveFileDialog1.FileName
                File.Create(file_name).Dispose()
                My.Computer.FileSystem.WriteAllText(file_name, result_text.Text.Trim, True)

                'วิธีนี้ก็ได้ แต่ต้องมีบรรทัด objwriter.Dispose() ป้องกัน access denine การเปิด 2 ครั้ง
                'Dim objwriter As New System.IO.StreamWriter("file_name", True)
                'objwriter.Dispose()
                'objwriter = File.AppendText(file_name)
                'objwriter.Write(result_amt.Text) 'กรณีบันทัดเดียว
                'objwriter.Writeline(result_amt.Text) 'กรณีหลายบันทัด ให้เพิ่มบรรทัดใหม่
                'objwriter.Close()

                MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "ผลลัพท์")
            Catch ex As Exception
                MsgBox("Failed.", MsgBoxStyle.OkOnly, "Failure")
                MsgBox("ไม่สามารถบันทึกได้ โปรดตรวจสอบ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "คำเตือน")
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked_2(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim objStreamReader As StreamReader
        Dim strLine As String

        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader("C:\DCONNECT.ini")

        'Read the first line of text.
        strLine = objStreamReader.ReadLine
        Dim str As String = ""

        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing

            'Write the line to the Console window.
            Console.WriteLine(strLine)

            'Read the next line.
            strLine = objStreamReader.ReadLine
            str += strLine
        Loop
        RichTextBox1.Text = str
        'Close the file.
        objStreamReader.Close()

        Console.ReadLine()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim objReader As New StreamReader("c:\111.txt")
        'Dim sLine As String = ""
        'Dim arrText As New ArrayList()

        'Do
        '    sLine = objReader.ReadLine
        '    If Not sLine Is Nothing Then
        '        arrText.Add(sLine)
        '    End If
        'Loop Until sLine Is Nothing
        'objReader.Close()

        'For Each sLine In arrText
        '    Console.WriteLine(sLine)
        'Next
        'Console.ReadLine()

        'แบบง่าย
        'RichTextBox1.Text = objReader.ReadToEnd()
        'หรือ
        RichTextBox1.Text = My.Computer.FileSystem.ReadAllText("c:\111.txt", System.Text.Encoding.Default) 'ใช้ encode=default เพื่ออ่านภาษาไทย ได้
        'Dim binaReader As New BinaryReader("c:\111.txt")
        'RichTextBox1.Text = binaReader.ReadToEnd()
    End Sub

End Class