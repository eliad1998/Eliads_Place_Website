<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" Debug="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<title>Register</title>
    <style type="text/css">
        .style1
        {
            height: 22px;
        }
        
 
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

<td class="labels"><asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtUser"  runat="server"></asp:TextBox></td>

   
</tr>
<tr>
<td class="labels"><asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox></td>
</tr>



<tr>
<td><asp:Label ID="Label4" runat="server" Text="First Name"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
</tr>


<tr>
<td><asp:Label ID="Label5" runat="server" Text="Last name"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtLname" runat="server"></asp:TextBox></td>
</tr>

    <tr>
<td><asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label></td>
<td>
    <asp:RadioButtonList ID="genderList" runat="server" BorderColor="Transparent">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
</td>



</tr>


<tr>
<td><asp:Label ID="Label6" runat="server" Text="City"></asp:Label></td>
<td>
    <asp:DropDownList ID="dropCity" runat="server">
        <asp:ListItem>Select City</asp:ListItem> 

    </asp:DropDownList>
</td>

</tr>

<tr>
<td><asp:Label ID="Label7" runat="server" Text="Street"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
</tr>

<tr>
<td><asp:Label ID="Label8" runat="server" Text="Numeber Street"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtStreetNum" runat="server"></asp:TextBox></td>
</tr>

    <tr>
<td><asp:Label ID="Label13" runat="server" Text="Birth Year"></asp:Label></td>
<td class="style1">
    <asp:DropDownList ID="ddBirth" runat="server">
        <asp:ListItem>2015</asp:ListItem>
        <asp:ListItem>2014</asp:ListItem>
