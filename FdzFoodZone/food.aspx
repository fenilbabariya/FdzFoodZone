<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="food.aspx.cs" Inherits="FdzFoodZone.Food" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
    <div class="container-fluid">    

        <%-- 1st row start --%>
        <div class="row">
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image1" runat="server" CssClass="card-img-top" AlternateText="Item 1" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label1" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label2" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label3" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button1_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image2" runat="server" CssClass="card-img-top" AlternateText="Item 2" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label4" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label5" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label6" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button2_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image3" runat="server" CssClass="card-img-top" AlternateText="Item 3" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label7" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label8" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label9" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button3" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button3_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image4" runat="server" CssClass="card-img-top" AlternateText="Item 4" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label10" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label11" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label12" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button4" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button4_Click" />
                 </div>
                 </div>
            </div>
        </div>

        <br />
        <%-- 2nd row start --%>
        <div class="row">
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image5" runat="server" CssClass="card-img-top" AlternateText="Item 5" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label13" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label14" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label15" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button5" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button5_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image6" runat="server" CssClass="card-img-top" AlternateText="Item 6" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label16" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label17" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label18" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button6" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button6_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image7" runat="server" CssClass="card-img-top" AlternateText="Item 7" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label19" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label20" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label21" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button7" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button7_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image8" runat="server" CssClass="card-img-top" AlternateText="Item 8" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label22" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label23" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label24" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button8" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button8_Click" />
                 </div>
                 </div>
            </div>
        </div>

        <br />
        <%-- 3rd row start --%>
        <div class="row">
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image9" runat="server" CssClass="card-img-top" AlternateText="Item 9" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label25" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label26" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label27" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button9" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button9_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image10" runat="server" CssClass="card-img-top" AlternateText="Item 10" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label28" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label29" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label30" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button10" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button10_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image11" runat="server" CssClass="card-img-top" AlternateText="Item 11" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label31" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label32" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label33" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button11" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button11_Click" />
                 </div>
                 </div>
            </div>

            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image12" runat="server" CssClass="card-img-top" AlternateText="Item 12" height="150" ImageAlign="Middle"/>
                 <div class="card-body d-grid gap-0">
                     <asp:Label ID="Label34" CssClass="card-title" runat="server" Text="Food Name" Font-Bold="True" Font-Size="Large"></asp:Label>
                     <asp:Label ID="Label35" CssClass="card-title" runat="server" Text="Food Price"></asp:Label>
                     <asp:Label ID="Label36" CssClass="card-text" runat="server" Text="Food Description"></asp:Label><hr />
                     <asp:Button ID="Button12" CssClass="btn btn-primary" runat="server" Text="ADD TO CART" OnClick="Button12_Click" />
                 </div>
                 </div>
            </div>
        </div>
    <br />
    </div>
    </section>
</asp:Content>
