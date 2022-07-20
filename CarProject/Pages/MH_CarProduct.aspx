<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MH_CarProduct.aspx.cs" Inherits="CarProject.Pages.MH_CarProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top:10px" class="container">
    <table style="width:100%; align-items:center">
            <tr>
                <td>
        <asp:Image ID="Image1" runat="server" Width="350px" Height="280px"/> <br />
        ID:&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="Label4" runat="server"></asp:Label> <br />
        Name:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server"></asp:Label> <br />
        Description:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server"></asp:Label> <br />
        Status:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" ></asp:Label> <br />
        <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
        <%--<asp:Button ID="Button3"  runat="server" Text="Add" OnClick="Button3_Click" />
        <asp:Button ID="Button4"  runat="server" Text="Edit" OnClick="Button4_Click" />
        <asp:Button ID="Button5"  runat="server" Text="Delete" OnClick="Button5_Click" />--%>
                    </td>
                <td style="text-align:center">
        <asp:GridView AutoGenerateColumns="False"  ID="GridView1" runat="server" Width="100%" Height="300px" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <%#Eval("DetailId") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <%#Eval("DetailName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Image">
                    <ItemTemplate>
                        <img width="50px" src='<%#Eval("DetailImgUrl") != null ? Eval("DetailImgUrl").ToString().Replace("~", "") : string.Empty %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <%#Eval("DetailStatus") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <%#Eval("DetailDescription") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnView"  runat="server" Text="View" OnClick="btnView_Click" />
                        
                        <asp:Button ID="btnEdit"  runat="server" Text="Edit" OnClick="btnEdit_Click" />
                        <asp:Button ID="btnDelete"  runat="server" Text="Delete" OnClick="btnDelete_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
                    </td>
     
                </tr>
               </table>
        </div>
</asp:Content>
