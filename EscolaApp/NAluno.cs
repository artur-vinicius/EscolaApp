using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    class NAluno
    {
        private static List<Aluno> aluno = new List<Aluno>();
        public static void Inserir(Aluno a)
        {
            aluno.Add(a);
        }
        public static List<Aluno> Listar()
        {
            return aluno;
        }
        public static void Atualizar(Aluno a)
        {
            foreach (Aluno obj in aluno)
                if (obj.Id == a.Id)
                {
                    obj.Nome = a.Nome;
                    obj.Matricula = a.Matricula;
                    obj.IdTurma = a.IdTurma;
                }
        }
        public static void Excluir(Aluno a)
        {
            Aluno x = null;
            foreach (Aluno obj in aluno)
                if (obj.Id == a.Id) x = obj;
            if (x != null) aluno.Remove(x);
        }
    }
}
