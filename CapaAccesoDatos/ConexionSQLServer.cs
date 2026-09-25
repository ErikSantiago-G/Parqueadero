using CapaNegocio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAccesoDatos
{
    public class ConexionSQLServer : FuenteDeDatos
    {
        private SqlConnection conexion;

        public ConexionSQLServer() {
            this.conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Application " +"Name=\"Ejemplo Parqueadero Capas\";Command Timeout=0;Initial Catalog=BD_Parqueadero");
        }

        public bool registrarIngresoVehiculo(Vehiculo vehiculo)
        {
            string insert = string.Format(
                "INSERT INTO vehiculos VALUES ('{0}', '{1}', '{2}') ",
                vehiculo.Placa,
                vehiculo.MomentoIngreso.ToString("yyyy-MM-dd HH:mm"),
                vehiculo.TipoVehiculo
                );

            conexion.Open();

            SqlCommand comando = new SqlCommand(insert, conexion);

            int filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();

            if( filasAfectadas == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool eliminarVehiculo(string placa)
        {
            string delete = string.Format(
                "DELETE FROM vehiculos WHERE placa = '{0}'",
                placa);

            conexion.Open();

            SqlCommand comando = new SqlCommand(delete, conexion);

            int filasAfectadas = comando.ExecuteNonQuery();

            conexion.Close();

            if (filasAfectadas == 1)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public Vehiculo consultarIngresoVehiculo(string placa)
        {
            Vehiculo vehiculo = new Vehiculo();

            string select = string.Format("SELECT * FROM vehiculos WHERE placa = '{0}' ", placa);

            conexion.Open();

            SqlCommand comando = new SqlCommand(select, conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read()) { 
                vehiculo.Placa = reader.GetString(0);
                vehiculo.MomentoIngreso = reader.GetDateTime(1);
                vehiculo.TipoVehiculo = reader.GetString(2);
            }

            conexion.Close();

            return vehiculo;
        }

    }
}
