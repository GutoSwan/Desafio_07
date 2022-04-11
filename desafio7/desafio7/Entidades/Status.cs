using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio7
{
    public class Status
    {
        public string nome { get; set; }
        public int id { get; set; }
        public int status_type { get; set; }
        public DateTime data_status { get; set; }

        public Status(int status, string nomeAluno, DateTime dataStatus, int id)
        {
            this.nome = nomeAluno;
            this.id = id;
            this.status_type = status;
            this.data_status = dataStatus;

        }
    }
}
