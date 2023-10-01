using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_PED
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            mostrarPacientes(dgvTotalPacientes);
            cmbPresion.Enabled = false;
            cmbGenero.Enabled = false;
            cmbTipoSangre.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form dashboardP = new Form7();
            dashboardP.Show();
            this.Hide();
        }

        public void mostrarPacientes(DataGridView tablaPacientes)
        {
            string query = "SELECT * FROM paciente";
           // string presion = "select * from paciente where presion = \"alta\";";

            try {
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        public void mostrarDataPorPresion(DataGridView tablaPacientes)
        {
            if (cmbPresion.SelectedItem != null)
            {
                string ItemSelected = cmbPresion.SelectedItem.ToString();

                switch (ItemSelected)
                {
                    case "Alta":
                        try
                        {
                            string presion = "SELECT * FROM paciente WHERE presion = \"alta\";";

                            Conexion objCon = new Conexion();

                            MySqlConnection con = objCon.conexion;
                            tablaPacientes.DataSource = null;
                            MySqlDataAdapter adapter = new MySqlDataAdapter(presion, con);

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            tablaPacientes.DataSource = dt;
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                        }
                        break;
                    case "Media":
                        try
                        {
                            string presion = "SELECT * FROM paciente WHERE presion = \"Media\";";

                            Conexion objCon = new Conexion();

                            MySqlConnection con = objCon.conexion;
                            tablaPacientes.DataSource = null;
                            MySqlDataAdapter adapter = new MySqlDataAdapter(presion, con);

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            tablaPacientes.DataSource = dt;
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                        }
                        break;
                    case "Baja":
                        try
                        {
                            string presion = "SELECT * FROM paciente WHERE presion = \"Baja\";";

                            Conexion objCon = new Conexion();

                            MySqlConnection con = objCon.conexion;
                            tablaPacientes.DataSource = null;
                            MySqlDataAdapter adapter = new MySqlDataAdapter(presion, con);

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            tablaPacientes.DataSource = dt;
                            con.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                        }
                        break;
                    default:
                        
                        break;
                }
            }
            
        }

        public void mostrarDataPorSangre(DataGridView tablaPacientes)
        {
           
            if (cmbTipoSangre.SelectedItem != null)
            {
                string ItemSelected = cmbTipoSangre.SelectedItem.ToString();



                switch(ItemSelected)
                {
                    case "A+":
                        try
                            {
                                string presion = "SELECT * FROM paciente WHERE tipo_sangre = \"A+\";";

                                Conexion objCon = new Conexion();

                                MySqlConnection con = objCon.conexion;
                                tablaPacientes.DataSource = null;
                                MySqlDataAdapter adapter = new MySqlDataAdapter(presion, con);

                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tablaPacientes.DataSource = dt;
                                con.Close();

                                lblMostrarEnfermedad.Text = "Este tipo de sangre " + ItemSelected + " propenso a Insomnio, Hipertension,  Deficit de B12";

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                            }
                        break;
                    case "O+":
                            try
                            {
                                string tipoSangre = "SELECT * FROM paciente WHERE tipo_sangre = \"O+\";";

                                Conexion objCon = new Conexion();

                                MySqlConnection con = objCon.conexion;
                                tablaPacientes.DataSource = null;
                                MySqlDataAdapter adapter = new MySqlDataAdapter(tipoSangre, con);

                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tablaPacientes.DataSource = dt;
                                con.Close();
                                lblMostrarEnfermedad.Text = "Este tipo de sangre " + ItemSelected + " es propenso a Insomnio, Hipertension";

                        }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                            }
                        break;
                    case "O-":
                            try
                            {
                                string tipoSangre = "SELECT * FROM paciente WHERE tipo_sangre = \"O-\";";

                                Conexion objCon = new Conexion();

                                MySqlConnection con = objCon.conexion;
                                tablaPacientes.DataSource = null;
                                MySqlDataAdapter adapter = new MySqlDataAdapter(tipoSangre, con);

                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tablaPacientes.DataSource = dt;
                                con.Close();
                                lblMostrarEnfermedad.Text = "Este tipo de sangre " + ItemSelected + " es " +
                                " propenso a Insomnio, Hipertension,  Colesterol alto";
                        }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                            }
                        break;
                    case "B-":
                            try
                            {
                                string tipoSangre = "SELECT * FROM paciente WHERE tipo_sangre = \"B-\";";

                                Conexion objCon = new Conexion();

                                MySqlConnection con = objCon.conexion;
                                tablaPacientes.DataSource = null;
                                MySqlDataAdapter adapter = new MySqlDataAdapter(tipoSangre, con);

                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tablaPacientes.DataSource = dt;
                                con.Close();
                                lblMostrarEnfermedad.Text = "Este tipo de sangre " + ItemSelected + " es propenso a Estreñimiento, Deficit de B12, \nAlzheimer, Circulacion, y Colesterol alto.";

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                            }
                            
                        break;
                    case "A--":
                            try
                            {
                                string tipoSangre = "SELECT * FROM paciente WHERE tipo_sangre = \"A--\";";

                                Conexion objCon = new Conexion();

                                MySqlConnection con = objCon.conexion;
                                tablaPacientes.DataSource = null;
                                MySqlDataAdapter adapter = new MySqlDataAdapter(tipoSangre, con);

                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tablaPacientes.DataSource = dt;
                                con.Close();
                                lblMostrarEnfermedad.Text = "Este tipo de sangre " + ItemSelected + " es propenso a Deficit de Hierro, Hipertension,  \nEstreñimiento, y Colesterol alto";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                            }
                        break;
                    case "B+":
                            try
                            {
                                string tipoSangre = "SELECT * FROM paciente WHERE tipo_sangre = \"B+\";";

                                Conexion objCon = new Conexion();

                                MySqlConnection con = objCon.conexion;
                                tablaPacientes.DataSource = null;
                                MySqlDataAdapter adapter = new MySqlDataAdapter(tipoSangre, con);

                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tablaPacientes.DataSource = dt;
                                con.Close();
                                lblMostrarEnfermedad.Text = "Este tipo de sangre " + ItemSelected + " es propenso a Insomnio, Hipertension,  Deficit de Hierro, Circulacion, Depresion";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                            }
                        break;
                    case "AB+":
                            try
                            {
                                string tipoSangre = "SELECT * FROM paciente WHERE tipo_sangre = \"AB+\";";

                                Conexion objCon = new Conexion();

                                MySqlConnection con = objCon.conexion;
                                tablaPacientes.DataSource = null;
                                MySqlDataAdapter adapter = new MySqlDataAdapter(tipoSangre, con);

                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                tablaPacientes.DataSource = dt;
                                con.Close();
                                lblMostrarEnfermedad.Text = "Este tipo de sangre " + ItemSelected + " es propenso a Hipertension,  Estreñimiento, Circulación, Depresión.";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                            }   
                        break;
                }    
            }
            else
            {
                MessageBox.Show("El combobox esta vacio");
            }
        }

        private void mostrarDataPorGenero(DataGridView tablaPaciente)
        {
            string ItemSelected = cmbGenero.SelectedItem.ToString();

            switch (ItemSelected)
            {
                case "Masculino":
                        try
                        {
                            string tipoSangre = "SELECT * FROM paciente WHERE genero = \"Masculino\";";

                            Conexion objCon = new Conexion();

                            MySqlConnection con = objCon.conexion;
                            tablaPaciente.DataSource = null;
                            MySqlDataAdapter adapter = new MySqlDataAdapter(tipoSangre, con);

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            tablaPaciente.DataSource = dt;
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                        }
                    break;
                case "Femenino":
                        try
                        {
                            string tipoSangre = "SELECT * FROM paciente WHERE genero = \"Femenino\";";

                            Conexion objCon = new Conexion();

                            MySqlConnection con = objCon.conexion;
                            tablaPaciente.DataSource = null;
                            MySqlDataAdapter adapter = new MySqlDataAdapter(tipoSangre, con);

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            tablaPaciente.DataSource = dt;
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se mostraron los dato de la base de datos, error: " + ex.ToString());
                        }
                    break;
                default:
                    Console.WriteLine("Dato erroneo");
                    break;
            }
        }

        private void cmbPresion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e) 
        {
            // mostrarDataPorPresion(dgvTotalPacientes);
            if (cmbPresion.SelectedItem != null && cmbTipoSangre.SelectedItem == null && cmbGenero.SelectedItem == null)
            {
                mostrarDataPorPresion(dgvTotalPacientes);
            }else if (cmbPresion.SelectedItem == null && cmbTipoSangre.SelectedItem != null && cmbGenero.SelectedItem == null)
            {
                mostrarDataPorSangre(dgvTotalPacientes);
            }else if (cmbPresion.SelectedItem == null && cmbTipoSangre.SelectedItem == null && cmbGenero.SelectedItem != null)
            {
                mostrarDataPorGenero(dgvTotalPacientes);
            }else if (cmbPresion.SelectedItem != null && cmbTipoSangre.SelectedItem != null && cmbGenero.SelectedItem != null)
            {
                mostrarDataPorPresion(dgvTotalPacientes);
                mostrarDataPorSangre(dgvTotalPacientes);
                mostrarDataPorGenero(dgvTotalPacientes);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dashboard = new Form6();
            dashboard.Show();
            this.Hide();
        }

        private void chkbPresion_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbPresion.Checked)
            {
                cmbPresion.Enabled = true;
            }
            else
            {
                cmbPresion.Enabled = false;
                cmbPresion.SelectedIndex = -1;
            }

        }

        private void chkbTipoSangre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbTipoSangre.Checked)
            {
                cmbTipoSangre.Enabled = false;
                cmbTipoSangre.SelectedIndex= -1;
            }
            else
            {
                cmbTipoSangre.Enabled = true;
            }
        }

        private void chkbTipoGenero_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbTipoGenero.Checked)
            {
                cmbGenero.Enabled = true;
            }
            else
            {
                cmbGenero.Enabled = false;
                cmbGenero.SelectedIndex = -1;
            }
        }

        private void lblInstruccion_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMostrarEnfermedad_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoSangre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvTotalPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
