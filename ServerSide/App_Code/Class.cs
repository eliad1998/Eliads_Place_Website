using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class
/// </summary>
public class Class
{
    private string idClass;

    private string nameClass;

    private int duration;

    private int maxPart;

    private string ages;

    private string gender;

    private string pic;
	public Class()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string Id
    {
        get { return idClass; }
        set { idClass = value; }
    }

    public string Name
    {
        get { return nameClass; }
        set { nameClass = value; }
    }

    public int Duration
    {
        get { return duration; }
        set { duration = value; }
    }



    public int MaxPart
    {
        get { return maxPart; }
        set { maxPart = value; }
    }

    public string Ages
    {
        get { return ages; }
        set { ages = value; }
    }

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }


    public string Pic
    {
        get { return pic; }
        set { pic = value; }
    }



}