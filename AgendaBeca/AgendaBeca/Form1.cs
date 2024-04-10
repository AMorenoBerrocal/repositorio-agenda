using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AgendaBeca
{
    public partial class Form1 : Form
    {

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
            Context.con.Open();

            // Habilitar IDENTITY_INSERT para la tabla Contacto
            SqlCommand enableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT Contacto ON", Context.con);
            enableIdentityInsertCmd.ExecuteNonQuery();

            // Insertar el nuevo registro con el valor explícito para la columna Id
            Context.cmd = new SqlCommand("INSERT INTO Contacto (Id, Nombre, FechaNacimiento, Telefono, Observaciones) VALUES(@Id, @Nombre, @FechaNacimiento, @Telefono, @Observaciones)", Context.con);
            Context.cmd.Parameters.AddWithValue("@Id", txtId.Text); // Valor explícito para el Id
            Context.cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            Context.cmd.Parameters.AddWithValue("@FechaNacimiento", txtFechaNacimiento.Text);
            Context.cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            Context.cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
            Context.cmd.ExecuteNonQuery();

            // Deshabilitar IDENTITY_INSERT para la tabla Contacto
            SqlCommand disableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT Contacto OFF", Context.con);
            disableIdentityInsertCmd.ExecuteNonQuery();

            Context.con.Close();
        }

    }
}
