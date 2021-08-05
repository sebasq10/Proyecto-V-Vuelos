<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="PuertasActivas.aspx.cs" Inherits="VVuelos.Vistas.PuertasActivas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Puertas Activas</p>
            <div class="table-responsive-lg col-md-10">
              <table class="table">             
                <thead class="table-primario-dark">
                  <tr>
                    <th scope="col">Codigo</th>
                    <th scope="col">Numero</th>
                    <th scope="col">Detalle</th>
                    <th scope="col">Acciones</th>
                  </tr>
                </thead>
                <tbody>
                  <th scope="row"></th>
                    <td></td>
                    <td></td>
                    <td>
                      <button type="button" class="btn btn-primary">Eliminar</button>
                    </td>
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