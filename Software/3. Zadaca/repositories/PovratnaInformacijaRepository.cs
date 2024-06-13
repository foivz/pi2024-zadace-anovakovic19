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
    public class PovratnaInformacijaRepository
    {
        public static PovratnaInformacija GetPovratnaInformacija(int id)
        {
            PovratnaInformacija povratna = null;
            string sql = $"SELECT * FROM Povratne_Informacije WHERE povratna_informacija_id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                povratna = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return povratna;
        }

        public static List<PovratnaInformacija> GetSvePovratneInformacije()
        {
            List<PovratnaInformacija> listaPovratnihInformacija = new List<PovratnaInformacija>();
            string sql = $"SELECT * FROM Povratne_Informacije";
            DB.OpenConnection();

            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                PovratnaInformacija povratnaInformacija = CreateObject(reader);
                listaPovratnihInformacija.Add(povratnaInformacija);
            }
            reader.Close();
            DB.CloseConnection();
            return listaPovratnihInformacija;
        }

        public static void InsertPovratnaInformacija(int Jelo_id, int Ocjena_jela, int Ocjena_kolicine, string Komentar)
        {
            string sql = $"INSERT INTO Povratne_Informacije (jelo_id, ocjena_jela, ocjena_kolicine, Komentar) VALUES ({Jelo_id}, {Ocjena_jela}, {Ocjena_kolicine}, '{Komentar}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeletePovratnaInformacija(int povratna_informacija_id)
        {
            string sql = $"DELETE FROM Povratne_Informacije WHERE povratna_informacija_id = {povratna_informacija_id}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        private static PovratnaInformacija CreateObject(SqlDataReader reader)
        {
            int povratna_Informacija_id = int.Parse(reader["povratna_informacija_id"].ToString());
            int jelo_id = int.Parse(reader["jelo_id"].ToString());
            int ocjena_Jela = int.Parse(reader["ocjena_jela"].ToString());
            int ocjena_Kolicine = int.Parse(reader["ocjena_kolicine"].ToString());
            string komentar = reader["Komentar"].ToString();
            var povratnaInformacija = new PovratnaInformacija
            {
                PovratnaInformacijaID = povratna_Informacija_id,
                JeloID = jelo_id,
                OcjenaJela = ocjena_Jela,
                OcjenaKolicine = ocjena_Kolicine,
                Komentar = komentar
            };
            return povratnaInformacija;
        }
    }
}
