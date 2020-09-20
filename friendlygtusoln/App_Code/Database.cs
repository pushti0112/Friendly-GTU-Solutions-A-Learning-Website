using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Database
/// </summary>
public class Database
{
    //string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    static String strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|Datadirectory|Database.mdf;Integrated Security=True";

   // static String strcon = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|Datadirectory|shrijaydwarkadhis.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
    

    SqlConnection con = new SqlConnection(strcon);
    String error = "";

    public String getConnectionString()
    {
        return strcon;
    }

    public void conn_state()
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

    }

    public Boolean insert(string query)
    {
        try
        {
            conn_state();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            error = ex.Message;
            return false;
        }

    }
    public String getErrorMsg()
    {
        return error;
    }

    public Boolean update(string query)
    {
        try
        {
            conn_state();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }




    public DataSet select(string query)
    {
        try
        {
            conn_state();
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
           
            adp.Fill(ds);
            return ds;
        }
        catch (Exception ex)
        {
            return null;
        }

    }



    public int auto(string field, string table)
    {
        int no = 0;
        string str = "select max(" + field + ") from " + table + "";
        try
        {
            conn_state();
            SqlCommand cmd = new SqlCommand(str, con);
            no = Convert.ToInt32(cmd.ExecuteScalar());
            no = no + 1;
            return no;


        }
        catch (Exception ex)
        {
            no = 1;
            return no;
        }

    }
}