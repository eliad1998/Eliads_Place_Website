using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
public partial class Restore : System.Web.UI.Page
{
    private localhost.Service s = new localhost.Service();
    private string sql = "";
    private static int number = 0;
    private static string[] deletes = null;
    private DataTable dt = null;
    private DataTable dtCities = null;

    private void Show(string sql, int status)
    {
        if (status == 1)
        {
            dt = s.SearchBySql(sql, "Clients");

            if (dt.Rows.Count == 0)
                lbldidnt.Visible = true;

            else
            {
                lbldidnt.Visible = false;
                txtuser.Text = dt.Rows[0][0].ToString();
                txtfname.Text = dt.Rows[0][2].ToString();
                txtlname.Text = dt.Rows[0][3].ToString();

                dropCity.SelectedIndex = int.Parse(dt.Rows[0][5].ToString());


                txtmail.Text = dt.Rows[0][9].ToString();

                img1.ImageUrl = "~/pics/users/" + dt.Rows[0][11].ToString();



                GrdClients.DataSource = dt;

                GrdClients.DataBind();

                for (int i = 0; i < GrdClients.Rows.Count; i++)
                    GrdClients.Rows[i].Cells[5].Text = s.CityFromid(int.Parse(GrdClients.Rows[i].Cells[5].Text));
            }

        }

        else
        {
            txtuser.Text = string.Empty;
            txtfname.Text = string.Empty;
            txtlname.Text = string.Empty;

            dropCity.SelectedIndex = 0;

            txtmail.Text = string.Empty;

            img1.ImageUrl = "~/pics/users/default.jpg";

            dt = s.SearchBySql(sql, "Clients");

            GrdClients.DataSource = dt;

            GrdClients.DataBind();

            for (int i = 0; i < GrdClients.Rows.Count; i++)
                GrdClients.Rows[i].Cells[5].Text = s.CityFromid(int.Parse(GrdClients.Rows[i].Cells[5].Text));
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("Home.aspx");

        else
        {
            DataTable you = (DataTable)Session["user"];

            string level = you.Rows[0][12].ToString();

            if (level.Equals("Client"))
                Response.Redirect("Home.aspx");

            if (!Page.IsPostBack)
            {
                dtCities = s.GetAllCities();
                sql = "SELECT * FROM Clients WHERE [Status]='Offline'";

                for (int i = 0; i < dtCities.Rows.Count; i++)
                    dropCity.Items.Add(dtCities.Rows[i][1].ToString());

                Show(sql, 0);
            }

        }
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        sql = "SELECT * FROM Clients WHERE [Status]='Offline'";

        string username = txtuser.Text;

        string firstName = txtfname.Text;

        string lastName = txtlname.Text;

        int city = dropCity.SelectedIndex;

        string mail = txtmail.Text;

        if (username.Equals(string.Empty) && firstName.Equals(string.Empty) && lastName.Equals(string.Empty) && city == 0 && mail.Equals(string.Empty))
            sql = "SELECT * FROM Clients WHERE [Status]='Offline'";


        if (!username.Equals(string.Empty))
            sql += " AND Username='" + username + "'";

        if (!firstName.Equals(string.Empty))
            sql += " AND FirstName='" + firstName + "'";

        if (!lastName.Equals(string.Empty))
            sql += " AND LastName='" + lastName + "'";

        if (city != 0)
            sql += " AND City=" + city;

        if (!mail.Equals(string.Empty))
            sql += " AND Mail='" + mail + "'";


        Show(sql, 1);
    }
    protected void btnRestore_Click(object sender, EventArgs e)
    {
        int index = 0;
        int size = 0;

        for (int i = 0; i < GrdClients.Rows.Count; i++)
        {
            if (GrdClients.Rows[i].RowType == DataControlRowType.DataRow)
            {
                CheckBox chkRow = GrdClients.Rows[i].Cells[0].FindControl("chkbox") as CheckBox;

                if (chkRow.Checked)
                    size++;
            }
        }


        if (size == 0)
            Response.Write(Functions.AlertBox("You did not select anyone"));

        else
        {
            string[] names = new string[size];
            for (int i = 0; i < GrdClients.Rows.Count; i++)
            {
                if (GrdClients.Rows[i].RowType == DataControlRowType.DataRow)
                {
                    CheckBox chkRow = GrdClients.Rows[i].Cells[0].FindControl("chkbox") as CheckBox;

                    if (chkRow.Checked)
                    {
                        names[index] = GrdClients.Rows[i].Cells[1].Text;
                        index++;
                    }
                }
            }

            DataTable your = (DataTable)Session["user"];

            string youruser = your.Rows[0][0].ToString();

            if (Functions.IsInArr(names, youruser))
                Response.Write(Functions.AlertBox("You can not change yourself"));


            else
            {

                for (int i = 0; i < names.Length; i++)
                    s.Restore_Client(names[i]);

                Response.Write(Functions.AlertBox("Restore has succeeded"));

                number = 0;

                sql = "SELECT * FROM Clients WHERE [Status]='Offline'";
                Show(sql, 1);

            }
        }
    }
    protected void GrdClients_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdClients.PageIndex = e.NewPageIndex;

        dt = s.SearchBySql("Select * from Clients WHERE [Status]='Offline'", "Clients");

        GrdClients.DataSource = dt;

        GrdClients.DataBind();
    }
}