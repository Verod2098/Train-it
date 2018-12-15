<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Info-cliente.aspx.cs" Inherits="Pages_Info_cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="UTF-8"/>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport"/>
    <title>Train-it</title>
    <!-- Favicon-->
    <link rel="icon" href="../../favicon.ico" type="image/x-icon"/>

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,700&subset=latin,cyrillic-ext" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" type="text/css"/>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" type="text/css"/>

    <!-- Bootstrap Core Css -->
    <link href="../../plugins/bootstrap/css/bootstrap.css" rel="stylesheet"/>

    <!-- Waves Effect Css -->
    <link href="../../plugins/node-waves/waves.css" rel="stylesheet" />

    <!-- Animation Css -->
    <link href="../../plugins/animate-css/animate.css" rel="stylesheet" />

    <!-- Custom Css -->
    <link href="../../css/style.css" rel="stylesheet"/>

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
            <!--Insertar Codigo-->
            <div class="block-header">
                   <div class="card">
                        <div class="body bg-gray">
                            <div class="h1">Información Personal</div>
                            <ul class="dashboard-stat-list col-md-">

                                <li>

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="Txt_NombreText" class="form-control" runat ="server"  ></asp:TextBox>
                                            <label class="form-label">Nombre </label>
                                        </div>
                                    </div>
                                 </li>

                                <li>
                                      <div class="form-group form-float">
                                        <div class="form-line focused">
                                                 <asp:TextBox ID="Txt_Fecha" runat="server"  CssClass="form-control dtp-date" >
                                                     </asp:TextBox>
                                            <label class="form-label">Fecha de Nacimiento</label>
                                        </div>
                                    </div>
                                         </li>
                                  <li>
                                      <div class="form-group form-float">
                                        <div class="form-line focused">
                                                 <asp:TextBox ID="Txtphone" runat="server"  CssClass="form-control glyphicon-phone" >
                                                     </asp:TextBox>
                                            <label class="form-label">Número de Teléfono</label>
                                        </div>
                                    </div>
                                         </li>

                                 <li>
                                      <div class="form-group form-float">
                                        <div class="form-line focused">
                                                 <asp:TextBox ID="TxtJob" runat="server"  CssClass="form-control" >
                                                     </asp:TextBox>
                                            <label class="form-label">Ocupación</label>
                                        </div>
                                    </div>
                                         </li>

                                 <li>
                                      <div class="form-group form-float">
                                        <div class="form-line focused">
                                                 <asp:TextBox ID="TxtCentroEducativo" runat="server"  CssClass="form-control" >
                                                     </asp:TextBox>
                                            <label class="form-label">Centro Educativo o Lugar de Trabajo</label>
                                        </div>
                                    </div>
                                         </li>
                             
                                <li>

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                                 <asp:TextBox ID="Txt_correo" runat="server"  class="form-control" TextMode="Email"></asp:TextBox>
                                                     
                                            <label class="form-label">Correo electrónico</label>
                                        </div>
                                    </div>
                                   
                                </li>

                                

                                              
                                                    <li>
                                      <div class="form-group form-float col-sm-3">
                                        

                                                     
                                            <label class="col-sm-3">Tipo de Cuenta</label> 
                                          
                                                <asp:label id="Labeltipe"  runat="server">    </asp:label> 
                                          <asp:Button ID="UpgradeButton" runat="server" Cssclass="btn-success" Text="Cambio de plan" OnClick="UpgradeButton_Click"/>

                                        
                                    
                                         
       
                                                 
                 
                      <span class="pull-right">
                    <asp:Button ID="BttnUdate" runat="server" Text="Modificar"  CssClass="btn primary bg-cyan" OnClick="BttnUdate_Click" />
                          <asp:Button ID="BttnnoActive" runat="server" Text="Desactivar Cuenta"  CssClass="btn primary bg-cyan" OnClick="BttnnoActive_Click" />

                          </span>

                                         
                 </li>


                </ul>
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