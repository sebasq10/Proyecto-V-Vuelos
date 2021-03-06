<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="NuevoUsuario.aspx.cs" Inherits="VVuelos.Vistas.NuevoUsuario" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Crear nueva cuenta</p>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Usuario:</label>
                <div class="col-sm-3">
                  <input type="text" class="form-control" id="txtUsr" runat="server">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Contraseña:</label>
                <div class="col-sm-3">
                  <input type="password" class="form-control" id="txtPass" runat="server">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Confirmar Contraseña:</label>
                <div class="col-sm-3">
                  <input type="password" class="form-control" id="txtConfPass" runat="server">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">E-mail:</label>
                <div class="col-sm-3">
                  <input type="email" class="form-control" id="txtEmail" runat="server">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Pregunta de Seguridad:</label>
                <div class="col-sm-3">
                  <input type="text" class="form-control" id="txtSecQues" runat="server">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Respuesta de Seguridad:</label>
                <div class="col-sm-3">
                  <input type="text" class="form-control" id="txtSecAns" runat="server">
                </div>
              </div>
            <button type="button" class="btn btn-success" runat="server" onserverclick="ConfirmarBtn_Click" UseSubmitBehavior="False">Crear Usuario</button>
            <asp:Label ID="lblMessage" runat="server" />
          </div>
</asp:Content>