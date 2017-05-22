<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="aext.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
    <head runat="server">
        <meta charset="UTF-8" />
        <title></title>
        <link rel="stylesheet" type="text/css" href="css/common.css"/>
        <link href="css/dome.css" rel="stylesheet" type="text/css" />
    </head>
<body>
	<!--tabs-mask start-->
    <div class="tabs-mask">
        <div class="shoppint-mask" id="shop">
            <b class="icon"></b>
            <span class="tab-txt">购物车</span>
            <b class="spp-num">0</b>
        </div>
        <div class="mui-mbar tab-ma">
            <i class="iconfont"><img src="images/money.png" alt=""/></i>
            <div class="tab-money mbar">
                <div class="tab-return">我的资产</div>
            <b class="b"></b>
            </div>
        </div>
        <div class="mui-mbar tab-mb">
            <i class="iconfont"><img src="images/pp.png" alt=""/></i>
            <div class="tab-money mbar">
                <div class="tab-return">我的品牌</div>
                <b class="b"></b>
            </div>
        </div> 
        <div class="mui-mbar tab-mb">
            <i class="iconfont"><img src="images/sc.png" alt=""/></i>
            <div class="tab-money mbar">
                <div class="tab-return">我的收藏</div>
                <b class="b"></b>
            </div>
        </div>
        <div class="mui-mbar tab-mb">
            <i class="iconfont"><img src="images/look.png" alt=""/></i>
            <div class="tab-money mbar">
                <div class="tab-return">我看过的</div>
                <b class="b"></b>
            </div>
        </div>
        <div class="mui-mbar tab-mb">
            <i class="iconfont"><img src="images/chongzhi.png" alt=""/></i>
            <div class="tab-money mbar">
                <div class="tab-return">我要充值</div>
                <b class="b"></b>
            </div>
        </div>
        <!--回到顶部 开始-->
        <div class="mbar m-top">
            <div class="tab-return" id="gettop">返回顶部</div>
            <b class="b"></b>
        </div>
        <div class="tabs-top" id="top" title="回到顶部" style="display:block;"></div>
        <!--回到顶部 结束-->
    </div>
     <!--tabs-mask end-->
    <!--site-nav start-->
    <div class="site-nav">
	    <div class="sn-bd">
	        <div class="sn-content">
	            <div class="sn-left">
	                <p class="sn-back-home">
	                    <i class="iconfont font">&#xf0175;</i>
	                    <a href="tmall.html">首页</a>
	                </p>
	                <p class="login-info">
                        <asp:Label ID="UserLabel" runat="server"></asp:Label>
	                    <em>喵，欢迎来购物中心</em>
	                    <a href="Login.aspx" class="sn-login sn">请登录</a>
	                    <a href="javascript:void(0);" class="sn-register sn">免费注册</a>
	                </p>
	            </div>
	            <div class="sn-right">
	                <ul>
	                    <li class="j_MyTaoba menu-item">
	                        <div  class="menu-bd">
	                            <ul>
	                                <li><a href="javascript:void(0);">已买到的宝贝</a></li>
	                                <li><a href="javascript:void(0);">已卖出的宝贝</a></li>
	                            </ul>
	                        </div>
	                    </li>
	                    <li>
	                        <i class="iconfont topicon" style="font-size:12px;">&#x3449;</i>
	                        <a href="javascript:void(0);">我关注的品牌</a>
	                    </li>
	                    <li>
	                        <i class="iconfont topicon" style="font-size:12px;">&#xf009f;</i>
	                        <a href="javascript:void(0);">购物车0件</a>
	                    </li>
	                    <li>
	                        <a href="javascript:void(0);">收藏夹</a>
	                    </li>
	                </ul>
	            </div>
	        </div>
	    </div>
    </div>
    <!--site-nav end-->
    <form id="form1" runat="server">
    <div id="header">
        <!-- header-dome start -->
        <div class="header-dome">
        	<div id="search">
                <div class="search-wrap">
                    <asp:TextBox ID="SearchTxt" runat="server" placeholder="搜索你想买的商品"/>
	                <asp:Button ID="SerachBtn" runat="server" Text="搜索" OnClick="SerachBtn_Click" />
                </div>
            </div>    
        </div>
        <!-- header-dome end -->
        <div id="nav">
        	<div class="nav-dome">
        		<asp:HyperLink ID="link1" runat="server" CssClass="link" NavigateUrl="~/Default.aspx">
        			<img src="images/navlcon.png" alt="" >
        			商城首页
        		</asp:HyperLink>
	            |
	            <asp:HyperLink ID="link2" runat="server" CssClass="link" onclick="LinkButton1_Click">新品上市</asp:HyperLink>
	            |
	            <asp:HyperLink ID="link3" runat="server" CssClass="link" NavigateUrl="~/2.aspx">精品推荐</asp:HyperLink>
	            |
	            <asp:HyperLink ID="link4" runat="server" CssClass="link" NavigateUrl="~/3.aspx">特价商品</asp:HyperLink>
	            |
	            <asp:HyperLink ID="link5" runat="server" CssClass="link" NavigateUrl="~/4.aspx">热销商品</asp:HyperLink>
        	</div>
        </div>
        
        <div id="content">
        	<div id="sp_content">
	            <div class="tab">
	            	<div class="itemLink">
	            		<img class="block" src="https://img.alicdn.com/bao/uploaded/i1/TB1u4RbOpXXXXX8XVXXSutbFXXX.jpg_300x1000q75s30.jpg_.webp" />
	            	</div>
                    <div class="sp_title">
                    	Dell笔记本2091<br />
                    	单价：<span style="color: #ff0066">￥6,500.00元</span>
                    </div>
                  	<a href="javascript:void(0);" class="shopbtn block">立即购买</a>
	            </div>
	        </div>
        </div>
        
        <!--footer start-->
        <div class="footer">
            
            <div class="tmall-copyright">
                <div class="footer-copyright  footercon">
                    &copy;2016 - facekeke.com 版权所有
                </div>
            </div>
        </div>
        <!--footer end-->
    </div>
    </form>
</body>
</html>
