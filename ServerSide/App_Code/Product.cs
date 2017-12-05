using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    private string id;
    private string name;
    private string information;
    private int minCap;
    private int maxCap;
    private int curCap;
    private int price;
    private int myPrice;
    private int provider;
    private string pic;
    private int status;
    public Product()
    {

    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Information
    {
        get { return information; }
        set { information = value; }
    }


    public int MinCap
    {
        get { return minCap; }
        set { minCap = value; }
    }

    public int MaxCap
    {
        get { return maxCap; }
        set { maxCap = value; }
    }

    public int CurCap
    {
        get { return curCap; }
        set { curCap = value; }
    }


    public int Price
    {
        get { return price; }
        set { price = value; }
    }

    public int MyPrice
    {
        get { return myPrice; }
        set { myPrice = value; }
    }



    public int Provider
    {
        get { return provider; }
        set { provider = value; }
    }



    public string Pic
    {
        get { return pic; }
        set { pic = value; }
    }


    public int Status
    {
        get { return status; }
        set { status = value; }
    }
}