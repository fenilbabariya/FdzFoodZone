<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="customer-cart.aspx.cs" Inherits="FdzFoodZone.customer_profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-7 mx-auto">
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
                           <h4>Your Orders</h4>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                         <asp:Label ID="lblTotalBillis" runat="server" ForeColor="#006699" Text="Total Bill: " Font-Bold="true"></asp:Label>
                         <asp:Label ID="lblTotalBill" runat="server" ForeColor="#006699"></asp:Label>
                     </div>
                     <div class="col-md-auto">
                         <asp:Button class="btn btn-primary btn-block" ID="btnClearCart" runat="server" Text="Clear Cart" OnClick="btnClearCart_Click"></asp:Button>
                         <asp:Button class="btn btn-primary btn-block" ID="btnPlaceOrder" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click"></asp:Button>
                     </div>
                  </div>
                   <hr />
                  <div class="row">
                     <div class="col">
                        <asp:GridView class="table table-striped table-bordered" ID="GridViewCart" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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
    </div>
      </div>
    <br />
</asp:Content>
