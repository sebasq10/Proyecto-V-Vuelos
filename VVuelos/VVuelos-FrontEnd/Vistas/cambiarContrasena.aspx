<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Vistas/Front-End-Master.Master" CodeBehind="cambiarContrasena.aspx.cs" Inherits="VVuelos_FrontEnd.Vistas.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container col-xl-10 col-xxl-8 px-4 py-5">
		<div class="container col-xl-10 col-xxl-8 px-4 py-5">
            <div class="row align-items-center g-lg-5 py-5">
                <div class="col-lg-5 text-center text-lg-start">
                    <h1 class="display-4 fw-bold lh-1 mb-3">Cambiar contraseña</h1>
                </div>
                <div class="col-md-10 mx-auto col-lg-6">
                    <!--<form class="p-4 p-md-5 border rounded-3 bg-light">-->
                    <div class="form-floating mb-3">
                        <asp:Textbox type="text" name="Usuario" runat="server" id="txtUsr" class="form-control" placeholder="Usuario"/>
                        <label for="floatingInput">Usuario</label>
                    </div>
                    <div class="form-floating mb-3">
                        <asp:Textbox type="password" name="Contraseña" runat="server" id="txtOldPass" class="form-control" placeholder="Vieja Contraseña"/>
                        <label for="floatingPassword">Contraseña</label>
                    </div>
                    <hr class="my-4">
                    <div class="form-floating mb-3">
                        <asp:Textbox type="password" name="NewPass" runat="server" id="txtNewPass" class="form-control" placeholder="Nueva Contraseña"/>
                        <label for="floatingInput">Nueva Contraseña</label>
                    </div>
                    <div class="form-floating mb-3">
                        <asp:Textbox type="password" name="ConfContraseña" runat="server" id="txtConfPass" class="form-control" placeholder="Confirmar Contraseña"/>
                        <label for="floatingPassword">Confirmar Contraseña</label>
                    </div>
                        <asp:Button ID="btnChangePass" runat="server" text="Cambiar Contraseña" OnClick="Cambiar_Click"/> <!--OnClick="Cambiar_Contrasena_Click"-->
                        <asp:Label ID="lblError" runat="server" />    
                    <!--</form>-->
                    </div>
                </div>
            </div>
    </div>
</asp:Content>