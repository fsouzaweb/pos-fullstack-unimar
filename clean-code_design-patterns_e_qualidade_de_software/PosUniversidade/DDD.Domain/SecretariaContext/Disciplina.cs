using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.SecretariaContext
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }
        public string Name { get; set; }
        public double Valor { get; set; }
        public bool Disponivel { get; set; }
        public bool Ead {  get; set; }
        public List<Aluno> Alunos { get; set; }
    }
}
