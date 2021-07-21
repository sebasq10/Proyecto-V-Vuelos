﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManejoConsecutivo.aspx.cs" Inherits="VVuelos.Vistas.ManejoConsecutivo" %>

<!doctype html>
<html>

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <meta name="description" content="">
  <title>V-Vuelos Backend</title>
  <!-- Fuente -->
  <link rel="preconnect" href="https://fonts.gstatic.com">
  <link href="https://fonts.googleapis.com/css2?family=Varela+Round&display=swap" rel="stylesheet">
  <!-- Bootstrap core CSS -->
  <link href="Resources/bootstrap-5.0.1-dist/css/bootstrap.min.css" rel="stylesheet">
  <!-- Bootstrap CUSTOM CSS -->
  <link rel="stylesheet" href="Resources/assets/css/main_custom.css">
  <link href="Resources/proyecto.css" rel="stylesheet">
  <!--Se añade el css de proyecto-->

  <!-- CSS Sidebar -->
  <link href="Resources/sidebars.css" rel="stylesheet">
</head>

<body>
        <form runat="server">
  <svg xmlns="http://www.w3.org/2000/svg" style="display: none;">
    <symbol id="bootstrap" viewBox="0 0 118 94">
      <path fill-rule="evenodd" clip-rule="evenodd"
        d="M24.509 0c-6.733 0-11.715 5.893-11.492 12.284.214 6.14-.064 14.092-2.066 20.577C8.943 39.365 5.547 43.485 0 44.014v5.972c5.547.529 8.943 4.649 10.951 11.153 2.002 6.485 2.28 14.437 2.066 20.577C12.794 88.106 17.776 94 24.51 94H93.5c6.733 0 11.714-5.893 11.491-12.284-.214-6.14.064-14.092 2.066-20.577 2.009-6.504 5.396-10.624 10.943-11.153v-5.972c-5.547-.529-8.934-4.649-10.943-11.153-2.002-6.484-2.28-14.437-2.066-20.577C105.214 5.894 100.233 0 93.5 0H24.508zM80 57.863C80 66.663 73.436 72 62.543 72H44a2 2 0 01-2-2V24a2 2 0 012-2h18.437c9.083 0 15.044 4.92 15.044 12.474 0 5.302-4.01 10.049-9.119 10.88v.277C75.317 46.394 80 51.21 80 57.863zM60.521 28.34H49.948v14.934h8.905c6.884 0 10.68-2.772 10.68-7.727 0-4.643-3.264-7.207-9.012-7.207zM49.948 49.2v16.458H60.91c7.167 0 10.964-2.876 10.964-8.281 0-5.406-3.903-8.178-11.425-8.178H49.948z">
      </path>
    </symbol>
  </svg>
  <main>

    <div class="container-fluid">
      <div class="row flex-nowrap">
        <div class="b-example-divider"></div>
        <div class="flex-shrink-0 p-4 bg-color-primario texto-sidebar-primario" style="width: 280px;">
          <!--Aquí se cambia el color de background y color del texto (o se cambiaría el color de texto si sirviera. Por alguna razón, solo se cambia algunos textos entonces tuve que hacerlo manual. Marco donde en donde lo hago, Sebastián) -->
          <a href="/" class="d-flex align-items-center pb-3 mb-3 link-dark text-decoration-none border-bottom">
            <!--Aquí se cambia la imagen, probablemente solo usar link -->
            <!--<svg class="bi me-2" width="30" height="24"><use xlink:href=""></use></svg>-->
            <svg class="bi me-2" width="30" height="24">
              <use
                xlink:href="https://media.discordapp.net/attachments/393184195729424384/850168225500364800/Avion.png?width=505&height=473">
              </use>
            </svg>
            <span class="fs-5 fw-semibold text-white">V-Vuelos</span>
          </a>
          <ul class="list-unstyled ps-0">
            <li class="mb-1">
              <button class="btn btn-toggle align-items-center rounded collapsed text-white" data-bs-toggle="collapse"
                data-bs-target="#seguridad-collapse" aria-expanded="true">
                Seguridad
              </button>
              <div class="collapse ms-3" id="seguridad-collapse">
                <button class="btn btn-toggle align-items-center rounded collapsed text-white" data-bs-toggle="collapse"
                  data-bs-target="#usuarios-collapse" aria-expanded="false">
                  Usuarios
                </button>
                <div class="collapse" id="usuarios-collapse">
                  <ul class="btn-toggle-nav list-unstyled fw-normal pb-1 small">
                    <li><a href="NuevoUsuario.html" class="link-dark rounded text-white">Crear Usuario</a></li>
                    <li><a href="ListaUsuarios.html" class="link-dark rounded text-white">Ver Usuario</a></li>
                  </ul>
                  <a class="btn align-items-center rounded collapsed text-white" href="CambiarContrasena.html"
                    role="button" aria-expanded="false">
                    Cambiar Contraseña
                  </a>
                </div>
              </div>
            </li>
            <li class="mb-1">
              <button class="btn btn-toggle align-items-center rounded collapsed text-white" data-bs-toggle="collapse"
                data-bs-target="#administracion-collapse" aria-expanded="false">Administración</button>
              <div class="collapse show" id="administracion-collapse">
                <ul class="btn-toggle-nav list-unstyled fw-normal pb-1 small">
                  <li><a href="ListaConsecutivos.html" class="link-dark rounded text-white">Consecutivos</a></li>
                  <li><a href="ListaPaises.html" class="link-dark rounded text-white">Paises</a></li>
                  <li><a href="ListaAerolineas.html" class="link-dark rounded text-white">Aerolíneas</a></li>
                  <li><a href="ListaPuertas.html" class="link-dark rounded text-white">Puertas del Aeropuerto</a></li>
                </ul>
              </div>
            </li>
            <li class="mb-1">
              <button class="btn btn-toggle align-items-center rounded collapsed text-white" data-bs-toggle="collapse"
                data-bs-target="#consultas-collapse" aria-expanded="false">Consultas</button>
              <div class="collapse" id="consultas-collapse">
                <ul class="btn-toggle-nav list-unstyled fw-normal pb-1 small">
                  <li><a href="Bitacora.html" class="link-dark rounded text-white">Bitácora</a></li>
                  <li><a href="Errores.html" class="link-dark rounded text-white">Errores</a></li>
                  <li><a href="Descargas.html" class="link-dark rounded text-white">Descargas</a></li>
                  <li><a href="AerolineasPais.html" class="link-dark rounded text-white">Aerolíneas</a></li>
                  <li><a href="PActivas.html" class="link-dark rounded text-white">Puertas</a></li>
                </ul>
              </div>
            </li>
          </ul>
        </div>
        <!-- Fin Sidebar -->

        <!-- Inicio Header -->
        <div class="col p-0 bg">
          <header
            class="d-flex flex-wrap align-items-center justify-content-center justify-content-md-between py-3 border-bottom bg-color-secundario">
            <div class="container-fluid">
              <div class="row">
                <div class="col-10">
                  <nav aria-label="breadcrumb ms-4">
                    <ol class="breadcrumb">
                      <li class="breadcrumb-item disabled">Administración</li>
                      <li class="breadcrumb-item active" aria-current="page"><a href="ListaConsecutivos.html">Consecutivos</a></li>
                      <li class="breadcrumb-item active" aria-current="page"><a href="ManejoConsecutivo.html">Manejo Consecutivos</a></li>
                    </ol>
                  </nav>
                </div>
                <div class="col-2">
                  <div class="dropdown">
                    <a href="#" class="d-flex align-items-center text-decoration-none dropdown-toggle text-dark"
                      id="dropdownUser1" data-bs-toggle="dropdown" aria-expanded="false">
                      <img src="https://github.com/mdo.png" alt="" width="32" height="32" class="rounded-circle me-2">
                      <strong>Administrador</strong>
                    </a>
                    <ul class="dropdown-menu" aria-labelledby="dropdownUser1">
                      <li><a class="dropdown-item" href="#">Opción 1</a></li>
                      <li><a class="dropdown-item" href="#">Opción 1</a></li>
                      <li>
                        <hr class="dropdown-divider">
                      </li>
                      <li><a class="dropdown-item" href="#">Cerrar Sesión</a></li>
                    </ul>
                  </div>
                </div>
              </div>
          </header>
          <!-- Fin Header -->

          <!-- Contenedor Principal -->
          <div class="col p-5">
            <p class="h3 row mb-4">Información del Consecutivo</p>
            <form>
              <div class="form-group row mb-3">
                <label for="descripcionConsecutivo" class="col-sm-2 col-form-label">Descripción:</label>
                <div class="col-sm-3">
                    <asp:dropdownlist runat="server" id="descripcionConsecutivo" class="form-select"> 
     <asp:listitem text="Países" value="1"></asp:listitem>
     <asp:listitem text="Aerolíneas" value="2"></asp:listitem>
     <asp:listitem text="Puertas del Aeropuerto" value="3"></asp:listitem>
     <asp:listitem text="Compra de Boletos" value="4"></asp:listitem>
     <asp:listitem text="Reservaciones de Boletos" value="5"></asp:listitem>
                        <asp:listitem text="Vuelos" value="5"></asp:listitem>
