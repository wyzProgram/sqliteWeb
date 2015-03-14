using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SqliteMan;

public partial class ajax_ajax_send : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void createsqlite(string filename)
    {
        string file = Server.MapPath("/") + filename;
        Run.createSqlite(file);
    }

    private int query(string filename,string password,string sql)
    {
        string connect = "Data Source=" + filename + ",password="+password+"";
        return Run.Query(sql, connect);
    }
}