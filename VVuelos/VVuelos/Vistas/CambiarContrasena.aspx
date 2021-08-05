<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="CambiarContrasena.aspx.cs" Inherits="VVuelos.Vistas.CambiarContrasena" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Cambio de Contraseña</p>
            <form>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Contraseña:</label>
                <div class="col-sm-3">
                  <input type="text" class="form-control" id="numeroConsecutivo">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Nueva Contraseña:</label>
                <div class="col-sm-3">
                  <input type="password" class="form-control" id="numeroConsecutivo">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Confirmar Contraseña:</label>
                <div class="col-sm-3">
                  <input type="password" class="form-control" id="numeroConsecutivo">
                </div>
              </div>
            </form>
            <button type="button" class="btn btn-success">Cambiar Contraseña</button>
            <button type="button" class="btn btn-danger">Cancelar</button>
          </div>
</asp:Content>
