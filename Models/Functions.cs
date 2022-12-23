using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InVentory_Management_System_MarsTrackTech.Models
{
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;
         public Functions() { 
        
            ConStr = @"Data Source = 132.148.75.0,1435; Initial Catalog = TRADING; Persist Security Info = True; User ID = amc; Password = amc123";
            Con= new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection= Con;
        }

        public DataTable GetData(string Query) {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query,ConStr);
            Sda.Fill(dt);
            return dt;
        }

        public int setData(string Query)
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed) {
                Con.Open();
            }
            Cmd.CommandText= Query;
            cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
    }
}