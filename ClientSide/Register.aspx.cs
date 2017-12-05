using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Register : System.Web.UI.Page
{
    private localhost.Service s = new localhost.Service();
    private localhost.Client c = new localhost.Client();
    private DataTable dtCities = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            dtCities = s.GetAllCities();

            for (int i = 0; i < dtCities.Rows.Count; i++)
                dropCity.Items.Add(dtCities.Rows[i][1].ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        localhost.Client c = new localhost.Client();

        if (s.HasClient(txtUser.Text))
            Response.Write(Functions.AlertBox("Username exists"));

        else if (DateTime.Now.Year - int.Parse(ddBirth.SelectedItem.Text) < 14)
            Response.Write(Functions.AlertBox("You are too young"));
        else
        {

            c.Username = txtUser.Text;

            c.Password = txtPass.Text;

            c.FirstName = txtName.Text;

            c.LastName = txtLname.Text;

            c.Gender = genderList.SelectedItem.Text;

            c.City = dropCity.SelectedIndex + 1;

            c.Street = txtStreet.Text;

            c.NumStreet = txtStreetNum.Text;

            c.Age = (DateTime.Now.Year - int.Parse(ddBirth.SelectedItem.Text)).ToString();

            c.Mail = txtMail.Text;

            c.Phone = txtPhone.Text;

            if (fuImage.HasFile)
            {
                c.Pic = fuImage.FileName;

                fuImage.SaveAs(Server.MapPath("pics/users/" + fuImage.FileName));
            }

            else
                c.Pic = "default.jpg";

            c.Level = "Client";

            c.Status = "Online";



            s.AddNewClient(c);
            Response.Write(Functions.AlertRedirect("Now you can login", "Login.aspx"));
        }

    }
  
}