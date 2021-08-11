<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Front-End-Master.Master" AutoEventWireup="true" CodeBehind="ListaVuelos.aspx.cs" Inherits="VVuelos_FrontEnd.Vistas.ListaVuelos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="container">
				<div class="row">
					<div class="col-md-7 col-md-push-5">
						<div class="booking-cta">
							<h1>Llegadas de Vuelos</h1>
						</div>
					</div>
					<div>
						<div class="col-md-15 col-md-pull-17">
							<div class="booking-form">
												<asp:GridView ID="tabla_VuelosEntrada" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Cod_Vuelo" HeaderText="Vuelo" />
						<asp:BoundField DataField="Aerolineas_Cod_Aerolinea" HeaderText="Aerolínea" />
						<asp:BoundField DataField="Paises_Cod_Pais" HeaderText="Procedencia" />
						<asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Puertas_Activas_Cod_Puerta" HeaderText="Puerta" />
                     <asp:TemplateField>
             </asp:TemplateField>
                    </Columns>
                </asp:GridView>
							</div>
						</div>
					</div>
				</div>
			</div>
			<div class="container">
				<div class="row">
					<div class="col-md-7 col-md-push-5">
						<div class="booking-cta">
							<h1>Salidas de Vuelos</h1>
						</div>
					</div>
					<div>
						<div class="col-md-15 col-md-pull-17">
							<div class="booking-form mb-4">
				<asp:GridView ID="tabla_VuelosSalidas" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Cod_Vuelo" HeaderText="Vuelo" />
						<asp:BoundField DataField="Aerolineas_Cod_Aerolinea" HeaderText="Aerolínea" />
						<asp:BoundField DataField="Paises_Cod_Pais" HeaderText="Procedencia" />
						<asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                        <asp:BoundField DataField="Estado" HeaderText="Estado" />
                        <asp:BoundField DataField="Puertas_Activas_Cod_Puerta" HeaderText="Puerta" />
                     <asp:TemplateField>
             </asp:TemplateField>
                    </Columns>
                </asp:GridView>
							</div>
						</div>
					</div>
				</div>
			</div>
</asp:Content>
