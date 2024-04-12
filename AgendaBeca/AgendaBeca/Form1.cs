using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

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
            txtId.ReadOnly = true;
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
            if (!datosPorConfirmar && readOnly)
            {
                txtId.Text = "";
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtFechaNacimiento.Text = "";
                txtObservaciones.Text = "";
                imagen.Image = null;
                datosPorConfirmar = true;
            }

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (!datosPorConfirmar && readOnly)
            {
                Context.con.Open();

                if (estaEnBDD(txtId.Text))
                {
                    repos.eliminarUsuario(txtId.Text);
                }
                else
                {
                    MessageBox.Show("El usuario no existe");
                }

                if (viewContactos.Rows.Count > 0)
                {
                    // Selecciona la primera fila
                    viewContactos.Rows[0].Selected = true;

                    // Llama al evento CellClick para simular la selección de la fila y desencadenar cualquier lógica asociada
                    dataGridView1_CellContentClick_1(viewContactos, new DataGridViewCellEventArgs(0, 0));
                }

                Context.con.Close();

                repos.BinData(viewContactos);
            }
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!datosPorConfirmar)
                {
                    seleccionarFila();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccione un usuario");
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtFechaNacimiento.Text = "";
            txtObservaciones.Text = "";
            imagen.Image = null;
            datosPorConfirmar = false;
            readOnly = true;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (datosPorConfirmar)
            {
                guardarDatos();
            }
            if (!readOnly)
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

            if (estaEnBDD(txtId.Text))
            {
                SqlCommand com = new SqlCommand("UPDATE Contacto " +
                    "SET Nombre = @Nombre, " +
                    "FechaNacimiento = @FechaNacimiento, " +
                    "Telefono = @Telefono, " +
                    "Observaciones = @Observaciones, " +
                    "Imagen = @Imagen" +
                    " WHERE Id = @Id", Context.con);
                com.Parameters.AddWithValue("@Id", txtId.Text);
                com.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                com.Parameters.AddWithValue("@FechaNacimiento", txtFechaNacimiento.Text);
                com.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                com.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);
                byte[] imagenBytes = Convert.FromBase64String(imagenToBase64(imagen.Image));
                com.Parameters.AddWithValue("@Imagen", imagenBytes);
                com.ExecuteNonQuery();
            }
            else
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
            Context.cmd = new SqlCommand("INSERT INTO Contacto " +
                "(Id, Nombre, FechaNacimiento, Telefono, Observaciones, Imagen) " +
                "VALUES(@Id, @Nombre, @FechaNacimiento, @Telefono, @Observaciones, @Imagen)", Context.con);
            Context.cmd.Parameters.AddWithValue("@Id", txtId.Text);
            Context.cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            Context.cmd.Parameters.AddWithValue("@FechaNacimiento", txtFechaNacimiento.Text);
            Context.cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            Context.cmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text);


            if(imagen.Image != null)
            {
                byte[] imagenBytes = Convert.FromBase64String(imagenToBase64(imagen.Image));
                Context.cmd.Parameters.AddWithValue("@Imagen", imagenBytes);
            } else
            {
                byte[] imagenPorDefecto = Convert.FromBase64String(imagenToBase64(Resource1.chico));
                Context.cmd.Parameters.AddWithValue("@Imagen", imagenPorDefecto);
            }


            Context.cmd.ExecuteNonQuery();

            // Deshabilitar IDENTITY_INSERT para la tabla Contacto
            SqlCommand disableIdentityInsertCmd = new SqlCommand("SET IDENTITY_INSERT Contacto OFF", Context.con);
            disableIdentityInsertCmd.ExecuteNonQuery();

            Context.con.Close();

            Repositorio repos = new Repositorio();
            repos.BinData(viewContactos);
            datosPorConfirmar = false;
        }

        private string imagenToBase64(Image imagen)
        {
            if(imagen!=null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagen.Save(ms, imagen.RawFormat);
                    byte[] imagenBytes = ms.ToArray();
                    return Convert.ToBase64String(imagenBytes);
                }
            } else
            {
                return null;
            }
        }

        public void seleccionarFila()
        {
            DataGridViewRow filaSeleccionada = viewContactos.SelectedRows[0];
            txtId.Text = filaSeleccionada.Cells["Id"].Value.ToString();
            txtId.ReadOnly = true;
            txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
            txtFechaNacimiento.Text = filaSeleccionada.Cells["FechaNacimiento"].Value.ToString();
            txtObservaciones.Text = filaSeleccionada.Cells["Observaciones"].Value.ToString();
            txtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
            byte[] imagenBytes = (byte[])filaSeleccionada.Cells["Imagen"].Value;

            imagen.Image = byteArrayToImagen(imagenBytes);

            readOnly = false;
        }

        public Image byteArrayToImagen(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        public void cargarImagen()
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png|Todos los archivos (*.*)|*.*\";\r\n ";

            if(abrirImagen.ShowDialog() == DialogResult.OK)
            {
                imagen.Image = Image.FromFile(abrirImagen.FileName);
            }
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

        private void imagen_Click(object sender, EventArgs e)
        {
            cargarImagen();
        }
    }
}
