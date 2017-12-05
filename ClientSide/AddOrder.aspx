<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddOrder.aspx.cs" Inherits="AddOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<a href="Orders.aspx">Return to orders</a>
<br />
<br />
    <asp:GridView ID="GrdOrder" runat="server" BackColor="White" 
        BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
        EnableModelValidation="True" 
            AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            <asp:BoundField DataField="Total Price" HeaderText="Total Price" />
<asp:TemplateField HeaderText="Image" >
    <ItemTemplate>
        <asp:Image ID="Image1" runat="server" Height="70px" 
            ImageUrl='<%# DataBinder.Eval(Container.DataItem,"Pic","pics/products/{0}") %>' 
            Width="88px" />
    </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />

  
    </asp:GridView>






    <br />

    <br />
    <p>Add your credit card details</p>
    <table>
    <tr>
    <td>
        <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
        </td>

    <td>
        <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
        </td>
    </tr>

      <tr>
    <td>
        <asp:Label ID="Label2" runat="server" Text="ExpiryDate"></asp:Label>
          </td>

    <td>
        <asp:DropDownList ID="dropMonth" runat="server" Height="45px" Width="94px">
            <asp:ListItem>Month</asp:ListItem>
        </asp:DropDownList>

        <asp:DropDownList ID="dropYear" runat="server" Height="39px" Width="76px">
            <asp:ListItem>Year</asp:ListItem>
        </asp:DropDownList>

         </td>
    </tr>

       <tr>
    <td>
        <asp:Label ID="Label3" runat="server" Text="CVV"></asp:Label>
           </td>

    <td>
        <asp:TextBox ID="txtCvv" runat="server"></asp:TextBox>
           </td>
    </tr>

    </table>

    <br />

    <asp:Button ID="btnOrder" runat="server" Text="Order" 
        onclick="btnOrder_Click" />
    </center>
</asp:Content>

