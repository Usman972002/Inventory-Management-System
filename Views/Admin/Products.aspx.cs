using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace InVentory_Management_System_MarsTrackTech.Views.Admin
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadCategory();
            loadSuppliers();
            if (!IsPostBack)
            {
                LoadRecord();
            }        
        }
     
        SqlConnection con = new SqlConnection("Data Source = 132.148.75.0,1435; Initial Catalog = TRADING; Persist Security Info = True; User ID = amc; Password = amc123");
        DateTime dt = DateTime.Now;
        string format = "yyyy-MM-dd HH:mm:ss";

        // To Display all the Categories
        public void loadCategory()
        {
            Pcategory.Items.Clear();
            SqlCommand command = new SqlCommand("select OM_ITEM_CATEGORY_DESCRIPTION from OM_ITEM_CATEGORY", con);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Pcategory.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();

        }

        // To Display all the Suppliers
        public void loadSuppliers()
        {
            Psupplier.Items.Clear();
            SqlCommand command = new SqlCommand("select FM_VEND_NAME from FM_VENDOR_MASTER", con);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Psupplier.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        void LoadRecord()
        {
            SqlCommand command = new SqlCommand("select OM_ITEM_CODE,OM_ITEM_MAIN_NAME,OM_ITEM_CATEGORY,OM_ITEM_CREATED_BY,OM_ITEM_COST_PRICE,OM_ITEM_CREATED_DATE from OM_ITEM_MASTER  order by OM_ITEM_CREATED_DATE DESC ", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Plist.DataSource = dt;
            Plist.DataBind();
        }



        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("INSERT INTO OM_ITEM_MASTER(OM_ITEM_CODE,OM_ITEM_MAIN_NAME,OM_ITEM_CATEGORY,OM_ITEM_CREATED_BY,OM_ITEM_COST_PRICE,OM_ITEM_CREATED_DATE) VALUES('" + Pcode.Value + "', '" + Pname.Value + "','" + Pcategory.Text + "','" + Psupplier.Text + "','" + Pprize.Value + "','" + dt.ToString(format) + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Product Added Succesfully!!";
            LoadRecord();
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("UPDATE OM_ITEM_MASTER SET  OM_ITEM_MAIN_NAME = '" + Pname.Value + "',OM_ITEM_CATEGORY='" + Pcategory.Text + "',OM_ITEM_CREATED_BY='" + Psupplier.Text + "',OM_ITEM_COST_PRICE='" + Pprize.Value + "',OM_ITEM_CREATED_DATE='" + dt.ToString(format) + "' WHERE  OM_ITEM_CODE='" + Pcode.Value + "'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Product Updated Succesfully";
            LoadRecord();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("DELETE FROM OM_ITEM_MASTER  WHERE  OM_ITEM_CODE='" + Pcode.Value + "'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Product Deleted Succesfully";
            LoadRecord();
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select OM_ITEM_CODE,OM_ITEM_MAIN_NAME,OM_ITEM_CATEGORY,OM_ITEM_CREATED_BY,OM_ITEM_COST_PRICE,OM_ITEM_CREATED_DATE from OM_ITEM_MASTER WHERE OM_ITEM_CODE='" + Psearch.Value + "' OR OM_ITEM_MAIN_NAME='" + Pdb1.Value + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Plist.DataSource = dt;
            Plist.DataBind();
        }

        protected void GetBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select OM_ITEM_CODE,OM_ITEM_MAIN_NAME,OM_ITEM_CATEGORY,OM_ITEM_CREATED_BY,OM_ITEM_COST_PRICE,OM_ITEM_CREATED_DATE from OM_ITEM_MASTER WHERE OM_ITEM_CODE='" + Pdb.Value + "'", con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())

            {
                Pcode.Value = r.GetValue(0).ToString();
                Pname.Value = r.GetValue(1).ToString();
                Pcategory.Text = r.GetValue(2).ToString();
                Psupplier.Text = r.GetValue(3).ToString();
                Pprize.Value = r.GetValue(4).ToString();
                Pdate.Value = r.GetValue(5).ToString();
            }
        }
    }


}