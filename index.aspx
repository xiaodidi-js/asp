<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="content">
    <!-- 新品上市 开始-->
    <div class="sp_content">
        <div class="goodNew">
            <h3>-- 新品上市 --</h3>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
	    <asp:DataList ID="SPDataList" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
            <HeaderTemplate></HeaderTemplate>
            <ItemTemplate>
                <div class="tab">
	                <div class="itemLink">
                        <asp:HyperLink ID="mation" CssClass="block" runat="server" NavigateUrl="javascript:void(0);">
                            <asp:Image runat="server" ID="SPImage" ImageUrl='<%# Eval("ImageUrl") %>' Width="250px" Height="220px"/>
                        </asp:HyperLink>
	                </div>
                    <div class="labels">
                        <p class="title"><asp:Label runat="server" ID="BookName" CssClass="BookName" Text='<%# Eval("BookName") %>'></asp:Label></p>
                        <p class="Price">
                            <span>热卖价：￥</span>
                            <asp:Label runat="server" ID="HotPrice" CssClass="HotPrice" Text='<%# Eval("HotPrice") %>'></asp:Label>
                            <span>元</span>
                        </p>
                    </div>
                    <asp:Button runat="server" CssClass="shopbtn block" Text="立即购买" />
	            </div>
            </ItemTemplate>
            
        </asp:DataList>
    </div>
    <!-- 新品上市 结束 -->

    <script type="text/javascript">
        (function () {
            var tabSP = document.getElementsByClassName("tab");
            for (var i = 0; i < tabSP.length; i++){
                tabSP[i].onmouseout = function () {
                    this.style.transition = "0.3s";
                };
            }
        })();
    </script>

    
    <script type="text/javascript" src="js/jquery-2.1.4.min.js"></script>
    <script type="text/javascript" src="js/demo.js"></script>

    <!-- 新品上市 开始-->
    <div class="sp_content">
        <div class="goodNew">
            <h3>-- 新品上市 --</h3>
        </div>
        <div class="stage-outer">
        	<div class="owl-item">
        		<ul>
                    <asp:DataList runat="server" ID="dlRefine" RepeatColumns="8" RepeatDirection="Vertical">
                        <ItemTemplate>
                            <li>
        				        <div class="about_sp">
        					        <div class="sp_img">
                                        <asp:Image runat="server" ID="Refineimages" ImageUrl='<%# Eval("ImageUrl") %>' Width="272" Height="245" />
                                        <%--<img src="images/shopping_2.jpg" />--%>
        					        </div>
        					        <div class="about_sp_xx">
        						        <p class="price">
                                            <asp:Label runat="server" ID="RefineName" CssClass="block price_title" Text='<%# Eval("BookName") %>'></asp:Label>
		                                    <span>热卖价：￥</span>
                                            <asp:Label runat="server" ID="lblRefine" CssClass="HotPrice" Text='<%# Eval("HotPrice") %>'></asp:Label>
		                                    <span>元</span>
		                                </p>
		                                <a href="javascript:void(0);" class="btn_show">
		                        	        立即查看
		                        	        <i class="iconfont icon_right">&#xe6a7;</i>
		                                </a>
        					        </div>
        				        </div>
        			        </li>
                        </ItemTemplate>
                    </asp:DataList>
        		</ul>
        	</div>
        	<div class="about_btn">
        		<a href="javascript:void(0);" class="btnleft fl block iconfont">&#xe697;</a>
        		<a href="javascript:void(0);" class="btnright fr block iconfont">&#xe6a7;</a>
        	</div>
        </div>
    </div>
	<script type="text/javascript">
		/*
		(function(){
			var btnShow = document.getElementsByClassName("btn_show");
			
			for(var i = 0; i < btnShow.length; i++){
				btnShow[i].onmousemove = function(){
					this.style.padding = "5px 25px 5px 25px";
					this.style.transition = "0.3s";
				};
				btnShow[i].onmouseout = function(){
					this.style.padding = "5px 15px";
					this.style.transition = "0.3s";
				};
			}
		})();*/
	</script>
</div>
</asp:Content>