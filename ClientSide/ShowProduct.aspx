<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowProduct.aspx.cs" Inherits="ShowProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<title>Show product</title>
        <style>

            
        table tr td 
        {
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
                <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label></td>
            <td>
                <asp:Label  ID="lblId" runat="server" Font-Bold="False"></asp:Label>

            </td>

            <td style="height:350px; width:350px;">
                <asp:Image ID="Image1" runat="server"  Height="350px" Width="350px"/>
            </td>
        </tr>


        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtName" runat="server" Width="228px"></asp:TextBox>
            </td>

            <td>
                <asp:Label ID="lblPicChange" runat="server" Text="Change Picture"></asp:Label>

                &nbsp;
                &nbsp;
                 <asp:FileUpload ID="fuImage" runat="server" />
            </td>
    
        </tr>

        <tr>
   <td>
                <asp:Label ID="Label4" runat="server" Text="Information"></asp:Label></td>
            <td>
        <asp:TextBox id="txtInformation" TextMode="multiline" Columns="50" Rows="5" runat="server" Height="167px" Width="227px" />


            </td>

            <td>
                <asp:Label ID="Label3" runat="server" 
                    Text="lblblbllblbbllbllblblblblblbllblbbllbllblblblblblbllblblbll" 
                    ForeColor="Transparent"></asp:Label>
                 </td>
        </tr>

        <tr>
   <td>
                <asp:Label ID="Label5" runat="server" Text="Minimum Capacity"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtMinCap" runat="server" Width="131px"></asp:TextBox>
            </td>

        </tr>

                <tr>
   <td>
                <asp:Label ID="Label6" runat="server" Text="Maximum Capacity"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtMaxCap" runat="server"></asp:TextBox>
            </td>

        </tr>

        <tr>
            <td>
                <asp:Label ID="Label13" runat="server" Text="Current Capacity"></asp:Label>
            </td>
           <td>
                <asp:TextBox ID="txtCurCap" runat="server"></asp:TextBox>
            </td>
        </tr>

                        <tr>
   <td>
                <asp:Label ID="Label7" runat="server" Text="Price"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>

        </tr>

        
                <tr>
   <td>
                <asp:Label ID="Label8" runat="server" Text="Provider"></asp:Label></td>
            <td>
                <asp:DropDownList ID="dropProvider" runat="server">
                    <asp:ListItem>Choose provider</asp:ListItem>
                </asp:DropDownList>
            </td>

        </tr>

        
                <tr>
   <td>
                <asp:Label ID="Label16" runat="server" Text="In the store"></asp:Label>
                    </td>
            <td>
               <asp:Label ID="lblInStore" runat="server"></asp:Label>
            </td>

        </tr>

             <tr>
            <td>
                <asp:Label ID="lblMyPrice" runat="server" Text="Your price"></asp:Label>
            </td>
           <td>
                <asp:TextBox ID="txtMyPrice" runat="server"></asp:TextBox>
                 </td>
        </tr>

        
                <tr>
   <td>
                <asp:Label ID="Label15" runat="server" Text="Type product"></asp:Label>
                    </td>
            <td>
                <asp:Label ID="lblType" runat="server"></asp:Label>
            </td>

        </tr>

                       <tr>
   <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" /></td>
            <td>
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            </td>

        </tr>





    </table>

</asp:Content>

