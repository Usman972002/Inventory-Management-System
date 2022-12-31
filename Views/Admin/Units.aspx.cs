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
using System.Reflection.Emit;

namespace InVentory_Management_System_MarsTrackTech.Views.Admin
{
    public partial class Units : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }

        }

        SqlConnection con = new SqlConnection("Data Source = 132.148.75.0,1435; Initial Catalog = TRADING; Persist Security Info = True; User ID = amc; Password = amc123");
        
        void LoadRecord()
        {
            SqlCommand command = new SqlCommand("select DISTINCT OT_ITEM_UOM AS UNITS from OT_PO_CHILD ", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Ulist.DataSource = dt;
            Ulist.DataBind();
        }


        protected void AddBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("INSERT INTO OT_PO_CHILD(OT_ITEM_UOM) VALUES('" +unit.Value + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Unit Added!!";
            LoadRecord();

        }

        protected void DelBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("delete OT_ITEM_UOM from OT_PO_CHILD WHERE OT_ITEM_UOM ='" +unit.Value +"'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Unit Deleted!!";
            LoadRecord();

        }
    }
}