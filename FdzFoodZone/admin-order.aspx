<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="admin-order.aspx.cs" Inherits="FdzFoodZone.admin_order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
    <div class="container-fluid">
      <div class="row">
         <div class="col-md-8 mx-auto">
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
                           <h4>All Orders</h4>
                        </center>
                     </div>
                  </div>
                  <hr />
                  <div class="row gap-2">
                     <div class="col d-grid mx-auto">
                         <asp:DropDownList ID="DropDownListCustomer" CssClass="btn dropdown-toggle" runat="server" ForeColor="#006699" OnSelectedIndexChanged="DropDownListCustomer_SelectedIndexChanged" AutoPostBack="True" ></asp:DropDownList>
                     </div>
                     <div class="col-md-auto">
                         <asp:Label ID="lblTotalBill" runat="server" ForeColor="#006699" Font-Bold="True" Font-Size="Large"></asp:Label>
                         </div>
                         <div class="col-md-auto">
                         <asp:Button ID="btnCompleteOrder" CssClass="btn btn-primary" runat="server" Text="Complete Order" OnClick="btnCompleteOrder_Click" />
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                         <br />
                         <asp:GridView class="table table-striped table-bordered" ID="GridViewOrder" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
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