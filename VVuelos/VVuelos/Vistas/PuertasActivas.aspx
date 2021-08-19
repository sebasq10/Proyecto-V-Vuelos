<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="PuertasActivas.aspx.cs" Inherits="VVuelos.Vistas.PuertasActivas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Puertas Activas</p>
            <div class="table-responsive-lg col-md-10">
              <asp:GridView ID="tabla_Puertas" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Cod_Puerta" HeaderText="Código de Puerta" />
                        <asp:BoundField DataField="Numero" HeaderText="Número" />
                        <asp:BoundField DataField="Detalle" HeaderText="Detalle" />
                    </Columns>
              </asp:GridView>
            </div>
          </div>
</asp:Content>