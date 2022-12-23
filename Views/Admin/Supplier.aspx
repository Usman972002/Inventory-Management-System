<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin_DashBoard.Master" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="InVentory_Management_System_MarsTrackTech.Views.Admin.Supplier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="height:20px;background-color:aquamarine;">

    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Add Supplier </h3>
            <div class="row">

            <div class="col-md-4 mb-2">
                <label>Supplier Code</label>
                <input type="text" placeholder="Code starts With S" id="Scode" runat="server" class="form-control mt-1" />
            </div>
            
            <div class="col-md-4 mb-2">
                <label>Supplier Name</label>
                <input type="text" placeholder="Enter Supplier Name" id="Sname" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Supplier Email-Id</label>
                <input type="text" placeholder="Enter Supplier E-mail Id" id="Semail" runat="server" class="form-control mt-1" />
            </div>

            
            <div class="col-md-4 mb-2">
                <label>Supplier Mobile Number</label>
                <input type="text" placeholder="Enter Supplier Mobile Number" id="Smobile" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Supplier Adress</label>
                <input type="text" placeholder="Enter Supplier's Adress" id="Sadress" runat="server" class="form-control mt-1" />
            </div>
            
            <div class="col-md-4 mb-2">
                <label>Supplier City</label>
                <input type="text" placeholder="Enter Supplier's City" id="Scity" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Supplier Country</label>
                <input type="text" placeholder="Enter Supplier's Country" id="Scountry" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>ZipCode</label>
                <input type="text" placeholder="Enter ZipCode" id="Szipcode" runat="server" class="form-control mt-1" />
            </div>

             
            </div>

            <div class="row mb-4">
                <label class="text-danger text-center" id="ErrMsg" runat="server"></label>
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
                    <input type="text" placeholder="Enter Id To search " id="Ssearch" runat="server" class="form-control mt-1" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Search" ID="SearchBtn" class ="btn btn-dark btn-block" runat="server" OnClick="SearchBtn_Click"/>
                </div>
                <div class="col-sm-2">
                    <input type="text" placeholder="Enter Id To search " id="Sdb" runat="server" class="form-control mt-1" />
                </div>
                <div class="col-sm-1 mb-2">
                    <asp:Button Text="GetDetails" ID="GetBtn" class ="btn btn-dark btn-block" runat="server" OnClick="GetBtn_Click"/>
                </div>
                
            </div>

        </div>

         
        <div class="col">
            <h3>Suppliers List</h3>
            
            <asp:GridView runat="server" ID="Slist" class="table" >
            </asp:GridView>
        </div>
        </div>
        
    
</asp:Content>
