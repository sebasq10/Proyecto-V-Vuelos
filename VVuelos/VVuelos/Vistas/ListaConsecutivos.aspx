<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="ListaConsecutivos.aspx.cs" Inherits="VVuelos.ListaConsecutivos" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Lista de Consecutivos</p>
            <div class="table-responsive-lg col-md-10">
                <asp:GridView ID="tabla_Consecutivos" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="ID_Consecutivo" HeaderText="Código" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                        <asp:BoundField DataField="Consecutivo" HeaderText="Consecutivo" />
                     <asp:TemplateField>
              <ItemTemplate>
                 <asp:LinkButton ID="seleccionar_Consecutivo" text="Seleccionar" type="button" class="btn btn-primary" runat="server" CommandArgument='<%# Eval("ID_Consecutivo") %>' OnClick="seleccionar_Consecutivo_Click"></asp:LinkButton>
               </ItemTemplate>
             </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <asp:Button id="nuevoConsecutivobtn" runat="server" class="btn btn-success" Text="Nuevo Consecutivo" OnClick="nuevoConsecutivobtn_Click"/>
          </div>
</asp:Content>