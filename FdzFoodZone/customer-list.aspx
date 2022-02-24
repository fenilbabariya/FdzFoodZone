<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="customer-list.aspx.cs" Inherits="FdzFoodZone.customer_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function () {
            $("table[id$='GridViewCustomer']").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="col-md-10 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100" src="images/logo.png"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Details of Customers</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FDzDatabaseConnectionString %>" SelectCommand="SELECT [username], [fullname], [dob], [contactno], [email], [state], [city], [pincode], [address] FROM [customer]"></asp:SqlDataSource>
                     <div class="col">
                         <asp:GridView class="table table-striped table-bordered" ID="GridViewCustomer" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" DataKeyNames="username" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                             <Columns>
                                 <asp:BoundField DataField="username" HeaderText="Username" ReadOnly="True" SortExpression="username" />
                                 <asp:BoundField DataField="fullname" HeaderText="Full Name" SortExpression="fullname" />
                                 <asp:BoundField DataField="dob" HeaderText="Date of Birth" SortExpression="dob" />
                                 <asp:BoundField DataField="contactno" HeaderText="Contact" SortExpression="contactno" />
                                 <asp:BoundField DataField="email" HeaderText="E-Mail" SortExpression="email" />
                                 <asp:BoundField DataField="state" HeaderText="State" SortExpression="state" />
                                 <asp:BoundField DataField="city" HeaderText="City" SortExpression="city" />
                                 <asp:BoundField DataField="pincode" HeaderText="Pincode" SortExpression="pincode" />
                                 <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                             </Columns>
                             <FooterStyle BackColor="White" ForeColor="#000066" />
                             <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                             <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                             <RowStyle ForeColor="#000066" />
                             <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                             <SortedAscendingCellStyle BackColor="#F1F1F1" />
                             <SortedAscendingHeaderStyle BackColor="#007DBB" />
                             <SortedDescendingCellStyle BackColor="#CAC9C9" />
                             <SortedDescendingHeaderStyle BackColor="#00547E" />
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
    <br />
</asp:Content>