<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Docente.aspx.cs" Inherits="Login.privado.Docente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    
<meta charset="utf-8" />
<meta http-equiv="X-UA-Compatible" content="IE=edge" />
<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
<meta name="description" content="" />
<meta name="author" content="" />
<title>Panel de Control - Virgen de Fátima</title>
<link href="https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css" rel="stylesheet" />
<link href="/css/styles.css" rel="stylesheet" />
<script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
    
</head>
<body>

    <nav class="sb-topnav navbar navbar-expand navbar-dark bg-dark">
            <!-- Navbar Brand-->
            <a class="navbar-brand ps-3" href="index.html">I.E. Virgen de Fátima</a>
            <!-- Sidebar Toggle-->
            <button class="btn btn-link btn-sm order-1 order-lg-0 me-4 me-lg-0" id="sidebarToggle" href="#!"><i class="fas fa-bars"></i></button>
            <!-- Navbar Search-->
            
            <!-- Navbar-->
            <ul class="navbar-nav ms-auto ms-md-0 me-3 me-lg-4">
                <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle" id="navbarDropdown" href="#" role="button" data-bs-toggle="dropdown" aria-expanded="false"><i class="fas fa-user fa-fw"></i></a>
                    <ul class="dropdown-menu dropdown-menu-end" aria-labelledby="navbarDropdown">
                        <li><a class="dropdown-item" href="#!">Settings</a></li>
                        <li><a class="dropdown-item" href="#!">Activity Log</a></li>
                        <li>
                            <hr class="dropdown-divider" />
                        </li>
                        <li><a class="dropdown-item" href="#!">Logout</a></li>
                    </ul>
                </li>
            </ul>
     </nav>

    <div id="layoutSidenav">
            <div id="layoutSidenav_nav">
                <nav class="sb-sidenav accordion sb-sidenav-dark" id="sidenavAccordion">
                    <div class="sb-sidenav-menu">
                        <div class="nav">
                            <div class="sb-sidenav-menu-heading">Inicio</div>

                            <a class="nav-link" href="segunda.aspx">
                                <div class="sb-nav-link-icon"><i class="fas fa-tachometer-alt"></i></div>
                                Tablero
                            </a>

                            <div class="sb-sidenav-menu-heading">Menú</div>
                            <a class="nav-link collapsed" href="#collapseLayouts" data-bs-toggle="collapse" data-bs-target="#collapseLayouts" aria-expanded="false" aria-controls="collapseLayouts">
                                <div class="sb-nav-link-icon"><i class="fas fa-columns"></i></div>
                                Estudiantes
                                <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                            </a>

                            <div class="collapse" id="collapseLayouts" aria-labelledby="headingOne" data-bs-parent="#sidenavAccordion">
                                <nav class="sb-sidenav-menu-nested nav">
                                    <a class="nav-link" href="Estudiante.aspx">Registro de Estudiante</a>
                                    <a class="nav-link" href="Deficit.aspx">Deficit</a>
                                    <a class="nav-link" href="Diagnostico.aspx">Diagnostico</a>
                                </nav>
                            </div>
                            <a class="nav-link collapsed" href="#" data-bs-toggle="collapse" data-bs-target="#collapsePages" aria-expanded="false" aria-controls="collapsePages">
                                <div class="sb-nav-link-icon"><i class="fas fa-book-open"></i></div>
                                Docentes
                                <div class="sb-sidenav-collapse-arrow"><i class="fas fa-angle-down"></i></div>
                            </a>

                            <div class="collapse" id="collapsePages" aria-labelledby="headingTwo" data-bs-parent="#sidenavAccordion">
                                <nav class="sb-sidenav-menu-nested nav accordion" id="sidenavAccordionPages">
                                    <a class="nav-link" href="Docente.aspx">
                                        <div class="sb-nav-link-icon"><i class="fas fa-chart-area"></i></div>
                                        Registro
                                    </a>
                                </nav>
                            </div>
                            <div class="sb-sidenav-menu-heading">Detalles</div>
                            <a class="nav-link" href="EstudiantesView.aspx" data-bs-target="#lista">
                                <div class="sb-nav-link-icon"><i class="fas fa-table"></i></div>
                                Listado de Tablas
                            </a>
                        </div>
                    </div>
                    <div class="sb-sidenav-footer">
                    </div>
                </nav>
            </div>
        <!--INICIO-->
        <div id="layoutSidenav_content">
            <main>
                <div class="container-fluid px-4">
                    <h1 class="mt-4">REGISTRO DE DOCENTES</h1>
                    <ol class="breadcrumb mb-4">
                        <li class="breadcrumb-item active">En este apartado introduzca sus datos personales</li>
                    </ol>

                    <div class="card mb-4">
                        <div class="card-header">
                            <form id="form1" runat="server">
                                <div>
                                    <p>
                                        Buscar:
                                        <asp:TextBox runat="server" ID="txtBuscar" />
                                        <asp:DropDownList ID="ddlCriterio" runat="server" OnSelectedIndexChanged="ddlCriterio_SelectedIndexChanged">
                                            <asp:ListItem Text="<seleccione>" />
                                            <asp:ListItem Text="codDocente" />
                                            <asp:ListItem Text="Apellidos" />
                                            <asp:ListItem Text="Nombres" />
                                            <asp:ListItem Text="DNI" />
                                            <asp:ListItem Text="correo" />
                                            <asp:ListItem Text="celular" />
                                            <asp:ListItem Text="FechaNac" />
                                            <asp:ListItem Text="Direccion" />
                                            <asp:ListItem Text="Genero" />
                                            <asp:ListItem Text="codInstitucion" />
                                            <asp:ListItem Text="codAdmin" />
                                        </asp:DropDownList>

                                        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />

                                    </p>
                                    <p>
                                        CodDocente :
                                        <asp:TextBox runat="server" ID="txtCodDocente" />
                                        <p>
                                            Apellidos :
                                            <asp:TextBox runat="server" ID="txtApellidos" />
                                            <p>Nombres:
                                                <asp:TextBox runat="server" ID="txtNombres" /></p>
                                            <p>Dni :
                                                <asp:TextBox runat="server" ID="txtDNI" /></p>
                                            <p>Correo :
                                                <asp:TextBox runat="server" ID="txtCorreo" /></p>
                                            <p>celular :
                                                <asp:TextBox runat="server" ID="txtCelular" /></p>
                                            <p>fechaNac:
                                                <asp:TextBox runat="server" ID="fechaNac" /></p>
                                            <p>Direccion :
                                                <asp:TextBox runat="server" ID="txtDireccion" Width="230px" /></p>
                                            <p>Genero :
                                                <asp:TextBox runat="server" ID="txtGenero" /></p>
                                            <p>codInstitucion:
                                                <asp:TextBox runat="server" ID="txtCodInstitucion" /></p>
                                            <p>codAdmin:
                                                <asp:TextBox runat="server" ID="txtCodAdmin" /></p>
                                            <p>
                                                <asp:Button Text="Agregar" runat="server" ID="btnAgregar" OnClick="btnAgregar_Click" />
                                                <asp:Button Text="Eliminar" runat="server" ID="btnEliminar" OnClick="btnEliminar_Click" />
                                                <asp:Button Text="Actualizar" runat="server" ID="btnActualizar" OnClick="btnActualizar_Click" />
                                            </p>
                                            <p>
                                                <asp:GridView runat="server" ID="gvDocente" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                                                    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                                    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                                    <RowStyle BackColor="White" ForeColor="#330099" />
                                                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                                    <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                                    <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                                    <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                                    <SortedDescendingHeaderStyle BackColor="#7E0000" />
                                                </asp:GridView>
                                            </p>
                                </div>
                            </form>
                        </div>
                    </div>
            </main>

            <footer class="py-4 bg-light mt-auto">
                <div class="container-fluid px-4">
                    <div class="d-flex align-items-center justify-content-between small">
                        <div class="text-muted">Copyright &copy; Isekai XD</div>
                        <div>
                            <a href="#">Politicas de Privacidad</a>
                            &middot;
                                <a href="#">Terminos &amp; Condiciones</a>
                        </div>
                    </div>
                </div>
            </footer>
        </div>
        <!--FIN-->

    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="/js/scripts.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
        <script src="/assets/demo/chart-area-demo.js"></script>
        <script src="/assets/demo/chart-bar-demo.js"></script>
        <script src="https://cdn.jsdelivr.net/npm/simple-datatables@latest" crossorigin="anonymous"></script>
        <script src="/js/datatables-simple-demo.js"></script>

</body>
</html>
