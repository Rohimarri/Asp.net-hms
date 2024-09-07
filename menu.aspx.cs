using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace HMS
{
    public partial class menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();

            }
        }

        protected void BindGrid()
        {
            string connectionString = "Data Source=ROHII\\ROHITHA;Initial Catalog=marchDB;User ID =sa;Password=rohitha"; // Replace with your connection string
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Menu", con))
                {
                    using (SqlDataAdapter dr = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        dr.Fill(dt);

                    }
                }
            }
        }



        protected void btn_submit_click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ROHII\\ROHITHA;Initial Catalog=marchDB;User ID =sa;Password=rohitha";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Insert into Menu values (@ItemNo,@Code,@ItemName,@price,@Quantity,@Active)", con))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ItemNo", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@Code", txtCode.Text);
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@Active", chkActive.Checked ? 1 : 0);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Redirect("Menuvw.aspx");
                }
            }
        }


        protected void btn_Update_click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ROHII\\ROHITHA;Initial Catalog=marchDB;User ID =sa;Password=rohitha";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("update Menu set ItemNo=@ItemNo,Code=@Code,ItemName=@ItemName,Price=@price,Quantity=@Quantity,Active=@Active", con))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ItemNo", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@Code", txtCode.Text);
                    cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@Active", chkActive.Checked ? 1 : 0);



                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Redirect("Menuvw.aspx");

                }
            }
        }
        protected void btn_delete_click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ROHII\\ROHITHA;Initial Catalog=marchDB;User ID =sa;Password=rohitha";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("delete Menu where ItemNo=@ItemNo", con))
                {

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ItemNo", txtItemNo.Text);
                    cmd.Parameters.AddWithValue("@Code", txtCode.Text);
                    cmd.Parameters.AddWithValue("@Name", txtItemName.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    cmd.Parameters.AddWithValue("@Active", chkActive.Checked ? 1 : 0);




                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Redirect("Menuvw.aspx");
                }
            }


        }

    }
  }
