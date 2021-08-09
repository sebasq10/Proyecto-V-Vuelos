<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FE-InicioSesion.aspx.cs" Inherits="VVuelos.Vistas.FE_InicioSesion" %>

!DOCTYPE html>
<html lang="en">

<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

  <title>Booking Form HTML Template</title>

  <!-- Google font -->
  <link href="https://fonts.googleapis.com/css2?family=Varela+Round&display=swap" rel="stylesheet">
  <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">

  <!-- Bootstrap -->
  <link href="bootstrap-5.0.1-dist/css/bootstrap.min.css" rel="stylesheet">
  <link href="https://use.fontawesome.com/cd73eec4c0.css" rel="stylesheet">

  <!-- Custom stlylesheet -->
  <link rel="stylesheet" href="Resources/assets/css/proyecto.css" runat="server"/>
  <link rel="stylesheet" href="Resources/assets/css/style.css" runat="server"/>
  <script src="https://use.fontawesome.com/cd73eec4c0.js"></script>


</head>

<body>
  <nav class="navbar fixed-top navbar-dark bg-dark">
    <div class="container-fluid">
      <a class="navbar-brand" href="#">Inicio de Sesion</a>
      <form class="d-flex">
        <button type="button" class="btn btn-primary">Registrarse</button>
      </form>
    </div>
  </nav>
  <div class="container col-xl-10 col-xxl-8 px-4 py-5">
    <div class="row align-items-center g-lg-5 py-5">
      <div class="col-lg-5 text-center text-lg-start">
        <h1 class="display-4 fw-bold lh-1 mb-3">Inicia sesion para poder sacar el máximo provecho de V-Vuelos
        </h1>
      </div>
      <div class="col-md-10 mx-auto col-lg-6">
        <form class="p-4 p-md-5 border rounded-3 bg-light">
          <div class="form-floating mb-3">
            <input type="text" class="form-control" id="floatingInput" placeholder="name@example.com">
            <label for="floatingInput">Usuario</label>
          </div>
          <div class="form-floating mb-3">
            <input type="password" class="form-control" id="floatingPassword" placeholder="Password">
            <label for="floatingPassword">Contraseña</label>
          </div>
          <hr class="my-4">
          <!-- 2 column grid layout for inline styling -->
          <div class="row mb-4">
            <div class="col d-flex justify-content-center">
              <!-- Checkbox -->
              <div class="form-check">
                <input class="form-check-input" type="checkbox" value="" id="form2Example3" checked />
                <label class="form-check-label" for="form2Example3"> Remember me </label>
              </div>
            </div>
            <div class="col">
              <!-- Simple link -->
              <a href="#!">Forgot password?</a>
            </div>
          </div>
          <button class="w-100 btn btn-lg btn-primary" type="submit">Iniciar Sesion</button>

          <div class="text-center">
            <p>o inicia sesion con:</p>
            <button type="button" class="btn btn-primary btn-floating mx-1">
              <i class="fab fa-facebook-f"></i>
            </button>
            <button type="button" class="btn btn-primary btn-floating mx-1">
              <i class="fab fa-google"></i>
            </button>
          </div>
          <div class="row mb-4">
            <div class="col d-flex justify-content-center">
              <a href="#!"> Cambiar Contraseña </a>
            </div>
            <div class="col">
              <a href="#!">Crear Nueva Cuenta</a>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</body><!-- This templates was made by Colorlib (https://colorlib.com) -->

</html>
