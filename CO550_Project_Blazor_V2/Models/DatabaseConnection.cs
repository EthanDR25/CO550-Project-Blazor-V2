using System.Net.NetworkInformation;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;

namespace CO550_Project_Blazor_V2.Models
{
    public class DatabaseConnection
    {

        //SqlCommand com = new SqlCommand();

        //SqlDataReader dr;

        //SqlConnection con = new SqlConnection();

        //List<DatabaseAddress> DBaddresses = new List<DatabaseAddress>();
        //public void FetchData()
        //{
        //    if(DBaddresses.Count > 0)
        //    {
        //        DBaddresses.Clear();
        //    }

        //    con.ConnectionString = CO550_Project_Blazor_V2.Properties.Resources.ConnectionString;

        //    try
        //    {
        //        con.Open();

        //        com.Connection = con;

        //        com.CommandText = "SELECT TOP (1000) [FilmID]\r\n      ,[Title]\r\n      ,[ReleaseDate]\r\n      ,[Duration]\r\n      ,[Price]\r\n      ,[Genre]\r\n      ,[Director]\r\n  FROM [aspnet-C0550_Project_MVC-A9A37BF3-47EF-4C23-83A7-24BDFF23D620].[dbo].[Film]";

        //        dr = com.ExecuteReader();

        //        while(dr.Read())
        //        {
        //            DBaddresses.Add(new DatabaseAddress()
        //            {
        //                FilmID = dr["FilmID"].ToString()
        //                Title = dr["Title"].ToString(),
        //                ReleaseDate = dr["ReleaseDate"].ToString(),
        //                Director = dr["Director"].ToString(),
        //                Duration = dr["Duration"].ToString(),
        //                Price = dr["Price"].ToString(),
        //                Genre = dr["Genre"].ToString()
        //            });
        //        }

        //        con.Close();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }

            
        //}
    }
}
