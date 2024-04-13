using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.PicContext
{
    public class Projeto
    {
        public int ProjetoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int AnosDuracao { get; set; }
        public List<Pesquisador> Pesquisadores { get; set; } = new List<Pesquisador>();
        public Projeto(Pesquisador pesquisador)
        {
            
        }
    }
}
