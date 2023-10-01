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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form dashboardP = new Form7();
            dashboardP.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Conexion objConectar = new Conexion();
            //objConectar.abrirConexion();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && cmbGenero.SelectedIndex !=-1 && cmbPresion.SelectedIndex != -1 && cmbTipoSangre.SelectedIndex != -1)
            {
                int num;
                if (int.TryParse(txtNombre.Text, out num) && int.TryParse(txtApellido.Text, out num))
                {
                    MessageBox.Show("No se permiten datos númericos");
                }
                else
                {
                    Conexion objCon = new Conexion();
                    try
                    {
                        if (objCon.AbrirConexion())
                        {
                            MySqlConnection con = objCon.conexion;
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO paciente (nombre, apellido, genero, presion, tipo_sangre) VALUES (@nombre, @apellido, @genero, @presion, @tipo_sangre)", con);
                            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@apellido", txtApellido.Text); 
                            cmd.Parameters.AddWithValue("@genero", cmbGenero.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@presion", cmbPresion.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@tipo_sangre", cmbTipoSangre.SelectedItem.ToString());
                            cmd.CommandType = CommandType.Text;

                            int filas = cmd.ExecuteNonQuery();
                            if (filas > 0)
                            {
                                MessageBox.Show("Datos ingresados correctamente");
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
                        txtApellido.Text = "";
                        txtNombre.Text = "";
                        cmbGenero.SelectedIndex = -1;
                        cmbPresion.SelectedIndex = -1;
                        cmbTipoSangre.SelectedIndex = -1;
                    }
                }
            } else
            {
                MessageBox.Show("No se permiten campos vacíos");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
