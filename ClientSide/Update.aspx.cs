using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Update : System.Web.UI.Page
{
    private static DataTable dt = null;
    private static string username = "";
    private static string typeUser = "";
    private static string password = "";
    private static string firstName = "";
    private static string lastName = "";
    private static string Gender = "";
    private static int city = 0;
    private static string street = "";
    private static string numStreet = "";
    private static string age = "";
    private static string mail = "";
    private static string phone = "";
    private static string img = "";

    private localhost.Service s = new localhost.Service();
    private localhost.Client c = new localhost.Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("Home.aspx");

        if (!this.IsPostBack)
        {
            dt = (DataTable)Session["user"];

            username = dt.Rows[0][0].ToString();

            img = dt.Rows[0][11].ToString();

            Image1.ImageUrl = "~/pics/users/" + img;
            lblUser.Text = username;



            lblType.Text = typeUser;

            password = dt.Rows[0][1].ToString();

            firstName = dt.Rows[0][2].ToString();

            txtFirst.Text = firstName;

            lastName = dt.Rows[0][3].ToString();

            txtLast.Text = lastName;

            Gender = dt.Rows[0][4].ToString();

            lblGender.Text = Gender;

            city = int.Parse(dt.Rows[0][5].ToString());

            dropCity.SelectedIndex = city - 1;

            street = dt.Rows[0][6].ToString();

            txtStreet.Text = street;

            numStreet = dt.Rows[0][7].ToString();

            txtNumStreet.Text = numStreet;

            age = dt.Rows[0][8].ToString();

            lblAge.Text = age;
            mail = dt.Rows[0][9].ToString();
            txtMail.Text = mail;
            phone = dt.Rows[0][10].ToString();

            txtPhone.Text = phone;

            typeUser = dt.Rows[0][12].ToString();

            lblType.Text = typeUser;


      
        }
        
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        bool cont=true;

     
        if (txtPass.Text.Length != 0 && txtPassNew.Text.Length!= 0)
        {
            if (!txtPass.Text.Equals(password))
            {
                Response.Write(Functions.AlertBox("Wrong old password"));
                cont = false;
            }
            else
                password = txtPassNew.Text;        
        }

        if (cont)
        {

            if (txtFirst.Text.Length != 0)
                firstName = txtFirst.Text;

            if (txtLast.Text.Length != 0)
                lastName = txtLast.Text;

            city = dropCity.SelectedIndex + 1;


            if (txtStreet.Text.Length != 0)
                street = txtStreet.Text;

            if (txtNumStreet.Text.Length != 0)
                numStreet = txtNumStreet.Text;

            if (txtMail.Text.Length != 0)
                mail = txtMail.Text;


            if (txtPhone.Text.Length != 0)
                phone = txtPhone.Text;

            if (fuImage.HasFile)
            {
                img = fuImage.FileName;
                fuImage.SaveAs(Server.MapPath("pics/users/") + fuImage.FileName);
            }



            localhost.Client c = new localhost.Client();
            c.Username = username;

            c.Password = password;
            c.FirstName = firstName;

            c.LastName = lastName;


            c.Gender = Gender;

            c.City = city;

            c.Street = street;

            c.NumStreet = numStreet;

            c.Age = age;

            c.Mail = mail;

            c.Phone = phone;

            c.Pic = img;

            c.Level = typeUser;

            c.Status = dt.Rows[0][13].ToString();

            s.UpdateClient(c);

            Session["user"] = s.SearchById(username);

            Response.Write(Functions.AlertRedirect("Update has succeeded","update.aspx"));

    

        }
    }
}