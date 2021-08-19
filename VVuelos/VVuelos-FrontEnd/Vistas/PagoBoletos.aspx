<%@ Page Language="C#" MasterPageFile="~/Vistas/Front-End-Master.Master" AutoEventWireup="true" CodeBehind="PagoBoletos.aspx.cs" Inherits="VVuelos_FrontEnd.Vistas.PagoBoletos" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container col-xl-10 col-xxl-8 px-4 py-5" />
    <div class="container col-xl-10 col-xxl-8 px-4 py-5" />
    <div class="row align-items-center g-lg-5 py-5">
        <div class="col-lg-5 text-center text-lg-start">
            <h1 class="display-4 fw-bold lh-1 mb-3">Pago de Boletos</h1>
        </div>
        <div class="col-md-10 mx-auto col-lg-6">
            <!--<form class="p-4 p-md-5 border rounded-3 bg-light">-->
            <h1 class="display-4 lh-1 mb-3" style="color: black;">Tarjeta Credito</h1>
            <div class="form-floating mb-3">
                <asp:TextBox type="text" name="Numero de Tarjeta" runat="server" ID="txtNumT" class="form-control" placeholder="Num_Tarjeta" MaxLength="16" />
                <label for="floatingInput">xxxx-xxxx-xxxx-xxxx</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox type="text" name="MesExp" runat="server" ID="txtMesExp" class="form-control" placeholder="MesExp" MaxLength="2" />
                <label for="floatingInput">Mes Exp</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox type="text" name="Año" runat="server" ID="txtAno" class="form-control" placeholder="Ano" MaxLength="2" />
                <label for="floatingInput">Año</label>
            </div>
            <div class="form-floating mb-2">
                <asp:TextBox type="text" name="CVV" runat="server" ID="txtCVV" class="form-control" placeholder="CVV" MaxLength="3" />
                <label for="floatingInput">CVV</label>
            </div>
            <div class="form-floating mb-2">
                <asp:TextBox type="text" name="Monto" runat="server" ID="txtMonto" class="form-control" placeholder="Monto" />
                <label for="floatingInput">Monto</label>
            </div>
            <div class="form-floating mb-2">
                <asp:TextBox type="text" name="Tipo" runat="server" ID="txtTipo" class="form-control" placeholder="Tipo" />
                <label for="floatingInput">Tipo</label>
            </div>
            <div class="form-floating mb-3">
                <asp:Button class="btn- btn-warning" ID="btnTarjeta" runat="server" Text="Tarjeta Debito/Credito" OnClick="btnTarjeta_Clicked" />
                <asp:Label ID="lblError" runat="server" />
            </div>
            <hr class="my-4">
            <h1 class="display-4 lh-1 mb-3" style="color: black;">EasyPay</h1>
            <div class="form-floating mb-3">
                <asp:TextBox type="text" name="Numero de Cuenta" runat="server" ID="TextNumCuenta" class="form-control" placeholder="Num_Cuenta" />
                <label for="floatingInput">Numero de Cuenta</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox type="text" name="CodSeguridad" runat="server" ID="txtCodSeg" class="form-control" placeholder="CodSeg" />
                <label for="floatingInput">Codigo de Seguridad</label>
            </div>
            <div class="form-floating mb-2">
                <asp:TextBox type="password" name="Contraseña" runat="server" ID="txtContrasena" class="form-control" placeholder="Contrasena" />
                <label for="floatingInput">Contraseña</label>
            </div>
            <div class="form-floating mb-3">
                <asp:Button class="btn- btn-warning" ID="btnEasyPay" runat="server" Text="EasyPay" OnClick="btnEasyPay_Clicked" />
                <asp:Label ID="lblError1" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>
