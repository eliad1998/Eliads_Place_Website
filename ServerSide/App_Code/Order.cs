using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Order
/// </summary>
public class Order
{
       private string id;
    private string username;
    private string date;
    private int total;
    private int status;

    	public Order()
	{
	}
    public string Id
    {
        get { return id; }
        set { id = value; }
    }


    public string Username
    {
        get { return username; }
        set { username = value; }
    }

    public string Date
    {
        get { return date; }
        set { date = value; }
    }

    public int Total
    {
        get { return total; }
        set { total = value; }
    }

    public int Status
    {
        get { return status; }
        set { status = value; }
    }


}

