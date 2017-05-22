<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!doctype html>
<html>
    <head>
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=10,IE=9,IE=8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
        <meta name="keywords" content="">
        <meta name="description" content="">
        <title></title>
        <link rel="stylesheet" href="../css/common.css" type="text/css" />
        <link rel="stylesheet" href="../css/login.css" type="text/css" />
        <link rel="stylesheet" href="../css/dome.css" type="text/css" />
    </head>
    <body>
        <!--content start-->
        <div class="content">
            <div class="header">
                <a href="tmall.html" class="tmall-logo"></a>
            </div>
                
            <div class="container">
                <div class="clearfix">
                    <a href="javascript:void(0);">
                        <img src="../images/images21.jpg" width="435" height="276" />
                    </a>
                </div>
                <div class="form">
                    <div class="login-body">
				  		<div class="tm-logo"></div>
				  		<form id="userinfo" runat="server" class="userinfo">
					  		<div class="login-message" id="l-msg">
					  			<span class="msg-txt">请输入账户名和密码</span>
					  		</div>
					  		<div class="login-A">
					  			<label class="la-txt">登录名：</label><Br/>
                                <asp:TextBox ID="UserName" CssClass="txt" runat="server"/>
					  		</div>
					  		<div class="login-A">
						  		<label class="la-txt">登录密码：</label><Br/>
	                            <asp:TextBox ID="PassWord" CssClass="txt" runat="server" TextMode="Password"/>
					   		</div>
					   		<div class="login-A">
						  		<label class="la-txt">验证码：</label><Br/>
                                <asp:TextBox runat="server" ID="Singleline" CssClass="txt SingleLine"></asp:TextBox>
						  		<asp:Label runat="server" ID="labValid">8888</asp:Label>
					   		</div>
                                <asp:Button ID="LoginBtn" CssClass="loginbtn" runat="server"  Text="登录" OnClick="LoginBtn_Click" />
					   			<a href="register.html">免费注册</a>
				  		</form>
				  	</div>
                </div>
            </div>
        </div>
        <!--content end-->
        <!--footer start-->
        <div class="footer">
            <div class="tmall-copyright">
                <div class="footer-copyright  footercon">
                    &copy;2016 - facekeke.com 版权所有
                </div>
            </div>
        </div>
        <!--footer end-->
    </body>
</html>
