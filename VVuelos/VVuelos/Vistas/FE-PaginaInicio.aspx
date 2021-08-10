<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FE-PaginaInicio.aspx.cs" Inherits="VVuelos.Vistas.FE_PaginaInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->

	<title>Booking Form HTML Template</title>
    
	<!-- Google font -->
	<link href="https://fonts.googleapis.com/css2?family=Varela+Round&display=swap" rel="stylesheet"/>

	<!-- Bootstrap -->
	<link href="bootstrap-5.0.1-dist/css/bootstrap.min.css" rel="stylesheet" runat="server"/>
    <link href="Resources/sidebars.css" rel="stylesheet" runat="server"/>
    <link rel="stylesheet" href="Resources/assets/css/main_custom.css" runat="server"/>
    <link href="Resources/proyecto.css" rel="stylesheet" runat="server"/>

	<!-- Custom stlylesheet -->
	<link type="text/css" rel="stylesheet" href="css/style.css" />
	<link type="text/css" rel="stylesheet" href="navbar.css" />
</head>
<body>
    <nav class="navbar fixed-top navbar-dark bg-dark">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">V-Vuelos</a>
            <form class="d-flex">
                <button type="button" class="btn btn-outline-primary">Crear Cuenta</button>
                <button type="button" class="btn btn-outline-primary">Accesar a cuenta</button>
                <button type="button" class="btn btn-primary">V-Vuelos Backend</button>
            </form>
        </div>
    </nav>
    <div id="booking" class="section">
        <div class="section-center">
            <div class="container">
                <div class="row">
                    <div class="col-md-7 col-md-push-5">
                        <div class="booking-cta">
                            <h1>V-Vuelos</h1>
                            <div class="input-group">
                                <input type="search" class="form-control rounded" placeholder="Search"
                                    aria-label="Search" aria-describedby="search-addon" />
                                <button type="button" class="btn btn-outline-primary">Search</button>
                            </div>
                        </div>
                    </div>
                    <div>
                        <div class="col-md-4 col-md-pull-7">
                            <div class="booking-form">
                                <form>
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <span class="form-label">Fecha de Salida</span>
                                                <input class="form-control" type="date" required>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col-sm-6">
                                            <div class="form-group">
                                                <span class="form-label">Fecha de Regreso</span>
                                                <input class="form-control" type="date" required>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-btn">
                                        <button class="submit-btn">Buscar</button>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="booking" class="section">
        <div class="section-center">
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
                                <form>
                                    <table class="table">
                                        <thead class="table-dark">
                                            <tr>
                                                <th scope="col">Vuelo</th>
                                                <th scope="col">Aerolinea</th>
                                                <th scope="col">Procedencia</th>
                                                <th scope="col">Fecha</th>
                                                <th scope="col">Hora</th>
                                                <th scope="col">Estado</th>
                                                <th scope="col">Puerta</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <th scope="col">CM-796</th>
                                                <th scope="col">COPA</th>
                                                <th scope="col">San Pedro</th>
                                                <th scope="col">06/01/21</th>
                                                <th scope="col">4:50pm</th>
                                                <th scope="col">Arribo</th>
                                                <th scope="col">10</th>
                                            </tr>
                                            <tr>
                                                <th scope="col">LR-698</th>
                                                <th scope="col">LACSA</th>
                                                <th scope="col">Panama</th>
                                                <th scope="col">06/01/21</th>
                                                <th scope="col">5:05pm</th>
                                                <th scope="col">Arribo</th>
                                                <th scope="col">4</th>
                                            </tr>
                                        </tbody>
                                    </table>

                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="booking" class="section">
        <div class="section-center">
            <div class="container">
                <div class="row">
                    <div class="col-md-7 col-md-push-5">
                        <div class="booking-cta">
                            <h1>Salidas de Vuelos</h1>
                        </div>
                    </div>
                    <div>
                        <div class="col-md-15 col-md-pull-17">
                            <div class="booking-form">
                                <form>
                                    <table class="table">
                                        <thead class="table-dark">
                                            <tr>
                                                <th scope="col">Vuelo</th>
                                                <th scope="col">Aerolinea</th>
                                                <th scope="col">Procedencia</th>
                                                <th scope="col">Fecha</th>
                                                <th scope="col">Hora</th>
                                                <th scope="col">Estado</th>
                                                <th scope="col">Puerta</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <th scope="col">CM-796</th>
                                                <th scope="col">COPA</th>
                                                <th scope="col">San Pedro</th>
                                                <th scope="col">06/01/21</th>
                                                <th scope="col">4:50pm</th>
                                                <th scope="col">Arribo</th>
                                                <th scope="col">10</th>
                                            </tr>
                                            <tr>
                                                <th scope="col">LR-698</th>
                                                <th scope="col">LACSA</th>
                                                <th scope="col">Panama</th>
                                                <th scope="col">06/01/21</th>
                                                <th scope="col">5:05pm</th>
                                                <th scope="col">Arribo</th>
                                                <th scope="col">4</th>
                                            </tr>
                                        </tbody>
                                    </table>

                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
