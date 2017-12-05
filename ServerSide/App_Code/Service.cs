using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    private string GetPath()
    {
        string path = Server.MapPath("App_Data/db.mdb");
        return path;
    }

    [WebMethod]
    public DataTable GetAllClients() {
      
       string sql="SELECT * FROM Clients";
       return (Connect.DownloadData(sql, "Clients", GetPath()));
    }

    [WebMethod]
    public bool HasClient(string username)
    {
          string sql="SELECT * FROM Clients WHERE [Username]='"+username+"'";
        DataTable dt=(Connect.DownloadData(sql, "Clients", GetPath()));

        return dt.Rows.Count!=0;
    }


    //Search datatables


    [WebMethod]
    public DataTable SearchById(string id)
    {
        string sql = "SELECT * FROM Clients WHERE Username='" + id + "'";

        return Connect.DownloadData(sql, "Clients", GetPath());
    }


    [WebMethod]
    public DataTable SearchBySql(string sql,string table)
    {
        return Connect.DownloadData(sql,table,GetPath());
    }

        [WebMethod]
    public DataTable GetAllTrainers()
    {
        string sql = "SELECT * FROM Clients WHERE [Level]='Trainer' OR [Level]='Admin' AND [Status]='Online'";
        return Connect.DownloadData(sql, "Clients", GetPath());
    }


    [WebMethod]
    public string CityFromid(int id) //מקבל את האיידי של העיר ומחזיר את שם העיר
    {
        string sql = "SELECT * FROM Cities WHERE idCity=" + id;

        return Connect.DownloadData(sql, "Cities", GetPath()).Rows[0][1].ToString();
    }

    //*********************************************


    //DELETE
    [WebMethod]


    public void Delete_Client(string username)
    {
           string sql = "UPDATE Clients SET [Status]='Offline' WHERE [Username]='"+username+"'";
   
      OleDbCommand cmd = new OleDbCommand(sql);

           Connect.TakeAction(cmd, GetPath());
    }

    [WebMethod]
    public void Restore_Client(string username)
    {
        string sql = "UPDATE Clients SET [Status]='Online' WHERE [Username]='" + username + "'";

        OleDbCommand cmd = new OleDbCommand(sql);

        Connect.TakeAction(cmd, GetPath());
    }




    //***********

    /// <summary>
    /// 
    /// </summary>
    /// <param name="c"></param>

    [WebMethod]
    public void AddNewClient(Client c) //client יבוא מהטופס יקרא לשרות ותפקיד השרות לשמור אותו במסד נתונים
    {
        string sql = "INSERT INTO Clients values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)";

        OleDbCommand cmd = new OleDbCommand(sql);

        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = c.Username;


        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = c.Password;

        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = c.FirstName;

        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.VarChar));
        cmd.Parameters["@p4"].Value = c.LastName ;


        cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.VarChar));
        cmd.Parameters["@p5"].Value = c.Gender;



        cmd.Parameters.Add(new OleDbParameter("@p6", OleDbType.Integer));
        cmd.Parameters["@p6"].Value = c.City;


        cmd.Parameters.Add(new OleDbParameter("@p7", OleDbType.VarChar));
        cmd.Parameters["@p7"].Value = c.Street;


        cmd.Parameters.Add(new OleDbParameter("@p8", OleDbType.VarChar));
        cmd.Parameters["@p8"].Value = c.NumStreet;


        cmd.Parameters.Add(new OleDbParameter("@p9", OleDbType.VarChar));
        cmd.Parameters["@p9"].Value = c.Age;

        cmd.Parameters.Add(new OleDbParameter("@p10", OleDbType.VarChar));
        cmd.Parameters["@p10"].Value = c.Mail;

        cmd.Parameters.Add(new OleDbParameter("@p11", OleDbType.VarChar));
        cmd.Parameters["@p11"].Value = c.Phone;

        cmd.Parameters.Add(new OleDbParameter("@p12", OleDbType.VarChar));
        cmd.Parameters["@p12"].Value = c.Pic;

        cmd.Parameters.Add(new OleDbParameter("@p13", OleDbType.VarChar));
        cmd.Parameters["@p13"].Value = c.Level ;


        cmd.Parameters.Add(new OleDbParameter("@p14", OleDbType.VarChar));
        cmd.Parameters["@p14"].Value = c.Status;

        Connect.TakeAction(cmd, GetPath());

    }


    [WebMethod]
    public DataTable GetAllCities()
    {

        string sql = "SELECT * FROM Cities";
        return (Connect.DownloadData(sql, "Cities", GetPath()));
    }

    [WebMethod]
    public DataTable LoginDT(string username, string password)
    {
        string sql = "SELECT * FROM Clients WHERE username='" + username + "' AND password='" + password + "'";

        DataTable dt = Connect.DownloadData(sql, "Clients", Server.MapPath("App_Data/db.mdb"));

        return dt;
    }

    [WebMethod]
    public void UpdateClient(Client c)
    {
        string sql = "UPDATE Clients SET [Password]=@p1,[FirstName]=@p2,[LastName]=@p3,[City]=@p4,[Street]=@p5,[NumStreet]=@p6,[Mail]=@p7,[Phone]=@p8,[pic]=@p9 WHERE [username]=@p10";
   
      OleDbCommand cmd = new OleDbCommand(sql);

        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = c.Password;


        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = c.FirstName;

        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = c.LastName ;

        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.Integer));
        cmd.Parameters["@p4"].Value = c.City;


        cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.VarChar));
        cmd.Parameters["@p5"].Value = c.Street;


        cmd.Parameters.Add(new OleDbParameter("@p6", OleDbType.VarChar));
        cmd.Parameters["@p6"].Value = c.NumStreet;


        cmd.Parameters.Add(new OleDbParameter("@p7", OleDbType.VarChar));
        cmd.Parameters["@p7"].Value = c.Mail;

        cmd.Parameters.Add(new OleDbParameter("@p8", OleDbType.VarChar));
        cmd.Parameters["@p8"].Value = c.Phone;

        cmd.Parameters.Add(new OleDbParameter("@p9", OleDbType.VarChar));
        cmd.Parameters["@p9"].Value = c.Pic;

        cmd.Parameters.Add(new OleDbParameter("@p10", OleDbType.VarChar));
        cmd.Parameters["@p10"].Value = c.Username;

    

        Connect.TakeAction(cmd, GetPath());
    }


    //ציוד ותוספי תזונה
    [WebMethod]
    public DataTable GetProviders(string type)
    {
        //All providers
        string sql = "SELECT * FROM Providers";

        //Equipment
        if(type.Equals("A"))
            sql+=" WHERE [Type]='A'";

                //Nutirition
         if(type.Equals("B"))
                sql+=" WHERE [Type]='B'";
        return (Connect.DownloadData(sql, "Providers", GetPath()));
    }

    [WebMethod]
    public int GetProviderId(string provider)
    {
        switch (provider)
        {
            case "TechnoGym":
                return 1;

            case "ENERGYM":
                return 2;
         
            case "VO2":
                return 3;
          
            case "MARCY":
                return 4;
  
            case "Super Effect":
                return 5;
         
            case "Dymatize":
                return 6;
     
            case "ANSI":
                return 7;

            case "Inner Armour":
                return 8;
         
            default:
                return 0;
        }
    }

    [WebMethod]
    public string GetProviderFromId(int provider)
    {
        switch (provider)
        {
            case 1 :
                return "TechnoGym";

            case 2:
                return "ENERGYM";

            case 3:
                return "VO2";

            case 4:
                return "MARCY";

            case 5:
                return "Super Effect";

            case 6:
                return "Dymatize";

            case 7:
                return "ANSI";

            case 8:
                return "Inner Armour";

            default:
                return string.Empty;
        }
    }
    //datatable of equipments/all/nutrition
    [WebMethod]
    public DataTable GetAllProducts(string type)
    {
        string sql = "";
        if(type.Equals("A"))
        {
         sql="SELECT * FROM Products WHERE IdProduct LIKE 'A%'";
         return Connect.DownloadData(sql, "Products", GetPath());
        }

        else if (type.Equals("B"))
        {
            sql = "SELECT * FROM Products WHERE IdProduct LIKE 'B%'";
            return Connect.DownloadData(sql, "Products", GetPath());
        }

        else //All products
        {
            sql = "SELECT * FROM Products";
            return Connect.DownloadData(sql, "Products", GetPath());
        }
    }
        [WebMethod]
    public void AddNewProduct(Product p) //product יבוא מהטופס יקרא לשרות ותפקיד השרות לשמור אותו במסד נתונים
    {
        string sql = "INSERT INTO Products values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";

        OleDbCommand cmd = new OleDbCommand(sql);

        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = p.Id;


        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value =p.Name;

        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = p.Information;

        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.Integer));
        cmd.Parameters["@p4"].Value = p.MinCap;

        cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.Integer));
        cmd.Parameters["@p5"].Value = p.MaxCap;


        cmd.Parameters.Add(new OleDbParameter("@p6", OleDbType.Integer));
        cmd.Parameters["@p6"].Value = p.CurCap;



        cmd.Parameters.Add(new OleDbParameter("@p7", OleDbType.Integer));
        cmd.Parameters["@p7"].Value = p.Price;


        cmd.Parameters.Add(new OleDbParameter("@p8", OleDbType.Integer));
        cmd.Parameters["@p8"].Value = p.MyPrice;


        cmd.Parameters.Add(new OleDbParameter("@p9", OleDbType.Integer));
        cmd.Parameters["@p9"].Value = p.Provider;


        cmd.Parameters.Add(new OleDbParameter("@p10", OleDbType.VarChar));
        cmd.Parameters["@p10"].Value = p.Pic;

        cmd.Parameters.Add(new OleDbParameter("@p11", OleDbType.VarChar));
        cmd.Parameters["@p11"].Value = p.Status;


        Connect.TakeAction(cmd, GetPath());

    }

    [WebMethod]
       public string GiveId(string letter)
    {
        DataTable products;
        if (letter.Equals("A")) //Equipment
        {
            products = GetAllProducts("A");

            return "A" + products.Rows.Count;
        }

        else
        {
            products = GetAllProducts("B");

            return "B" + products.Rows.Count;
        }
    }

    [WebMethod]
    public DataTable SearchProductById(string id)
    {
        string sql = "SELECT * FROM Products WHERE IdProduct='"+id+"'";

        return Connect.DownloadData(sql, "Products", GetPath());
    }

    [WebMethod]
    public DataTable SearchProducts(int func, string value,string type,string provider,string status)
    {
        string sql="SELECT * FROM Products";

        if (!value.Equals(string.Empty))
        {
            switch (func)
            {

                case 1: //Search by id
                    sql += " WHERE IdProduct='" + value + "'";
                    break;
                case 2: //Search by name
                    sql += " WHERE NameProduct='" + value + "'";
                    break;
                case 3: //Search by price lower than value
                    sql += " WHERE [Price]<=" + int.Parse(value);
                    break;

            }

            if (!type.Equals("All types"))
            {
                if (type.Equals("Equipment"))
                    sql += " AND IdProduct LIKE 'A%'";

                else //Nutrition
                    sql += " AND IdProduct LIKE 'B%'";

            }


            if (!provider.Equals("All Providers"))
                sql += " AND Provider=" + GetProviderId(provider);

            if (!status.Equals("All"))
            {
                if (status.Equals("On the store"))
                    sql += " AND [Status]=1";

                else //Not on the store
                    sql += " AND [Status]=0";
            }
        }

        else //value=String.Empty
        {
            //Search by company
            if (!type.Equals("All types"))
            {
                if (type.Equals("Equipment"))
                    sql += " WHERE IdProduct LIKE 'A%'";

                else //Nutrition
                    sql += " WHERE IdProduct LIKE 'B%'";



                if (!provider.Equals("All Providers"))
                    sql += " AND Provider=" + GetProviderId(provider);

                if (!status.Equals("All"))
                {
                    if (status.Equals("On the store"))
                        sql += " AND [Status]=1";

                    else //Not on the store
                        sql += " AND [Status]=0";
                }
            }

            else
            {
                if (!provider.Equals("All Providers"))
                {
                    sql += " WHERE Provider=" + GetProviderId(provider);

                    if (!status.Equals("All"))
                    {
                        if (status.Equals("On the store"))
                            sql += " AND [Status]=1";

                        else //Not on the store
                            sql += " AND [Status]=0";
                    }
                }

                else
                {
                    if (!status.Equals("All"))
                    {
                        if (status.Equals("On the store"))
                            sql += " WHERE [Status]=1";

                        else //Not on the store
                            sql += " WHERE [Status]=0";
                    }
                }

            }

        }
        return SearchBySql(sql, "Products");
    }




    [WebMethod]
    public void UpdateProduct(Product p)
    {
        string sql = "UPDATE Products SET [NameProduct]=@p1,[Information]=@p2,[MinCap]=@p3,[MaxCap]=@p4,[CurCap]=@p5,[Price]=@p6,[MyPrice]=@p7,[Provider]=@p8,[Pic]=@p9 WHERE [IdProduct]=@p10";

        OleDbCommand cmd = new OleDbCommand(sql);


        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = p.Name;

        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = p.Information;

        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.Integer));
        cmd.Parameters["@p3"].Value = p.MinCap;


        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.Integer));
        cmd.Parameters["@p4"].Value = p.MaxCap;


        cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.Integer));
        cmd.Parameters["@p5"].Value = p.CurCap;


        cmd.Parameters.Add(new OleDbParameter("@p6", OleDbType.Integer));
        cmd.Parameters["@p6"].Value = p.Price;

        cmd.Parameters.Add(new OleDbParameter("@p7", OleDbType.Integer));
        cmd.Parameters["@p7"].Value = p.MyPrice;

        cmd.Parameters.Add(new OleDbParameter("@p8", OleDbType.Integer));
        cmd.Parameters["@p8"].Value = p.Provider;

        cmd.Parameters.Add(new OleDbParameter("@p9", OleDbType.VarChar));
        cmd.Parameters["@p9"].Value = p.Pic;

        cmd.Parameters.Add(new OleDbParameter("@p10", OleDbType.VarChar));
        cmd.Parameters["@p10"].Value = p.Id;


        Connect.TakeAction(cmd, GetPath());
    }

    [WebMethod]
    public void DeleteOrRestoreProduct(string id,bool delete)
    {

        string sql;
        if (delete) //delete
             sql = "UPDATE Products SET [Status]=0 WHERE [IdProduct]=@p1";

        else//restore
            sql = "UPDATE Products SET [Status]=1 WHERE [IdProduct]=@p1";

            OleDbCommand cmd = new OleDbCommand(sql);
            cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
            cmd.Parameters["@p1"].Value = id;


            Connect.TakeAction(cmd, GetPath());
        }

   

    /**************
    Credit Card functions
    */

    [WebMethod]
    public void AddCreditCard(CreditCard c)
    {
        string sql = "INSERT INTO CreditCard values(@p1,@p2,@p3,@p4)";

        OleDbCommand cmd = new OleDbCommand(sql);

        cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
        cmd.Parameters["@p1"].Value = c.Username;


        cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
        cmd.Parameters["@p2"].Value = c.Code;

        cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
        cmd.Parameters["@p3"].Value = c.ExpiryDate;

        cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.Integer));
        cmd.Parameters["@p4"].Value = c.Cvv;

        Connect.TakeAction(cmd, GetPath());
    }
      [WebMethod]
    public bool SearchCardCode(string code)
    {
        string sql = "SELECT * FROM CreditCard WHERE Code='" + code + "'";

        DataTable dt = SearchBySql(sql, "CreditCard");

          //If true-found
        return dt.Rows.Count != 0;

    }

    //Order functions
    [WebMethod]
      public void AddOrder(Order order)
      {
          string sql = "INSERT INTO Orders values(@p1,@p2,@p3,@p4,@p5)";

          OleDbCommand cmd = new OleDbCommand(sql);

          cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
          cmd.Parameters["@p1"].Value = order.Id;


          cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
          cmd.Parameters["@p2"].Value = order.Username;

          cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.VarChar));
          cmd.Parameters["@p3"].Value = order.Date;

          cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.Integer));
          cmd.Parameters["@p4"].Value = order.Total; ;

          cmd.Parameters.Add(new OleDbParameter("@p5", OleDbType.Integer));
          cmd.Parameters["@p5"].Value = order.Status; ;
          Connect.TakeAction(cmd, GetPath());
      }

    [WebMethod]
    public bool SearchOrderId(string id)
      {
          string sql = "SELECT * FROM Orders WHERE IdOrder='" + id + "'";

          DataTable dt = SearchBySql(sql,"Orders");

          return dt.Rows.Count != 0;
      }




      //  OrderDetails functions
    [WebMethod]
      public void AddOrderDetails(OrderDetails details)
      {
          string sql = "INSERT INTO OrderDetails values(@p1,@p2,@p3,@p4)";

          OleDbCommand cmd = new OleDbCommand(sql);

          cmd.Parameters.Add(new OleDbParameter("@p1", OleDbType.VarChar));
          cmd.Parameters["@p1"].Value = details.IdOrder;


          cmd.Parameters.Add(new OleDbParameter("@p2", OleDbType.VarChar));
          cmd.Parameters["@p2"].Value = details.IdProduct;

          cmd.Parameters.Add(new OleDbParameter("@p3", OleDbType.Integer));
          cmd.Parameters["@p3"].Value = details.Quantity;

          cmd.Parameters.Add(new OleDbParameter("@p4", OleDbType.Integer));
          cmd.Parameters["@p4"].Value = details.Price;

          Connect.TakeAction(cmd, GetPath());
      }


   
}