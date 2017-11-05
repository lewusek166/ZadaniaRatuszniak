<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Zadanie2cz1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>Label</h2>
    <h3>&nbsp;</h3>
    

        <table style="width:100%;">
            <tr>
                <td>
                    Imię
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;<asp:Label ID="Label2" runat="server" Text=" " ForeColor="#FF3300"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td>
                    Wiek</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" Text=" " ForeColor="#FF3300"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td>
                    Żonaty/Mężatka</td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                
            </tr>
            <tr>
                <td>
                    Płeć</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                        
                        <asp:ListItem></asp:ListItem>
                        
                        <asp:ListItem>Kobieta</asp:ListItem>
                        <asp:ListItem>Mężczyzna</asp:ListItem>
                        <asp:ListItem>Nieznana</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label ID="Label4" runat="server" Text=" " ForeColor="#FF3300"></asp:Label>
                </td>
               
            </tr>
            <tr>
                <td colspan="2"> 
                    <asp:Button ID="Button1" runat="server" Text="ZAPISZ" OnClick="Button1_Click" />
                
                    
                </td>
               
            </tr>
            <tr>
                <td colspan="2"> 
                    
                    <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
                    
                </td>
               
            </tr>
        </table>

    
</asp:Content>
