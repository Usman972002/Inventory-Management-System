using System;
using System.Collections.Generic;
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
        Models.Functions Con;       
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowSuppliers();

        }
        private void ShowSuppliers()
        {
            string Query = "select FM_VEND_CODE,FM_VEND_NAME,FM_VEND_CONTACT_TEL,FM_VEND_EMAIL,FM_VEND_ADDR_1,FM_VEND_COUNTRY,FM_VEND_CITY,FM_VEND_ZIP_CODE from FM_VENDOR_MASTER";
            Slist.DataSource = Con.GetData(Query);
            Slist.DataBind();
        }
      

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Scode.Value == "" || Sname.Value == "" || Smobile.Value == "" || Semail.Value == "" || Sadress.Value == "" || Scity.Value == "" || Scountry.Value == "" || Szipcode.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data!!!!!!!";
                }
                else
                {
                    string SCode = Scode.Value;
                    string SName = Sname.Value;
                    string SMobile = Smobile.Value;
                    string SEmail = Semail.Value;
                    string SAdress = Sadress.Value;
                    string SCountry = Scountry.Value;
                    string SCity = Scity.Value;
                    string SZip = Szipcode.Value;

                    string Query1 = "INSERT INTO FM_VENDOR_MASTER(FM_VEND_CODE,FM_VEND_NAME,FM_VEND_CONTACT_TEL,FM_VEND_EMAIL,FM_VEND_ADDR_1,FM_VEND_COUNTRY,FM_VEND_CITY,FM_VEND_ZIP_CODE) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')";
                    Query1 = string.Format(Query1, SCode, SName, SMobile, SEmail, SAdress, SCountry, SCity, SZip);
                    Con.setData(Query1);
                    ShowSuppliers();
                    ErrMsg.InnerText = "Supplier Added!!";

                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

        }

        //int Key = 0;
        protected void Slist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Scode.Value = Slist.SelectedRow.Cells[1].Text;
            Sname.Value = Slist.SelectedRow.Cells[2].Text;
            Smobile.Value = Slist.SelectedRow.Cells[3].Text;
            Semail.Value = Slist.SelectedRow.Cells[4].Text;
            Sadress.Value = Slist.SelectedRow.Cells[5].Text;
            Scountry.Value = Slist.SelectedRow.Cells[6].Text;
            Scity.Value = Slist.SelectedRow.Cells[7].Text;
            Szipcode.Value = Slist.SelectedRow.Cells[8].Text;
            /*
            if (Scode.Value == "")
            {
                Key= 0;
            }
            else
            {

                Key = Convert.ToInt16(Slist.SelectedRow.Cells[1].ToString());
                
            }*/


        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (Scode.Value == "" || Sname.Value == "" || Smobile.Value == "" || Semail.Value == "" || Sadress.Value == "" || Scity.Value == "" || Scountry.Value == "" || Szipcode.Value == "")
                {
                    ErrMsg.InnerText = "Missing Data!!!!!!!";
                }
                else
                {
                    string SCode = Scode.Value;
                    string SName = Sname.Value;
                    string SMobile = Smobile.Value;
                    string SEmail = Semail.Value;
                    string SAdress = Sadress.Value;
                    string SCountry = Scountry.Value;
                    string SCity = Scity.Value;
                    string SZip = Szipcode.Value;

                    string Query2 = "UPDATE FM_VENDOR_MASTER SET  '{0}', '{1}','{2}','{3}','{4}','{5}','{6}','{7}' WHERE Scode={8}";
                    Query2 = string.Format(Query2,SCode,SName, SMobile, SEmail, SAdress, SCountry, SCity, SZip, Slist.SelectedRow.Cells[1].Text);
                    Con.setData(Query2);
                    ShowSuppliers();
                    ErrMsg.InnerText = "Supplier Updated!!";

                }
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }

        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {


            try
            {

                string SCode = Scode.Value;
                string SName = Sname.Value;
                string SMobile = Smobile.Value;
                string SEmail = Semail.Value;
                string SAdress = Sadress.Value;
                string SCountry = Scountry.Value;
                string SCity = Scity.Value;
                string SZip = Szipcode.Value;

                string Query3 = "DELETE FROM  FM_VENDOR_MASTER  WHERE Scode = {0}";
                Query3 = string.Format(Query3, Slist.SelectedRow.Cells[1].Text);
                Con.setData(Query3);
                ShowSuppliers();
                ErrMsg.InnerText = "Supplier Deleted!!";


            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;


            }
        }
        
    }
}