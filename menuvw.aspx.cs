using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace HMS
{
    public partial class menuvw : System.Web.UI.Page

    {

        string connectionString = "Data Source=ROHII\\ROHITHA;Initial Catalog=marchDB;User ID =sa;Password=rohitha";

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Menu", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gvMenu.DataSource = dt;
                gvMenu.DataBind();
            }
        }
    }
}
    