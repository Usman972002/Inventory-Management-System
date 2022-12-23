<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin_DashBoard.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="InVentory_Management_System_MarsTrackTech.Views.Admin.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="height:20px;background-color:aquamarine;">

    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Add Product </h3>
            <div class="row">
            <div class="col-md-4 mb-2">
                <label>Product Name</label>
                <input type="text" placeholder="Enter Supplier Name" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Product Supplier </label>
                <asp:DropDownList runat="server" class="form-control mt-1">
                    
                </asp:DropDownList>
                
            </div>

            <div class="col-md-4 mb-2">
                <label>Product Quantity</label>
                <input type="number" placeholder="Quantity Of the Product" runat="server" class="form-control mt-1" />
            </div>


            <div class="col-md-4 mb-2">
                <label>Product Units</label>
                <asp:DropDownList runat="server" class="form-control mt-1">
                    
                </asp:DropDownList>
            </div>

                      
            </div>

            <div class="row">
                <div class="col-sm-1">
                    <asp:Button Text="Edit"  class="btn btn-block btn-dark " runat="server"/>
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Save"  class="btn btn-block btn-dark" runat="server"/>
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Delete"  class="btn btn-block btn-dark" runat="server"/>
                </div>
                
            </div>

        </div>
        </div>
        <div class="row mt-2" style="height:20px;background-color:aquamarine;"></div>
        <div class="col">
            <h3>Product's List</h3>
            <asp:GridView runat="server"  class="table" >

            </asp:GridView>
        </div>
    



</asp:Content>
