<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Nota-cliente.aspx.cs" Inherits="Pages_Nota_cliente" %>

<!DOCTYPE html>

<head runat="server">
 <meta charset="UTF-8">
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <title>Train-it</title>
    <!-- Favicon-->
    <link rel="icon" href="../../favicon.ico" type="image/x-icon">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,700&subset=latin,cyrillic-ext" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" type="text/css">

    <!-- Bootstrap Core Css -->
    <link href="../../plugins/bootstrap/css/bootstrap.css" rel="stylesheet">

    <!-- Waves Effect Css -->
    <link href="../../plugins/node-waves/waves.css" rel="stylesheet" />

    <!-- Animation Css -->
    <link href="../../plugins/animate-css/animate.css" rel="stylesheet" />

    <!-- Custom Css -->
    <link href="../../css/style.css" rel="stylesheet">

    <!-- AdminBSB Themes. You can choose a theme from css/themes instead of get all themes -->
    <link href="../../css/themes/all-themes.css" rel="stylesheet" />
</head>

<body class="theme-cyan">
    <form id="Form1" runat="server">

    <!-- Page Loader -->
   <div class="page-loader-wrapper">
        <div class="loader">
            <div class="preloader">
                <div class="spinner-layer pl-cyan">
                    <div class="circle-clipper left">
                        <div class="circle"></div>
                    </div>
                    <div class="circle-clipper right">
                        <div class="circle"></div>
                    </div>
                </div>
            </div>
            
        </div>
    </div>
        
    <!-- #END# Page Loader -->
    <!-- Overlay For Sidebars -->
    <div class="overlay"></div>
    <!-- #END# Overlay For Sidebars -->
   
    <!-- #END# Search Bar -->
    <!-- Top Bar -->
    <nav class="navbar bg-cyan">
        <div class="container-fluid">
            <div class="navbar-header" >
                <a href="javascript:void(0);" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar-collapse" aria-expanded="false"></a>
                <a href="javascript:void(0);" class="bars"></a>
            <a > <img src="../Images/Train-it (1).png" class="img" width=230px /> </a> 
          
            </div>
            <div class="collapse navbar-collapse" id="navbar-collapse">
                
                <ul class="nav navbar-nav navbar-right">
                     <li class="header">
                                          
                                    <a  class="btn bg-cyan waves-effect" href="Sign-in.aspx"  >
                                        
                                    <i class="material-icons">exit_to_app</i>
                                       
                                        </a>
                      
                                              
                </li>
                    </ul>
                    <!-- #END# Notifications -->
                    <!-- Tasks -->
                    
                    
            </div>
        </div>
    </nav>
    <!-- #Top Bar -->
    <section>
        <!-- Left Sidebar -->
        <aside id="leftsidebar" class="sidebar">
            
            <!-- Menu -->
            <div class="menu">
                <ul class="list">
                    <br />
                    <!--<li class="header">Menú Principal</li> -->
                    <li class="active">
                        <a href="Index-cliente.aspx">
                            <i class="material-icons">home</i>
                            <span >Página Principal</span>
                        </a>
                    </li>
                    <li>
                        <a href="Record-cliente.aspx">
                            <i class="material-icons">description</i>
                            <span>Historial de pruebas</span>
                        </a>
                    </li>

                     <li>
                        <a href="Info-cliente.aspx">
                            <i class="material-icons">face </i>
                            <span>Información Personal</span>
                        </a>
                    </li>
                   
                  
                </ul>
            </div>
            <!-- #Menu -->
           
        </aside>
        <!-- #END# Left Sidebar -->
        <!-- Right Sidebar -->
     
        <!-- #END# Right Sidebar -->
    </section>
    
    <section class="content">
        <div class="container-fluid">
    <div class="block-header">
                <div class="col-xs-12 col-sm-12 ">
                    <div class="card">
                        <div class="body bg-gray">
                            <div class="font-bold m-b--35">Calificiación obtenida</div>
                            <ul class="dashboard-stat-list">
                                 
                                <li>
                                   <asp:Label ID="LblCod" runat="server" Text="Código de la Prueba" ></asp:Label>
                                     <span class="pull-right">
                                    <asp:Label ID="LblCodTxt" runat="server" Text=""></asp:Label>
                                         </span>

                                </li>
                                <li>
                                   <asp:Label ID="LblNom" runat="server" Text="ID del estudiante" ></asp:Label>
                                     <span class="pull-right">
                                    <asp:Label ID="LblNomTex" runat="server" Text=""></asp:Label>
                                         </span>
                                </li>
                                <li>
                                     <asp:Label ID="LblCac" runat="server" Text="Calificación" ></asp:Label>
                                     <span class="pull-right">
                                    <asp:Label ID="LblCacTex" runat="server" Text=""></asp:Label>
                                         </span>
                                </li>
                               
                                <li>
                                 <span class="pull-right">
                                <asp:Button ID="BttnNota" runat="server" Text="Volver al inicio" CssClass=" btn bg-cyan" OnClick="BttnNota_Click"/>
                                      </span>
                                    </li>
                            </ul>

                        </div>
                    </div>
                </div>
            </div>

    <div class="col-xs-12 col-sm-12 ">
                    <div class="card">
                        <div class="body bg-gray">
                            <div class="font-bold m-b--35">Respuestas de la Prueba</div>
                            <br />
                           
                            <asp:GridView ID="GridViewRespuestas" runat="server" CssClass="table-responsive" DataSourceID="ObjectDataSource1"></asp:GridView> 
                            
                            <br />
                            <br />
                            <h4>Subscribirse a Premiun para obtener mas preguntas</h4>
                            <asp:Button ID="BttnLinkPremiun" runat="server" Text="Subscribirse"  CssClass="btn bg-cyan" OnClick="BttnLinkPremiun_Click"/>
                            

                        </div>
                    </div>
                </div>
          
            </div>
      
    </section>

    <!-- Jquery Core Js -->
    <script src="../../plugins/jquery/jquery.min.js"></script>

    <!-- Bootstrap Core Js -->
    <script src="../../plugins/bootstrap/js/bootstrap.js"></script>

    <!-- Select Plugin Js -->
    <script src="../../plugins/bootstrap-select/js/bootstrap-select.js"></script>

    <!-- Slimscroll Plugin Js -->
    <script src="../../plugins/jquery-slimscroll/jquery.slimscroll.js"></script>

    <!-- Waves Effect Plugin Js -->
    <script src="../../plugins/node-waves/waves.js"></script>

    <!-- Custom Js -->
    <script src="../../js/admin.js"></script>

    <!-- Demo Js -->
    <script src="../../js/demo.js"></script>
        </form>
</body>
</html>
