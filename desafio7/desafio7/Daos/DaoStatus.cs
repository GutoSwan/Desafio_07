using Npgsql;

namespace desafio7
{
    public class DaoStatus : Idaobase<Status>
    {
        NpgsqlConnection db = null;

        public DaoStatus()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=1234;Database=postgres";

            db = new NpgsqlConnection(connectionString);
        }

        public bool salvar(Status status,int id)
        {
            db.Open();

            var sql = "INSERT INTO Status(nomedoaluno,id,status_type,data_status) VALUES(@nomedoaluno,@id,@status_type,@data_status)";
            using var cmd = new NpgsqlCommand(sql, db);

            cmd.Parameters.AddWithValue("nomedoaluno", status.nome);
            cmd.Parameters.AddWithValue("id", status.id);
            cmd.Parameters.AddWithValue("status_type", status.status_type);
            cmd.Parameters.AddWithValue("data_status", status.data_status);
            cmd.Prepare();

            var result = cmd.ExecuteNonQuery();

            db.Close();

            return result == 1;


        }
    }
}