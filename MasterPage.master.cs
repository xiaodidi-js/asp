using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["UserName"] == null)
        //{
        //    Response.Redirect("Views/login.aspx");
        //}
        //else
        //{
        //    UserLabel.Text = Session["UserName"].ToString();
        //    Plogin.Visible = false;
        //}
    }
    protected void SerachBtn_Click(object sender, EventArgs e)
    {
        DBClass db = new DBClass();
        SqlConnection conn = db.GetConnection();
        String SqlStr = "select * from tb_BookInfo where BookName like '%" + SearchTxt.Text.Trim() + "%';";
        SqlCommand cmd = new SqlCommand(SqlStr, conn);
        cmd.Parameters.Add("@BookName", SqlDbType.VarChar, 20).Value = SearchTxt.Text.Trim();
        int i = (int)cmd.ExecuteScalar();
        if (i >= 1)
        {
            Session["var1"] = "select BookName from tb_BookInfo where BookName like '%" + SearchTxt.Text.Trim() + "%'";
            Server.Transfer("Search.aspx");
            return;
        }
        else
        {
            Response.Write("<script>alert('抱歉，没有此商品')</Script>");
            SearchTxt.Text = "";
        }
    }
}