<asp:ListItem>2013</asp:ListItem> 
<asp:ListItem>2012</asp:ListItem> 
<asp:ListItem>2011</asp:ListItem> 
<asp:ListItem>2010</asp:ListItem> 
<asp:ListItem>2009</asp:ListItem> 
<asp:ListItem>2008</asp:ListItem> 
<asp:ListItem>2007</asp:ListItem> 
<asp:ListItem>2006</asp:ListItem> 
<asp:ListItem>2005</asp:ListItem> 
<asp:ListItem>2004</asp:ListItem> 
<asp:ListItem>2003</asp:ListItem> 
<asp:ListItem>2002</asp:ListItem> 
<asp:ListItem>2001</asp:ListItem> 
<asp:ListItem>2000</asp:ListItem> 
<asp:ListItem>1999</asp:ListItem> 
<asp:ListItem>1998</asp:ListItem> 
<asp:ListItem>1997</asp:ListItem> 
<asp:ListItem>1996</asp:ListItem> 
<asp:ListItem>1995</asp:ListItem> 
<asp:ListItem>1994</asp:ListItem> 
<asp:ListItem>1993</asp:ListItem> 
<asp:ListItem>1992</asp:ListItem> 
<asp:ListItem>1991</asp:ListItem> 
<asp:ListItem>1990</asp:ListItem> 
<asp:ListItem>1989</asp:ListItem> 
<asp:ListItem>1988</asp:ListItem> 
<asp:ListItem>1987</asp:ListItem> 
<asp:ListItem>1986</asp:ListItem> 
<asp:ListItem>1985</asp:ListItem> 
<asp:ListItem>1984</asp:ListItem> 
<asp:ListItem>1983</asp:ListItem> 
<asp:ListItem>1982</asp:ListItem> 
<asp:ListItem>1981</asp:ListItem> 
<asp:ListItem>1980</asp:ListItem> 
<asp:ListItem>1979</asp:ListItem> 
<asp:ListItem>1978</asp:ListItem> 
<asp:ListItem>1977</asp:ListItem> 
<asp:ListItem>1976</asp:ListItem> 
<asp:ListItem>1975</asp:ListItem> 
<asp:ListItem>1974</asp:ListItem> 
<asp:ListItem>1973</asp:ListItem> 
<asp:ListItem>1972</asp:ListItem> 
<asp:ListItem>1971</asp:ListItem> 
<asp:ListItem>1970</asp:ListItem> 
<asp:ListItem>1969</asp:ListItem> 
<asp:ListItem>1968</asp:ListItem> 
<asp:ListItem>1967</asp:ListItem> 
<asp:ListItem>1966</asp:ListItem> 
<asp:ListItem>1965</asp:ListItem> 
<asp:ListItem>1964</asp:ListItem> 
<asp:ListItem>1963</asp:ListItem> 
<asp:ListItem>1962</asp:ListItem> 
<asp:ListItem>1961</asp:ListItem> 
<asp:ListItem>1960</asp:ListItem> 
<asp:ListItem>1959</asp:ListItem> 
<asp:ListItem>1958</asp:ListItem> 
<asp:ListItem>1957</asp:ListItem> 
<asp:ListItem>1956</asp:ListItem> 
<asp:ListItem>1955</asp:ListItem> 
<asp:ListItem>1954</asp:ListItem> 
<asp:ListItem>1953</asp:ListItem> 
<asp:ListItem>1952</asp:ListItem> 
<asp:ListItem>1951</asp:ListItem> 
<asp:ListItem>1950</asp:ListItem> 
<asp:ListItem>1949</asp:ListItem> 
<asp:ListItem>1948</asp:ListItem> 
<asp:ListItem>1947</asp:ListItem> 
<asp:ListItem>1946</asp:ListItem> 
<asp:ListItem>1945</asp:ListItem> 
<asp:ListItem>1944</asp:ListItem> 
<asp:ListItem>1943</asp:ListItem> 
<asp:ListItem>1942</asp:ListItem> 
<asp:ListItem>1941</asp:ListItem> 
<asp:ListItem>1940</asp:ListItem> 
<asp:ListItem>1939</asp:ListItem> 
<asp:ListItem>1938</asp:ListItem> 
<asp:ListItem>1937</asp:ListItem> 
<asp:ListItem>1936</asp:ListItem> 
<asp:ListItem>1935</asp:ListItem> 
<asp:ListItem>1934</asp:ListItem> 
<asp:ListItem>1933</asp:ListItem> 
<asp:ListItem>1932</asp:ListItem> 
<asp:ListItem>1931</asp:ListItem> 
<asp:ListItem>1930</asp:ListItem> 
<asp:ListItem>1929</asp:ListItem> 
<asp:ListItem>1928</asp:ListItem> 
<asp:ListItem>1927</asp:ListItem> 
<asp:ListItem>1926</asp:ListItem> 
<asp:ListItem>1925</asp:ListItem> 
<asp:ListItem>1924</asp:ListItem> 
<asp:ListItem>1923</asp:ListItem> 
<asp:ListItem>1922</asp:ListItem> 
<asp:ListItem>1921</asp:ListItem> 
<asp:ListItem>1920</asp:ListItem> 
<asp:ListItem>1919</asp:ListItem> 
<asp:ListItem>1918</asp:ListItem> 
<asp:ListItem>1917</asp:ListItem> 
<asp:ListItem>1916</asp:ListItem> 
<asp:ListItem>1915</asp:ListItem> 

    </asp:DropDownList></td>
</tr>

<tr>
<td><asp:Label ID="Label9" runat="server" Text="Mail"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtMail" runat="server"></asp:TextBox></td>
</tr>

<tr>
<td><asp:Label ID="Label10" runat="server" Text="Phone"></asp:Label></td>
<td class="style1"><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
</tr>

    <tr>
<td><asp:Label ID="Label14" runat="server" Text="Image"></asp:Label></td>
<td class="style1">
       <asp:Image ID="imgUser" runat="server" ImageUrl="~/pics/users/default.jpg" Height="181px" Width="218px" />
    <br />
    <asp:FileUpload ID="fuImage" runat="server" /></td>

</tr>


<tr><td>
    <asp:Button ID="Button1" runat="server" Text="Register" 
        onclick="Button1_Click" />
    </td></tr>

</table>
</asp:Content>

