using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    private localhost.Service s = new localhost.Service();
    private localhost.Client c = new localhost.Client();
    public string st = "";
    DataTable dtCities = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        dtCities = s.GetAllCities();

        for (int i = 0; i < dtCities.Rows.Count; i++)
            st += "<asp:ListItem>" + dtCities.Rows[i][1].ToString() + "</asp:ListItem> \n";

    }
}