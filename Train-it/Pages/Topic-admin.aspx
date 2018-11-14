<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Topic-admin.aspx.cs" Inherits="Pages_Topic_admin" %>



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
                         <li class="active">
                        <a href="Index-admin.aspx">
                            <i class="material-icons">home</i>
                            <span>Página Principal</span>
                        </a>
                    </li>
                    <li>
                        <a href="Prueba-Admin.aspx">
                            <i class="material-icons">description</i>
                            <span>Agregar Prueba</span>
                        </a>
                    </li>
                    <li>
                        <a href="Pregunta-Admin.aspx">
                            <i class="material-icons">help_outline</i>
                            <span>Preguntas</span>
                        </a>
                    </li>
                    <li>
                        <a href="Usuario-Admin.aspx">
                            <i class="material-icons">face</i>
                            <span>Creación de usuarios</span>
                        </a>
                      
                    </li>

                     <li>
                        <a href="Topic-Admin.aspx">
                            <i class="material-icons">edit</i>
                            <span>Agregar Temas</span>
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
                            <div class="font-bold m-b--35">Agregar tema para prueba</div>
                            <ul class="dashboard-stat-list">

                                <li>

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="txt_codtemapru" class="form-control" runat ="server"  ></asp:TextBox>
                                            <label class="form-label">Codigo del tema</label>
                                        </div>
                                    </div>
                                 </li>

                                <li>
                                      <div class="form-group form-float">
                                        <div class="form-line focused">
                                                 <asp:TextBox ID="txtNombretemapru" runat="server"  CssClass="form-control">
                                                     </asp:TextBox>
                                            <label class="form-label">Nombre del tema</label>
                                        </div>
                                    </div>
                                         </li>
                              <li>

                                  <li>
                      <span class="pull-right">
                    <asp:Button ID="BttnAddpru" runat="server" Text="Agregar"  CssClass=" btn bg-cyan"  style="left: 7px; top: -4px" OnClick="BttnAddpru_Click"/>
                          <asp:Button ID="BttnUPptu" runat="server" Text="Actualizar"  CssClass=" btn bg-cyan" style="left: 7px; top: -4px" OnClick="BttnUPptu_Click"/>
                          <asp:Button ID="BttnDELpru" runat="server" Text="Eliminar"  CssClass=" btn bg-cyan" style="left: 7px; top: -4px" OnClick="BttnDELpru_Click"/>
                           
                          </span>
                 </li>
                                <br />
                                
                                </ul>
                               
                                    <div >

                                   
                                   <div class="font-bold m-b--35"> Temas Agregados </div>
                                       <br />
                                       <br />
                                    <asp:GridView ID="GridViewTopic" runat="server" CssClass="table" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2" >
                                        <Columns>
                                            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ReadOnly="True" />
                                            <asp:BoundField DataField="Topic" HeaderText="Topic" SortExpression="Topic" />
                                        </Columns>
                                     
                                    </asp:GridView>
                                    
                                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=DELL\SQLEXPRESS;Initial Catalog=TRAINT-IT;Persist Security Info=True;User ID=Vero;Password=123" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Topic_Test]"></asp:SqlDataSource>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DELL\SQLEXPRESS;Initial Catalog=TRAINT-IT;Persist Security Info=True;User ID=Vero;Password=123" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Topic_Question]"></asp:SqlDataSource>
                                    
                </div>
              
                               
               
         </div>
            </div>

                  <div class="card">
                        <div class="body bg-gray">
                            <div class="font-bold m-b--35">Agregar tema para pregunta</div>
                            <ul class="dashboard-stat-list">

                                <li>

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="Txtcodtemapre" class="form-control" runat ="server"  ></asp:TextBox>
                                            <label class="form-label">Codigo del tema</label>
                                        </div>
                                    </div>
                                 </li>

                                <li>
                                      <div class="form-group form-float">
                                        <div class="form-line focused">
                                                 <asp:TextBox ID="Txtnombretemapre" runat="server"  CssClass="form-control">
                                                     </asp:TextBox>
                                            <label class="form-label">Nombre del tema</label>
                                        </div>
                                    </div>
                                         </li>
                              <li>

                                  <li>
                      <span class="pull-right">
                    <asp:Button ID="BttnAddpre" runat="server" Text="Agregar"  CssClass=" btn bg-cyan" style="left: 7px; top: -4px" OnClick="BttnAddpre_Click"/>
                          <asp:Button ID="BttnUPpre" runat="server" Text="Actualizar"  CssClass=" btn bg-cyan" style="left: 7px; top: -4px" OnClick="BttnUPpre_Click"/>
                          <asp:Button ID="BttnDelPRe" runat="server" Text="Eliminar"  CssClass=" btn bg-cyan" style="left: 7px; top: -4px" OnClick="BttnDelPRe_Click"/>
                          
                          </span>
                 </li>
                                <br />
                                
                                </ul>
                               
                                    <div >

                                   
                                   <div class="font-bold m-b--35"> Temas Agregados </div>
                                       <br />
                                       <br />
                                    <asp:GridView ID="GridViewPre" runat="server" CssClass="table" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" >
                                        <Columns>
                                            <asp:BoundField DataField="Topic" HeaderText="Topic" SortExpression="Topic" />
                                            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                                        </Columns>
                                     
                                    </asp:GridView>
                                   
              
                               
               
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

        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <!-- Custom Js -->
    <script src="../../js/admin.js"></script>

    <!-- Demo Js -->
    <script src="../../js/demo.js"></script>
        </form>
</body>
</html>
