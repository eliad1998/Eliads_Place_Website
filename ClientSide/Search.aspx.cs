using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Search : System.Web.UI.Page
{
    private localhost.Service s = new localhost.Service();
    private string sql = "";
    DataTable dt = null;
    private DataTable dtCities;
    //private DataTable dt = null;

    private void Show(string sql,int status)
    {
       
        if (status == 1)
        {
            dt = s.SearchBySql(sql,"Clients");

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
                    GrdClients.Rows[i].Cells[4].Text = s.CityFromid(int.Parse(GrdClients.Rows[i].Cells[4].Text));
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
                GrdClients.Rows[i].Cells[4].Text = s.CityFromid(int.Parse(GrdClients.Rows[i].Cells[4].Text));
        }

        //else
        //{
        //                txtuser.Text = string.Empty;
        //    txtfname.Text = string.Empty;
        //    txtlname.Text = string.Empty;

        //    dropCity.SelectedIndex = 0;


        //    txtmail.Text = string.Empty;

        //    img1.ImageUrl = "~/pics/users/default.jpg";

        //    sql="SELECT * FROM Clients";
        //    dt = s.SearchBySql(sql);

        //    GrdClients.DataSource = dt;

        //    GrdClients.DataBind();

        //    for (int i = 0; i < GrdClients.Rows.Count; i++)
        //        GrdClients.Rows[i].Cells[4].Text = s.CityFromid(int.Parse(GrdClients.Rows[i].Cells[4].Text));
        }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("Home.aspx");

        else
        {
            DataTable you = (DataTable)Session["user"];

            string level=you.Rows[0][12].ToString();

            if(level.Equals("Client"))
                Response.Redirect("Home.aspx");

                if (!Page.IsPostBack)
                {
                    dtCities = s.GetAllCities();

                    for (int i = 0; i < dtCities.Rows.Count; i++)
                        dropCity.Items.Add(dtCities.Rows[i][1].ToString());

                    sql = "SELECT * FROM Clients";
                    Show(sql, 0);
                }
            
            }


        
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {

        sql = "SELECT * FROM Clients";

        string username = txtuser.Text;

        string firstName = txtfname.Text;

        string lastName = txtlname.Text;

        int city = dropCity.SelectedIndex;

        string mail = txtmail.Text;

        if (username.Equals(string.Empty) && firstName.Equals(string.Empty) && lastName.Equals(string.Empty) && city == 0 && mail.Equals(string.Empty))
            sql = "SELECT * FROM Clients";


        else
        {
            if (!username.Equals(string.Empty))
            {
                sql += " WHERE Username='" + username + "'";

                if (!firstName.Equals(string.Empty))
                    sql += " AND FirstName='" + firstName + "'";

                if (!lastName.Equals(string.Empty))
                    sql += " AND LastName='" + lastName + "'";

                if (city != 0)
                    sql += " AND City=" + city;

                if (!mail.Equals(string.Empty))
                    sql += " AND Mail='" + mail + "'";

            }


            else if (!firstName.Equals(string.Empty))
            {
                sql += " WHERE FirstName='" + firstName + "'";

                if (!lastName.Equals(string.Empty))
                    sql += " AND LastName='" + lastName + "'";

                if (city != 0)
                    sql += " AND City=" + city;

                if (!mail.Equals(string.Empty))
                    sql += " AND Mail='" + mail + "'";
            }

            else if (!lastName.Equals(string.Empty))
            {
                sql += " WHERE LastName='" + lastName + "'";

                if (city != 0)
                    sql += " AND City=" + city;

                if (!mail.Equals(string.Empty))
                    sql += " AND Mail='" + mail + "'";

            }


            else if (city != 0)
            {
                sql += " WHERE City=" + city;

                         if (!mail.Equals(string.Empty))
                    sql += " AND Mail='" + mail + "'";


            }

            else
                sql += " WHERE Mail='" + mail + "'";

        }

        Show(sql,1);




    }

    protected void GrdClients_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdClients.PageIndex = e.NewPageIndex;

        dt = s.SearchBySql("Select * from Clients", "Clients");

        GrdClients.DataSource = dt;

        GrdClients.DataBind();
    }
}