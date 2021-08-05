<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="Errores.aspx.cs" Inherits="VVuelos.Vistas.Errores" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Errores</p>
            <div class="table-responsive-lg col-md-10">
              <table class="table">             
                <thead class="table-primario-dark">
                  <tr>
                    <th scope="col">Fecha</th>
                    <th scope="col">Numero Error</th>
                    <th scope="col">Mensaje</th>
                    <th scope="col">Acciones</th>
                  </tr>
                </thead>
                <tbody>
                  <tr>
                    <th><input type="date" class="col-sm-6" id="fecha" placeholder="Filtrar..."></th>
                    <td><input type="text" class="col-sm-4" id="Nombre" placeholder="Filtrar..."></td>
                  </tr>
                  <tr>
                    <th scope="row"></th>
                    <td></td>
                    <td></td>
                    <td>
                      <button type="button" class="btn btn-primary">Eliminar</button>
                    </td>
                  </tr>
                  <tr>
                    <th scope="row"></th>
                    <td></td>
                    <td></td>
                    <td>
                      <button type="button" class="btn btn-primary">Eliminar</button>
                    </td>
                  </tr>
                </tbody>
              </table>
            </div>
            <a class="btn btn-success" href="ManejoConsecutivo.aspx">Nuevo</a></li>
          </div>
</asp:Content>