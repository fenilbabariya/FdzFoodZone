<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="customer-login.aspx.cs" Inherits="FdzFoodZone.CustomerLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img src="images/customer.png" />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Customer Login</h3>
                                    <hr/>
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                
                                    <div class="mb-3">
                                        <label for="exampleInputEmail1" class="form-label">Username</label>
                                        <asp:TextBox CssClass="form-control" ID="txtUsernameCustomer" placeholder="Username" runat="server"></asp:TextBox>
                                        <div id="emailHelp" class="form-text">We'll never share your details with anyone else.</div>
                                    </div>

                                    <div class="mb-3">
                                        <label for="exampleInputPassword1" class="form-label">Password</label>
                                        <asp:TextBox CssClass="form-control" ID="txtPasswordCustomer" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="mb-3 d-grid gap-2">
                                        <asp:Button class="btn btn-primary btn-block" ID="btnLoginCustomer" runat="server" Text="LOGIN" OnClick="btnLoginCustomer_Click"></asp:Button>
                                        <asp:Label ID="lblInvalidCredentials" runat="server" ForeColor="Red"></asp:Label>
                                    </div>
                                
                                    <div class="mb-3 d-grid gap-2"">
                                        <asp:Button class="btn btn-info btn-block" ID="btnSignUpCustomer" runat="server" Text="Sign Up" OnClick="btnSignUpCustomer_Click"></asp:Button>
                                    </div>
                                
                            </div>
                        </div>
                    </div>
                </div>

                <a href="home.aspx"><< Back to Home</a><br /><br />
            </div>
        </div>
    </div>

</asp:Content>
