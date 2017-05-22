<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="zhuce1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="../css/common.css" type="text/css" />
    <link rel="stylesheet" href="../css/animate.css" type="text/css" />
    <link rel="stylesheet" href="../css/dome.css" type="text/css" />
    <link rel="stylesheet" href="../css/register.css" type="text/css" />
    <title></title>
</head>
<body>
    <!--site-nav start-->
    <div class="site-nav">
        <div class="sn-bd">
            <div class="sn-content">
                <div class="sn-left">
                    <p class="sn-back-home">
                        <i class="iconfont font">&#xe74f;</i>
                        <a href="../index.aspx">首页</a>
                    </p>
                    <p class="login-info">
                        <asp:Label ID="UserLabel" runat="server"></asp:Label>
                        <em>喵，欢迎来购物中心</em>
                        <asp:HyperLink ID="Plogin" runat="server" CssClass="sn-login sn" NavigateUrl="Login.aspx">请登录</asp:HyperLink>
                        <a href="Views/register.aspx" class="sn-register sn">免费注册</a>
                    </p>
                </div>
                <div class="sn-right">
                    <ul>
                        <li class="j_MyTaoba menu-item">
                            <div class="menu-bd">
                                <ul>
                                    <li><a href="javascript:void(0);">已买到的宝贝</a></li>
                                    <li><a href="javascript:void(0);">已卖出的宝贝</a></li>
                                </ul>
                            </div>
                        </li>
                        <li>
                            <i class="iconfont topicon" style="font-size: 12px;">&#xe730;</i>
                            <a href="javascript:void(0);">我关注的品牌</a>
                        </li>
                        <li>
                            <i class="iconfont topicon" style="font-size: 12px;">&#xe698;</i>
                            <a href="javascript:void(0);">购物车0件</a>
                        </li>
                        <li>
                            <i class="iconfont topicon">&#xe69e;</i>
                            <a href="javascript:void(0);">网站留言</a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <!--site-nav end-->
    <div id="RegTitle">
        <h1>会员注册</h1>
    </div>
    <form id="form" runat="server">
        <div id="RegContent">
            <div class="RegTd">
                <div class="RegName">用户名：</div>
                <div class="RegText">
                    <asp:TextBox ID="UserNameText" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="RegTd">
                <div class="RegName">密码：</div>
                <div class="RegText">
                    <asp:TextBox ID="PassWordText" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="RegTd">
                <div class="RegName">确认密码：</div>
                <div class="RegText">
                    <asp:TextBox ID="ConfirmText" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="RegTd">
                <div class="RegName">姓名：</div>
                <div class="RegText">
                    <asp:TextBox ID="NameText" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="RegTd">
                <div class="RegName">性别：</div>
                <div class="RegText">
                    <asp:DropDownList runat="server" ID="ddlSex">
                        <asp:ListItem Selected="True" Value="1">男生</asp:ListItem>
                        <asp:ListItem Value="0">女生</asp:ListItem>
                    </asp:DropDownList>
                    <%--<asp:TextBox ID="SexText" runat="server"></asp:TextBox>--%>
                </div>
            </div>
            <div class="RegTd">
                <div class="RegName">联系电话：</div>
                <div class="RegText">
                    <asp:TextBox ID="PhoneText" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="RegTd">
                <div class="RegName">E-MALL：</div>
                <div class="RegText">
                    <asp:TextBox ID="EmailText" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="RegTd">
                <div class="RegName">地址：</div>
                <div class="RegText">
                    <asp:TextBox ID="AddressText" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="RegTd">
                <div class="RegName">邮编：</div>
                <div class="RegText">
                    <asp:TextBox ID="PostText" runat="server"></asp:TextBox>
                </div>
            </div>
            <div class="RegTd">
                <asp:Button ID="RegisterBtn" runat="server" OnClick="RegisterBtn_Click" Text="立即注册" />
                <a href="../index.aspx" class="LoginNow">马上登录</a>
            </div>
        </div>
    </form>

    <!--footer start-->
    <div class="footer">
        <div class="tmall-copyright">
            <div class="footer-copyright  footercon">
                &copy;2016 - facekeke.com 版权所有
            </div>
        </div>
    </div>
</body>
</html>
