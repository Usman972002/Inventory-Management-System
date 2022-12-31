using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;

namespace InVentory_Management_System_MarsTrackTech.Views.Admin
{
    public partial class PurchaseOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadProduct();
            loadUnits();
            if (!IsPostBack)
            {
                LoadRecord();
            }
        }

        SqlConnection con = new SqlConnection("Data Source = 132.148.75.0,1435; Initial Catalog = TRADING; Persist Security Info = True; User ID = amc; Password = amc123");
        DateTime dt = DateTime.Now;
        string format = "yyyy-MM-dd HH:mm:ss";

        // To Display all the Product Id's
        public void loadProduct()
        {
            OPid.Items.Clear();
            SqlCommand command = new SqlCommand("select  OM_ITEM_CODE from OM_ITEM_MASTER ", con);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                
                OPid.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();

        }

        // To Display all the Units
        
        public void loadUnits()
        {
            Ounits.Items.Clear();
            SqlCommand command = new SqlCommand("select DISTINCT OT_ITEM_UOM from OT_PO_CHILD ", con);
            con.Open(); 
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Ounits.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }
        

        void LoadRecord()
        {
            SqlCommand command = new SqlCommand("select OT_PO_NO AS OID ,OT_ITEM_CODE AS PID,OT_PO_DATE AS ODATE, OT_ITEM_DESCRIPTION AS PNAME,OT_ITEM_UOM AS UNITS,OT_ITEM_QTY AS QUANTIY,OT_ITEM_RATE AS PRICE, OT_ITEM_AMOUNT AS TOTALAMOUNT  from  OT_PO_CHILD order by OT_PO_DATE DESC ", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Olist.DataSource = dt;
            Olist.DataBind();
        }

        

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("INSERT INTO OT_PO_CHILD(OT_PO_NO,OT_ITEM_CODE ,OT_ITEM_DESCRIPTION,OT_PO_DATE, OT_ITEM_UOM ,OT_ITEM_QTY ,OT_ITEM_RATE) VALUES('" + Oid.Value + "', '" + OPid.Text + "','" + OPname.Value + "','" + dt.ToString(format) + "','" +Ounits.Text + "','" + Oqty.Value + "','" + Oprice.Value + "')", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Purchase Order Added Succesfully!!";
            LoadRecord();
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("UPDATE OT_PO_CHILD SET  OT_PO_CODE = '" + OPid.Text + "',OT_ITEM_DESCRIPTION='" + OPname.Value + "',OT_PO_DATE='" + dt.ToString(format) + "',OT_ITEM_UOM='" + Ounits.Text + "',OP_ITEM_QTY='" + Oqty.Value + "',OP_ITEM_RATE='" + Oprice.Value + "' WHERE  OT_PO_NO='" + Oid.Value + "'", con);
            con.Open(); 
            con.Close();
            ErrMsg.InnerText = "Purchase Order Updated Succesfully";
            LoadRecord();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("DELETE FROM OT_PO_CHILD  WHERE  OT_PO_NO='" + Oid.Value + "'", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            ErrMsg.InnerText = "Purchase Order Deleted Succesfully";
            LoadRecord();
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select OT_PO_NO AS OID ,OT_ITEM_CODE AS PID,OT_PO_DATE AS ODATE, OT_ITEM_DESCRIPTION AS PNAME,OT_ITEM_UOM AS UNITS,OT_ITEM_QTY AS QUANTIY,OT_ITEM_RATE AS PRICE, OT_ITEM_AMOUNT AS TOTALAMOUNT  from  OT_PO_CHILD WHERE OT_PO_NO='" + Osearch.Value + "' OR OT_ITEM_DESCRIPTION='" + Odb1.Value + "'", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);
            Olist.DataSource = dt;
            Olist.DataBind();
        }

        protected void GetBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("select OT_PO_NO AS OID ,OT_ITEM_CODE AS PID,OT_PO_DATE AS ODATE, OT_ITEM_DESCRIPTION AS PNAME,OT_ITEM_UOM AS UNITS,OT_ITEM_QTY AS QUANTIY,OT_ITEM_RATE AS PRICE, OT_ITEM_AMOUNT AS TOTALAMOUNT  from  OT_PO_CHILD WHERE OT_PO_NO='" + Odb.Value + "'", con);
            SqlDataReader r = command.ExecuteReader();
            while (r.Read())

            {
                Oid.Value = r.GetValue(0).ToString();
                OPid.Text = r.GetValue(1).ToString();
                OPname.Value = r.GetValue(2).ToString();
                Odate.Value = r.GetValue(3).ToString();
                Ounits.Text = r.GetValue(4).ToString();
                Oqty.Value = r.GetValue(5).ToString();
                Oprice.Value = r.GetValue(6).ToString();
            }
        }

        protected void PrintBtn_Click(object sender, EventArgs e)
        {
            Response.ContentType = "Application/pdf";
            Response.AddHeader("content-Disposition", "attachement;filename=YourFile.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            Olist.RenderControl(hw);
            Document doc = new Document(PageSize.A4, 50f, 50f, 100f, 30f);
            HTMLWorker htw = new HTMLWorker(doc);
            PdfWriter.GetInstance(doc, Response.OutputStream);
            doc.Open();
            StringReader sr = new StringReader(sw.ToString());
            htw.Parse(sr);
            doc.Close();
            Response.Write(doc);
            Response.End();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }
    }
    
}