<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="VBwebform._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

 <div style ="background-color:darkgoldenrod; font-size:x-large; color:white; align-content:center">
     CRUD operations in ASP VB.NET

 </div>
    <br />
    <div style="padding:20px"> Various Products Information

        <table class="nav-justified">
            <tr>
                <td>ProductID</td>
                <td>
                    <asp:TextBox ID="txtproductID" runat="server" Font-Size="Medium" Width="243px"></asp:TextBox>
                &nbsp;
                    <asp:Button ID="Button5" runat="server" Font-Size="Small" ForeColor="Black" Height="24px" Text="Search" Width="76px" />
                </td>
            </tr>
            <tr>
                <td>Item name</td>
                <td>
                    <asp:TextBox ID="txtitemname" runat="server" Font-Size="Medium" Width="243px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Specification</td>
                <td>
                    <asp:TextBox ID="txtspecification" runat="server" Font-Size="Medium" Width="243px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Unit</td>
                <td>
                    <asp:DropDownList ID="Dropunit" runat="server" Font-Size="Medium" Width="200px">
                        <asp:ListItem>KG</asp:ListItem>
                        <asp:ListItem>PCS</asp:ListItem>
                        <asp:ListItem>DZ</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="height: 20px">Color</td>
                <td style="height: 20px">
                    <asp:RadioButtonList ID="Radiocolor" runat="server" Font-Size="Medium" RepeatDirection="Horizontal" Width="268px">
                        <asp:ListItem>Grey</asp:ListItem>
                        <asp:ListItem>White</asp:ListItem>
                        <asp:ListItem>Black</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>Insert date</td>
                <td>
                    <asp:TextBox ID="txtdate" runat="server" Font-Size="Medium" Width="243px"></asp:TextBox>
  
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender" runat="server" TargetControlID="txtdate">
</ajaxToolkit:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td>Opening Quantity</td>
                <td>
                    <br />
                    <asp:TextBox ID="txtopeningqty" runat="server" Font-Size="Medium" Width="243px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Product Status</td>
                <td>
                    <asp:CheckBox ID="Checkregular" runat="server" Text="Regular" />
&nbsp;<asp:CheckBox ID="Checkirregular" runat="server" Text="Irregular" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td id="button3">
                    <asp:Button ID="Button2" runat="server" Font-Size="Medium" ForeColor="Black" Height="41px" Text="Insert" Width="102px" />
                &nbsp;
                    <asp:Button ID="Button3" runat="server" Font-Size="Medium" ForeColor="Black" Height="41px" Text="Update" Width="102px" />
                &nbsp;<asp:Button ID="Button4" runat="server" Font-Size="Medium" ForeColor="Black" Height="41px" Text="Delete" Width="102px" OnClientClick="return confirm('Are you sure to delete?')" />
                </td>
            </tr>
        </table>
        <div align="center">
            <hr />

            <asp:GridView ID="GridView1" runat="server" Width="600px">
                <HeaderStyle BackColor="darkgoldenrod" ForeColor="White" />
            </asp:GridView>

        </div>
    </div>

</asp:Content>
