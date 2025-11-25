<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FormVehiculo.aspx.vb" Inherits="ControlVehiculos.FormVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <div class="container d-flex flex-column mb-3 gap-2">

         <asp:DropDownList ID="ddlPersona" CssClass="form-control" runat="server">
            <asp:ListItem Text="-- Seleccione Persona --" Value="0"></asp:ListItem>
        </asp:DropDownList>

        <asp:TextBox ID="txtPlaca" CssClass="form-control" placeholder="Ingrese la Placa" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtMarca" CssClass="form-control" placeholder="Ingrese la Marca" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtModelo" CssClass="form-control" placeholder="Ingrese el Modelo" runat="server"></asp:TextBox>

        <asp:Button ID="btnGuardarVehiculo" CssClass="btn btn-primary" runat="server" Text="Guardar Vehículo" OnClick="btnGuardarVehiculo_Click" />

        <asp:Label ID="lblMensajeVehiculo" runat="server" CssClass="mt-2"></asp:Label>

    </div>



</asp:Content>
