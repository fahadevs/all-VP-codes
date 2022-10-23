<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeWebForm.aspx.cs" Inherits="_3_tier_web.EmployeeWebPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 72%;
            height: 497px;
        }
        .auto-style3 {
            width: 163px;
        }
        .auto-style4 {
            width: 227px;
        }
        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 163px;
            height: 85px;
        }
        .auto-style7 {
            width: 227px;
            height: 85px;
        }
        .auto-style8 {
            height: 85px;
            text-align: center;
        }
        .auto-style9 {
            width: 163px;
            height: 154px;
        }
        .auto-style10 {
            width: 227px;
            height: 154px;
        }
        .auto-style11 {
            text-align: center;
            height: 154px;
        }
        .auto-style12 {
            width: 163px;
            height: 79px;
        }
        .auto-style13 {
            width: 227px;
            height: 79px;
        }
        .auto-style14 {
            height: 79px;
            text-align: center;
        }
        .auto-style15 {
            height: 79px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table align="center" class="auto-style2">
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td class="auto-style13"><h2>EMPLOYEES</h2></td>
                <td class="auto-style15">
                    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Back" />
                </td>
            </tr>
            <tr>
                <td class="auto-style12">Id</td>
                <td class="auto-style13">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Name</td>
                <td class="auto-style7">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="Label1" runat="server" Text="ConfirmationLabel" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Cell</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style11">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="auto-style5" DataKeyNames="EmpId" DataSourceID="SqlDataSource1" Width="288px">
                        <Columns>
                            <asp:BoundField DataField="EmpId" HeaderText="EmpId" InsertVisible="False" ReadOnly="True" SortExpression="EmpId" />
                            <asp:BoundField DataField="EmpName" HeaderText="EmpName" SortExpression="EmpName" />
                            <asp:BoundField DataField="EmpCell" HeaderText="EmpCell" SortExpression="EmpCell" />
                            <asp:BoundField DataField="EmpAddress" HeaderText="EmpAddress" SortExpression="EmpAddress" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lovel\OneDrive\Documents\Shop.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Employees]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Address</td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
                </td>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search By ID" />
                </td>
            </tr>
        </table>
        <br />
    </p>
</asp:Content>
