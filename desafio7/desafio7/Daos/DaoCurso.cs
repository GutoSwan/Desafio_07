using Npgsql;

namespace desafio7
{
    public class DaoCurso : Idaobase<Curso>
    {
        NpgsqlConnection db = null;

        public DaoCurso()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=1234;Database=postgres";

            db = new NpgsqlConnection(connectionString);
        }

        public bool salvar(Curso curso, int id)
        {
            db.Open();

            var sql = "INSERT INTO Cursos(nome,id) VALUES(@nome,@id)";
            using var cmd = new NpgsqlCommand(sql, db);

            cmd.Parameters.AddWithValue("nome", curso.nome);
            cmd.Parameters.AddWithValue("id", curso.id);
            cmd.Prepare();

            var result = cmd.ExecuteNonQuery();

            db.Close();

            return result == 1;


        }
    }
}
