using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AgendaBeca
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=WINAPUO5K7YUPCF\SQLEXPRESS02;Initial Catalog=Agenda; Integrated Security=True;");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void aniadir_Click(object sender, EventArgs e)
        {
            con.Open();

            // Habilitar IDENTITY_INSERT para la tabla Contacto
            SqlCommand enableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT Contacto ON", con);
            enableIdentityInsertCmd.ExecuteNonQuery();

            // Insertar el nuevo registro con el valor explícito para la columna Id
            cmd = new SqlCommand("INSERT INTO Contacto (Id, Nombre, FechaNacimiento, Telefono, Observaciones) VALUES(@Id, @Nombre, @FechaNacimiento, @Telefono, @Observaciones)", con);
            cmd.Parameters.AddWithValue("@Id", txtId.Text); // Valor explícito para el Id
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@FechaNacimiento", txtFechaNacimiento.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
            cmd.ExecuteNonQuery();

            // Deshabilitar IDENTITY_INSERT para la tabla Contacto
            SqlCommand disableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT Contacto OFF", con);
            disableIdentityInsertCmd.ExecuteNonQuery();

            con.Close();
        }

    }
}
