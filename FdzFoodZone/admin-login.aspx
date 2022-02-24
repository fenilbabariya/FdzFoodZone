<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="admin-login.aspx.cs" Inherits="FdzFoodZone.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="images/admin.png" />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Admin Login</h3>
                                    <hr/>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                
                                    <div class="mb-3">
                                        <label for="exampleInputEmail1" class="form-label">Username</label>
                                        <asp:TextBox CssClass="form-control" ID="txtUsernameAdmin" placeholder="Username" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="mb-3">
                                        <label for="exampleInputPassword1" class="form-label">Password</label>
                                        <asp:TextBox CssClass="form-control" ID="txtPasswordAdmin" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="mb-3 d-grid gap-2">
                                        <asp:Button class="btn btn-primary" ID="btnLoginAdmin" runat="server" Text="LOGIN" OnClick="btnLoginAdmin_Click"></asp:Button>
                                        <asp:Label ID="lblInvalidCredentials" runat="server" ForeColor="Red"></asp:Label>
                                    </div>
                                
                            </div>
                        </div>
                    </div>
                </div>
                <br /><br />
            </div>
        </div>
    </div>
</asp:Content>
