using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//数据引用
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


/// <summary>
/// UserClass 的摘要说明
/// </summary>
public class UserClass
{
	public UserClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public DataTable UserLogin(String uName,String pWord) {
        //调用DBClass类的GetCommandProc 方法执行存储过程，并返回一个SqlCommand 类对象
        DBClass db = new DBClass();
        SqlCommand cmd = db.GetCommandProc("proc_UserLogin");
        //添加参数（用户名）
        SqlParameter Name = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
        SqlParameter Pwd = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
        Name.Value = uName;
        Pwd.Value = uName;
        cmd.Parameters.Add(Name);
        cmd.Parameters.Add(Pwd);
        //调用DBClass 类的ExecNonQuery方法执行Sql查询语句,并返回受影响的行数
        db.ExecNonQuery(cmd);
        DataTable table = db.GetDataSet(cmd, "tb_Member");
        return table;
    }


    public int AddUser(String strName,String strPassword,String strRealName,bool blSex,String strPhoneCoode,String strEmail,String strAddress,String strPostCode){
        DBClass db = new DBClass();
        SqlConnection conn = db.GetConnection();
        SqlCommand cmd = new SqlCommand("proc_AddUser", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        //参数帐号
        SqlParameter uName = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
        uName.Value = strName;
        cmd.Parameters.Add(uName);
        //参数密码
        SqlParameter pWord = new SqlParameter("@PassWord", SqlDbType.VarChar, 50);
        pWord.Value = strPassword;
        cmd.Parameters.Add(pWord);

        //参数（名称）
        SqlParameter rName = new SqlParameter("@RealName", SqlDbType.VarChar, 50);
        rName.Value = strRealName;
        cmd.Parameters.Add(rName);

        //参数（性别）
        SqlParameter sEx = new SqlParameter("@Sex", SqlDbType.Bit, 1);
        sEx.Value = blSex;
        cmd.Parameters.Add(sEx);

        //参数（移动手机）
        SqlParameter pCode = new SqlParameter("@Phonecode", SqlDbType.VarChar, 20);
        pCode.Value = strPhoneCoode;
        cmd.Parameters.Add(pCode);

        //参数（电子邮件）
        SqlParameter eMail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
        eMail.Value = strEmail;
        cmd.Parameters.Add(eMail);

        //参数（地址）
        SqlParameter aDdress = new SqlParameter("@Address", SqlDbType.VarChar, 200);
        aDdress.Value = strAddress;
        cmd.Parameters.Add(aDdress);

        //参数（邮编）
        SqlParameter postCode = new SqlParameter("@PostCode", SqlDbType.Char, 10);
        postCode.Value = strPostCode;
        cmd.Parameters.Add(postCode);

        //参数（创建时间）
        DateTime dtime = System.DateTime.Now;
        cmd.Parameters.Add("@LoadDate", SqlDbType.DateTime).SqlValue = dtime;

        SqlParameter RetrueValue = cmd.Parameters.Add("RetureValue",SqlDbType.Int,4);
        RetrueValue.Direction = ParameterDirection.ReturnValue;
        db.ExecNonQuery(cmd);
        return Convert.ToInt32(RetrueValue.Value.ToString());
    }
}