using Npgsql;


namespace desafio7
{
    public class DaoAluno : Idaobase<Aluno>
    {
        NpgsqlConnection db = null;

        public DaoAluno()
        { 
            var connectionString = "Host=localhost;Username=postgres;Password=1234;Database=postgres";

            db = new NpgsqlConnection(connectionString);
        }

        public bool salvar(Aluno aluno, int id)
        {
            db.Open();

            var sql = "INSERT INTO Alunos(nome, idade, nota,id) VALUES(@nome, @idade, @nota, @id)";
            using var cmd = new NpgsqlCommand(sql, db);

            cmd.Parameters.AddWithValue("nome", aluno.nome);
            cmd.Parameters.AddWithValue("idade", aluno.idade);
            cmd.Parameters.AddWithValue("nota", aluno.nota);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();

            var result = cmd.ExecuteNonQuery();

            db.Close();

            return result == 1;

            
        }
    }
}
