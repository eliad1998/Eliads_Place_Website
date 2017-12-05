<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Trainers.aspx.cs" Inherits="Trainers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Trainers</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GrdTrainers" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4" EnableModelValidation="True">
        <Columns>
            <asp:BoundField DataField="FirstName" HeaderText="First name"></asp:BoundField>
            <asp:BoundField DataField="LastName" HeaderText="Last name" />
            <asp:BoundField DataField="Gender" HeaderText="Gender" />
            <asp:BoundField DataField="City" HeaderText="City" />
            <asp:BoundField DataField="Mail" HeaderText="Mail" />
            <asp:TemplateField HeaderText="Pic">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" 
                        ImageUrl='<%# DataBinder.Eval(Container.DataItem,"Pic","pics/trainers/{0}") %>' Height="138px" Width="197px" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    </asp:GridView>
</asp:Content>

