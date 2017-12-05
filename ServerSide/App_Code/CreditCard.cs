using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCard
/// </summary>
public class CreditCard
{
    private string username;
    private string code;
    private string expiryDate;
    private int cvv;
  

	public CreditCard()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public string Username
    {
        get { return username; }
        set { username = value; }
    }


    public string Code
    {
        get { return code; }
        set { code = value; }
    }

    public string ExpiryDate
    {
        get { return expiryDate; }
        set { expiryDate = value; }
    }


    public int Cvv
    {
        get { return cvv; }
        set { cvv = value; }
    }
}