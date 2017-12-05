using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderDetails
/// </summary>
public class OrderDetails
{
    private string idOrder;
    private string idProduct;
    private string quantity;
    private int total;
    private int price;
	public OrderDetails()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string IdOrder
    {
        get { return idOrder; }
        set { idOrder = value; }
    }


    public string IdProduct
    {
        get { return idProduct; }
        set { idProduct = value; }
    }

    public int Quantity
    {
        get { return Quantity; }
        set { Quantity = value; }
    }


    public int Price
    {
        get { return price; }
        set { price = value; }
    }
}