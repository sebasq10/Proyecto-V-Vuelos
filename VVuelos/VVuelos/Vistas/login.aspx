<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="VVuelos.Vistas.login" %>

<!DOCTYPE html>
<html>
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Login Template</title>
  <link rel="preconnect" href="https://fonts.gstatic.com">
<link href="https://fonts.googleapis.com/css2?family=Varela+Round&display=swap" rel="stylesheet"> 
  <!-- <link rel="stylesheet" href="https://cdn.materialdesignicons.com/4.8.95/css/materialdesignicons.min.css"> -->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
  <link rel="stylesheet" href="Resources/assets/css/login.css">
</head>
<body>
    <form runat="server">
  <main class="d-flex align-items-center min-vh-100 py-3 py-md-0">
    <div class="container">
      <div class="card login-card">
        <div class="row no-gutters">
          <div class="col-md-5">
            <img src="Resources/assets/images/login2.jpg" alt="login" class="login-card-img">
          </div>
          <div class="col-md-7">
            <div class="card-body">
              <div class="brand-wrapper">
                <img src="Resources/assets/images/logo.svg" alt="logo" class="logo">
              </div>

              <p class="login-card-description">Inicia sesión en tu cuenta</p>
                  <div class="form-group">
                    <label for="email" class="sr-only">Cuenta</label>
                    <asp:Textbox type="text" name="email" runat="server" id="email" class="form-control" placeholder="Correo"/>
                  </div>
                  <div class="form-group mb-4">
                    <label for="password" class="sr-only">Contraseña</label>
                    <asp:Textbox type="password" name="password" runat="server" id="password" class="form-control" placeholder="***********"/>
                    <asp:Button ID="Login" runat="server" text="Login" OnClick="login_Click"/>
                  </div>
                <!-- <a href="#!" class="forgot-password-link">Forgot password?</a>
                <p class="login-card-footer-text">Don't have an account? <a href="#!" class="text-reset">Register here</a></p>
                <nav class="login-card-footer-nav">
                  <a href="#!">Terms of use.</a>
                  <a href="#!">Privacy policy</a>
                </nav> -->
            </div>
          </div>
        </div>
      </div>
    </div>
  </main>
  <script src="https://code.jquery.com/jquery-3.4.1.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</form>
</body>
</html>

