<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="Bitacora.aspx.cs" Inherits="VVuelos.Vistas.Bitacora" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Bitacora</p>
                <asp:GridView ID="tabla_Bitacora" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                        <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                        <asp:BoundField DataField="Codigo_Registro" HeaderText="Codigo_Registro" />
                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" />
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                     <asp:TemplateField>
              <ItemTemplate>
                 <asp:LinkButton ID="seleccionar_Bitacora" text="Ver Detalle" type="button" class="btn btn-primary" runat="server" CommandArgument='<%# Eval("Codigo_Registro") %>'></asp:LinkButton>
               </ItemTemplate>
             </asp:TemplateField>
                    </Columns>
                </asp:GridView>
          </div>
</asp:Content>