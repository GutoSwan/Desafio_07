using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio7
{
    public interface Idaobase<T> where T : class
    {
        bool salvar(T entity, int id);
    }
}
