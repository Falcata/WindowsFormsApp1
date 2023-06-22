using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;




namespace WindowsFormsApp1
{
    public class sqlManagement
    {
        public  SQLiteConnection sqlite_conn; // variable publica que almacena la conexion

        public SQLiteConnection conexion()
        {

            //SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=seguridad.db; Version = 3; New = True; Compress = True; ");
         // Open the connection:
         try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;

        }
        public void buscar(SQLiteConnection conn)

        {

        }
    }
}
