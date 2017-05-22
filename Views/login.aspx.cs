using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack){
            CommonClass cClass = new CommonClass();
            this.labValid.Text = cClass.RandomNum(4);
        }
    }
    protected void LoginBtn_Click(object sender, EventArgs e)
    {
        //清空Session对象
        Session["UserName"] = null;
        String uName = UserName.Text.Trim();
        String pWord = PassWord.Text.Trim();
        String Sing = Singleline.Text.Trim();
        //实例化DBClass
        DBClass db = new DBClass();
        //链接数据
        db.GetConnection();
        //Sql登录查询语句
        String SqlStr = "select UserName,PassWord from tb_Member where UserName = '" + uName + "' and PassWord = '" + pWord + "'";
        SqlDataReader dr = db.reDr(SqlStr);
        if (uName == "" || pWord == "" || Sing == "")
        {
            Response.Write("<script>alert('文本框为空！！！')</script>");
        }
        else
        {
            if (Sing == labValid.Text.Trim())
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    //将username控件储存到Session["Name"]中
                    Session["UserName"] = uName;
                    //将页面重定向到另外一个页面，并转递一个参数
                    Response.Redirect("../index.aspx?uName=" + uName);
                }
                else
                {
                    Response.Write("<script>alert('账号或者密码错误！！！')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('请输入正确的验证码！！！')</script>");
            }
        }
    }
}