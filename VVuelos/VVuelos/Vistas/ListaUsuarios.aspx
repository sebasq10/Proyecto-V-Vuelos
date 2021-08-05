<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="VVuelos.Vistas.ListaUsuarios" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Lista de Usuarios</p>
            <div class="container mb-4">
              <div class="row">
                <div class="col-4">
                <asp:GridView ID="tabla_Usuarios" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Nombre_Usuario" HeaderText="Nombre de Usuario" />
                     <asp:TemplateField>
              <ItemTemplate>
                 <asp:LinkButton ID="seleccionar_Consecutivo" text="Seleccionar" type="button" class="btn btn-primary" runat="server" CommandArgument='<%# Eval("Nombre_Usuario") %>' OnClick="seleccionar_Usuario_Click"></asp:LinkButton>
               </ItemTemplate>
             </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </div>
                <div class="col-4">
                  <div class="form-group row mb-3">
                    <label class="col-sm-4 col-form-label">Usuario Seleccionado:</label>
                    <div class="col-sm-2">
                       <asp:TextBox runat="server" type="text" class="form-control" id="usuarioSeleccionado" enabled ="false"/>
                    </div>
                  </div>
                  <div class="form-check">
                    <asp:CheckBox  ID="usuarioAdministradorchk" runat="server" Checked="false" AutoPostBack="true" />
                    <label class="form-check-label" for="AdministradorCheck">Administrador</label>
                  </div>
                  <div class="form-check">
                    <asp:CheckBox  ID="usuarioSeguridadchk" runat="server" Checked="false" AutoPostBack="true" />
                    <label class="form-check-label" for="AdministradorCheck">Seguridad</label>
                  </div>
                  <div class="form-check">
                    <asp:CheckBox  ID="usuarioConsecutivochk" runat="server" Checked="false" AutoPostBack="true" />
                    <label class="form-check-label" for="AdministradorCheck">Consecutivo</label>
                  </div>
                  <div class="form-check">
                    <asp:CheckBox  ID="usuarioMantenimientochk" runat="server" Checked="false" AutoPostBack="true" />
                    <label class="form-check-label" for="AdministradorCheck">Mantenimiento</label>
                  </div>
                  <div class="form-check">
                    <input class="form-check-input" type="checkbox" value="" id="AdministradorCheck">
                    <label class="form-check-label" for="AdministradorCheck">Consulta</label>
                  </div>
                </div>
              </div>
            </div>
              <asp:Button id="aceptarUsuariobtn" runat="server" class="btn btn-success" Text="Guardar Cambios" OnClick="aceptarUsuariobtn_Click"/>
          </div>
</asp:Content>
