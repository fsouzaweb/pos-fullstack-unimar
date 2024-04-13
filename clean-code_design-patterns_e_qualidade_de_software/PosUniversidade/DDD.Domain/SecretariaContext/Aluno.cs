using DDD.Domain.UserManagement;

namespace DDD.Domain.SecretariaContext
{
    public class Aluno : User
    {
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
    }
}
