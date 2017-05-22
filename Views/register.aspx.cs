using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class zhuce1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void RegisterBtn_Click(object sender, EventArgs e)
    {
        DBClass db = new DBClass();
        String uNameText = UserNameText.Text.Trim();
        String pWordText = PassWordText.Text.Trim();
        String rNameText = NameText.Text.Trim();
        String pCodeText = PhoneText.Text.Trim();
        String eMailText = EmailText.Text.Trim();
        String aDdressText = AddressText.Text.Trim();
        String postCodeText = PostText.Text.Trim();
        DateTime dtime = System.DateTime.Now;
        UserClass uc = new UserClass();
       
        if (uNameText == "" && pWordText == "" && rNameText == "" && pCodeText == "" && eMailText == "" && aDdressText == "" && postCodeText == "")
        {
            Response.Write("<script>alert('文本框为空！！！')</script>");
        }else if (ConfirmText.Text.Trim() != pWordText){
            Response.Write("<script>alert('确认密码不一样')</script>");
        }
        else {
            int IntReturnValue = uc.AddUser(uNameText, pWordText, rNameText, transfer(ddlSex.SelectedItem.Text), pCodeText, eMailText, aDdressText, postCodeText);
            if (IntReturnValue == 100)
            {
                Response.Write("<script>alert('注册成功')</script>");
                CloseText();
            }
            else {
                Response.Write("<script>alert('插入失败，用户名已经存在！！！')</script>");
            }
        }
    }

    /// <summary>
    ///  将性别转化为Bool值
    /// </summary>
    /// <param name="strValue">需要转化的性别值</param>
    /// <returns>返回转化后的性别值</returns>
    protected bool transfer(string strValue)
    {
        if (strValue == "男")
        {
            return true;
        }
        else
        {
            return false;

        }
    }

    public void CloseText() {
        UserNameText.Text = "";
        PassWordText.Text = "";
        NameText.Text = "";
        ddlSex.Text = "";
        PhoneText.Text = "";
        EmailText.Text = "";
        AddressText.Text = "";
    }
}