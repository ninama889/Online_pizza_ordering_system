<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="WebApplication6.Admin.Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        /*for alert msg*/
        window.onload = function () {
            var seconds = 10;
            setTimeout(function () {
                document.getElementById("<%=lblMsg.ClientID%>").style.display = "none";
            }, seconds = 1000);
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pcoded-inner-content pt-0">
        <div class="align-align-self-end">
            <asp:Label ID="lblMsg" runat="server" Visible="false" />
        </div>
        <div class="main-body">
            <div class="page-wrapper">
                <div class="page-body">
                    <div class="row">
                        <div class="col-sm-12">
                            <div class="card">
                                <div class="card-header">
                                </div>
                                <div class="card-block">
                                    <h4 class="sub-title">Order Lists</h4>
                                    <div class="card-block table-border-style">
                                        <div class="table-responsive">
                                            <asp:Repeater ID="rOrder" runat="server" OnItemCommand="rOrder_ItemCommand">
                                                <HeaderTemplate>
                                                    <table class="table data-table-export table-hover nowrap">
                                                        <thead>
                                                            <tr>
                                                                <th class="table-plus">Name</th>
                                                                <th>Order</th>
                                                                <th>Email</th>
                                                                <th>Address</th>
                                                                <th>Mobile</th>
                                                                <th>OrderDate</th>
                                                                <th class="datatable-nosort">Action</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td class="table-plus"><%# Eval("Name") %></td>
                                                        <td><%# Eval("OrderName") %></td>
                                                        <td><%# Eval("Email") %></td>
                                                        <td><%# Eval("Address") %></td>
                                                        <td><%# Eval("Mobile") %></td>
                                                        <td><%# Eval("OrderDate") %></td>
                                                        <td>
                                                            <asp:LinkButton ID="lnkDelete" Text="Delete" runat="server" CssClass="badge bg-danger"
                                                                CommandArgument='<%# Eval("UserOrderId")%>' CommandName="delete"
                                                                CausesValidation="false" OnClientClick="return confirm('Do You want to delete this Order?')">
                                                                        <i class="ti-trash"></i>
                                                            </asp:LinkButton>

                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                                <FooterTemplate>
                                                    </tbody>
                                                            </table>
                                                </FooterTemplate>
                                            </asp:Repeater>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
