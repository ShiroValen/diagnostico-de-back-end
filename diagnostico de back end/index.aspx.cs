using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Diagnostics;

namespace diagnostico_de_back_end
{
    public partial class index : System.Web.UI.Page
    {
        protected void Comprar_Click(object sender, EventArgs e)
        {
            // Lógica para manejar la compra cuando se hace clic en un botón de compra.
            Button btn = (Button)sender;
            string producto = btn.Attributes["data-producto"];

            // Conecta a la base de datos utilizando tu cadena de conexión
            using (SqlConnection con = new SqlConnection("Data Source=SHIROVALEN\\SQLEXPRESS;Initial Catalog=cafecito;Integrated Security=True;"))
            {
                con.Open();

                // Obtener el precio y el ID_Cafes desde la tabla 'bebidas' utilizando el nombre del producto
                string selectQuery = "SELECT ID, Precio, ID_Cafes FROM bebidas WHERE Nombre = @Producto";

                using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                {
                    selectCmd.Parameters.AddWithValue("@Producto", producto);
                    SqlDataReader reader = selectCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int idBebida = Convert.ToInt32(reader["ID"]);
                        decimal precio = Convert.ToDecimal(reader["Precio"]);
                        int idTipoCafe = Convert.ToInt32(reader["ID_Cafes"]);

                        // Cerrar el primer DataReader por si se llegase a quedar abierto. Más vale prevenir.
                        reader.Close();

                        // Insertar los datos en la tabla de ventas
                        string insertQuery = "INSERT INTO ventas (ID_Bebida, ID_TipoCafe, FechaVenta, PrecioTotal) " +
                            "VALUES (@ID_Bebida, @ID_TipoCafe, GETDATE(), @PrecioTotal)";

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@ID_Bebida", idBebida);
                            insertCmd.Parameters.AddWithValue("@ID_TipoCafe", idTipoCafe);
                            insertCmd.Parameters.AddWithValue("@PrecioTotal", precio);
                            insertCmd.ExecuteNonQuery();
                            ScriptManager.RegisterStartupScript(this, GetType(), "ocultarLabelScript", "ocultarLabel();", true);
                        }
                        lblMensaje.Text = "Gracias por su compra. Ya se insertó en la base de datos.";
                        lblMensaje.ForeColor = System.Drawing.Color.Green; // lbl a verde para indicar que funcionó
                        lblMensaje.Visible = true;

                    }
                    else
                    {
                        // Por si el código se petatea
                        Debug.WriteLine("Producto no encontrado en la base de datos.");
                        lblMensaje.Text = "Error al insertar en la base de datos.";
                        lblMensaje.ForeColor = System.Drawing.Color.Red; // lbl a rojo para que sea un mensaje de error.
                        lblMensaje.Visible = true;
                    }
                }
            }
        }

        protected void IniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtuser.Text;
            string contraseña = txtpass.Text;
            string rol = "";

            using (SqlConnection con = new SqlConnection("Data Source=SHIROVALEN\\SQLEXPRESS;Initial Catalog=cafecito;Integrated Security=True;"))
            {
                using (SqlCommand cmd = new SqlCommand("VerificarCredenciales", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                    cmd.Parameters.Add("@Rol", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                    string query = cmd.CommandText;

                    con.Open();

                    string mensaje = (string)cmd.ExecuteScalar();

                    if (mensaje == "Inicio de sesión exitoso")
                    {
                        // El inicio de sesión fue exitoso, puedes redirigir al usuario a su área privada.
                        ScriptManager.RegisterStartupScript(this, GetType(), "ocultarLabelScript", "ocultarLabel();", true);
                        lblMensaje.Text = "Inicio de sesión exitoso.";
                        lblMensaje.Visible = true;
                        lblMensaje.ForeColor = System.Drawing.Color.Green; // lbl a verde para indicar que funcionó

                        // Se guarda en rol el rol
                        rol = cmd.Parameters["@Rol"].Value.ToString();

                        if (rol == "Administrador")
                        {
                            string idVentaText = txtIDVenta.Text;
                            if (!string.IsNullOrEmpty(idVentaText))
                            {
                                if (int.TryParse(idVentaText, out int idVenta))
                                {
                                    // Define la consulta para eliminar el registro de ventas
                                    string deleteQuery = "DELETE FROM ventas WHERE ID = @IDVenta";

                                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                                    {
                                        deleteCmd.Parameters.AddWithValue("@IDVenta", idVenta);
                                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                                        if (rowsAffected > 0)
                                        {
                                            lblMensaje.Text = "Acceso administrador - venta eliminada";
                                            lblMensaje.Visible = true;
                                            lblMensaje.ForeColor = System.Drawing.Color.Green; // lbl a verde para indicar que funcionó
                                        }
                                        else
                                        {
                                            lblMensaje.Text = "Acceso administrador - venta no encontrada.";
                                            lblMensaje.Visible = true;
                                            lblMensaje.ForeColor = System.Drawing.Color.Yellow; // lbl a amarillo para indicar que no se encontró la venta
                                        }
                                    }
                                }
                                else
                                {
                                    lblMensaje.Text = "Por favor, introduce un ID de venta válido para cancelar.";
                                    lblMensaje.Visible = true;
                                    lblMensaje.ForeColor = System.Drawing.Color.Red; // lbl a rojo para que sea un mensaje de error.
                                }
                            }
                            else
                            {
                                lblMensaje.Text = "Por favor, introduce el ID de venta para cancelar.";
                                lblMensaje.Visible = true;
                                lblMensaje.ForeColor = System.Drawing.Color.Red; // lbl a rojo para que sea un mensaje de error.
                            }
                        }
                        else
                        {
                            lblMensaje.Text = "Inicio de nivel cliente - no puede borrar ventas";
                            lblMensaje.Visible = true;
                            lblMensaje.ForeColor = System.Drawing.Color.Yellow; // lbl a verde para indicar que funcionó
                        }
                    }
                    else
                    {
                        // El inicio de sesión falló, puedes mostrar un mensaje de error.
                        ScriptManager.RegisterStartupScript(this, GetType(), "ocultarLabelScript", "ocultarLabel();", true);
                        lblMensaje.Text = "Inicio de sesión fallido.";
                        lblMensaje.Visible = true;
                        lblMensaje.ForeColor = System.Drawing.Color.Red; // lbl a rojo para que sea de error.
                    }
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
