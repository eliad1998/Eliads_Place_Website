<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddClass.aspx.cs" Inherits="AddClass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<title>Add class</title>

 <style type="text/css">
            table td
        {
        	padding:20px;
        }
        
  table 
  {
  	border:1px solid black;
	background: #f5f5f5;
	border-collapse: separate;

	font-size: 12px;
	line-height: 24px;
	margin: 30px auto;
	text-align: left;
    width:800px;
}	
td {
	border-right: 1px solid #fff;
	border-left: 1px solid #e8e8e8;
	border-top: 1px solid #fff;
	border-bottom: 1px solid #e8e8e8;
	padding: 10px 15px;*
	position: relative;
	transition: all 300ms;
}
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<table>
<tr>

<td class="labels"><asp:Label ID="Label1" runat="server" Text="Id"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtId" ReadOnly="true"  runat="server"></asp:TextBox></td>

   
</tr>
<tr>
<td class="labels"><asp:Label ID="Label2" runat="server" Text="Name Class"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
</tr>



<tr>
<td><asp:Label ID="Label4" runat="server" Text="Duration"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtDuration" runat="server"></asp:TextBox></td>
</tr>


<tr>
<td><asp:Label ID="Label5" runat="server" Text="Maximum participants"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtMaxPart" runat="server"></asp:TextBox></td>
</tr>

        <tr>
<td><asp:Label ID="Label6" runat="server" Text="Ages"></asp:Label></td>
<td class="style1">From  <asp:TextBox ID="txtAge1" runat="server" Width="16px"></asp:TextBox> to 
    <asp:TextBox ID="txtAge2" runat="server" Width="16px"></asp:TextBox></td>
</tr>

        <tr>
<td><asp:Label ID="Label7" runat="server" Text="Gender"></asp:Label></td>
<td class="style1">
    <asp:DropDownList ID="drpGender" runat="server">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:DropDownList>
            </td>
</tr>

       

        <tr>
<td><asp:Label ID="Label14" runat="server" Text="Image"></asp:Label></td>
<td class="style1">
       <asp:Image ID="imgClass" runat="server" ImageUrl="~/pics/classes/default.png" Height="181px" Width="218px" />
    <br />
    <asp:FileUpload ID="fuImage" runat="server" /></td>

</tr>

        <tr>

            <td>
                <asp:Button ID="btnAddClass" runat="server" Text="Add Class" />
            </td>
        </tr>
    </table>
</asp:Content>

