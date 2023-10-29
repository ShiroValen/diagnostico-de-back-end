using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data;
using System.Data.SqlClient;


namespace diagnostico_de_back_end
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindVentasData();
            }
        }

        private void BindVentasData()
        {
            string connectionString = "Data Source=SHIROVALEN\\SQLEXPRESS;Initial Catalog=cafecito;Integrated Security=True;";
            string query = "SELECT v.*, b.Nombre AS Bebida FROM ventas AS v INNER JOIN bebidas AS b ON v.ID_Bebida = b.ID ORDER BY v.FechaVenta DESC; ; "; // consulta aquí

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ventasRepeater.DataSource = dt;
                    ventasRepeater.DataBind();
                }
            }
        }
    }
}
