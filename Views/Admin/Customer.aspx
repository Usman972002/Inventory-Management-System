<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin_DashBoard.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="InVentory_Management_System_MarsTrackTech.Views.Admin.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="row" style="height:20px;background-color:aquamarine;">

    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Add Customer</h3>
            <div class="row">

            <div class="col-md-4 mb-2">
                <label>Customer Code</label>
                <input type="text" placeholder="Code starts With S" id="Ccode" runat="server" class="form-control mt-1" />
            </div>
            
            <div class="col-md-4 mb-2">
                <label>Customer Name</label>
                <input type="text" placeholder="Enter Customer Name" id="Cname" runat="server" class="form-control mt-1" />
            </div>

                        
            <div class="col-md-4 mb-2">
                <label>Customer Mobile Number</label>
                <input type="text" placeholder="Enter Customer Mobile Number" id="Cmobile" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Customer Adress</label>
                <input type="text" placeholder="Enter Customer's Adress" id="Cadress" runat="server" class="form-control mt-1" />
            </div>
            
            <div class="col-md-4 mb-2">
                <label>Customer City</label>
                <input type="text" placeholder="Enter Customer's City" id="Ccity" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>Customer Country</label>
                <input type="text" placeholder="Enter Customer's Country" id="Ccountry" runat="server" class="form-control mt-1" />
            </div>

            <div class="col-md-4 mb-2">
                <label>ZipCode</label>
                <input type="text" placeholder="Enter ZipCode" id="Czipcode" runat="server" class="form-control mt-1" />
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
            <h3>Customer List</h3>            
            <asp:GridView runat="server" ID="Clist" class="table" >
            </asp:GridView>
        </div>
    
        
           



</asp:Content>
