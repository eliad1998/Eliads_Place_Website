<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="centerBlock" style="width:120%">
<table>
<tr>
<td>
    <asp:DropDownList ID="dropType" runat="server" 
        onselectedindexchanged="dropType_SelectedIndexChanged" AutoPostBack="true">
        <asp:ListItem>Equipment</asp:ListItem>
        <asp:ListItem>Nutrition</asp:ListItem>
    </asp:DropDownList> </td>

    <td>
        <asp:DropDownList ID="dropProvider" runat="server" 
            onselectedindexchanged="dropProvider_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>All products</asp:ListItem>
        </asp:DropDownList>
    </td>

    <td>
        &nbsp;</td>
</tr>

</table>
    <asp:DataList ID="dtlProd" runat="server" RepeatColumns="2" 
        RepeatDirection="Horizontal" oneditcommand="dtlProd_EditCommand" 
        onselectedindexchanged="dtlProd_SelectedIndexChanged" SelectedItemStyle-BackColor="#999999" BackColor="White" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
        ForeColor="Black" GridLines="Vertical" onupdatecommand="dtlProd_UpdateCommand" OnItemDataBound="dtlProd_ItemDataBound">

        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />

    <ItemTemplate>
    
    <table>
    <tr>
    <td rowspan="3" colspan="2">
        <asp:Image ID="img" runat="server" Height="135px" 
            ImageUrl='<%# DataBinder.Eval(Container.DataItem,"Pic","pics/Products/{0}") %>' 
            Width="143px" />  </td>
    </tr>
    
    <tr>
    <td>Name:</td>
    <td>
        <asp:Label ID="lblName" runat="server" 
            Text='<%# DataBinder.Eval(Container.DataItem,"NameProduct") %>'></asp:Label></td>



    </tr>
  

  <tr>
   
    <td>Price</td>
    <td>
    
            <asp:Label ID="lblPrice" runat="server" 
            Text='<%# DataBinder.Eval(Container.DataItem,"Price") %>'></asp:Label></td>
    </td>
</tr>



       <tr>
  <td>
      <asp:Button ID="btnChoose" runat="server" Text="Choose" CommandName="Edit" /></td>
   
      <td><a href="ShowProduct.aspx?id=<%# DataBinder.Eval(Container.DataItem,"IdProduct") %>" target="_blank">Details</a></td>

  </tr>
    </table>
    </ItemTemplate>

        <AlternatingItemStyle BackColor="#CCCCCC" />

    <EditItemTemplate>
    

        <table>
    <tr>
    <td rowspan="4">
        <asp:Image ID="img" runat="server" Height="135px" 
            ImageUrl='<%# DataBinder.Eval(Container.DataItem,"Pic","pics/Products/{0}") %>' 
            Width="143px" />  </td>
    </tr>
    
    <tr>
    <td>Name:</td>
    <td>
        <asp:Label ID="lblName" runat="server" 
            Text='<%# DataBinder.Eval(Container.DataItem,"NameProduct") %>'></asp:Label></td>
  
        
                          <%-- The current capacity label--%>
        <td> 
            <asp:Label ID="lblCurCap" runat="server" Visible="false" Text='<%# DataBinder.Eval(Container.DataItem,"CurCap") %>'></asp:Label>  </td>
        
        
        
<%--id do not visible--%>
    <td>
        <asp:Label ID="lblId" runat="server" Text="" Visible="false"></asp:Label>
    </td>
          </tr>

    <tr>
    <td>
    Quantity
    </td>
    <td>
        <asp:DropDownList ID="drpQua" runat="server" Width="56px" AutoPostBack="True">
        </asp:DropDownList> </td>

   
    </tr>
      <tr>
    
    <td>Price</td>
    <td>
    
            <asp:Label ID="lblPrice" runat="server" 
            Text='<%# DataBinder.Eval(Container.DataItem,"Price") %>'></asp:Label></td>

     
    </tr>

       <tr>
  <td>
      <asp:Button ID="btnOrder" runat="server" Text="Order" CommandName="Update" /></td>



        <td>
      <asp:Button ID="btnCancel" runat="server" Text="Cancel" CommandName="Select" /></td>
  </tr>



    </table>

    </EditItemTemplate>

        <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="Red" />

    </asp:DataList>


    <br />
    <br />
        <table>
            <tr>

                <td>
                    <asp:Button ID="btnOrder" runat="server" Text="Order" OnClick="btnOrder_Click" />
                </td>
                <td>
                    <asp:Button ID="btnShow" runat="server" Text="Show orders" OnClick="btnShow_Click" />
                </td>
            </tr>

        </table>
    <asp:GridView Visible="False" ID="GrdOrder" runat="server" BackColor="White" 
        BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
        EnableModelValidation="True" 
        onselectedindexchanged="GrdOrder_SelectedIndexChanged" 
            AutoGenerateColumns="False">
        <Columns>
            <asp:CommandField ButtonType="Button" SelectText="Remove" 
                ShowSelectButton="True" />
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






</div>

</asp:Content>

