using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_PED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                Conexion objCon = new Conexion();
                try
                {   if (objCon.AbrirConexion()){
                        MySqlConnection con = objCon.conexion;
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE usuario = @usuario AND pass = @pass", con);
                        cmd.Parameters.AddWithValue("@usuario", txtUser.Text);
                        cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            Form dashboard = new Form2();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Usuario o contraseña incorrectos");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error de conexión a la base de datos: " + ex.Message);
                }
                finally
                {
                    objCon.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacíos");
            }
        }
    }
}
