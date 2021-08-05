<%@ Page Language="C#" MasterPageFile="~/Vistas/Back-End-Master.Master" AutoEventWireup="true" CodeBehind="ListaPaises.aspx.cs" Inherits="VVuelos.Vistas.ListaPaises" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                    <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Lista de Países</p>
            <div class="container mb-4">
              <div class="row">
                <div class="col-4">
                 <asp:GridView ID="tabla_Paises" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Cod_Pais" HeaderText="Código" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                        <asp:TemplateField>
    <ItemTemplate>
        <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" ImageUrl='<%#"data:Image/png;base64," + Eval("Imagen") %>'/>
    </ItemTemplate>
</asp:TemplateField>
                    </Columns>
                </asp:GridView>
                </div>
                <div class="col-8">
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Código País:</label>
                    <div class="col-sm-2">
                      <asp:TextBox runat="server" type="text" class="form-control" id="CodPais" MaxLength="5"/>
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Nombre:</label>
                    <div class="col-sm-2">
                      <asp:TextBox runat="server" type="text" class="form-control" id="NombrePais" MaxLength="5"/>
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Imágen:</label>
                    <div class="col-sm-2">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </div>
                  </div>
                  <div class="form-group row mb-3">
                    <div class="col-sm-4">
                      <asp:Button ID="btnUploadImage" runat="server" Text="Subir Imagen" OnClick="btnUploadImage_Click" />
                      <button type="button" class="btn btn-danger">Borrar</button>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
</asp:Content>