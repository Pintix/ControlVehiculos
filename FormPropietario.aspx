<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="FormPropietario.aspx.vb" Inherits="ControlVehiculos.FormPropietario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container d-flex flex-column mb-3 gap-2">
        <asp:DropDownList ID="ddlPersona" CssClass="form-control" runat="server">
            <asp:ListItem Text="Seleccione Persona" Value=""></asp:ListItem>
        </asp:DropDownList>

        <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtApellido1" CssClass="form-control" placeholder="Apellido1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtApellido2" CssClass="form-control" placeholder="Apellido2" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtNacionalidad" CssClass="form-control" placeholder="Nacionalidad" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtfechaNacimiento" CssClass="form-control" placeholder="FechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
        <asp:TextBox ID="txtTelefono" CssClass="form-control" placeholder="Telefono" runat="server"></asp:TextBox>




        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

    </div>

</asp:Content>
