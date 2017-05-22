using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack){
            GoodsClass gc = new GoodsClass();
            //gc.DLDeplayGI(1,dlRefine,"Refine");
            SPSS_Code();
            dlRefindSP();
        }
    }

    public void dlRefindSP() {
        DBClass db = new DBClass();
        SqlConnection conn = db.GetConnection();
        String StrSql = "select top 8 BookName,HotPrice,ImageUrl from tb_BookInfo left join tb_Image on tb_BookInfo.BookID = tb_Image.ImageID";
        SqlDataAdapter adap = new SqlDataAdapter(StrSql, conn);
        DataSet ds = new DataSet();
        adap.Fill(ds);
        //设置数据源，用于填充控件中的项的值列表
        dlRefine.DataSource = ds;
        //将控件及其所有子控件绑定到指定的数据源
        dlRefine.DataBind();
    }

    /// <summary>
    /// 新品上市列表
    /// </summary>
    private void SPSS_Code(){
        DBClass db = new DBClass();
        SqlConnection conn = db.GetConnection();
        String StrSql = "select top 8 BookName,HotPrice,ImageUrl from tb_BookInfo left join tb_Image on tb_BookInfo.BookID = tb_Image.ImageID";
        SqlDataAdapter adap = new SqlDataAdapter(StrSql, conn);
        DataSet ds = new DataSet();
        adap.Fill(ds);
        //设置数据源，用于填充控件中的项的值列表
        SPDataList.DataSource = ds;
        //将控件及其所有子控件绑定到指定的数据源
        SPDataList.DataBind();
    }
}