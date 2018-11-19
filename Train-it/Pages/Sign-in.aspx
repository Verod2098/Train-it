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

<body class="login-page bg-cyan">
    
    <div class="login-box">
        <div class="logo">
            &nbsp;<img src="../Images/Train-it%20(1).png" class="auto-style2"  /><br />
   
        </div>
        <div class="card">
            <div class="body">
                <form id="sign_in" method="POST" runat="server">
                    <div class="msg">Inicia sesión para comenzar</div>
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
                            <br />
                        </div>
                        
                        
                         <div class="auto-style3">
                                                  
                            <a href="sign-up.aspx">Registrese Ahora</a> 
                           
                            </div>
                            

                    </div>
                                            
                            <asp:Button ID="BttnSign" runat="server" Text="Entrar" class="btn bg-cyan" OnClick="BttnSign_Click" /> <a href="forgot-password.aspx">¿Olvido su contraseña?</a>
                            </div>
                    
                       
                   
                    
                    
                        <!--Boton Facebook-->
                       <!--<div class="fb-login-button" data-max-rows="1" data-size="large" data-button-type="login_with" data-show-faces="false" data-auto-logout-link="true" data-use-continue-as="true"></div>
                   -->
                     
       
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

   <!--Conectar con facebook SDK JS-->
    <!--
    <script>
  window.fbAsyncInit = function() {
    FB.init({
      appId      : '497495194086520',
      cookie     : true,
      xfbml      : true,
      version    : '3.2'
    });
      
    FB.AppEvents.logPageView();   
      
  };

  (function(d, s, id){
     var js, fjs = d.getElementsByTagName(s)[0];
     if (d.getElementById(id)) {return;}
     js = d.createElement(s); js.id = id;
     js.src = "https://connect.facebook.net/en_US/sdk.js";
     fjs.parentNode.insertBefore(js, fjs);
        }(document, 'script', 'facebook-jssdk'));

        function checkLoginState() {
  FB.getLoginStatus(function(response) {
    statusChangeCallback(response);
  });
}
</script>

    <div id="fb-root"></div>

<script>(function(d, s, id) {
  var js, fjs = d.getElementsByTagName(s)[0];
  if (d.getElementById(id)) return;
  js = d.createElement(s); js.id = id;
  js.src = 'https://connect.facebook.net/es_ES/sdk.js#xfbml=1&version=v3.2&appId=497495194086520&autoLogAppEvents=1';
  fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
        -->
</body>

</html>