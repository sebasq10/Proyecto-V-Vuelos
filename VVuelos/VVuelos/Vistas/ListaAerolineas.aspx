<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="ListaAerolineas.aspx.cs" Inherits="VVuelos.Vistas.ListaAerolineas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Lista de Aerolíneas</p>
            <div class="container mb-4">
              <div class="row">
                <div class="col-4">
                  <asp:GridView ID="tabla_aerolineas" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Cod_Aerolinea" HeaderText="Código de Aerolinea" />
                        <asp:BoundField DataField="Nombre" HeaderText="Número" />
                        <asp:BoundField DataField="Imagen" HeaderText="Imagen" />
                     <asp:TemplateField>
              <ItemTemplate>
                 <asp:LinkButton ID="editar_Aerolinea" text="Seleccionar" type="button" class="btn btn-primary" runat="server" CommandArgument='<%# Eval("Cod_Aerolinea") %>' OnClick="editar_Aerolinea_Click"></asp:LinkButton>
               </ItemTemplate>
             </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                  </div>
                </div>
                <div class="col-8">
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Código Aerolínea:</label>
                    <div class="col-sm-2">
                      <asp:TextBox runat="server" type="number" class="form-control" id="codigoAerolinea" enabled ="false"/>
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Nombre:</label>
                    <div class="col-sm-2">
                      <asp:TextBox runat="server" type="number" class="form-control" id="numeroPuerta"/>
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Imágen:</label>
                    <div class="col-sm-2">
          
                            <INPUT id="oFile" type="file" runat="server" NAME="oFile">
                            <asp:button id="btnUpload" type="submit" text="Upload" runat="server"></asp:button>
                            <asp:Panel ID="frmConfirmation" Visible="False" Runat="server">
                                <asp:Label id="lblUploadResult" Runat="server"></asp:Label>
                            </asp:Panel>

                      <img src="https://www.juergenbaumbusch.de/wp-content/uploads/2013/05/Delta-Logo.jpg" alt="Delta" width="100" height="60">
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <div class="col-sm-4">
                      <button type="button" class="btn btn-success"  id="btnAceptar">Aceptar</button>
                      <button type="button" class="btn btn-danger">Borrar</button>
                    </div>
                  </div>
                </div>
              </div>
            </div>
</asp:Content>