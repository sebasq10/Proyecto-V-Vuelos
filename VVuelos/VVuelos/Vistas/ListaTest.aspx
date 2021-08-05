<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="ListaTest.aspx.cs" Inherits="VVuelos.Vistas.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Lista de Usuarios</p>
            <div class="container mb-4">
              <div class="row">
                <div class="col-4">
                  <div class="overflow-auto p-3 bg-light" style="width: 200px; max-height: 400px;">
                    <div class="list-group">
                      <a href="#" class="list-group-item list-group-item-action">Usuario 1</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 2</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 3</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 4</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 5</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 6</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 7</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 8</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 9</a>
                      <a href="#" class="list-group-item list-group-item-action">Usuario 10</a>
                    </div>
                  </div>
                </div>
                <div class="col-4">
                  <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="AdministradorCheck">
                    <label class="form-check-label" for="AdministradorCheck">Administrador</label>
                  </div>
                  <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="AdministradorCheck">
                    <label class="form-check-label" for="AdministradorCheck">Seguridad</label>
                  </div>
                  <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="AdministradorCheck">
                    <label class="form-check-label" for="AdministradorCheck">Consecutivo</label>
                  </div>
                  <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="AdministradorCheck">
                    <label class="form-check-label" for="AdministradorCheck">Mantenimiento</label>
                  </div>
                  <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="AdministradorCheck">
                    <label class="form-check-label" for="AdministradorCheck">Consulta</label>
                  </div>
                </div>
              </div>
            </div>
            <button type="button" class="btn btn-success">Guardar Cambios</button>
          </div>
</asp:Content>
