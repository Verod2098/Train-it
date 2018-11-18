<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sign-in.aspx.cs" Inherits="Pages_Sign_in" %>

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
        .auto-style1 {
            left: 0px;
            top: 0px;
        }
    </style>
</head>

<body class="login-page bg-cyan">
    
    <div class="login-box">
        <div class="logo">
            <a href="javascript:void(0);">Train-<b>IT</b></a>
            <small>Plataforma de exámenes en linea</small>
        </div>
        <div class="card">
            <div class="body">
                <form id="sign_in" method="POST" runat="server">
                    <div class="msg">Ingrese su información para acceder a la plataforma</div>
                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">person</i>
                        </span>
                        <div class="form-line">
                            <asp:TextBox ID="TxtUser" runat="server" CssClass="form-control" placeholder="Correo Electrónico" TextMode="Email"></asp:TextBox>
                             
                        </div>
                    </div>
                    <div class="input-group">
                        <span class="input-group-addon">
                            <i class="material-icons">lock</i>
                        </span>
                        <div class="form-line">
                               <asp:TextBox ID="TxtPassword" runat="server" class="form-control" name="password" placeholder="Contraseña"  TextMode="Password" ></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-4">
                            <asp:Button ID="BttnSign" runat="server" Text="Entrar" class="btn btn-block bg-light-green waves-effect" OnClick="BttnSign_Click" />
                  
                        </div>
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