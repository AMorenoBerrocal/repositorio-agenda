using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace AgendaBeca
{
    public partial class Form1 : Form
    {

        Repositorio repos = new Repositorio();
        private bool datosPorConfirmar = false;
        private bool readOnly = true;

        public Form1()
        {
            InitializeComponent();
            repos.BinData(viewContactos);
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
            if(!datosPorConfirmar && readOnly)
            {
                txtId.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtFechaNacimiento.Text = "";
                txtObservaciones.Text = "";
                datosPorConfirmar = true;
            }

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if(!datosPorConfirmar && readOnly) {
                Context.con.Open();

                SqlCommand com = new SqlCommand("DELETE FROM Contacto WHERE Id = @Id", Context.con);
                com.Parameters.AddWithValue("@Id", txtId.Text);
                com.ExecuteNonQuery();

                Context.con.Close();

                repos.BinData(viewContactos);
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (!datosPorConfirmar)
            {
                seleccionarFila();
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtFechaNacimiento.Text = "";
            txtObservaciones.Text = "";
            datosPorConfirmar = false;
            readOnly = true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if(datosPorConfirmar)
            {
                guardarDatos();
            }
            if(!readOnly)
            {
                modificarDatos();
            }
        }

        public bool estaEnBDD(string id)
        {
            bool existe = false;

            SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Contacto WHERE Id = @Id", Context.con);
            com.Parameters.AddWithValue("@Id", id);
            int count = (int)com.ExecuteScalar();
            existe = (count > 0);

            return existe;
        }

        public void modificarDatos()
        {
            Context.con.Open();

            if(estaEnBDD(txtId.Text))
            {
                SqlCommand com = new SqlCommand("UPDATE Contacto SET Nombre = @Nombre, FechaNacimiento = @FechaNacimiento, Telefono = @Telefono, Observaciones = @Observaciones WHERE Id = @Id", Context.con);
                com.Parameters.AddWithValue("@Id", txtId.Text);
                com.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                com.Parameters.AddWithValue("@FechaNacimiento", txtFechaNacimiento.Text);
                com.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                com.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
                com.ExecuteNonQuery();
            } else
            {
                Context.con.Close();
                guardarDatos();
            }

            Context.con.Close();
            repos.BinData(viewContactos);
            readOnly = true;
        }

        public void guardarDatos()
        {
            Context.con.Open();

            // Habilitar IDENTITY_INSERT para la tabla Contacto
            SqlCommand enableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT Contacto ON", Context.con);
            enableIdentityInsertCmd.ExecuteNonQuery();

            // Insertar el nuevo registro con el valor explícito para la columna Id
            Context.cmd = new SqlCommand("INSERT INTO Contacto (Id, Nombre, FechaNacimiento, Telefono, Observaciones) VALUES(@Id, @Nombre, @FechaNacimiento, @Telefono, @Observaciones)", Context.con);
            Context.cmd.Parameters.AddWithValue("@Id", txtId.Text);
            Context.cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            Context.cmd.Parameters.AddWithValue("@FechaNacimiento", txtFechaNacimiento.Text);
            Context.cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            Context.cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
            Context.cmd.ExecuteNonQuery();

            // Deshabilitar IDENTITY_INSERT para la tabla Contacto
            SqlCommand disableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT Contacto OFF", Context.con);
            disableIdentityInsertCmd.ExecuteNonQuery();

            Context.con.Close();

            Repositorio repos = new Repositorio();
            repos.BinData(viewContactos);
            datosPorConfirmar = false;
        }

        public void seleccionarFila()
        {
            DataGridViewRow filaSeleccionada = viewContactos.SelectedRows[0];
            txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtFechaNacimiento.Text = filaSeleccionada.Cells["FechaNacimiento"].Value.ToString();
            txtObservaciones.Text = filaSeleccionada.Cells["Observaciones"].Value.ToString();
            txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
            readOnly = false;
        }



        private void txtObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewDatosContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
