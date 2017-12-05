using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class Login : System.Web.UI.Page
{
    private localhost.Service s = new localhost.Service();
    private localhost.Client c = new localhost.Client();
   
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DataTable dtLogin = s.LoginDT(txtUser.Text, txtPass.Text);


        if (dtLogin.Rows.Count == 0)
            lbltxt.Text = "Wrong username or password";


        else
        {
            string status = dtLogin.Rows[0][13].ToString();

            if (status.Equals("Offline"))
                lbltxt.Text = "This user was deleted";

            else
            {

                Session["user"] = dtLogin;

                Response.Write(Functions.AlertRedirect("Welcome", "Home.aspx"));
            }
        }
    }
}