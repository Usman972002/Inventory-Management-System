<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin_DashBoard.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="InVentory_Management_System_MarsTrackTech.Views.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="row" style="height:20px;background-color:aquamarine;">

    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Add Category </h3>
            <div class="row">
            <div class="col-md-4 mb-2">
                <label>Category Name</label>
                <input type="text" placeholder="Enter Category Name" runat="server" class="form-control mt-1" />
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
        
    





</asp:Content>
