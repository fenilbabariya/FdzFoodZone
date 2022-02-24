<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="change-password.aspx.cs" Inherits="FdzFoodZone.change_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
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
                                    <h3>Change Password</h3>
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
                                        <label for="exampleInputPassword1" class="form-label">New Password</label>
                                        <asp:TextBox CssClass="form-control" ID="txtPasswordAdmin" placeholder="New Password" TextMode="Password" runat="server"></asp:TextBox>
                                    </div>

                                    <div class="mb-3 d-grid gap-2">
                                        <asp:Button class="btn btn-primary btn-block" ID="btnChangePassword" runat="server" Text="SUBMIT" OnClick="btnChangePassword_Click"></asp:Button>
                                        <asp:Label ID="lblInvalidCredentials" runat="server" ForeColor="Red"></asp:Label>
                                    </div>
                                
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <br />
</asp:Content>
