using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断Session是否为空否则重定向到Login页面
        /*if (Session["Name"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            UserLabel.Text = Session["Name"].ToString();
        }*/
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //创建connection对象
       /* OleDbConnection conn = new OleDbConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["acestr"].ToString();
        conn.Open();

        //创建command对象

        OleDbCommand com = new OleDbCommand();
        com.Connection = conn;
        //com.CommandText = "select count(*) from userinfo where uname='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "'";
        int i=(int)com.ExecuteScalar();
        if (i >= 1)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Label1.Text = "欢迎" + TextBox1.Text + "来到购物商城";
            if (Request.Cookies["fwsj"] != null)
            {
                Label2.Text = "你上次访问时间是：" + Request.Cookies["fwsj"].Value.ToString();
            }

            Response.Cookies["fwsj"].Value = DateTime.Now.ToString();
            Response.Cookies["fwsj"].Expires = DateTime.Now.AddDays(2);

        }
        else
        {
            Response.Write("<script>alert('用户名密码错误')</script>");
        }
        conn.Close();*/
    }
    
    protected void SerachBtn_Click(object sender, EventArgs e)
    {
        
    }
}
