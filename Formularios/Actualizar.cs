using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq.Expressions;

namespace InterfazActualizadaNuGet_WinForm.Formularios
{
    public partial class Actualizar : Form
    {
        SqlConnection miConexionSql;
        
        public Actualizar()
        {
            InitializeComponent();


            string miConexion = ConfigurationManager.ConnectionStrings["InterfazActualizadaNuGet_WinForm.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);

            MuestraTodosClientes();
        }


        private void MuestraTodosClientes() //Funciona
        {
            using (miConexionSql)
            {
                miConexionSql.Open();

                string query = "SELECT * FROM CLIENTE";

                SqlDataAdapter da = new SqlDataAdapter(query, miConexionSql);
                DataTable dt = new DataTable();
                da.Fill(dt);

                list_Todos_clientes.DataSource = dt;
                list_Todos_clientes.DisplayMember = "nombre";
                list_Todos_clientes.ValueMember = "Id";

            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e) //primera parte de ejecucion //CORREGIR
        {
            text_cliente.Enabled = true;

            string consulta = "SELECT nombre FROM CLIENTE WHERE ID=@ClId";
            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(miSqlCommand);

            using (miAdaptadorSql) //almacenar los datos en un data table
            {
                miSqlCommand.Parameters.AddWithValue("@ClId", list_Todos_clientes.SelectedValue);
                DataTable clientesTabla1 = new DataTable();
                miAdaptadorSql.Fill(clientesTabla1);
                text_cliente.Text = clientesTabla1.Rows[0]["nombre"].ToString();
            }

        }

        private void btn_Actualiza_Click(object sender, EventArgs e) //segunda parte de ejecucion
        {

             string consultaSql = "UPDATE CLIENTE SET nombre=@nombre WHERE Id=" ; //+
             SqlCommand miSqlCommand2 = new SqlCommand(consultaSql, miConexionSql);

             miConexionSql.Open();
             miSqlCommand2.Parameters.AddWithValue("@nombre", text_cliente.Text);
             miSqlCommand2.ExecuteNonQuery();
             miConexionSql.Close();
             MessageBox.Show("Se ha actualizado correctamente el dato!");
             this.Close(); 
        }

    }
}