</asp:dropdownlist>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="numeroConsecutivo" class="col-sm-2 col-form-label">Consecutivo:</label>
                <div class="col-sm-2">
                    <asp:TextBox runat="server" type="number" class="form-control" id="numeroConsecutivo"/>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="prefijoConsecutivoCheck" class="col-sm-2 col-form-label">Posee Prefijo:</label>
                <div class="col-sm-10">
                    <asp:CheckBox ID="prefijochk" runat="server" Checked="false" OnCheckedChanged="prefijochk_CheckedChanged" />
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="prefijoConsecutivo" class="col-sm-2 col-form-label">Prefijo:</label>
                <div class="col-sm-3">
                    <asp:TextBox runat="server" type="text" class="form-control" id="prefijoConsecutivo" MaxLength="5"/>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoCheck" class="col-sm-2 col-form-label">Posee Rango:</label>
                <div class="col-sm-10">
                  <asp:CheckBox ID="rangochk" runat="server" Checked="false" OnCheckedChanged="rangochk_CheckedChanged" />
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoInicial" class="col-sm-2 col-form-label">Rango Inicial:</label>
                <div class="col-sm-3">
                  <asp:TextBox runat="server" type="number" class="form-control" id="rangoConsecutivoInicial" min="1"/>
                </div>
              </div>
              <div class="form-group row mb-3">
                <label for="rangoConsecutivoFinal" class="col-sm-2 col-form-label">Rango Final:</label>
                <div class="col-sm-3">
                  <asp:TextBox runat="server" type="number" class="form-control" id="rangoConsecutivoFinal" min="1"/>
                </div>
              </div>
            </form>


              <asp:Button id="aceptarConsecutivobtn" runat="server" class="btn btn-success" Text="Aceptar"  OnClick="aceptarConsecutivobtn_Click1"/>
              <asp:Button id="cancelarConsecutivobtn" runat="server" class="btn btn-danger" Text="Cancelar" OnClick="cancelarConsecutivobtn_Click"/>
          </div>
        </div>
      </div>
    </div>
  </main>
  <script src="Resources/bootstrap-5.0.1-dist/js/bootstrap.bundle.min.js"></script>
  <script src="Resources/sidebars.js"></script>
                </form>
</body>

</html>