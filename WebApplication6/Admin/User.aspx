<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="None" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="WebApplication6.Admin.User" %>
<%@ Import Namespace="WebApplication6" %>
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
                                    <div class="row">
                                        <div class="col-sm-6 col-md-4 col-lg-4">
                                            <h4 class="sub-title">User</h4>
                                            <div>
                                                <div class="form-group">
                                                    <label>User Name</label>
                                                    <div>
                                                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"
                                                            placeholder="Enter User Name" />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                                                            runat="server" ErrorMessage="Text is required" ForeColor="Red" Display="Dynamic"
                                                            SetFocusOnError="true" ControlToValidate="txtName"></asp:RequiredFieldValidator>
                                                        <asp:HiddenField ID="hdnId" runat="server" Value="0" />
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label>User Name</label>
                                                    <div>
                                                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"
                                                            placeholder="Enter User Email" />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                                                            runat="server" ErrorMessage="Email is required" ForeColor="Red" Display="Dynamic"
                                                            SetFocusOnError="true" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label>User Name</label>
                                                    <div>
                                                        <asp:TextBox ID="txtPass" runat="server" CssClass="form-control"
                                                            placeholder="Enter User PassWord" />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6"
                                                            runat="server" ErrorMessage="Password is required" ForeColor="Red" Display="Dynamic"
                                                            SetFocusOnError="true" ControlToValidate="txtPass"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label>Contact no</label>
                                                    <div>
                                                        <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control"
                                                            placeholder="Enter User Price" />
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                                            runat="server" ErrorMessage="Mobile is required" ForeColor="Red" Display="Dynamic"
                                                            SetFocusOnError="true" ControlToValidate="txtMobile"></asp:RequiredFieldValidator>

                                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
                                                            ErrorMessage="Mobile must be in decimal" ForeColor="Red" Display="Dynamic"
                                                            SetFocusOnError="true" ControlToValidate="txtMobile"
                                                            ValidationExpression="^\d{0,8}(\.\d{1,4})?$"></asp:RegularExpressionValidator>
                                                    </div>
                                                </div>
                                                <div class="form-group">
                                                    <label>User Address</label>
                                                    <div>
                                                        <asp:TextBox ID="txtAddress" runat="server" CssClass="form-control"
                                                            placeholder="Enter User Address"  Multiline="true"/>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                                                            runat="server" ErrorMessage="Address is required" ForeColor="Red" Display="Dynamic"
                                                            SetFocusOnError="true" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
                                                        
                                                    </div>
                                                </div>
                                                
                                                <div class="form-check pl-5">
                                                    <asp:Button ID="btnAddOrUpdate" runat="server" Text="Add" CssClass="btn btn-primary" CausesValidation="false" OnClick="btnAddOrUpdate_Click" />
                                                    &nbsp;
                                                    <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn btn-primary" CausesValidation="false" OnClick="btnClear_Click" />

                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-6 col-md-8 col-lg-8 mobile-inputs">
                                            <h4 class="sub-title">User Lists</h4>
                                            <div class="card-block table-border-style">
                                                <div class="table-responsive">
                                                    <asp:Repeater ID="rUser" runat="server" OnItemCommand="rUser_ItemCommand" >
                                                        <HeaderTemplate>
                                                            <table class="table data-table-export table-hover nowrap">
                                                                <thead>
                                                                    <tr>
                                                                        <th class="table-plus">Name</th>
                                                                        <th>Email</th>
                                                                        <th>Address</th>
                                                                        <th>Mobile</th>
                                                                        <th>CreatedDate</th>
                                                                        <th class="datatable-nosort">Action</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                        </HeaderTemplate>
                                                        <ItemTemplate>
                                                            <tr>
                                                                <td class="table-plus"><%# Eval("Name") %></td>
                                                                <td><%# Eval("Email") %></td>
                                                                <td><%# Eval("Address") %></td>
                                                                <td><%# Eval("Mobile") %></td>
                                                                <td><%# Eval("CreatedDate") %></td>
                                                                <td>
                                                                    <asp:LinkButton ID="lnkEdit" Text="Edit" runat="server" CssClass="badge badge-primary"
                                                                        CommandArgument='<%# Eval("UserId")%>' CommandName="edit" CausesValidation="false">
                                                                        <i class="ti-pencil"></i>
                                                                    </asp:LinkButton>
                                                                    <asp:LinkButton ID="lnkDelete" Text="Delete" runat="server" CssClass="badge bg-danger"
                                                                        CommandArgument='<%# Eval("UserId")%>' CommandName="delete" 
                                                                        CausesValidation="false" OnClientClick="return confirm('Do You want to delete this User?')">
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
        </div>
    </div>
</asp:Content>
