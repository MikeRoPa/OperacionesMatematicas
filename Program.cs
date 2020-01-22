/*
 * Creado por SharpDevelop.
 * Usuario: Propietario
 * Fecha: 07/12/2019
 * Hora: 09:34 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Generic;
using System.Data.SQLite.Linq;

namespace SEMINARIO
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{			
//			CrearDBSqlite();
//            ConsultarBDSqlite();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	
	public static void ConsultarBDSqlite()
    {
            // Creamos la conexion a la BD
            // El Data Source contiene la ruta del archivo de la BD
            SQLiteConnection conexion = new SQLiteConnection("Data Source=prueba.sqlite;Version=3;New=False;Compress=True;");
            conexion.Open();
            
            // Lanzamos la consulta y preparamos la estructura para leer datos
            string consulta = "select * from gente";
            SQLiteCommand cmd = new SQLiteCommand(consulta, conexion);
            SQLiteDataReader datos = cmd.ExecuteReader();
            
            // Leemos los datos de forma repetitiva
            while (datos.Read())
            {
                string nombre = Convert.ToString(datos[1]);
                int edad = Convert.ToInt32(datos[2]);
                
                // Y los mostramos
                System.Console.WriteLine("Nombre: {0}, edad: {1}",
                nombre, edad);
            }
            
            // Finalmente, cerramos la conexion
            conexion.Close();
//            Console.ReadKey();
     }

     public static void CrearDBSqlite()
     {
            Console.WriteLine("Creando la base de datos...");

            // Creamos la conexion a la BD.
            // El Data Source contiene la ruta del archivo de la BD
            SQLiteConnection conexion = new SQLiteConnection
            ("Data Source=prueba.sqlite;Version=3;New=True;Compress=True;");
            conexion.Open();
            
            // Creamos la tabla
            string creacion = "CREATE TABLE gente (codigo INT PRIMARY KEY, nombre VARCHAR(40), edad INT);";
            SQLiteCommand cmd = new SQLiteCommand(creacion, conexion);
            cmd.ExecuteNonQuery();
            
            // E insertamos dos datos
            string insercion = "INSERT INTO gente VALUES (1,'Juan',20);";
            cmd = new SQLiteCommand(insercion, conexion);
            int cantidad = cmd.ExecuteNonQuery();
            if (cantidad < 1)
                Console.WriteLine("No se ha podido insertar");

            insercion = "INSERT INTO gente VALUES (2,'Pedro',19);";
            cmd = new SQLiteCommand(insercion, conexion);
            cantidad = cmd.ExecuteNonQuery();
            if (cantidad < 1)
                Console.WriteLine("No se ha podido insertar");
            
            // Finalmente, cerramos la conexion
            conexion.Close();
            Console.WriteLine("Creada.");
//            Console.ReadKey();
     }		
	}
}
