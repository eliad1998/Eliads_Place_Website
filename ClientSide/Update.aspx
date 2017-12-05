<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Update.aspx.cs" Inherits="Update" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Update your details</title>

    <style>
        table tr td {
            font-weight:bold;
            padding:30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Home" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="regTable">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label></td>
            <td>
                <asp:Label  ID="lblUser" runat="server" Text="" Font-Bold="False"></asp:Label>

            </td>

            <td>
                <asp:Image ID="Image1" runat="server"  Height="350px" Width="350px"/>
            </td>
        </tr>


        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Old Password"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
            </td>

            <td>
                <asp:Label ID="Label3" runat="server" Text="Change Picture"></asp:Label>

                &nbsp;
                &nbsp;
                 <asp:FileUpload ID="fuImage" runat="server" />
            </td>
    
        </tr>

        <tr>
   <td>
                <asp:Label ID="Label4" runat="server" Text="New Password"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPassNew" runat="server" TextMode="Password"></asp:TextBox>
            </td>

            <td>
                <asp:Label ID="Label16" runat="server" Text="If you didn't entered your old or new password it won't update it."></asp:Label>
            </td>
        </tr>

        <tr>
   <td>
                <asp:Label ID="Label5" runat="server" Text="First Name"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
            </td>

        </tr>

                <tr>
   <td>
                <asp:Label ID="Label6" runat="server" Text="Last Name"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
            </td>

        </tr>

        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Gender"></asp:Label>
            </td>
           <td>
               <asp:Label ID="lblGender" runat="server" Text=""></asp:Label></td>
        </tr>

                        <tr>
   <td>
                <asp:Label ID="Label7" runat="server" Text="City"></asp:Label></td>
            <td>
                    <asp:DropDownList ID="dropCity" runat="server">
        <asp:ListItem>Givat Shmuel</asp:ListItem> 
<asp:ListItem>Tel Aviv</asp:ListItem> 
<asp:ListItem>Ramat Gan</asp:ListItem> 
<asp:ListItem>New York</asp:ListItem> 
<asp:ListItem>Kfar Saba</asp:ListItem> 
<asp:ListItem>Bat Yam</asp:ListItem> 

    </asp:DropDownList>
            </td>

        </tr>

        
                <tr>
   <td>
                <asp:Label ID="Label8" runat="server" Text="Street"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
            </td>

        </tr>

        
                <tr>
   <td>
                <asp:Label ID="Label9" runat="server" Text="Number Street"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtNumStreet" runat="server"></asp:TextBox>
            </td>

        </tr>

             <tr>
            <td>
                <asp:Label ID="Label14" runat="server" Text="Age"></asp:Label>
            </td>
           <td>
               <asp:Label ID="lblAge" runat="server" Text=""></asp:Label></td>
        </tr>

        
                <tr>
   <td>
                <asp:Label ID="Label10" runat="server" Text="Mail"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtMail" runat="server"></asp:TextBox>
            </td>

        </tr>

                       <tr>
   <td>
                <asp:Label ID="Label11" runat="server" Text="Phone"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            </td>

        </tr>

             <tr>
            <td>
                <asp:Label ID="Label15" runat="server" Text="Type User"></asp:Label>
            </td>
           <td>
               <asp:Label ID="lblType" runat="server" Text=""></asp:Label></td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" /></td>
        </tr>




    </table>
</asp:Content>

