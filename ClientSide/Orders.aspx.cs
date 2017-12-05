using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class Orders : System.Web.UI.Page
{
    private localhost.Service s = new localhost.Service();

    private static DataTable dtOrders = new DataTable(); //לקלוט מה שאני בוחר בדטא ליסט ולהוסיף שורה כל פעם
    private DataTable dtProviders = null;
    private DataTable dt = null;
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


        dtlProd.DataSource = s.SearchProducts(0, string.Empty, dropType.SelectedValue, dropProvider.SelectedValue, "On the store");

        dtlProd.DataBind();
    }


    
    private void DropProviderChange()
    {
        dtlProd.DataSource = s.SearchProducts(0, string.Empty, dropType.SelectedValue, dropProvider.SelectedValue, "On the store");

        dtlProd.DataBind();
    }


    

    protected void Page_Load(object sender, EventArgs e)
    {
    
        if (!Page.IsPostBack)
        {

            //ההזמנה חדשה
            if (Session["order"] == null)
            {
                dtOrders.TableName = "Orders";//חייבים לתת שם אחרת ייתקע

                if (dtOrders.Columns.Count == 0) //שאם נכנס עוד פעם שלא ייקרה מצב שיוסיף עוד שדות
                {
                    DataColumn dc1 = new DataColumn();

                    dc1.ColumnName = "Id";

                    dtOrders.Columns.Add(dc1);

                    DataColumn dc2 = new DataColumn();

                    dc2.ColumnName = "Name";

                    dtOrders.Columns.Add(dc2);

                    DataColumn dc3 = new DataColumn();

                    dc3.ColumnName = "Quantity";

                    dtOrders.Columns.Add(dc3);

                    DataColumn dc4 = new DataColumn();
                    dc4.ColumnName = "Total Price";

                    dtOrders.Columns.Add(dc4);


                    DataColumn dc5 = new DataColumn();
                    dc5.ColumnName = "Pic";

                    dtOrders.Columns.Add(dc5);
                }

            }

            else //התחרטות באמצע ההזמנה
            {
                dtOrders = (DataTable)Session["order"];
                GrdOrder.DataSource = dtOrders;
                GrdOrder.DataBind();
            }
            DropTypeChange();
            DropProviderChange();

        }
    }
    //Choose
    protected void dtlProd_EditCommand(object source, DataListCommandEventArgs e)
    {
       

        dtlProd.EditItemIndex = e.Item.ItemIndex;


        dtlProd.DataSource = s.SearchProducts(0, string.Empty, dropType.SelectedValue, dropProvider.SelectedValue, "On the store");

        dtlProd.DataBind();

    }
    //Cancel
    protected void dtlProd_SelectedIndexChanged(object sender, EventArgs e)
    {
        dtlProd.EditItemIndex = -1;

        dtlProd.DataSource = s.SearchProducts(0, string.Empty, dropType.SelectedValue, dropProvider.SelectedValue, "On the store");

        dtlProd.DataBind();
    }

    //Add to cart
    protected void dtlProd_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        string id = ((Label)dtlProd.Items[e.Item.ItemIndex].FindControl("lblId")).Text;
        string name = ((Label)dtlProd.Items[e.Item.ItemIndex].FindControl("lblName")).Text;

        Image img = (Image)dtlProd.Items[e.Item.ItemIndex].FindControl("img");

        string imgName = img.ImageUrl.Substring(img.ImageUrl.LastIndexOf("/") + 1);
        int curcap = int.Parse(((Label)e.Item.FindControl("lblCurCap")).Text);

        int qua =int.Parse(((DropDownList)dtlProd.Items[e.Item.ItemIndex].FindControl("drpQua")).SelectedValue);

        int price = int.Parse(((Label)dtlProd.Items[e.Item.ItemIndex].FindControl("lblPrice")).Text);

        int total = price * qua;



        int row_find=Functions.SearchGridView(GrdOrder,2, name);

        
        //The name exist so we need to update the total
        if (row_find != -1)
        {
          int updatequa = int.Parse(dtOrders.Rows[row_find][2].ToString()) + qua;

            if (updatequa > curcap)
            Response.Write(Functions.AlertBox("You can not order that capacity"));
           
            else
            {
                //Update quantity
                dtOrders.Rows[row_find][2] = (int.Parse(dtOrders.Rows[row_find][2].ToString()) + qua).ToString();

                //Update total
                dtOrders.Rows[row_find][3] = (int.Parse(dtOrders.Rows[row_find][3].ToString()) + total).ToString();

     }
        }
        else
        {
            DataRow dr = dtOrders.NewRow();
            dr[0] = id;
            dr[1] = name;

            dr[2] = qua;

            dr[3] = total;

            dr[4] = imgName;
            dtOrders.Rows.Add(dr);

        }
        GrdOrder.DataSource = dtOrders;

        GrdOrder.DataBind();

   
     
    }
    protected void GrdOrder_SelectedIndexChanged(object sender, EventArgs e)
    {
        dtOrders.Rows.RemoveAt(GrdOrder.SelectedIndex);

        GrdOrder.DataSource = dtOrders;

        GrdOrder.DataBind();
    }
    protected void dropType_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropTypeChange();
    }




    protected void dropProvider_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropProviderChange();
    }

    //event שבו אנו מתייחסים למידע שבאלמנטים שבדטה ליסט
    protected void dtlProd_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //אנחנו מתיחיסים לדרופ דוון ליסט שבתוך האדיט אייטם לכן האיף הזה
        if ((e.Item.ItemType == ListItemType.EditItem))
        {
            int curcap = int.Parse(((Label)e.Item.FindControl("lblCurCap")).Text);

          
           DropDownList drp =(DropDownList)e.Item.FindControl("drpQua");

           if (drp != null)
           {
               for (int i = 1; i <= curcap; i++)
                   drp.Items.Add(i.ToString());

           }

   
        }
    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        if (GrdOrder.Visible == false)
        {
            GrdOrder.Visible = true;
            btnShow.Text = "Hide order";

        }

        else
        {
            GrdOrder.Visible = false;
            btnShow.Text = "Show order";

        }
    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        Session["order"] = dtOrders;

       Response.Redirect("AddOrder.aspx");
    }
}