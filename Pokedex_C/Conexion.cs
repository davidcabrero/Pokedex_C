using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pokedex_C

    //Conexión a la base de datos Pokemons
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = listapokemons; Uid = root; Pwd =; Port = 3306");
        }

        //Sacar los pokemons por ID
        public DataTable getPoquemonPorId(int id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon WHERE id='" + id + "'", conexion); //Comando sql
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch(MySqlException e)
            {
                throw e;
            }
        }
    }
}
