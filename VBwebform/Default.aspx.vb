Imports System.Data.SqlClient
Imports System.Web.UI.HtmlControls


Public Class _Default
    Inherits Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connect As New SqlConnection("Data Source=HARSHA-YOGA;Initial Catalog=CRUD_DB;User ID=sa;Password=******")
        Dim productid As Integer = txtproductID.Text
        Dim itemname As String = txtitemname.Text
        Dim specification As String = txtspecification.Text
        Dim unit As String = Dropunit.SelectedValue
        Dim color As String = Radiocolor.SelectedValue
        Dim insertdate As DateTime = txtdate.Text
        Dim opening As Double = txtopeningqty.Text
        Dim status As String = ""
        If Checkregular.Checked = True Then
            status = "Regular"
        Else
            status = "irregular"

        End If
        connect.Open()

        Dim command As New SqlCommand("Insert into ProductInfo_Tab values('" & productid & "', '" & itemname & "','" & specification & "','" & unit & "','" & color & "','" & insertdate & "','" & opening & "','" & status & "')", connect
                                      )
        command.ExecuteNonQuery()
        MsgBox("Successfully inserted", MsgBoxStyle.Information, "MEssage")
        connect.Close()

        ListProduct()


    End Sub

    Protected Sub ListProduct()
        Dim connect As New SqlConnection("Data Source=HARSHA-YOGA;Initial Catalog=CRUD_DB;User ID=sa;Password=******")
        Dim command As New SqlCommand("select * from ProductInfo_Tab", connect)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()


    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connect As New SqlConnection("Data Source=HARSHA-YOGA;Initial Catalog=CRUD_DB;User ID=sa;Password=******")
        Dim productid As Integer = txtproductID.Text
        Dim itemname As String = txtitemname.Text
        Dim specification As String = txtspecification.Text
        Dim unit As String = Dropunit.SelectedValue
        Dim color As String = Radiocolor.SelectedValue
        Dim insertdate As DateTime = txtdate.Text
        Dim opening As Double = txtopeningqty.Text
        Dim status As String = ""
        If Checkregular.Checked = True Then
            status = "Regular"
        Else
            status = "irregular"

        End If
        connect.Open()

        Dim command As New SqlCommand("update ProductInfo_Tab set ItemName = '" & itemname & "', Specification = '" & specification & "', Unit = '" & unit & "', Color  = '" & color & "', InsertDate = '" & insertdate & "', Opening = '" & opening & "', Status = '" & status & "' where ProductID = '" & productid & "'", connect)

        command.ExecuteNonQuery()
        MsgBox("Successfully updated", MsgBoxStyle.Information, "Message")
        connect.Close()

        ListProduct()


    End Sub

    Protected Sub txtdate_TextChanged(sender As Object, e As EventArgs) Handles txtdate.TextChanged

    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListProduct()
    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connect As New SqlConnection("Data Source=HARSHA-YOGA;Initial Catalog=CRUD_DB;User ID=sa;Password=********")
        Dim productid As Integer = txtproductID.Text
        connect.Open()

        Dim command As New SqlCommand("Delete ProductInfo_Tab where ProductID = '" & productid & "'", connect)

        command.ExecuteNonQuery()
        MsgBox("Successfully deleted", MsgBoxStyle.Information, "Message")
        connect.Close()

        ListProduct()

    End Sub

    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim productid As Integer = txtproductID.Text
        Dim connect As New SqlConnection("Data Source=HARSHA-YOGA;Initial Catalog=CRUD_DB;User ID=sa;Password=*******")
        Dim command As New SqlCommand("select * from ProductInfo_Tab where ProductID = '" & productid & "' ", connect)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()

    End Sub
End Class
