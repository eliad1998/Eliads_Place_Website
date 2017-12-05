using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string level = "";
    protected void Page_Load(object sender, EventArgs e)
    {
   //   Page.MaintainScrollPositionOnPostBack = true;
        if (Session["user"] != null)
        {
            DataTable you = (DataTable)Session["user"];

            level = you.Rows[0][12].ToString();
           
        }
    }
}
