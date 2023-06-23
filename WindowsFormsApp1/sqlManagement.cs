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
        public void buscar()
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM USUARIOS";
            
            try {

                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string myreader = sqlite_datareader.GetString(1).ToString();
                    Console.WriteLine(myreader);
                }
            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message + "\n");

            }    
           
            sqlite_conn.Close();
        }
    }
}
