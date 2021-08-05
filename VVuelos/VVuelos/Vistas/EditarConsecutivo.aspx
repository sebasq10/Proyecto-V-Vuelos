<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="EditarConsecutivo.aspx.cs" Inherits="VVuelos.Vistas.EditarConsecutivo" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Información del Consecutivo</p>
            <form>
              <div class="form-group row mb-3">
                <label for="descripcionConsecutivo" class="col-sm-2 col-form-label">Descripción:</label>
                <div class="col-sm-3">
                  <select id="descripcionConsecutivo" class="form-select">
                    <option selected>Países</option>
                    <option>Aerolíneas</option>
                    <option>Puertas del Aeropuerto</option>
                    <option>Compra de Boletos</option>
                    <option>Reservaciones de Boletos</option>
                    <option>Vuelos</option>
                  </select>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Consecutivo:</label>
                <div class="col-sm-2">
                  <input type="number" class="form-control" id="numeroConsecutivo" placeholder="123">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="prefijoConsecutivoCheck" class="col-sm-2 col-form-label">Posee Prefijo:</label>
                <div class="col-sm-10">
                  <input class="form-check-input" type="checkbox" value="" id="prefijoConsecutivoCheck">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="prefijoConsecutivo" class="col-sm-2 col-form-label">Prefijo:</label>
                <div class="col-sm-3">
                  <input type="text" class="form-control" id="prefijoConsecutivo" placeholder="AA-">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoCheck" class="col-sm-2 col-form-label">Posee Rango:</label>
                <div class="col-sm-10">
                  <input class="form-check-input" type="checkbox" value="" id="rangoConsecutivoCheck">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoInicial" class="col-sm-2 col-form-label">Rango Inicial:</label>
                <div class="col-sm-3">
                  <input type="number" class="form-control" id="rangoConsecutivoInicial" placeholder="123">
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoFinal" class="col-sm-2 col-form-label">Rango Final:</label>
                <div class="col-sm-3">
                  <input type="number" class="form-control" id="rangoConsecutivoFinal" placeholder="123">
                </div>
              </div>
            </form>
              <asp:Button id="testButton" runat="server" class="btn btn-success" Text="Aceptar"/>
            <button type="button" class="btn btn-danger" id="cancelarConsecutivo" runat="server">Cancelar</button>
          </div>
</asp:Content>