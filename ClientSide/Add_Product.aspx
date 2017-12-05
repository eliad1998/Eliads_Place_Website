<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Add_Product.aspx.cs" Inherits="Add_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Add Product</title>

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
<td class="labels"><asp:Label ID="Label2" runat="server" Text="Name Product"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
</tr>

<tr>

 <td>
     <asp:Label ID="Label15" runat="server" Text="Information"></asp:Label>
    </td>

    <td>
        <asp:TextBox id="txtInformation" TextMode="multiline" Columns="50" Rows="5" runat="server" Height="167px" Width="203px" />


    </td>
        </tr>


<tr>
<td><asp:Label ID="Label4" runat="server" Text="Minimum capacity"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtMinCap" runat="server"></asp:TextBox></td>
</tr>


<tr>
<td><asp:Label ID="Label5" runat="server" Text="Maximum capacity"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtMaxCap" runat="server"></asp:TextBox></td>
</tr>

        <tr>
<td><asp:Label ID="Label6" runat="server" Text="Current capacity"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtCurCap" runat="server"></asp:TextBox></td>
</tr>

        <tr>
<td><asp:Label ID="Label7" runat="server" Text="Price for consumer"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
</tr>

                <tr>
<td><asp:Label ID="Label8" runat="server" Text="Price for you"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtMyPrice" runat="server"></asp:TextBox></td>
</tr>

        <tr>
<td><asp:Label ID="Label9" runat="server" Text="Type"></asp:Label></td>
<td>
    <asp:DropDownList ID="dropType" runat="server" OnSelectedIndexChanged="dropType_SelectedIndexChanged" AutoPostBack="true">
        <asp:ListItem>Equipment</asp:ListItem> 

        <asp:ListItem>Nutrition</asp:ListItem>

    </asp:DropDownList>
</td>

</tr>
<tr>
<td><asp:Label ID="Label3" runat="server" Text="Provider"></asp:Label></td>
<td>
    <asp:DropDownList ID="dropProvider" runat="server">
        <asp:ListItem>Select provider</asp:ListItem> 

    </asp:DropDownList>
</td>

</tr>

        <tr>
<td><asp:Label ID="Label14" runat="server" Text="Image"></asp:Label></td>
<td class="style1">
       <asp:Image ID="imgProduct" runat="server" ImageUrl="~/pics/products/default.png" Height="181px" Width="218px" />
    <br />
    <asp:FileUpload ID="fuImage" runat="server" /></td>

</tr>

        <tr>

            <td>
                <asp:Button ID="btnAddProduct" runat="server" OnClick="btnAddProduct_Click" Text="Add product" />
            </td>
        </tr>
    </table>




</asp:Content>

