using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Linq.Expressions;

namespace InterfazActualizadaNuGet_WinForm.Formularios
{
    public partial class Pedidos : Form
    {

        SqlConnection miConexionSql;
        public Pedidos()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["InterfazActualizadaNuGet_WinForm.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT *, CONCAT (cCLIENTE, ' ', fechaPedido, ' ', formaPago) AS INFOCOMPLETA FROM PEDIDO", miConexionSql); //consulta de campo nuevo calculado
                miConexionSql.Open();
                SqlDataReader drSql = consulta.ExecuteReader(); //ejecuta el procedimiento almacenado
                if (drSql.HasRows)
                {
                    while (drSql.Read()) //lee todos los registros de la tabla uno a uno hasta que no queden mas
                    {
                        //this.list_Pedidos.Items.Add(drSql);
                        list_Pedidos.Items.Add(drSql.GetValue(4)); //llamo al 4 elemento de la tabla que es INFOCOMPLETA, la tabla "virtual" donde estan concatenados los 3 datos juntos + el Id asociado
                    }
                }
            }catch(Exception e3)
            {
                MessageBox.Show(e3.ToString());
            }
            
        }

    }
}
