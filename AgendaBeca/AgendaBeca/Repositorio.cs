using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaBeca
{
    public class Repositorio
    {
        public void BinData(DataGridView dataGridView1)
        {
            SqlCommand command = new SqlCommand("SELECT Id, Nombre, FechaNacimiento, Telefono, Observaciones, Imagen FROM Contacto", Context.con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public void eliminarUsuario(String id)
        {
            SqlCommand com = new SqlCommand("DELETE FROM Contacto WHERE Id = @Id", Context.con);
            com.Parameters.AddWithValue("@Id", id);
            com.ExecuteNonQuery();
        }

    }
}
