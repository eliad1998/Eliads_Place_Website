<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="Products"  EnableEventValidation="false" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <table>
     
        <tr>
            <td>
                <asp:DropDownList ID="dropType" runat="server" OnSelectedIndexChanged="dropType_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem>All types</asp:ListItem>
                    <asp:ListItem Value="Equipment">Equipment</asp:ListItem>
                    <asp:ListItem>Nutrition</asp:ListItem>
                </asp:DropDownList>

                </td>
            <td>
                <asp:DropDownList ID="dropProvider" runat="server">
                    <asp:ListItem>All providers</asp:ListItem>
                </asp:DropDownList>
            </td>
                        <td class="style1">
                            &nbsp;</td>
            </tr>


                <tr>
            <td>
                <asp:DropDownList ID="dropSearch" runat="server" OnSelectedIndexChanged="dropSearch_SelectedIndexChanged" AutoPostBack="true">
                    <asp:ListItem>Show all</asp:ListItem>
                    <asp:ListItem>Search by id</asp:ListItem>
                    <asp:ListItem>Search by name</asp:ListItem>
                    <asp:ListItem>Search by price lower than</asp:ListItem>
                </asp:DropDownList>

            </td>

            <td>
                <asp:DropDownList ID="dropStatus" runat="server">
                    <asp:ListItem>All</asp:ListItem>
                    <asp:ListItem>On the store</asp:ListItem>
                    <asp:ListItem>Was in the store</asp:ListItem>
                </asp:DropDownList>
                    </td>
        </tr>
        <tr>
            <td>
                 <asp:TextBox ID="txtSearch" runat="server" Width="197px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click" Width="209px"  />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td align="center" class="style4">
                <asp:Label ID="lbldidnt" runat="server" Text="Didn't found" Visible="false" Font-Bold="true" ForeColor="Red" Font-Size="Large"></asp:Label>
            </td>
        </tr>
     
    </table>

    <asp:gridview id="GrdProducts" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" EnableModelValidation="True" Height="246px" Width="806px" AllowPaging="True" OnPageIndexChanging="GrdProducts_PageIndexChanging" PageSize="5">
        <Columns>
            <asp:TemplateField HeaderText="Details">
                <ItemTemplate>
                    <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="IdProduct" HeaderText="Id" />
            <asp:BoundField DataField="NameProduct" HeaderText="Name" />
            <asp:BoundField DataField="CurCap" HeaderText="Current capacity" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
            <asp:BoundField DataField="Provider" HeaderText="Provider" />
            <asp:TemplateField HeaderText="Picture">
                <ItemTemplate>
                    <asp:Image ID="imgProduct" runat="server" Height="152px" ImageUrl='<%# DataBinder.Eval(Container.DataItem,"Pic","pics/products/{0}") %>' Width="217px" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="Status" HeaderText="On the store" />
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    </asp:gridview>
</asp:Content>

