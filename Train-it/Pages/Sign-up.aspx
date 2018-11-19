﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sign-up.aspx.cs" Inherits="Pages_Sign_up" %>

<!DOCTYPE html>

<head runat="server">
 <meta charset="UTF-8">
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <title>Registro</title>
    <!-- Favicon-->
    <link rel="icon" href="../../favicon.ico" type="image/x-icon">

    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,700&subset=latin,cyrillic-ext" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" type="text/css">

    <!-- Bootstrap Core Css -->
    <link href="../../plugins/bootstrap/css/bootstrap.css" rel="stylesheet">

    <!-- Waves Effect Css -->
    <link href="../../plugins/node-waves/waves.css" rel="stylesheet" />

    <!-- Animation Css -->
    <link href="../../plugins/animate-css/animate.css" rel="stylesheet" />

    <!-- Custom Css -->
    <link href="../../css/style.css" rel="stylesheet">
    <style type="text/css">
        .auto-style2 {
            width: 444px;
            margin-left: 78px;
        }
        .auto-style3 {
            position: relative;
            min-height: 1px;
            float: left;
            width: 83.33333333%;
            left: -37px;
            top: 76px;
            padding-left: 15px;
            padding-right: 15px;
        }
    </style>
</head>

<body class="signup-page bg-cyan">
    
    <div class="signup-box">
        <div class="logo">
            &nbsp;<img src="../Images/Train-it%20(1).png" class="auto-style2"  /><br />
   
        </div>
         <div class="card">
            <div class="body">
                <form id="sign_up" method="POST" runat="server">
                    <div class="msg">Registre un nuevo usuario</div>

                    
                     <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">featured_play_list</i>
                        </span>
                        <div class="form-line">
                        <asp:TextBox ID="Txtid" runat="server" CssClass="form-control" placeholder="Cédula" ></asp:TextBox>
                        </div>
                    </div>

                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">person</i>
                        </span>
                        <div class="form-line">
                    <asp:TextBox ID="TxtName" runat="server" placeholder="Nombre" CssClass="form-control"  ></asp:TextBox>
                        </div>
                    </div>
                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">email</i>
                        </span>
                        <div class="form-line">
                        <asp:TextBox ID="TxtMail" runat="server" placeholder="Correo Electronico" CssClass="form-control" TextMode="Email" ></asp:TextBox>
                        </div>
                    </div>
                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">lock</i>
                        </span>
                        <div class="form-line">
                        <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Contraseña"  ></asp:TextBox>
                        </div>
                    </div>
                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">event_note</i>
                        </span>
                        <div class="form-line">
                        <asp:TextBox ID="Txtdate" runat="server" CssClass="form-control" placeholder="Fecha de nacimiento" TextMode="Date"></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">business_center</i>
                        </span>
                        <div class="form-line">
                        <asp:TextBox ID="TxtOcupation" runat="server" CssClass="form-control" placeholder="Ocupación" ></asp:TextBox>
                        </div>
                    </div>
                    
                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">place</i>
                        </span>
                        <div class="form-line">
                        <asp:TextBox ID="Txtplace" runat="server" CssClass="form-control" placeholder="Lugar de Ocupación" ></asp:TextBox>
                        </div>
                    </div>

                     <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">phone</i>
                        </span>
                        <div class="form-line">
                        <asp:TextBox ID="TxtPhone" runat="server" CssClass="form-control" placeholder="Teléfono" ></asp:TextBox>
                        </div>
                    </div>

                    <asp:Button ID="BttnSingup" runat="server" Text="Registrarse" class="btn btn-block btn-lg bg-cyan waves-effect" OnClick="BttnSingup_Click" />

                  

                    <div class="m-t-25 m-b--5 align-center">
                        <a href="sign-in.aspx">¿Ya se encuentra registrado?</a>
                    </div>
                </form>
            </div>
        </div>
    </div>
                     
      

    <!-- Jquery Core Js -->
    <script src="../../plugins/jquery/jquery.min.js"></script>

    <!-- Bootstrap Core Js -->
    <script src="../../plugins/bootstrap/js/bootstrap.js"></script>

    <!-- Waves Effect Plugin Js -->
    <script src="../../plugins/node-waves/waves.js"></script>

    <!-- Validation Plugin Js -->
    <script src="../../plugins/jquery-validation/jquery.validate.js"></script>

    <!-- Custom Js -->
    <script src="../../js/admin.js"></script>
    <script src="../../js/pages/examples/sign-in.js"></script>

 
     
</body>

</html>
