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
    public partial class new_movie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=d:\\mudb2.db");
            conn.Open();
            string sql = "select * from movie";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);//创建适配器
            SQLiteCommandBuilder build = new SQLiteCommandBuilder(da);//构造sql语句
            DataSet ds = new DataSet();//创建数据集
            da.Fill(ds, "sqlite_test");//填充数据集
            DataTable tb = ds.Tables["sqlite_test"];//创建表

            DataRow row = ds.Tables["sqlite_test"].NewRow();
            row["movie_name"] = TextBox1.Text;
            row["showtimes"] = TextBox2.Text;
            row["movie_area"] = TextBox3.Text;
            row["movie_director"] = TextBox4.Text;
            row["trailer_url"] = TextBox6.Text;
            row["movie_summary"] = TextBox9.Text;
            ds.Tables["sqlite_test"].Rows.Add(row);
            da.Update(ds, "sqlite_test");

            sql = "select * from style";
            da = new SQLiteDataAdapter(sql, conn);//创建适配器
            build = new SQLiteCommandBuilder(da);//构造sql语句
            ds = new DataSet();//创建数据集
            da.Fill(ds, "sqlite_test");//填充数据集
            tb = ds.Tables["sqlite_test"];//创建表
            for (int i = 0; i < CheckBoxList1.Items.Count; i++) {
                if (CheckBoxList1.Items[i].Selected == true)
                {
                    row = ds.Tables["sqlite_test"].NewRow();
                    row[0] = TextBox1.Text;
                    row[1] = CheckBoxList1.Items[i].Text;
                    ds.Tables["sqlite_test"].Rows.Add(row);
                }
            }
            da.Update(ds, "sqlite_test");

            sql = "select * from movie_actor";
            da = new SQLiteDataAdapter(sql, conn);//创建适配器
            build = new SQLiteCommandBuilder(da);//构造sql语句
            ds = new DataSet();//创建数据集
            da.Fill(ds, "sqlite_test");//填充数据集
            tb = ds.Tables["sqlite_test"];//创建表
            string a = TextBox8.Text;
            string[] b = a.Split(',');
            foreach (string x in b)
            {
                row = ds.Tables["sqlite_test"].NewRow();
                row[0] = x;
                row[1] = TextBox1.Text;
                ds.Tables["sqlite_test"].Rows.Add(row);
                
            }
            da.Update(ds, "sqlite_test");


        }


    }
}