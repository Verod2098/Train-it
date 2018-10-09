﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pregunta-Cliente.aspx.cs" Inherits="Pregunta_Cliente" %>

<!DOCTYPE html>

<head runat="server">
 <meta charset="UTF-8">
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <title>Train-it</title>
     <!--Pregunta css -->
    <link href="../../css/Pregunta.css" rel="stylesheet" />
    <!-- Favicon-->
    <link rel="icon" href="../../favicon.ico" type="image/x-icon">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,700&subset=latin,cyrillic-ext" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" type="text/css">

    <!-- Bootstrap Core Css -->
    <link href="../../plugins/bootstrap/css/bootstrap.css" rel="stylesheet">
    <link rel=stylesheet href="https://s3-us-west-2.amazonaws.com/colors-css/2.2.0/colors.min.css">

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
    <form id="Form" runat="server">
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
                    <li class="header">Menú Principal</li>
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
                        <a href="Record-cliente.aspx">
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
                <div class="quiz" id="quiz" data-toggle="buttons">
                       <div class="modal-dialog">
      <div class="modal-content">
          <asp:ScriptManager ID="ScriptManager1"
                               runat="server" />
            <asp:Panel ID="Panel1"
                       GroupingText="Preguntas de la prueba"
                       runat="server">
                <asp:UpdatePanel ID="UpdatePanel1"
                                 UpdateMode="Conditional"
                                 runat="server">
                    <ContentTemplate>
                           <asp:Label ID="LblPregunta" runat="server" Text="" CssClass="labelpregunta"></asp:Label>
                            <asp:Button ID="Button_Q1" class="element-animation1 btn btn-lg  btn-block bg-navy" runat="server" ></asp:Button>
                            <asp:Button ID="Button_Q2" class="element-animation1 btn btn-lg  btn-block bg-navy" runat="server" ></asp:Button>
                            <asp:Button ID="Button_Q3" class="element-animation1 btn btn-lg  btn-block bg-navy" runat="server"></asp:Button>
                            <asp:Button ID="Button_Q4" class="element-animation1 btn btn-lg  btn-block bg-navy" runat="server"></asp:Button>
                    </ContentTemplate>
                </asp:UpdatePanel>
      </asp:Panel>
</div>
</div>
</div>
            </div>
        </div>
    </section>

    <!-- Jquery Core Js -->
    <script src="../../plugins/jquery/jquery.min.js"></script>

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
        <!--Pregunta JS-->
   <script src="../../js/Pregunta.js"></script>
        </form>
</body>
</html>