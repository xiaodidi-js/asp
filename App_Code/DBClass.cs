using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// DBClass 的摘要说明
/// </summary>
public class DBClass
{
	public DBClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// 连接数据库
    /// </summary>
    /// <returns>返回SqlConnection对象</returns>
    public SqlConnection GetConnection()
    {
        string myStr = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        SqlConnection myConn = new SqlConnection(myStr);
        myConn.Open();
        return myConn;
    }

    /// <summary>
    /// 执行Sql 语句 ，并返回受影响的行数
    /// </summary>
    /// <param name="cmd">执行Sql语句命令的SqlCommand 对象</param>
    public void ExecNonQuery(SqlCommand cmd)
    {
        try
        {
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            //使用 SqlCommand对象的ExecuteNonQuery 方法执行Sql语句，并返回受影响的行数
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();//关闭数据库的连接
        }
    }


    /// <summary>
    /// 说明：从数据库中检索数据，并返回数据集的表的集合
    /// 返回值：数据源的数据表
    /// 参数：cmd 为执行Sql 语句命令的SqlCommand 对象，TableName 为数据表名称
    /// </summary>
    /// <param name="cmd"></param>
    /// <param name="TableName"></param>
    /// <returns></returns>
    public DataTable GetDataSet(SqlCommand cmd, String TableName)
    {
        SqlDataAdapter adapter;
        DataSet ds = new DataSet();
        try
        {
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();                                                  //打开数据库
            }
            adapter = new SqlDataAdapter(cmd);                                          //实例化SqlDataAdapter 类对象
            adapter.Fill(ds, TableName);                                                 //调用SqlDataAdapter 类对象的Fill方法，填充数据集DataSet
            return ds.Tables[TableName];                                                //返回数据集DataSet 的表集合
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
        finally
        {
            if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();   //关闭与数据库的连接
        }
    }

    /// <summary>
    /// GetCommandProc 方法用与执行存储过程，并返回一个SqlCommand类对象
    /// </summary>
    /// <param name="strProcName"></param>
    /// <returns></returns>
    public SqlCommand GetCommandProc(String strProcName)
    {
        //调用GetConnection 方法，获取与数据库的连接字符串
        DBClass db = new DBClass();
        SqlConnection conn = db.GetConnection();
        //实例化SqlCommand 类对象
        SqlCommand cmd = new SqlCommand();
        //为SqlCommand类对象指定与数据库的连接字符串
        cmd.Connection = conn;
        //获取或者设置对数据源执行的是存储过程
        cmd.CommandText = strProcName;
        //执行存储过程
        cmd.CommandType = CommandType.StoredProcedure;
        //返回cmd
        return cmd;
    }


    /// <summary>
    /// 执行Sql查询语句
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public SqlDataReader reDr(String str)
    {
        //连接数据库
        SqlConnection conn = GetConnection();
        //执行操作
        //SqlCommand com = new SqlCommand(str, conn);
        //读取数据库
        //SqlDataReader dr = com.ExecuteReader(CommandBehavior.CloseConnection);
        SqlDataReader dr = new SqlCommand(str,conn).ExecuteReader(CommandBehavior.CloseConnection);
        return dr;//返回SqlDataReader 对象 dr
    }
}