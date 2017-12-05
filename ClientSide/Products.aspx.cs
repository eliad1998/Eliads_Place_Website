using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class Products : System.Web.UI.Page
{
    private DataTable dt = null;
    private DataTable dtProviders = null;

    private localhost.Service s = new localhost.Service();

    private string sql = "";
    private void Show(DataTable dt)
    {
            if (dt.Rows.Count == 0)
                lbldidnt.Visible = true;

            else
            {
                lbldidnt.Visible = false;
                GrdProducts.DataSource = dt;

                GrdProducts.DataBind();

                for (int i = 0; i < GrdProducts.Rows.Count; i++)
                {
                    GrdProducts.Rows[i].Cells[5].Text = s.GetProviderFromId(int.Parse(GrdProducts.Rows[i].Cells[5].Text));

                    if (GrdProducts.Rows[i].Cells[7].Text.Equals("1"))
                        GrdProducts.Rows[i].Cells[7].Text = "YES";

                    else
                        GrdProducts.Rows[i].Cells[7].Text = "No";
                }
            }

        }

    

    private void DropSearchChange()
    {
        if (dropSearch.SelectedIndex == 0)
        {
            txtSearch.ReadOnly = true;
            txtSearch.Text = string.Empty;
        }
        else
            txtSearch.ReadOnly = false;
    }

    private void DropTypeChange()
    {
        if (dropType.SelectedValue.Equals("Equipment"))
        {
            dtProviders = s.GetProviders("A");
            dt = s.GetAllProducts("A");
        }

        else if (dropType.SelectedValue.Equals("Nutrition"))
        {
            dtProviders = s.GetProviders("B");
            dt = s.GetAllProducts("B");
        }
        else
        {
            dtProviders = s.GetProviders("All");
            dt = s.GetAllProducts("All");
        }
  
        dropProvider.Items.Clear();
        dropProvider.Items.Add("All Providers");
        for (int i = 0; i < dtProviders.Rows.Count; i++)
            dropProvider.Items.Add(dtProviders.Rows[i][1].ToString());


    }


    protected void Page_Load(object sender, EventArgs e)
    {
  
        if (!Page.IsPostBack)
        {
            sql = "SELECT * FROM Products";
            dt = s.SearchBySql(sql, "Products");
            Show(dt);

            DropTypeChange();
            DropSearchChange();

        }


    }
    ////  protected override void OnUnload(EventArgs e)
    ////{
    ////    base.OnUnload(e);

    ////    // your code
    ////   // Response.Write(Functions.AlertBox("Bye"));
    ////}





    protected void btnSearch_Click(object sender, EventArgs e)
    {
        dt = s.SearchProducts(dropSearch.SelectedIndex, txtSearch.Text, dropType.SelectedValue, dropProvider.SelectedValue, dropStatus.SelectedValue);

        Show(dt);

        if (txtSearch.Text.Equals(string.Empty))
        {
            dropSearch.SelectedIndex = 0;
            txtSearch.ReadOnly = true;
        }
    }


    protected void dropType_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropTypeChange();

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        //Get the row that contains this button
        GridViewRow gvr = (GridViewRow)btn.NamingContainer;

        int row = gvr.RowIndex;
        
        string id = GrdProducts.Rows[row].Cells[1].Text;
        Response.AppendHeader("Refresh", "0;url=ShowProduct.aspx?id="+id);
    }
    protected void dropSearch_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropSearchChange();
    }
    protected void GrdProducts_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GrdProducts.PageIndex = e.NewPageIndex;
        dt = s.SearchProducts(dropSearch.SelectedIndex, txtSearch.Text, dropType.SelectedValue, dropProvider.SelectedValue, dropStatus.SelectedValue);

        Show(dt);

        //dt = s.SearchBySql("Select * from Products", "Procuts");

        //GrdProducts.DataSource = dt;

        //GrdProducts.DataBind();
    }
}