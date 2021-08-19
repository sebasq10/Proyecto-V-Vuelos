<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/Front-End-Master.Master" AutoEventWireup="true" CodeBehind="ReservarBoletos.aspx.cs" Inherits="VVuelos_FrontEnd.Vistas.ProcesarBoletos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container col-xl-10 col-xxl-8 px-4 py-5 mt-5">
		<div class="row align-items-center g-lg-5 py-5">
			<div class="col-lg-5 text-center text-lg-start">
				<h1 class="display-4 lh-1 mb-3" style="color: #fff;">Estas a un paso de reservar tus boletos
				</h1>
			</div>
			<div class="col-md-10 mx-auto col-lg-6">
				<!--<form class="p-4 p-md-5 border rounded-3 bg-light">-->
					<div class="form-floating mb-3">
						<asp:Textbox type="text" name="Nombre" runat="server" id="asientosReservarTxt" class="form-control" placeholder="Nombre"/>
						<label for="floatingInput">Cuantos asientos desea reservar?</label>
					</div>
					<hr class="my-4">
				<asp:Button class="btn btn-secondary" ID="cancelarBtn" runat="server" Text="Aceptar" OnClick="cerrarAccion_Click" />
				<asp:Button class="btn btn-primary mt-3" ID="aceptarBtn" runat="server" Text="Aceptar" OnClick="guardarAccion_Click" />
				<!--</form>-->
			</div>
		</div>
	</div>
</asp:Content>
