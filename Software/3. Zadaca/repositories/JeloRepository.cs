using _3.Zadaca.models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Zadaca.repositories
{
    public class JeloRepository
    {
        public static Jelo GetJelo(int id)
        {
            Jelo jelo = null;
            string sql = $"SELECT * FROM Jela WHERE jelo_id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                jelo = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return jelo;
        }

        public static List<Jelo> GetSvaJelaPoNazivu(string naziv)
        {
            List<Jelo> listaJela = new List<Jelo>();
            string sql = $"SELECT * FROM Jela WHERE naziv LIKE '%{naziv}%'";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Jelo jelo = CreateObject(reader);
                listaJela.Add(jelo);
            }
            reader.Close();
            DB.CloseConnection();
            return listaJela;
        }

        public static List<Jelo> GetSvaJela()
        {
            List<Jelo> listaJela = new List<Jelo>();
            string sql = $"SELECT * FROM Jela";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Jelo jelo = CreateObject(reader);
                listaJela.Add(jelo);
            }
            reader.Close();
            DB.CloseConnection();
            return listaJela;
        }

        public static void InsertJelo(string Naziv, string Opis, string Kategorija)
        {
            string sql = $"INSERT INTO Jela (naziv, opis, kategorija) VALUES ('{Naziv}', '{Opis}', '{Kategorija}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteJelo(int jelo)
        {
            string sql = $"DELETE FROM Jela WHERE jelo_id = {jelo}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static Jelo CreateObject(SqlDataReader reader)
        {
            int jelo_id = int.Parse(reader["jelo_id"].ToString());
            string naziv = reader["naziv"].ToString();
            string opis = reader["opis"].ToString();
            string kategorija = reader["kategorija"].ToString();
            var jelo = new Jelo
            {
                Jelo_id = jelo_id,
                Naziv = naziv,
                Opis = opis,
                Kategorija = kategorija,
            };
            return jelo;
        }
    }
}
