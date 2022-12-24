using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace InVentory_Management_System_MarsTrackTech.Views.Admin
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadRecord();
            }
        }


        SqlConnection con = new SqlConnection("Data Source = 132.148.75.0,1435; Initial Catalog = TRADING; Persist Security Info = True; User ID = amc; Password = amc123");
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("INSERT INTO OM_CLIENT_MASTER(OM_CLIENT_CODE,OM_CLIENT_NAME,OM_CLIENT_CONTACT_TELEPHONE,OM_CLIENT_ADDRESS_1,OM_CLIENT_COUNTRY,OM_CLIENT_CITY,OM_CLIENT_ZIP) VALUES('" + Ccode.Value + "', '" + Cname.Value + "','" + Cmobile.Value + "','" + Cadress.Value + "','" + Ccountry.Value + "','" + Ccity.Value + "','" + Czipcode.Value + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Customer Added!!";
            LoadRecord();

        }
        void LoadRecord()
        {
            SqlCommand command = new SqlCommand("select OM_CLIENT_CODE,OM_CLIENT_NAME,OM_CLIENT_CONTACT_TELEPHONE,OM_CLIENT_ADDRESS_1,OM_CLIENT_COUNTRY,OM_CLIENT_CITY,OM_CLIENT_ZIP from OM_CLIENT_MASTER ORDER BY OM_CLIENT_CODE DESC", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Clist.DataSource = dt;
            Clist.DataBind();
        }
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("UPDATE OM_CLIENT_MASTER SET  OM_CLIENT_NAME = '" + Cname.Value + "',OM_CLIENT_CONTACT_TELEPHONE='" + Cmobile.Value + "',OM_CLIENT_ADDRESS_1='" + Cadress.Value + "',OM_CLIENT_COUNTRY='" + Ccountry.Value + "',OM_CLIENT_CITY='" + Ccity.Value + "',OM_CLIENT_ZIP='" + Czipcode.Value + "' WHERE  OM_CLIENT_CODE='" + Ccode.Value + "'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Customer Updated Succesfully";
            LoadRecord();
        }
        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

            SqlCommand com = new SqlCommand("DELETE FROM OM_CLIENT_MASTER  WHERE  OM_CLIENT_CODE='" + Ccode.Value + "'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Customer Deleted Succesfully";
            LoadRecord();

        }

        protected void SearchBtn_Click(Object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select OM_CLIENT_CODE,OM_CLIENT_NAME,OM_CLIENT_CONTACT_TELEPHONE,OM_CLIENT_ADDRESS_1,OM_CLIENT_COUNTRY,OM_CLIENT_CITY,OM_CLIENT_ZIP from OM_CLIENT_MASTER WHERE OM_CLIENT_CODE='" + Csearch.Value + "' OR OM_CLIENT_NAME='" +Cdb1.Value + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Clist.DataSource = dt;
            Clist.DataBind();
         
       }

        
        protected void GetBtn_Click(Object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select OM_CLIENT_CODE,OM_CLIENT_NAME,OM_CLIENT_CONTACT_TELEPHONE,OM_CLIENT_ADDRESS_1,OM_CLIENT_COUNTRY,OM_CLIENT_CITY,OM_CLIENT_ZIP from OM_CLIENT_MASTER WHERE OM_CLIENT_CODE='" + Cdb.Value + "' ", con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                Ccode.Value = r.GetValue(0).ToString();
                Cname.Value = r.GetValue(1).ToString();
                Cmobile.Value = r.GetValue(2).ToString();
                Cadress.Value = r.GetValue(3).ToString();   
                Ccountry.Value = r.GetValue(4).ToString();  
                Ccity.Value = r.GetValue(5).ToString();
                Czipcode.Value = r.GetValue(6).ToString();
                
                
            }

        }

    }
}