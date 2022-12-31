<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin_DashBoard.Master" AutoEventWireup="true" CodeBehind="PurchaseOrder.aspx.cs" Inherits="InVentory_Management_System_MarsTrackTech.Views.Admin.PurchaseOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="height: 20px; background-color: aquamarine;">
    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Add Purchases </h3>
            <div class="row">

                <div class="col-md-4 mb-2">
                    <label>Purchase ID</label>
                    <input type="text" placeholder="Enter Purchase Id" id="Oid" runat="server" class="form-control mt-1" />
                </div>



                <div class="col-md-4 mb-2">
                    <label>Product Id</label>
                    <asp:DropDownList runat="server" ID="OPid" class="form-control mt-1">
                    </asp:DropDownList>
                </div>

                <div class="col-md-4 mb-2">
                    <label>Product Name</label>
                    <input type="text" placeholder="Enter Product  Name" id="OPname" runat="server" class="form-control mt-1" />
                </div>

                <div class="col-md-4 mb-2">
                    <label>Order Date and Time </label>
                    <input type="datetime-local" id="Odate" runat="server" class="form-control mt-1" />
                </div>

                <div class="col-md-4 mb-2">
                    <label>Units</label>
                     <asp:DropDownList runat="server" ID="Ounits" class="form-control mt-1">
                    </asp:DropDownList>
                
                </div>

                <div class="col-md-4 mb-2">
                    <label>Quantity</label>
                    <input type="number" placeholder="Enter Quantity" id="Oqty" runat="server" class="form-control mt-1" />
                </div>

                <div class="col-md-4 mb-2">
                    <label>Cost price</label>
                    <input type="number" placeholder="Enter cost per Item" id="Oprice" runat="server" class="form-control mt-1" />
                </div>

            </div>

            <div class="row mb-4">

                <div class="col-sm-1">
                    <asp:Button Text="Edit" ID="EditBtn" class="btn  btn-dark btn-block" runat="server" OnClick="EditBtn_Click" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Save" ID="SaveBtn" class="btn  btn-dark btn-block" runat="server" OnClick="SaveBtn_Click" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Delete" ID="DeleteBtn" class="btn btn-dark btn-block" runat="server" OnClick="DeleteBtn_Click" />
                </div>
                <div class="col-sm-1">
                    <input type="text" placeholder="Enter Id To search " id="Osearch" runat="server" class="form-control mt-1" />
                </div>
                <div class="col-sm-2">
                    <input type="text" placeholder="Enter Name To search " id="Odb1" runat="server" class="form-control mt-1" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Search" ID="SearchBtn" class="btn btn-dark btn-block" runat="server" OnClick="SearchBtn_Click" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Print" ID="PrintBtn" class="btn btn-dark btn-block" runat="server" OnClick="PrintBtn_Click" />
                </div>
                <div class="col-sm-1">
                    <input type="text" placeholder="Enter Id To search " id="Odb" runat="server" class="form-control mt-1" />
                </div>

                <div class="col-sm-1 mb-2">
                    <asp:Button Text="GetDetails" ID="GetBtn" class="btn btn-dark btn-block" runat="server" OnClick="GetBtn_Click" />
                </div>
                <label class="text-danger text-center" id="ErrMsg" runat="server"></label>

            </div>

        </div>
    </div>
    <div class="row mt-2" style="height: 20px; background-color: aquamarine;"></div>
    <div class="col">
        <h3>Purchase Order List</h3>
        <asp:GridView runat="server" ID="Olist" class="table">
        </asp:GridView>
    </div>



</asp:Content>
