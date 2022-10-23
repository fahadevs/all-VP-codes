<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Webform1.aspx.cs" Inherits="WebApplication.Webform1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 72%;
        height: 162px;
    }
    .auto-style2 {
        width: 247px;
    }
    .auto-style4 {
        width: 247px;
        text-align: center;
    }
    .auto-style5 {
        text-align: left;
    }
        .auto-style6 {
            width: 247px;
            text-align: center;
            height: 26px;
            margin-left: 160px;
        }
        .auto-style7 {
            text-align: left;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 247px;
            text-align: center;
            height: 80px;
            margin-left: 160px;
        }
        .auto-style10 {
            height: 80px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <table align="center" class="auto-style1">
        <tr>
            <td class="auto-style4" >Name</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4" >Cell</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Gender</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Other</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Address</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Age</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Country</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">City</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style9">Designation</td>
            <td class="auto-style10">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Software-Engineer" />
                <br />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Intern" />
                <br />
                <asp:RadioButton ID="RadioButton3" runat="server" Text="Team-Lead" />
                <br />
            </td>

            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style5">
                <asp:Button ID="Button1" runat="server" Text="Submit" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
</p>
</asp:Content>
