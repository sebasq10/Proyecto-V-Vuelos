<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Front-End-Master.Master" AutoEventWireup="true" CodeBehind="BuscarVuelos.aspx.cs" Inherits="VVuelos_FrontEnd.Vistas.BuscarVuelos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
				<div class="row mt-5">
					<div class="col-md-7 col-md-push-5">
						<div class="booking-cta">
							<h1>Búsqueda de Vuelos</h1>
						</div>
					</div>
						<div class="card-body">
							<form class="form">
								<div class="input-group input--large">
									<label class="label">Destino</label>
									<asp:Textbox type="text" name="password" runat="server" id="Destinotxt" class="input--style-1" placeholder=""/>
								</div>
								<div class="input-group input--medium">
									<label class="label">Fecha de Vuelo</label>
									<asp:Textbox type="date" name="checkin" runat="server" id="Fechatxt" class="input--style-1" placeholder="mm/dd/yyyy"/>
								</div>
								<asp:Button class="btn-submit" ID="buscarVuelosbtn" runat="server" text="Buscar!" OnClick="buscarVuelosbtn_Click"/>
							</form>
						</div>
					</div>
					<div>
						<div class="col-md-15 col-md-pull-17">
							<div class="booking-form">
				<asp:GridView ID="tabla_BuscarVuelos" AutoGenerateColumns="false" class="table" border="0" runat="server">
                  <headerstyle CssClass="table-primario-dark"/>
                    <Columns>
                        <asp:BoundField DataField="Cod_Vuelo" HeaderText="Vuelo" />
						<asp:BoundField DataField="Aerolinea" HeaderText="Aerolínea" />
						<asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                     <asp:TemplateField>
              <ItemTemplate>
                 <asp:LinkButton ID="seleccionar_Vuelo" text="Seleccionar" type="button" class="btn btn-primary" runat="server" CommandArgument='<%# Eval("Cod_Vuelo") %>' OnClick="seleccionar_Vuelo_Click"></asp:LinkButton>
               </ItemTemplate>
             </asp:TemplateField>
                    </Columns>
                </asp:GridView>
							</div>
						</div>
					</div>
				</div>
</asp:Content>
