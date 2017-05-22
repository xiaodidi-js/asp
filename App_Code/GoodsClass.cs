using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;

/// <summary>
/// GoodsClass 的摘要说明
/// </summary>
public class GoodsClass
{
	public GoodsClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// dlBind方法用于对DataList 数据控件进行绑定
    /// </summary>
    /// <param name="dlName"></param>
    /// <param name="dsTable"></param>
    public void dlBind(DataList dlName, DataTable dsTable)
    {
        if (dsTable != null)
        {
            dlName.DataSource = dsTable.DefaultView;
            dlName.DataKeyField = dsTable.Columns[0].ToString();
            dlName.DataBind();
        }
    }

    /// <summary>
    /// 在首页中绑定商品信息
    /// </summary>
    /// <param name="intDeplay">商品分类标志</param>
    /// <param name="dlName">绑定商品的DataList控件</param>
    /// <param name="TableName">数据集标志</param>
    public void DLDeplayGI(int intDeplay,DataList dlName,String TableName) {
        //调用DBClass 类的GetCommandProc 方法执行存储过程，并返回一个SqlCommand对象
        DBClass dbObj = new DBClass();
        SqlCommand cmd = dbObj.GetCommandProc("proc_DeplayGI");
        //增加参数
        SqlParameter Deplay = new SqlParameter("@Deplay",SqlDbType.Int,4);
        Deplay.Value = intDeplay;
        //调用 DBClass 类的 ExecNonQuery 方法执行Sql语句，并返回受影响的行数
        dbObj.ExecNonQuery(cmd);
        DataTable table = dbObj.GetDataSet(cmd,TableName);
        dlBind(dlName,table);
    }

    /*
    public String GetClass(int IntClassID)
    {
        //调用DBClass 类的GetCommandProc 方法执行存储过程，并返回一个SqlCommand对象
        DBClass dbObj = new DBClass();
        SqlCommand cmd = dbObj.GetCommandProc("proc_DeplayGI");
    }*/

}