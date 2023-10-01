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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            mostrarPacientes(dgvTotalPacientes);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form dashboardP = new Form7();
            dashboardP.Show();
            this.Hide();
        }

        private void dgvTotalPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarPacientes(txtId, txtNombre, txtApellido, cmbGenero, cmbPresion, cmbTipoSangre, dgvTotalPacientes);
        }

        public void mostrarPacientes(DataGridView tablaPacientes)
        {
            string query = "SELECT * FROM paciente";
            try
            {
                Conexion objCon = new Conexion();

                MySqlConnection con = objCon.conexion;
                tablaPacientes.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPacientes.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
            }
        }

        public void seleccionarPacientes(TextBox id, TextBox nombre, TextBox apellido, ComboBox genero, ComboBox presion, ComboBox tipoSangre, DataGridView tablaPacientes)
        {
            id.Text = tablaPacientes.CurrentRow.Cells[0].Value.ToString();
            nombre.Text = tablaPacientes.CurrentRow.Cells[1].Value.ToString();
            apellido.Text = tablaPacientes.CurrentRow.Cells[2].Value.ToString();

            //genero
            string generoSeleccionado = tablaPacientes.CurrentRow.Cells[3].Value.ToString();
            int indexGenero = genero.Items.IndexOf(generoSeleccionado);
                genero.SelectedIndex = indexGenero;

            //presion
            string presionSeleccionada = tablaPacientes.CurrentRow.Cells[4].Value.ToString();
            int indexPresion = presion.Items.IndexOf(presionSeleccionada);
                presion.SelectedIndex = indexPresion;

            //tipoSangre
            string tipoSangreSeleccionado = tablaPacientes.CurrentRow.Cells[5].Value.ToString();
            int indexTipoSangre = tipoSangre.Items.IndexOf(tipoSangreSeleccionado);
                tipoSangre.SelectedIndex = indexTipoSangre;

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion objCon = new Conexion();
            try
            {
                if (objCon.AbrirConexion())
                {
                    MySqlConnection con = objCon.conexion;
                    MySqlCommand cmd = new MySqlCommand("UPDATE paciente SET nombre = @nombre, apellido = @apellido, genero = @genero, presion = @presion, tipo_sangre = @tipo_sangre WHERE id_paciente = @id", con);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
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
                mostrarPacientes(dgvTotalPacientes);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion objCon = new Conexion();
            try
            {
                if (objCon.AbrirConexion())
                {
                    MySqlConnection con = objCon.conexion;
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM paciente WHERE id_paciente = @id", con);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);
                    cmd.CommandType = CommandType.Text;

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                    {
                        MessageBox.Show("Paciente eliminado correctamente");
                    }
                    else
                        MessageBox.Show("Ocurrió un error al eliminar al paciente");
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
    }
}
