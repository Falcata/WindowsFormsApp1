using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class sqlManagement
    {
        public SQLiteConnection sqlite_conn; // variable publica que almacena la conexion

        public SQLiteConnection conexion()
        {

            //SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=c:\\Users\\oracle\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\seguridad.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en la conexion");
                Console.WriteLine(ex.Message + "\n");
               



            }
            return sqlite_conn;

        }
        public Boolean buscar(String Nombre, String Apellidos)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM USUARIOS"; // podemos hacer un where...
            Boolean retorno = false;
            try
            {

                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    // esto es pura fuerza bruta descargando toda la tabla y leyendola
                    string nombre = sqlite_datareader.GetString(1).ToString();
                    string apellidos = sqlite_datareader.GetString(2).ToString();
                    if (nombre == Nombre && apellidos == Apellidos)
                    {
                        //MessageBox.Show("User & Password tested!");
                        retorno = true;
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message + "\n");

            }

            sqlite_conn.Close();
            return retorno;
        }
    }
}
