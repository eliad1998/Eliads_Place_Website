using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class Add_Product : System.Web.UI.Page
{
    private localhost.Service s = new localhost.Service();
    private localhost.Product p = new localhost.Product();
    DataTable dtProviders = null;
    private int lastProduct = 1;//id של המוצר

  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
            Response.Redirect("Home.aspx");

        else
        {
            DataTable you = (DataTable)Session["user"];

            string level = you.Rows[0][12].ToString();

            if (!level.Equals("Admin"))
                Response.Redirect("Home.aspx");

            else
            {
                if (!Page.IsPostBack)
                {
                    //Set dropProvider and generate Id
                    if (dropType.SelectedValue.Equals("Equipment"))
                    {
                        dtProviders = s.GetProviders("A");
                        txtId.Text = s.GiveId("A");
                    }
                    else
                    {
                        dtProviders = s.GetProviders("B");
                        txtId.Text = s.GiveId("B");
                    }

                    for (int i = 0; i <dtProviders.Rows.Count; i++)
                        dropProvider.Items.Add(dtProviders.Rows[i][1].ToString());
                
                

                
                }
               
            }

        }
    }
    protected void dropType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (dropType.SelectedValue.Equals("Equipment"))
        {
            dtProviders = s.GetProviders("A");
            txtId.Text = s.GiveId("A");
        }
        else
        {
            dtProviders = s.GetProviders("B");
            txtId.Text = s.GiveId("B");
        }

        dropProvider.Items.Clear();
        dropProvider.Items.Add("Select Provider");
        for (int i = 0; i < dtProviders.Rows.Count; i++)
            dropProvider.Items.Add(dtProviders.Rows[i][1].ToString());
    

    }

    protected void btnAddProduct_Click(object sender, EventArgs e)
    {
        localhost.Product p = new localhost.Product();

        p.Id = txtId.Text;

        p.Name = txtName.Text;

        p.Information = txtInformation.Text;

        p.MinCap = int.Parse(txtMinCap.Text);

        p.MaxCap = int.Parse(txtMaxCap.Text);

        p.CurCap = int.Parse(txtCurCap.Text);

        p.Price = int.Parse(txtPrice.Text);

        p.MyPrice = int.Parse(txtMyPrice.Text);

        string provider = dropProvider.SelectedValue;

        p.Provider = s.GetProviderId(provider);


        if (fuImage.HasFile)
        {
          p.Pic = fuImage.FileName;

            fuImage.SaveAs(Server.MapPath("pics/products/" + fuImage.FileName));
        }

        else
            p.Pic = "default.png";


        p.Status = 1;

        s.AddNewProduct(p);

        Response.Write(Functions.AlertRedirect("The product added", "Home.aspx"));


    }
}