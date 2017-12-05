using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class AddOrder : System.Web.UI.Page
{
    private DataTable dtOrders = null;
   
    private static DataTable  dtClient = null;

   // private string username = "";
    private localhost.Service s = new localhost.Service();

    private localhost.CreditCard card = new localhost.CreditCard();

    private localhost.Order order = new localhost.Order();

    private localhost.OrderDetails details = new localhost.OrderDetails();
       private void BindDataCreditCard()
        {

            for (int i = 0; i < 15; i++)
            {
                string year = Convert.ToString(DateTime.Now.Year + i);
                dropYear.Items.Add(new ListItem(year, year));
            }

            for (int i = 1; i <= 12; i++)
            {
                string text = (i < 10) ? "0" + i.ToString() : i.ToString();
                dropMonth.Items.Add(new ListItem(text, i.ToString()));
            }
        }


       private int GetTotal()
       {
           int total=0;
           for (int i = 0; i < GrdOrder.Rows.Count; i++)
               total += int.Parse(GrdOrder.Rows[i].Cells[2].Text);

           return total;
       }

       protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Session["user"] == null)
                Response.Redirect("Home.aspx");

            else if (Session["order"] == null)
                Response.Redirect("Orders.aspx");
            else
            {
                dtClient = (DataTable)Session["user"];

                //Response.Write(Functions.AlertBox(dtClient.Rows[0][0].ToString()));
                dtOrders = (DataTable)Session["order"];
                GrdOrder.DataSource = dtOrders;


                GrdOrder.DataBind();

                BindDataCreditCard();

            }
        }

    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
       // Response.Write(Functions.AlertBox(dtClient.Rows[0][0].ToString()));
        //Add the credit card
        localhost.CreditCard card = new localhost.CreditCard();


        card.Username = dtClient.Rows[0][0].ToString();
        card.Code = txtCode.Text;

        card.ExpiryDate = dropMonth.SelectedValue + "/" + dropYear.SelectedValue;

        card.Cvv = int.Parse(txtCvv.Text);


       if (!s.SearchCardCode(txtCode.Text))
        s.AddCreditCard(card);

        //******************************************************


        //Add the order products

       localhost.Order order = new localhost.Order();

       string generate = Functions.generateID();

       while (s.SearchOrderId(generate))
           generate = Functions.generateID();

       order.Id = generate;

       order.Username = dtClient.Rows[0][0].ToString();

       order.Date = DateTime.Now.ToString("dd/MM/yyyy");

       order.Total = GetTotal();

       order.Status = 1;
       s.AddOrder(order);
        //Add the order details
        string idProduct = "";
        //localhost.OrderDetails details = new localhost.OrderDetails();
        //for (int i = 0; i < GrdOrder.Rows.Count; i++)
        //{
        //    idProduct = s.SearchProducts(2, GrdOrder.Rows[i].Cells[0].Text,"All types","All Providers", "On the store").Rows[0][0].ToString();
        //    details.IdOrder = generate;

        //    details.IdProduct = idProduct;

        //    details.Price = int.Parse(GrdOrder.Rows[i].Cells[2].Text) / int.Parse(GrdOrder.Rows[i].Cells[1].Text);

        //    details.Quantity = int.Parse(GrdOrder.Rows[i].Cells[1].Text);


        //    s.AddOrderDetails(details);

        //}

        




    }
}