<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin_DashBoard.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="InVentory_Management_System_MarsTrackTech.Views.Admin.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="height:20px;background-color:aquamarine;">

    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Add Customer </h3>
            <div class="row">
            <div class="col-md-4 mb-2">
                <label>Customer Name</label>
                <input type="text" placeholder="Enter Customer Name" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Customer Email-Id</label>
                <input type="email" placeholder="Enter Customer E-mail Id" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>CustomerPassword</label>
                <input type="password" placeholder="Give Password for a Customer" runat="server" class="form-control mt-1" />
            </div>


            <div class="col-md-4 mb-2">
                <label>Customer Mobile Number</label>
                <input type="number" placeholder="Enter Customer Mobile Number" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Customer Adress</label>
                <input type="text" placeholder="Enter Customer's Adress" runat="server" class="form-control mt-1" />
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
            <h3>Customer List</h3>
            <asp:GridView runat="server"  class="table" >

            </asp:GridView>
        </div>
    



</asp:Content>
