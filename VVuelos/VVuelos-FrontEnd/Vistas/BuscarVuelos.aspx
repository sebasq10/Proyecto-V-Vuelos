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
                        <asp:TextBox type="text" name="password" runat="server" ID="Destinotxt" class="input--style-1" placeholder="" />
                    </div>
                    <div class="input-group input--medium">
                        <label class="label">Fecha de Vuelo</label>
                        <asp:TextBox type="date" name="checkin" runat="server" ID="Fechatxt" class="input--style-1" placeholder="mm/dd/yyyy" />
                    </div>
                    <asp:Button class="btn-submit" ID="buscarVuelosbtn" runat="server" Text="Buscar!" OnClick="buscarVuelosbtn_Click" />
                </form>
            </div>
        </div>
        <div>
            <div class="col-md-15 col-md-pull-17">
                <div class="booking-form">
                    <asp:GridView ID="tabla_BuscarVuelos" AutoGenerateColumns="false" class="table" border="0" runat="server">
                        <HeaderStyle CssClass="table-primario-dark" />
                        <Columns>
                            <asp:BoundField DataField="Cod_Vuelo" HeaderText="Vuelo" />
                            <asp:BoundField DataField="Aerolinea" HeaderText="Aerolínea" />
                            <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="verificar_asientos" Text="Reservar" type="button" class="btn btn-success" runat="server" CommandArgument='<%# Eval("Cod_Vuelo") %>' OnClick="verificar_Asientos_Click"></asp:LinkButton>
<%--                                    <asp:LinkButton ID="reservar_Vuelo" Text="Reservar" type="button" class="btn btn-primary" runat="server" CommandArgument='<%# Eval("Cod_Vuelo") %>' data-bs-toggle="modal" data-bs-target="#exampleModal"></asp:LinkButton>
                                    <asp:LinkButton ID="comprar_Vuelo" Text="Comprar" type="button" class="btn btn-primary" runat="server" CommandArgument='<%# Eval("Cod_Vuelo") %>' data-bs-toggle="modal" data-bs-target="#exampleModal"></asp:LinkButton>--%>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>


                    <!-- Modal 1-->
                    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">Selección de Vuelo</h5>
                                    <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                                </div>
                                <div class="modal-body">
                                    <form>
                                        <div class="mb-3">
                                            <asp:Label ID="cantidadVueloslbl" runat="server" Text="Este vuelo tiene 69 asientos disponibles"></asp:Label>

                                        </div>
                                        <div class="mb-3">
                                            <label for="examplelabel" class="form-label">Cuantos asientos desea reservar?</label>
                                            <asp:TextBox runat="server" type="number" class="form-control" id="asientosReservarTxt" min="1"/>
                                        </div>
                                    </form>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button class="btn btn-secondary" ID="Button1" runat="server" Text="Cancelar" data-bs-dismiss="modal" />
                                    <asp:Button class="btn btn-primary" ID="Button2" runat="server" Text="Aceptar" OnClick="guardarAccion_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>