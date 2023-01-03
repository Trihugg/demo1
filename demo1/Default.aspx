
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="demo1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox runat="server" ID="startDate">

    </asp:TextBox>

    <table border="1" style="width:1000px">
        <tr>
            <td>
                 <asp:Label ID="hhh" runat="server" Text="Label" ></asp:Label>            
                 <asp:Button runat="server" ID="Submit" OnClick="Submit_Click" /> 
                    
            </td>
                
            <td>
                  <asp:Button runat="server" ID="Button2" Text="Delete" OnClick="Delete_Click"/>
            </td>
        </tr>

        <tr>
            <td>asdas</td>
            <td>dfsdfs</td>
         
        </tr>
        <tr>
            <td>asdas</td>
            <td>dfsdfs</td>
        </tr>
        <tr>
            <td>asdas</td>
            <td>dfsdfs</td>
        </tr>
        <tr>
            <td>asdas</td>
            <td>dfsdfs</td>
        </tr>
        <tr>
            <td>asdas</td>
            <td>dfsdfs</td>
        </tr>

    </table>


</asp:Content>
