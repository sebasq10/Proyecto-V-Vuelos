<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="ListaPuertas.aspx.cs" Inherits="VVuelos.Vistas.ListaPuertas" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Lista de Puertas del Aeropuerto</p>
            <div class="container mb-4">
              <div class="row">
                <div class="col-4">
                <asp:GridView ID="tabla_Puertas" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Cod_Puerta" HeaderText="Código de Puerta" />
                        <asp:BoundField DataField="Numero" HeaderText="Número" />
                        <asp:BoundField DataField="Detalle" HeaderText="Detalle" />
                     <asp:TemplateField>
              <ItemTemplate>
                 <asp:LinkButton ID="editar_Puerta" text="Seleccionar" type="button" class="btn btn-primary" runat="server" CommandArgument='<%# Eval("Cod_Puerta") %>' OnClick="editar_Puerta_Click"></asp:LinkButton>
               </ItemTemplate>
             </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </div>
                <div class="col-8">
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Código Puerta:</label>
                    <div class="col-sm-2">
                       <asp:TextBox runat="server" type="text" class="form-control" id="codigoPuerta" enabled ="false"/>
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Número:</label>
                    <div class="col-sm-2">
                       <asp:TextBox runat="server" type="number" class="form-control" id="numeroPuerta"/>
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Abierto:</label>
                    <div class="col-sm-2">
                      <asp:CheckBox ID="puertachk" runat="server" Checked="false" AutoPostBack="true" />
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <div class="col-sm-4">
              <asp:Button id="aceptarPuertabtn" runat="server" class="btn btn-success" Text="Aceptar" OnClick="aceptarPuertabtn_Click" />
              <asp:Button id="cancelarPuertabtn" runat="server" class="btn btn-danger" Text="Cancelar" OnClick="cancelarPuertabtn_Click"/>
                    </div>
                  </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
</asp:Content>