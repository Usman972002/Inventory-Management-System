using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace InVentory_Management_System_MarsTrackTech.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }
        SqlConnection con = new SqlConnection("Data Source = 132.148.75.0,1435; Initial Catalog = TRADING; Persist Security Info = True; User ID = amc; Password = amc123");
        DateTime dt = DateTime.Now;
        string format = "yyyy-MM-dd HH:mm:ss";
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            
            SqlCommand com = new SqlCommand("INSERT INTO OM_ITEM_CATEGORY(OM_ITEM_CATEGORY_CODE,OM_ITEM_CATEGORY_DESCRIPTION,OM_ITEM_CATEGORY_CREATED_DATE) VALUES('" + Cid.Value + "','" + Cname.Value + "','" +dt.ToString(format)+ "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Category Added!!";
            LoadRecord();

        }
        void LoadRecord()
        {
            SqlCommand command = new SqlCommand("select OM_ITEM_CATEGORY_CODE AS CID,OM_ITEM_CATEGORY_DESCRIPTION AS CNAME,OM_ITEM_CATEGORY_CREATED_DATE AS CDATE from OM_ITEM_CATEGORY ORDER BY OM_ITEM_CATEGORY_CREATED_DATE DESC", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Clist.DataSource = dt;
            Clist.DataBind();
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("UPDATE OM_ITEM_CATEGORY SET  OM_ITEM_CATEGORY_DESCRIPTION = '" + Cname.Value + "',OM_ITEM_CATEGORY_CREATED_DATE='" + dt.ToString(format) + "' WHERE OM_ITEM_CATEGORY_CODE='"+Cid.Value +"' ", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Category Updated Succesfully";
            LoadRecord();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {

            SqlCommand com = new SqlCommand("DELETE FROM OM_ITEM_CATEGORY  WHERE  OM_ITEM_CATEGORY_CODE='"+Cid.Value +"'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Category Deleted Succesfully";
            LoadRecord();

        }
        
        protected void SearchBtn_Click(Object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select OM_ITEM_CATEGORY_CODE AS CID,OM_ITEM_CATEGORY_DESCRIPTION AS CNAME,OM_ITEM_CATEGORY_CREATED_DATE AS CDATE  from OM_ITEM_CATEGORY  WHERE OM_ITEM_CATEGORY_CODE='"+Csearch.Value + "' OR OM_ITEM_CATEGORY_DESCRIPTION='" + Cdb1.Value +"' ", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Clist.DataSource = dt;
            Clist.DataBind();
        }
        
        protected void GetBtn_Click(Object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select OM_ITEM_CATEGORY_CODE AS CID ,OM_ITEM_CATEGORY_DESCRIPTION AS CNAME,OM_ITEM_CATEGORY_CREATED_DATE AS CDATE from OM_ITEM_CATEGORY WHERE OM_ITEM_CATEGORY_CODE='" + Cdb.Value + "'", con);
             SqlDataReader r = command.ExecuteReader();
           while (r.Read())
           {
               
               Cid.Value = r.GetValue(0).ToString();
               Cname.Value= r.GetValue(1).ToString();
               Cdate.Value= r.GetValue(2).ToString();
              
           }

        }
    }

}