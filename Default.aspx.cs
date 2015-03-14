using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqliteMan;
using System.Data;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string file =Server.MapPath("/")+"data1.sqlite";
        Run.createSqlite(file);
        string connect="Data Source="+file+",password=123";
        int ret=Run.Query("create table if not exists test1(ID integer not null primary key autoincrement,title text,contenct text)", connect);
        int retinsert = Run.Query("insert into test1(title,contenct)values('first','内容')",connect);
        DataTable dt = Run.selectsql("select title,contenct from test1 order by id",connect);
        foreach(DataRow dr in dt.Rows)
        {
            foreach(DataColumn col in dt.Columns)
            {
                Response.Write(col+":"+dr[col]+";");
            }
        }
    }
}