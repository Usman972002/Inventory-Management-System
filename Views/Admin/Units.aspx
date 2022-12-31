<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin_DashBoard.Master" AutoEventWireup="true" CodeBehind="Units.aspx.cs" Inherits="InVentory_Management_System_MarsTrackTech.Views.Admin.Units" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="height:20px;background-color:aquamarine;">

    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Add Units </h3>
            <div class="row">

            <div class="col-md-4 mb-2">
                <label>Unit Name</label>
                <input type="text" placeholder="Enter name of the Unit" id="unit" runat="server" class="form-control mt-1" />
            </div>

            <div class="row mb-4">
                
                <div class="col-sm-1">
                    <asp:Button Text="Add" ID="AddBtn" class="btn  btn-dark btn-block" runat="server" OnClick="AddBtn_Click" />
                </div>
                <div class="col-sm-1">
                    <asp:Button Text="Delete" ID="DelBtn" class="btn  btn-dark btn-block" runat="server" OnClick="DelBtn_Click" />
                </div>

                <label class="text-danger text-center" id="ErrMsg" runat="server"></label>
            </div>
        </div>
        </div>
    </div>
    <div class="row mt-2" style="height:20px;background-color:aquamarine;"></div>
        <div class="col">
            <h3>Unit's List</h3>            
            <asp:GridView runat="server" ID="Ulist" class="table" >
            </asp:GridView>
        </div>
</asp:Content>
