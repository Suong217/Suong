<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MH_CarList.aspx.cs" Inherits="CarProject.Pages.MH_CarList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="text-align:center">Car Product</h2>
    <div style="text-align:center" class="row">
    <asp:Repeater ID="rpCarList" runat="server">
        <ItemTemplate>
                <div class="col-md-4">
                    <div>
                        <div>
                            <img width="250px" src='<%#Eval("CarImgUrl") != null ? Eval("CarImgUrl").ToString().Replace("~", "") : string.Empty %>' />
                            </div>
                        <div>
                            <h4 style="font-weight:700" id="Name"><%# Eval("CarName") %></h4>
                            <%--<h5 id="Status"><%# Eval("CarStatus") %></h5>
                            <h5 id="Desc"><%# Eval("CarDescription") %></h5>--%>
                            <asp:Button ID="btnView" runat="server" Text="View" OnClick="btnView_Click" />
                            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click"/>
                            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
                            </div>
                        </div>

            </div>
        </ItemTemplate>
    </asp:Repeater>
        </div>
</asp:Content>
