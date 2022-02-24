<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="customer-signup.aspx.cs" Inherits="FdzFoodZone.customer_signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />    
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/customer.png" />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Customer Sign-Up</h4>
                                   
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                 <hr>
                            </div>
                        </div>
                       
                       
                        <div class="row">
                            <div class="col-md-6">
                                  <label for="Full Name" class="form-label">Full Name</label>
                                       <div class ="form-group"> <asp:TextBox CssClass="form-control" ID="txtFullName" placeholder="Full Name" runat="server"></asp:TextBox>
                                        </div>
                                    </div>
                             <div class="col-md-6">
                                    <label for="Date of Birth" class="form-label">Date of Birth</label>
                                     <div class ="form-group">   <asp:TextBox CssClass="form-control" ID="txtDOB" placeholder="Date of Birth" TextMode="Date" runat="server"></asp:TextBox>
                                    </div>
                            </div>
                     
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-6">
                                  <label for="Contact Number" class="form-label">Contact Number</label>
                                       <div class ="form-group"> <asp:TextBox CssClass="form-control" ID="txtContactNo" placeholder="Contact Number" runat="server">
                                        </asp:TextBox>
                                        </div>
                                    </div>
                             <div class="col-md-6">
                                    <label for="Email-Id" class="form-label">Email -Id</label>
                                     <div class ="form-group">   <asp:TextBox CssClass="form-control" ID="txtEmail" placeholder="Email-Id" TextMode="Email" runat="server"></asp:TextBox>
                                    </div>
                            </div>
                     
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-4">
                                  <label for="State" class="form-label">State</label>
                                       <div class ="form-group">
                                           <asp:DropDownList ID="dropdownState" class="form-control" runat="server">
                                             
                                               <asp:ListItem Text ="Andhra Pradesh" Value="Andhra Pradesh" />
                                               <asp:ListItem Text ="Arunachal Pradesh" Value="Arunachal Pradesh" />
                                                <asp:ListItem Text ="Assam" Value="Assam" />
                                                <asp:ListItem Text ="Bihar" value="Bihar" />
                                                <asp:ListItem Text ="Chhattisgarh" Value="Chhattisgarh" />
                                                <asp:ListItem Text ="Goa" Value="Goa" />
                                                <asp:ListItem Text ="Gujarat" Value="Gujarat" />
                                                <asp:ListItem Text ="Haryana" Value="Haryana" />
                                                <asp:ListItem Text ="Himachal Pradesh" Value="Himachal Pradesh" />
                                                <asp:ListItem Text ="Jharkhand" Value="Jharkhand" />
                                                <asp:ListItem Text ="Karnataka" Value="Karnataka" />
                                                <asp:ListItem Text ="Kerala" Value="Kerala" />
                                                <asp:ListItem Text ="Madhya Pradesh" Value="Madhya Pradesh" />
                                                <asp:ListItem Text ="Maharashtra" Value="Maharashtra" />
                                                <asp:ListItem Text ="Manipur" Value="Manipur" />
                                                <asp:ListItem Text ="Meghalaya" Value="Meghalaya" />
                                                <asp:ListItem Text ="Mizoram" Value="Mizoram" />
                                                <asp:ListItem Text ="Nagaland" Value="Nagaland" />
                                                <asp:ListItem Text ="Punjab" Value="Punjab" />
                                                <asp:ListItem Text ="Rajasthan" Value="Rajasthan" />
                                                <asp:ListItem Text ="Sikkim" Value="Sikkim" />
                                                <asp:ListItem Text ="Tripura" Value="Tripura" />
                                                <asp:ListItem Text ="Uttar Pradesh" Value="Uttar Pradesh" />
                                                <asp:ListItem Text ="Uttarakhand" Value="Uttarakhand" />
                                                <asp:ListItem Text ="West Bengal" Value="West Bengal" />
                                               </asp:DropDownList>
                                        </div>
                                  </div>
                             <div class="col-md-4">
                                    <label for="City" class="form-label">City</label>
                                     <div class ="form-group">   <asp:TextBox CssClass="form-control" ID="txtCity" placeholder="City"  runat="server"></asp:TextBox>
                                    </div>
                                 </div>  
                            <div class="col-md-4">
                                    <label for="Pincode" class="form-label">Pincode</label>
                                     <div class ="form-group">   <asp:TextBox CssClass="form-control" ID="txtPinCode" placeholder="Pincode" runat="server"></asp:TextBox>
                                    </div>
                            </div>
                     
                        </div>
                        <br />
                         
                        <div class="row">
                            <div class="col">
                                  <label for="Address" class="form-label">Address</label>
                                       <div class ="form-group"> <asp:TextBox CssClass="form-control" ID="txtAdress" placeholder="Address" TextMode="MultiLine" runat="server">
                                        </asp:TextBox>
                                        </div>
                                    </div>
                           
                     
                        </div>
                        <br />
                         
                        <div class="row">
                            <div class="col-md-6">
                                  <label for="User ID" class="form-label">User ID</label>
                                       <div class ="form-group"> <asp:TextBox CssClass="form-control" ID="txtUsernameCustomer" placeholder="User-ID"  runat="server">
                                        </asp:TextBox>
                                        </div>
                                    </div>
                             <div class="col-md-6">
                                    <label for="Password" class="form-label">Password</label>
                                     <div class ="form-group">   <asp:TextBox CssClass="form-control" ID="txtPasswordCustomer" placeholder="Password" TextMode="Password" runat="server"></asp:TextBox>
                                    </div>
                            </div>
                     
                        </div>
                        <br />
                                    <div class="mb-3">
                                    <div class="mb-3">
                                    <div class="mb-3 d-grid gap-2">
                                        <asp:Button class="btn btn-primary btn-block" ID="btnSignupCustomer" runat="server" Text="SIGN UP" OnClick="btnSignupCustomer_Click"></asp:Button>
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
