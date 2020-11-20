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
    public partial class Clientes : Form
    {
        //Conexion SQL
        SqlConnection miConexionSql;

        public Clientes()
        {
            InitializeComponent();

            string miConexion = ConfigurationManager.ConnectionStrings["InterfazActualizadaNuGet_WinForm.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion); //le paso por parametro una cadena de conexion (miConexion)

        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            try {
                SqlCommand cm = new SqlCommand("SELECT * FROM CLIENTE", miConexionSql);
                miConexionSql.Open();
                SqlDataReader dr = cm.ExecuteReader(); //ejecuta el procedimiento almacenado
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        this.listBclientes.Items.Add(dr.GetString(1)); //parametro 1 por que ese es el campo donde estan los nombres de los clientes (0 = Id)
                    }
                }
                
            }
            catch(Exception e5) 
            {
                MessageBox.Show("No puede moestrar 2 veces los mismos registros!");
                MessageBox.Show(e5.ToString());
            }
            
        }



    }
}
