﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_I_clase_15.Datos.Acceso
{
    internal class Personajes
    {
        private string connectionString = "Server=localhost;Database=prueba;Uid=root;Pwd=Umg$2023";
        public bool pruebaConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))

                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                };
            }
        public DataTable LeerPersonajes()
        {
            DataTable personajes = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM personajes_dragon_ball";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }
        public int CrearPersonaje(string nombre, string raza, int nivelPoder)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO personajes_dragon_ball (nombre, raza, nivel_poder) VALUES (@nombre, @raza, @nivelPoder)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@raza", raza);
                    command.Parameters.AddWithValue("@nivelPoder", nivelPoder);

                    return command.ExecuteNonQuery();
                }
            }
        }

    }

 
}
