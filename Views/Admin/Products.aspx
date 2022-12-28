<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin_DashBoard.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="InVentory_Management_System_MarsTrackTech.Views.Admin.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row" style="height: 20px; background-color: aquamarine;">
    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Add Product </h3>
            <div class="row">

                <div class="col-md-4 mb-2">
                    <label>Product Code</label>
                    <input type="text" placeholder="Enter Product Code" id="Pcode" runat="server" class="form-control mt-1" />
                </div>

                <div class="col-md-4 mb-2">
                    <label>Product Name</label>
                    <input type="text" placeholder="Enter Product Name" id="Pname" runat="server" class="form-control mt-1" />
                </div>

                <div class="col-md-4 mb-2">
                    <label>Product Supplier </label>
                    <asp:DropDownList runat="server" ID="Psupplier" class="form-control mt-1">
                    </asp:DropDownList>

                </div>

                <div class="col-md-4 mb-2">
                    <label>Product Category</label>
                    <asp:DropDownList runat="server" name="Pcat" ID="Pcategory" class="form-control mt-1">
                    </asp:DropDownList>
                </div>

                <div class="col-md-4 mb-2">
                    <label>Product Units</label>
                    <asp:DropDownList runat="server" ID="Punits" class="form-control mt-1">
                    </asp:DropDownList>
                </div>

                <div class="col-md-4 mb-2">
                    <label>Product Price</label>
                    <input type="number" placeholder="Enter product prize" id="Pprize" runat="server" class="form-control mt-1" />
                </div>

                <div class="col-md-4 mb-2">
                    <label>Add Date and Time </label>
                    <input type="datetime-local" id="Pdate" runat="server" class="form-control mt-1" />
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
                <div class="col-sm-2">
                    <input type="text" placeholder="Enter Id To search " id="Psearch" runat="server" class="form-control mt-1" />
                </div>
                <div class="col-sm-2">
                    <input type="text" placeholder="Enter Name To search " id="Pdb1" runat="server" class="form-control mt-1" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Search" ID="SearchBtn" class ="btn btn-dark btn-block" runat="server" OnClick="SearchBtn_Click"/>
                </div>
                <div class="col-sm-2">
                    <input type="text" placeholder="Enter Id To search " id="Pdb" runat="server" class="form-control mt-1" />
                </div>
                
                <div class="col-sm-1 mb-2">
                    <asp:Button Text="GetDetails" ID="GetBtn" class ="btn btn-dark btn-block" runat="server" OnClick="GetBtn_Click"/>
                </div>
                <label class="text-danger text-center" id="ErrMsg" runat="server"></label>
                
            </div>



        </div>
    </div>

    <div class="row mt-2" style="height: 20px; background-color: aquamarine;"></div>
    <div class="col">
        <h3>Product's List</h3>
        <asp:GridView runat="server" ID="Plist" class="table">
        </asp:GridView>
    </div>




</asp:Content>
