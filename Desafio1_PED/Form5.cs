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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form dashboard = new Form2();
            dashboard.Show();
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && !string.IsNullOrEmpty(txtPass.Text))
            {
                int num;
                if (int.TryParse(txtUser.Text, out num))
                {
                    MessageBox.Show("Ingresa un nombre usuario válido");
                }
                else
                {
                    Conexion objCon = new Conexion();
                    try
                    {
                        if (objCon.AbrirConexion())
                        {
                            MySqlConnection con = objCon.conexion;
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO usuario (usuario, pass) VALUES (@usuario, @pass)", con);
                            cmd.Parameters.AddWithValue("@usuario", txtUser.Text);
                            cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                            cmd.CommandType = CommandType.Text;

                            int filas = cmd.ExecuteNonQuery();
                            if (filas > 0)
                            {
                                MessageBox.Show("Usuario registrado correctamente");
                            }
                            else
                                MessageBox.Show("Ocurrió un error");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error de conexión a la base de datos: " + ex.Message);
                    }
                    finally
                    {
                        objCon.CerrarConexion();
                        txtUser.Text = "";
                        txtPass.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("No se permiten campos vacíos");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
