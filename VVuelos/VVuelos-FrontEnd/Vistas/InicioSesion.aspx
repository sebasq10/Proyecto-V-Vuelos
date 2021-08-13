<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Vistas/Front-End-Master.Master" CodeBehind="InicioSesion.aspx.cs" Inherits="VVuelos_FrontEnd.Vistas.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="container col-xl-10 col-xxl-8 px-4 py-5 mt-5">
    <div class="row align-items-center g-lg-5 py-5">
      <div class="col-lg-5 text-center text-lg-start">
        <h1 class="display-4 lh-1 mb-3" style="color: #fff">Inicia sesion para poder sacar el máximo provecho de V-Vuelos
        </h1>
      </div>
      <div class="col-md-10 mx-auto col-lg-6">
        <!--<form class="p-4 p-md-5 border rounded-3 bg-light">-->
          <div class="form-floating mb-3">
            <asp:Textbox type="text" name="Usuario" runat="server" id="txtUsr" class="form-control" placeholder="Usuario"/>

            <label for="floatingInput">Usuario</label>
          </div>
          <div class="form-floating mb-3">
              <asp:Textbox type="text" name="Contraseña" runat="server" id="txtPass" class="form-control" placeholder="Contraseña"/>
            <label for="floatingPassword">Contraseña</label>
          </div>
          <hr class="my-4">
          <asp:Button class="btn- btn-warning" ID="btnLogin" runat="server" text="Iniciar Sesión" OnClick="login_Click" />
          <div class="text-center">
            <p>o inicia sesion con:</p>
            <asp:Button ID="Button1" runat="server" text="Facebook"/> <!--OnClick="login_Click"-->
          </div>
          <div class="row mb-4">
            <div class="col d-flex justify-content-center">
              <!--<a href="cambiarContrasena.aspx"> Cambiar Contraseña </a>-->
            </div>
          </div>
        <!--</form>-->
      </div>
    </div>
  </div>

</asp:Content>
