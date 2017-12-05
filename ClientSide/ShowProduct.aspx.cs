using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class ShowProduct : System.Web.UI.Page
{
    private DataTable dtClient = null;
    private DataTable dtProduct = null;
    private DataTable dtProviders = null;
    private string level = "";
    private localhost.Service s = new localhost.Service();
    private localhost.Product p = new localhost.Product();
    private void AllowUpdate(bool allow)
    {
        if (allow)
        {
            txtName.ReadOnly = false;
            txtInformation.ReadOnly = false;
            txtMinCap.ReadOnly = false;
            txtMaxCap.ReadOnly = false;
            txtCurCap.ReadOnly = false;
            txtPrice.ReadOnly = false;
            dropProvider.Enabled = true;
            lblPicChange.Visible = true;
            fuImage.Visible = true;
            txtMyPrice.ReadOnly = false;
        }

        else
        {
            txtName.ReadOnly = true;
            txtInformation.ReadOnly = true;
            txtMinCap.ReadOnly = true;
            txtMaxCap.ReadOnly = true;
            txtCurCap.ReadOnly = true;
            txtPrice.ReadOnly = true;
            dropProvider.Enabled = false;
            lblPicChange.Visible = false;
            fuImage.Visible = false;
            txtMyPrice.ReadOnly = true;
        }
    }

    private void ShowProviders(char letter)
    {
        string provider = s.GetProviderFromId(int.Parse(dtProduct.Rows[0][8].ToString()));
        int j = 0;
        if (letter == 'A')//Equipment
            dtProviders = s.GetProviders("A");

        else//Nutriton
            dtProviders = s.GetProviders("B");

        string[] providers = new string[dtProviders.Rows.Count];
        for (int i = 0; i < dtProviders.Rows.Count; i++)
            dropProvider.Items.Add(dtProviders.Rows[i][1].ToString());


        dropProvider.Items.FindByValue(provider).Selected = true;

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            //Show details about product
            //******************************************
            string id = Request.QueryString["id"];
            //if (id.Equals(string.Empty))
            //    Response.Redirect("Products.aspx");

            dtProduct = s.SearchProductById(id);

            if (dtProduct.Rows.Count == 0) // כשמכניסים בקישור מזהה לא קיים או שסתם נכנסים לדף בלי הקישור
                Response.Redirect("Products.aspx");
            //Response.Write(Functions.AlertBox(id));

            AllowUpdate(false);
            lblId.Text = dtProduct.Rows[0][0].ToString();
            txtName.Text = dtProduct.Rows[0][1].ToString();
            txtInformation.Text = dtProduct.Rows[0][2].ToString();
            txtMinCap.Text = dtProduct.Rows[0][3].ToString();
            txtMaxCap.Text = dtProduct.Rows[0][4].ToString();
            txtCurCap.Text = dtProduct.Rows[0][5].ToString();
            txtPrice.Text = dtProduct.Rows[0][6].ToString();

            if (dtProduct.Rows[0][10].ToString().Equals("0"))
                lblInStore.Text = "No";

            else
                lblInStore.Text = "Yes";


            if (id[0] == 'A')//Equipment
            {
                ShowProviders('A');

                lblType.Text = "Equipment";
            }
            else
            {
                ShowProviders('B');
                lblType.Text = "Nutrition";
            }

            //******************************************

            Image1.ImageUrl = "~/pics/products/" + dtProduct.Rows[0][9].ToString();

            if (Session["user"] == null)
            {
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                lblMyPrice.Visible = false;
                txtMyPrice.Visible = false;
            }

            else
            {
                dtClient = (DataTable)Session["user"];

                level = dtClient.Rows[0][12].ToString();

                if (!level.Equals("Admin"))
                {
                    lblMyPrice.Visible = false;
                    txtMyPrice.Visible = false;
                    btnUpdate.Visible = false;
                    btnDelete.Visible = false;
                }

                else
                {
                    lblMyPrice.Visible = true;
                    txtMyPrice.Visible = true;
                    txtMyPrice.Text = dtProduct.Rows[0][7].ToString();
                    btnUpdate.Visible = true;
                    btnDelete.Visible = true;

                    if (lblInStore.Text.Equals("Yes"))
                        btnDelete.Text = "Delete";

                    else
                        btnDelete.Text = "Restore";
                }
            }
        }

    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        int provider;
        if (btnUpdate.Text.Equals("Update"))
        {
            AllowUpdate(true);
            btnUpdate.Text = "Save";
        }

        else
        {
            dtProduct = s.SearchProductById(lblId.Text);
            //Update
            localhost.Product p = new localhost.Product();

            p.Id = lblId.Text;

            if (txtName.Text.Length == 0)
                p.Name = dtProduct.Rows[0][1].ToString();

            else
                p.Name = txtName.Text;

            if (txtInformation.Text.Length == 0)
                p.Information = dtProduct.Rows[0][2].ToString();

            else
                p.Information = txtInformation.Text;

            if (txtMinCap.Text.Length == 0)
                p.MinCap = int.Parse(dtProduct.Rows[0][3].ToString());

            else
                p.MinCap = int.Parse(txtMinCap.Text);

            if (txtMaxCap.Text.Length == 0)
                p.MaxCap = int.Parse(dtProduct.Rows[0][4].ToString());

            else
                p.MaxCap = int.Parse(txtMaxCap.Text);

            if (txtCurCap.Text.Length == 0)
                p.CurCap = int.Parse(dtProduct.Rows[0][5].ToString());

            else
                p.CurCap = int.Parse(txtCurCap.Text);

            if (txtPrice.Text.Length == 0)
                p.Price = int.Parse(dtProduct.Rows[0][6].ToString());

            else
                p.Price = int.Parse(txtPrice.Text);

            if (txtMyPrice.Text.Length == 0)
                p.MyPrice = int.Parse(dtProduct.Rows[0][7].ToString());

            else
                p.MyPrice = int.Parse(txtMyPrice.Text);

            if (dropProvider.SelectedIndex == 0)
                provider = int.Parse(dtProduct.Rows[0][6].ToString());

            else
                provider = s.GetProviderId(dropProvider.SelectedValue);

            p.Provider = provider;
            if (fuImage.HasFile)
            {
                p.Pic = fuImage.FileName;

                fuImage.SaveAs(Server.MapPath("pics/products/" + fuImage.FileName));
            }

            else
                p.Pic = dtProduct.Rows[0][9].ToString();


            p.Status = int.Parse(dtProduct.Rows[0][10].ToString());

            s.UpdateProduct(p);

            AllowUpdate(false);
            btnUpdate.Text = "Update";

            Response.Write(Functions.AlertRedirect("The product has updated", "ShowProduct.aspx?id=" + lblId.Text));



        }


    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        if (btnDelete.Text.Equals("Delete"))
        {
            s.DeleteOrRestoreProduct(lblId.Text, true);
            Response.Write(Functions.AlertRedirect("The product has deleted", "ShowProduct.aspx?id=" + lblId.Text));
        }

        else//Restore
        {
            s.DeleteOrRestoreProduct(lblId.Text, false);
            Response.Write(Functions.AlertRedirect("The product has restored", "ShowProduct.aspx?id=" + lblId.Text));

        }

    }
}