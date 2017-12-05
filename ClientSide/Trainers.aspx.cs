using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Trainers : System.Web.UI.Page
{
    private localhost.Service s = new localhost.Service();
    private string sql = "";
    DataTable dt = null;
    private DataTable dtCities;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            dt = s.GetAllTrainers();
            GrdTrainers.DataSource = dt;

            GrdTrainers.DataBind();

            for (int i = 0; i < GrdTrainers.Rows.Count; i++)
                GrdTrainers.Rows[i].Cells[3].Text = s.CityFromid(int.Parse(GrdTrainers.Rows[i].Cells[3].Text));
        }
    }
}