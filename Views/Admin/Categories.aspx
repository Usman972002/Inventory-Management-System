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
                <label>Category ID</label>
                <input type="text" placeholder="Enter Category Id" id="Cid" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Category Name</label>
                <input type="text" placeholder="Enter Category Name" id="Cname" runat="server" class="form-control mt-1" />
            </div>
             
            <div class="col-md-4">
                <label>Add Date and Time </label>
                <input type="datetime-local" id="Cdate" runat ="server" class="form-control mt-1" />
            </div>
                    
            </div>

            <div class="row">
                <div class="col-sm-1">
                    <asp:Button Text="Edit" ID="EditBtn" class="btn btn-block btn-dark " runat="server" OnClick="EditBtn_Click" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Save" ID="SaveBtn" class="btn btn-block btn-dark" runat="server" OnClick="SaveBtn_Click" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Delete" id="DeleteBtn" class="btn btn-block btn-dark" runat="server" OnClick="DeleteBtn_Click"/>
                </div>
                <div class="col-sm-2">
                    <input type="text" placeholder="Enter Id To search " id="Csearch" runat="server" class="form-control mt-1" />
                </div>
                <div class="col-sm-2">
                    <input type="text" placeholder="Enter Name To search " id="Cdb1" runat="server" class="form-control mt-1" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Search" ID="SearchBtn" class ="btn btn-dark btn-block" runat="server" OnClick="SearchBtn_Click"/>
                </div>
                <div class="col-sm-2">
                    <input type="text" placeholder="Enter Id To search " id="Cdb" runat="server" class="form-control mt-1" />
                </div>
                
                <div class="col-sm-1 mb-2">
                    <asp:Button Text="GetDetails" ID="GetBtn" class ="btn btn-dark btn-block" runat="server" OnClick="GetBtn_Click"/>
                </div>
                <label class="text-danger text-center" id="ErrMsg" runat="server"></label>
            </div>

        </div>
        </div>
    <div class="row mt-2" style="height:20px;background-color:aquamarine;"></div>
        <div class="col">
            <h3>Categories List</h3>
            <asp:GridView runat="server"  class="table" ID="Clist" >

            </asp:GridView>
        </div>
        
    





</asp:Content>
