<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Record-cliente.aspx.cs" Inherits="Pages_Record_cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
    <form id="Form1" runat ="server">
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
                   <!-- <li class="header">Menú Principal</li> -->
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
            <div class="card">
             <h2>Historial de examenes</h2>
            <div class="block-header">
               
                <div class="block-header">
                    <asp:GridView ID="GridViewRecord" class="table" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" >
                        <Columns>
                            <asp:BoundField DataField="Grade" HeaderText="Nota" SortExpression="Grade" />
                            <asp:BoundField DataField="ID_Test" HeaderText="Examen" SortExpression="ID_Test" />
                        </Columns>
                    </asp:GridView>
                
                  
                       
                
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TRAINT-ITConnectionString %>" SelectCommand="SELECT [Grade], [ID_Test] FROM [Record] WHERE ([ID] = @ID)">
                        <SelectParameters>
                            <asp:SessionParameter DefaultValue="" Name="ID" SessionField="User_id" Type="Decimal" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                
                  
                       
                
                    </div>
                </div>
            </div>
        </div>
    </section>
    </form>


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
</body>
</html>
