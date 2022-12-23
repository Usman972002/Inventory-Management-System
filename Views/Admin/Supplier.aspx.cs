using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace InVentory_Management_System_MarsTrackTech.Views.Admin
{
    public partial class Supplier : System.Web.UI.Page
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

            SqlCommand com = new SqlCommand("INSERT INTO FM_VENDOR_MASTER(FM_VEND_CODE,FM_VEND_NAME,FM_VEND_CONTACT_TEL,FM_VEND_EMAIL,FM_VEND_ADDR_1,FM_VEND_COUNTRY,FM_VEND_CITY,FM_VEND_ZIP_CODE) VALUES('" + Scode.Value + "', '" + Sname.Value + "','" + Smobile.Value + "','" + Semail.Value + "','" + Sadress.Value + "','" + Scountry.Value + "','" + Scity.Value + "','" + Szipcode.Value + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Supplier Added!!";
            LoadRecord();

        }
        void LoadRecord()
        {
            SqlCommand command = new SqlCommand("select FM_VEND_CODE, FM_VEND_NAME, FM_VEND_CONTACT_TEL, FM_VEND_EMAIL, FM_VEND_ADDR_1, FM_VEND_COUNTRY, FM_VEND_CITY, FM_VEND_ZIP_CODE from FM_VENDOR_MASTER", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Slist.DataSource = dt;
            Slist.DataBind();
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {


            SqlCommand com = new SqlCommand("UPDATE FM_VENDOR_MASTER SET  FM_VEND_NAME = '" + Sname.Value + "',FM_VEND_CONTACT_TEL='" + Smobile.Value + "',FM_VEND_EMAIL='" + Semail.Value + "',FM_VEND_ADDR_1='" + Sadress.Value + "',FM_VEND_COUNTRY='" + Scountry.Value + "',FM_VEND_CITY='" + Scity.Value + "',FM_VEND_ZIP_CODE='" + Szipcode.Value + "' WHERE  FM_VEND_CODE='" + Scode.Value + "'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Supplier Updated Succesfully";
            LoadRecord();

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

            SqlCommand com = new SqlCommand("DELETE FROM FM_VENDOR_MASTER  WHERE  FM_VEND_CODE='" + Scode.Value + "'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Supplier Deleted Succesfully";
            LoadRecord();

        }

        protected void SearchBtn_Click(Object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select  FM_VEND_CODE, FM_VEND_NAME, FM_VEND_CONTACT_TEL, FM_VEND_EMAIL, FM_VEND_ADDR_1, FM_VEND_COUNTRY, FM_VEND_CITY, FM_VEND_ZIP_CODE from FM_VENDOR_MASTER WHERE FM_VEND_CODE='" + Ssearch.Value + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Slist.DataSource = dt;
            Slist.DataBind();
        }

        protected void GetBtn_Click(Object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select  FM_VEND_CODE, FM_VEND_NAME, FM_VEND_CONTACT_TEL, FM_VEND_EMAIL, FM_VEND_ADDR_1, FM_VEND_COUNTRY, FM_VEND_CITY, FM_VEND_ZIP_CODE from FM_VENDOR_MASTER WHERE FM_VEND_CODE='" + Sdb.Value + "'", con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())
            {
                Scode.Value = r.GetValue(0).ToString();
                Sname.Value = r.GetValue(1).ToString();
                Smobile.Value = r.GetValue(2).ToString();
                Semail.Value = r.GetValue(3).ToString();
                Sadress.Value = r.GetValue(4).ToString();
                Scountry.Value = r.GetValue(5).ToString();
                Scity.Value = r.GetValue(6).ToString();
                Szipcode.Value = r.GetValue(7).ToString();
            }

        }
    }

    }