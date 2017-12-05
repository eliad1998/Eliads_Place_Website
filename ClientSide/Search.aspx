<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Search</title>

   <style>
        #pad tr td { padding:50px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
                    <tr>
            <td rowspan="7">
                <asp:Image ID="img1" runat="server" Height="231px" Width="215px" 
                    ImageUrl="~/pics/users/user.jpg"></asp:Image>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lbl1" runat="server" Text="Username"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
            </td>

        </tr>

        <tr>
            <td>
                <asp:Label ID="lbl3" runat="server" Text="First name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Last name"></asp:Label>
            </td>
            <td align="center" class="style2">
                <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
        <td><asp:Label ID="Label6" runat="server" Text="City"></asp:Label></td>
<td>
    <asp:DropDownList ID="dropCity" runat="server">
            <asp:ListItem>All cities</asp:ListItem> 

    </asp:DropDownList>
</td>
        </tr>
                        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Mail"></asp:Label>
            </td>
            <td align="center" class="style4">
                <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
            </td>
        </tr>



       <tr>
             <td class="style1">
                <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click"  />
            </td>

            
            <td>
     <asp:Label ID="lbldidnt" runat="server" Text="Didn't found" Visible="false" Font-Bold="true" ForeColor="Red" Font-Size="Large"></asp:Label>

            </td>
        </tr>   
        
    
   
    </table>

<asp:GridView ID="GrdClients" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
        CellPadding="6" EnableModelValidation="True" AllowPaging="True" 
    onpageindexchanging="GrdClients_PageIndexChanging" PageSize="5">
    <Columns>
        <asp:BoundField DataField="Username" HeaderText="Username" />
        <asp:BoundField DataField="FirstName" HeaderText="First name" />
        <asp:BoundField DataField="LastName" HeaderText="Last name" />
        <asp:BoundField DataField="Gender" HeaderText="Gender" />
        <asp:BoundField DataField="City" HeaderText="City" />
        <asp:BoundField DataField="Age" HeaderText="Age" />
        <asp:BoundField DataField="Mail" HeaderText="Mail" />
        <asp:BoundField DataField="Phone" HeaderText="Phone" />
        <asp:TemplateField HeaderText="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Picture&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;">
            <ItemTemplate>
                <asp:Image ID="Image1" runat="server"
                    
                    
                    ImageUrl='<%# DataBinder.Eval(Container.DataItem,"Pic","pics/users/{0}") %>' 
                    Height="100px" Width="160px" 
                     />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Level" HeaderText="Type " />
        <asp:BoundField DataField="Status" HeaderText="Status" />
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <RowStyle BackColor="White" ForeColor="#330099" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
</asp:GridView>
</asp:Content>

