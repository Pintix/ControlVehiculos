<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FormPropietario.aspx.vb" Inherits="ControlVehiculos.FormPropietario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container d-flex flex-column mb-3 gap-2">

        <asp:DropDownList ID="ddlPersona" CssClass="form-control" runat="server">
            <asp:ListItem Text="-- Seleccione Persona --" Value="0"></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtVehiculo" CssClass="form-control" placeholder="Ingrese la Cantidad de Vehiculos" runat="server"></asp:TextBox>


        <asp:Button ID="btnGuardar" CssClass="btn btn-primary" runat="server" Text="Guardar Propietario" OnClick="btnGuardar_Click" />

        <asp:Label ID="lblMensaje" runat="server" CssClass="mt-2"></asp:Label>

    </div>


</asp:Content>
