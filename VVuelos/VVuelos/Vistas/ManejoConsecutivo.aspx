<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="ManejoConsecutivo.aspx.cs" Inherits="VVuelos.Vistas.ManejoConsecutivo" %>
          <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Información del Consecutivo</p>
            <form>
              <div class="form-group row mb-3">
                <label for="descripcionConsecutivo" class="col-sm-2 col-form-label">Descripción:</label>
                <div class="col-sm-3">
                    <asp:dropdownlist runat="server" id="descripcionConsecutivo" class="form-select"> 
     <asp:listitem text="Países" value="1"></asp:listitem>
     <asp:listitem text="Aerolíneas" value="2"></asp:listitem>
     <asp:listitem text="Puertas del Aeropuerto" value="3"></asp:listitem>
     <asp:listitem text="Compra de Boletos" value="4"></asp:listitem>
     <asp:listitem text="Reservaciones de Boletos" value="5"></asp:listitem>
     <asp:listitem text="Vuelos" value="6"></asp:listitem>
</asp:dropdownlist>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Consecutivo:</label>
                <div class="col-sm-2">
                    <asp:TextBox runat="server" type="number" class="form-control" id="numeroConsecutivo"/>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="prefijoConsecutivoCheck" class="col-sm-2 col-form-label">Posee Prefijo:</label>
                <div class="col-sm-10">
                    <asp:CheckBox ID="prefijochk" runat="server" Checked="false" AutoPostBack="true" OnCheckedChanged="prefijochk_CheckedChanged" />
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="prefijoConsecutivo" class="col-sm-2 col-form-label">Prefijo:</label>
                <div class="col-sm-3">
                    <asp:TextBox runat="server" type="text" class="form-control" id="prefijoConsecutivo" MaxLength="5"/>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoCheck" class="col-sm-2 col-form-label">Posee Rango:</label>
                <div class="col-sm-10">
                  <asp:CheckBox ID="rangochk" runat="server" Checked="false" AutoPostBack="true" OnCheckedChanged="rangochk_CheckedChanged" />
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoInicial" class="col-sm-2 col-form-label">Rango Inicial:</label>
                <div class="col-sm-3">
                  <asp:TextBox runat="server" type="number" class="form-control" id="rangoConsecutivoInicial" min="1"/>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoFinal" class="col-sm-2 col-form-label">Rango Final:</label>
                <div class="col-sm-3">
                  <asp:TextBox runat="server" type="number" class="form-control" id="rangoConsecutivoFinal" min="1"/>
                </div>
              </div>
            </form>


              <asp:Button id="aceptarConsecutivobtn" runat="server" class="btn btn-success" Text="Aceptar"  OnClick="aceptarConsecutivobtn_Click1"/>
              <asp:Button id="cancelarConsecutivobtn" runat="server" class="btn btn-danger" Text="Cancelar" OnClick="cancelarConsecutivobtn_Click"/>
          </div>
</asp:Content>