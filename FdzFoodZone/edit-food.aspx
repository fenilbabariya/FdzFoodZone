<%@ Page Title="" Language="C#" MasterPageFile="~/Index.Master" AutoEventWireup="true" CodeBehind="edit-food.aspx.cs" Inherits="FdzFoodZone.edit_food" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
    <div class="container-fluid">    
        <%-- 1st row start --%>
        <div class="row">
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image1" runat="server" CssClass="card-img-top" AlternateText="Item 2" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload1" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName1" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice1" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription1" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate1" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate1_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image2" runat="server" CssClass="card-img-top" AlternateText="Item 2" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload2" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName2" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice2" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription2" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate2" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate2_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image3" runat="server" CssClass="card-img-top" AlternateText="Item 3" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload3" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName3" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice3" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription3" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate3" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate3_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image4" runat="server" CssClass="card-img-top" AlternateText="Item 4" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload4" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName4" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice4" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription4" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate4" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate4_Click" />
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
                    <asp:FileUpload ID="photoUpload5" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName5" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice5" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription5" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate5" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate5_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image6" runat="server" CssClass="card-img-top" AlternateText="Item 6" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload6" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName6" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice6" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription6" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate6" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate6_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image7" runat="server" CssClass="card-img-top" AlternateText="Item 7" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload7" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName7" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice7" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription7" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate7" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate7_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image8" runat="server" CssClass="card-img-top" AlternateText="Item 8" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload8" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName8" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice8" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription8" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate8" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate8_Click" />
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
                    <asp:FileUpload ID="photoUpload9" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName9" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice9" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription9" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate9" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate9_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image10" runat="server" CssClass="card-img-top" AlternateText="Item 10" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload10" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName10" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice10" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription10" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate10" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate10_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image11" runat="server" CssClass="card-img-top" AlternateText="Item 11" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload11" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName11" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice11" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription11" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate11" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate11_Click" />
                 </div>
                 </div>
            </div>
            
            <div class="col-md-3">
                 <div class="card" style="width: 18rem;">
                    <asp:Image ID="Image12" runat="server" CssClass="card-img-top" AlternateText="Item 12" height="150" ImageAlign="Middle"/>
                    <asp:FileUpload ID="photoUpload12" runat="server" />
                 <div class="card-body d-grid gap-1">
                     <asp:TextBox ID="txtName12" CssClass="form-control" placeholder="Food Name" Font-Bold="True" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtPrice12" CssClass="form-control" placeholder="Food Price" runat="server"></asp:TextBox>
                     <asp:TextBox ID="txtDescription12" CssClass="form-control" placeholder="Food Description" runat="server" TextMode="MultiLine"></asp:TextBox><hr />
                     <asp:Button ID="btnUpdate12" CssClass="btn btn-primary" runat="server" Text="UPDATE" OnClick="btnUpdate12_Click" />
                 </div>
                 </div>
            </div>
        </div>
    </div>
        <br />
    </section>
</asp:Content>
