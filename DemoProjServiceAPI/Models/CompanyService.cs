using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProjServiceAPI.Models
{
    public class CompanyService
    {

        public static List<Company> GetCompanies()
        {
            //return listEmp.First(e => e.ID == id);  
            SqlDataReader reader = null;
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Server=198.71.226.2;Database=infocept_xdev;User ID=infocept_xdev;Password=8Aaqc%12;";
            myConnection.Open();

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select companyID,companyName,email,phoneNumber from tblCompany";
            sqlCmd.Connection = myConnection;
            reader = sqlCmd.ExecuteReader();
            List<Company> lst = null;
            while (reader.Read())
            {
                lst = new List<Company>()
                {
                    new Company {Id=Convert.ToInt32(reader.GetValue(0)), Name=reader.GetValue(1).ToString(),EmailId=reader.GetValue(2).ToString(),Phone=reader.GetValue(3).ToString() },


                };

            }


            myConnection.Close();
            return lst;
        }
    }
}
