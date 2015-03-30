using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SQLite;
using System.Data.OleDb;

namespace 数据库项目
{
    public partial class 管理员 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=d:\\mudb2.db");
            conn.Open();
            String sql = "select * from admin";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader dr = cmd.ExecuteReader();
            Boolean flag = false;
            while (dr.Read())
                if (dr.GetString(0) == modlgn_username.Value && dr.GetString(1) == modlgn_passwd.Value)
                    flag = true;
            if (flag)
                Response.Redirect("new_movie.aspx");
            else
                Page.ClientScript.RegisterStartupScript(this.GetType(), "message", "alert('账户密码错误')", true);
        }
    }
}