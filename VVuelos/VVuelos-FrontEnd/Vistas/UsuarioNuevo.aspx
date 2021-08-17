<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Vistas/Front-End-Master.Master" CodeBehind="UsuarioNuevo.aspx.cs" Inherits="VVuelos_FrontEnd.Vistas.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="container col-xl-10 col-xxl-8 px-4 py-5 mt-5">
		<div class="row align-items-center g-lg-5 py-5">
			<div class="col-lg-5 text-center text-lg-start">
				<h1 class="display-4 lh-1 mb-3" style="color: #fff;">Regístrate para poder sacar el máximo provecho de V-Vuelos
				</h1>
			</div>
			<div class="col-md-10 mx-auto col-lg-6">
				<!--<form class="p-4 p-md-5 border rounded-3 bg-light">-->
					<div class="form-floating mb-3">
						<asp:Textbox type="text" name="Nombre" runat="server" id="txtFirstname" class="form-control" placeholder="Nombre"/>
						<label for="floatingInput">Nombre</label>
					</div>
					<div class="form-floating mb-3">
						<asp:Textbox type="text" name="Primer Apellido" runat="server" id="txtLastName" class="form-control" placeholder="Primer Apellido"/>
						<label for="floatingInput">Primer Apellido</label>
					</div>
					<div class="form-floating mb-3">
						<asp:Textbox type="text" name="Segundo Apellido" runat="server" id="txtSecLastName" class="form-control" placeholder="Segundo Apellido"/>
						<label for="floatingInput">Segundo Apellido</label>
					</div>
					<div class="form-floating mb-3">
						<asp:Textbox type="text" name="Correo Electrónico" runat="server" id="txtEmail" class="form-control" placeholder="Correo"/>
						<label for="floatingInput">Correo Electrónico</label>
					</div>
					<div class="row g-2 mb-3">
						<div class="col-md-8">
							<div class="form-floating">
								<asp:Textbox type="text" name="Nombre de usuario" runat="server" id="txtUser" class="form-control" placeholder="Nombre de Usuario"/>
								<label for="floatingInput">Nombre de Usuario</label>
							</div>
						</div>
						<div class="col-md">
							<div class="form-floating">
								<asp:Button class="btn- btn-info" ID="btnVerify" runat="server" text="Verificar Cuenta" OnClick="Verify_Click"/>
								<asp:Label ID="lblVerify" runat="server" />
							</div>
						</div>
					</div>
					<div class="form-floating mb-3">
						<asp:Textbox type="password" name="Contraseña" runat="server" id="txtPass" class="form-control" placeholder="Contraseña"/>
						<label for="floatingInput">Contraseña</label>
					</div>
					<div class="form-floating mb-3">
						<asp:Textbox type="password" name="ConfirmarContraseña" runat="server" id="txtConfPass" class="form-control" placeholder="Confirmar Contraseña"/>
						<label for="floatingInput">Confirmar Contraseña</label>
					</div>
					<hr class="my-4">
					<div>
						<center>
							<table bordercolor ="black" bgcolor="#62caf0">
								<h1 class="display-4 lh-1 mb-3" style="color: #fff;">Vaidación CAPTCHA</h1>
								<tr>
									<td>
										Código de Seguridad :
									</td>
									<td>
										<asp:Image ID="imgCaptcha" runat="server" ImageUrl="~/CaptchaImage.aspx" />
									</td>
								</tr>
								<tr>
									<td>Inserte código aquí</td>
									<td>
										<asp:TextBox ID="txtCaptchaText" runat="server" Width="100px" />
									</td>
								</tr>
								<tr>
									<td></td>
									<td>
										<asp:Button ID="btnSubmit" runat="server"  Text="Confirmar CAPTCHA" OnClick="btnSubmit_Click"/>
									</td>
								</tr>
								<tr>
									<td></td>
									<td>
										<asp:Label ID="lblMessage" runat="server" />
									</td>
								</tr>
							</table>
						</center>
					</div>
					
					<hr class="my-4">
					<asp:Button class="btn- btn-warning" ID="btnConfirm" runat="server" text="Registrarse" OnClick="Confirm_Click"/>
					<asp:Label ID="lblError" runat="server" />
				<!--</form>-->
			</div>
		</div>
	</div>
</asp:Content>