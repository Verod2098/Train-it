<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pregunta-admin.aspx.cs" Inherits="Pages_Pregunta_admin" %>

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
                            <div class="font-bold m-b--35">Agregar Preguntas</div>
                            <ul class="dashboard-stat-list ">

                                <li class="col-sm-5 ">


                                   <div class="form-group form-float ">
                                        <div class="form-line focused ">
                                            <asp:TextBox ID="txt_Nump" class="form-control" runat ="server"  >     </asp:TextBox>
                                            <label class="form-label">Número de la pregunta   </label>
                                        </div>
                                    </div>
                                 </li>

                             <li class="col-sm-5 ">
                                      <div class="form-group form-float">
                                        <div class="form-line focused">
                                                 <asp:TextBox ID="txt_pregunta" runat="server"  CssClass="form-control">
                                                     </asp:TextBox>
                                            <label class="form-label">Pregunta</label>
                                        </div>
                                    </div>
                                         </li>
                              <li  class="col-sm-5 ">

                                  <div class="form-line focused">
                                                 
                                            <label class="form-label">Imagen para la pregunta</label>
                                      <asp:FileUpload ID="image" runat="server" class="file"/>
                                        </div>

                                  </li>

                                <li  class="col-sm-5 ">

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="txt_RN1" class="form-control" runat ="server"  ></asp:TextBox>
                                            <label class="form-label">Respuesta Negativa 1</label>
                                        </div>
                                    </div>
                                 </li>

                                <li  class="col-sm-5 ">


                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="txt_RN2" class="form-control" runat ="server"  ></asp:TextBox>
                                            <label class="form-label">Respuesta Negativa 2</label>
                                        </div>
                                    </div>
                                 </li>

                                                       <li  class="col-sm-5 ">

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="txt_RN3" class="form-control" runat ="server"  ></asp:TextBox>
                                            <label class="form-label">Respuesta Negativa 3</label>
                                        </div>
                                    </div>
                                 </li>

                                                       <li class="col-sm-5 ">

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="txt_RA" class="form-control" runat ="server"  ></asp:TextBox>
                                            <label class="form-label">Respuesta Afirmativa</label>
                                        </div>
                                    </div>
                                 </li>

                                                       <li  class="col-sm-5 ">

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <label class="form-label">Tipo de pregunta</label>
                                            <asp:DropDownList ID="DDLTipoPregunta" runat="server" class="dropdown-animated">
                                                <asp:ListItem>Si/No</asp:ListItem>
                                                <asp:ListItem>Falso/Verdadero</asp:ListItem>
                                                <asp:ListItem>Respuesta Multiple</asp:ListItem>
                                                <asp:ListItem></asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                 </li>

                                                       <li  class="col-sm-5 ">

                                    <div class="form-group form-float">
                                        <div class="form-line focused">
                                            <asp:TextBox ID="txt_Porcentaje" class="form-control" runat ="server"  ></asp:TextBox>
                                            <label class="form-label">Porcentaje</label>
                                        </div>
                                    </div>
                                 </li>

                                                       <li  class="col-sm-5 ">

                                    <div class="form-group form-float">
                                            <label class="form-label">Prueba a la que pertenece</label>
                                            <asp:DropDownList ID="DropDownListCodPrueba" runat="server"  class="dropdown-animated" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="ID"></asp:DropDownList>
                                       
                                    
                                                           <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TRAINT-ITConnectionString %>" SelectCommand="SELECT [ID], [Name] FROM [Test]"></asp:SqlDataSource>
                                       
                                    </div>
                                 </li>

                                                       <li  class="col-sm-5 ">

                                 
                                            <label class="form-label">Código del tema</label>
                                            <asp:DropDownList ID="DropDownListCodTema" runat="server"  class="dropdown-animated" DataSourceID="SqlDataSource1" DataTextField="Topic" DataValueField="Id"></asp:DropDownList>
                                       
                                   
                                                           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TRAINT-ITConnectionString %>" SelectCommand="SELECT * FROM [Topic_Question]"></asp:SqlDataSource>
                                       
                                   
                                 </li>
                
                 <li  class="col-sm-5 ">
                      <span class="pull-right">
                    <asp:Button ID="BttnAdd" runat="server" Text="Agregar"  CssClass=" btn bg-cyan" OnClick="BttnAdd_Click"/>
                          <asp:Button ID="BttnDel" runat="server" Text="Eliminar"  CssClass=" btn bg-cyan" OnClick="BttnDel_Click" style="height: 35px"/>
                          <asp:Button ID="BttnUp" runat="server" Text="Actualizar"  CssClass=" btn bg-cyan" OnClick="BttnUp_Click"/>
                          </span>
                 </li>
                                </ul>
                              <br />  
                            <br />
                            <div >

                                   
                                   <div class="font-bold m-b--35 ">     </div>
                                       <br />
                                       <br />
                                
                                    <asp:GridView ID="GridViewPregunta" runat="server" CssClass="table-responsive" AutoGenerateColumns="False" DataSourceID="SqlDataSource3">
                                        <Columns>
                                            <asp:BoundField DataField="Id_Questions" HeaderText="ID" SortExpression="Id_Questions" />
                                            <asp:BoundField DataField="Question" HeaderText="Pregunta" SortExpression="Question" />
                                            <asp:BoundField DataField="Percentaje" HeaderText="Porcentaje" SortExpression="Percentaje" />
                                            <asp:BoundField DataField="Correct_Answer" HeaderText="Respuesta Correcta" SortExpression="Correct_Answer" />
                                            <asp:BoundField DataField="Bad_Answer1" HeaderText="Respuesta Negativa 1 " SortExpression="Bad_Answer1" />
                                            <asp:BoundField DataField="Bad_Answer2" HeaderText="Respuesta Negativa 2" SortExpression="Bad_Answer2" />
                                            <asp:BoundField DataField="Bad_Answer3" HeaderText="Respuesta Negativa 3" SortExpression="Bad_Answer3" />
                                            <asp:BoundField DataField="Type_Question" HeaderText="Tipo" SortExpression="Type_Question" />
                                            <asp:BoundField DataField="Image" HeaderText="Imagen" SortExpression="Image" />
                                            <asp:BoundField DataField="Name" HeaderText="Prueba a la que pertenece" SortExpression="Name" />
                                            <asp:BoundField DataField="Topic" HeaderText="Tema " SortExpression="Topic" />
                                            <asp:BoundField DataField="Name1" HeaderText="Creada por" SortExpression="Name1" />
                                        </Columns>
                                    </asp:GridView>
             
                                   <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:TRAINT-ITConnectionString %>" SelectCommand="SELECT Question.Id_Questions, Question.Question, Question.Percentaje, Question.Correct_Answer, Question.Bad_Answer1, Question.Bad_Answer2, Question.Bad_Answer3, Question.Type_Question, Question.Image, Test.Name, Topic_Question.Topic, [User].Name FROM Question INNER JOIN Test ON Question.ID_Test = Test.ID INNER JOIN Topic_Question ON Question.ID_Topic = Topic_Question.Id INNER JOIN [User] ON Question.ID_Creator = [User].Id"></asp:SqlDataSource>
             
                                </div>
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
