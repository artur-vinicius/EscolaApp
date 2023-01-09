using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    class NAluno
    {
        private static List<Aluno> aluno = new List<Aluno>();
        public static void Inserir(Aluno a)
        {
            Abrir();
            aluno.Add(a);
            Salvar();
        }
        public static List<Aluno> Listar()
        {
            Abrir();
            return aluno;
        }
        public static void Atualizar(Aluno a)
        {
            Abrir();
            foreach (Aluno obj in aluno)
                if (obj.Id == a.Id)
                {
                    obj.Nome = a.Nome;
                    obj.Matricula = a.Matricula;
                    obj.Email = a.Email;
                }
            Salvar();
        }
        public static void Excluir(Aluno a)
        {
            Abrir();
            Aluno x = null;
            foreach (Aluno obj in aluno)
                if (obj.Id == a.Id) x = obj;
            if (x != null) aluno.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                // Objeto que serializa (transforma) uma lista de turmas em um texto em XML
                XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
                // Objeto que abre um texto em um arquivo
                f = new StreamReader("./turmas.xml");
                // Chama a operação de desserialização informando a origem do texto XML
                aluno = (List<Aluno>)xml.Deserialize(f);
            }
            catch
            {
                aluno = new List<Aluno>();
            }
            // Fecha o arquivo
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            // Objeto que serializa (transforma) uma lista de turmas em um texto em XML
            XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
            // Objeto que grava um texto em um arquivo
            StreamWriter f = new StreamWriter("./turmas.xml", false);
            // Chama a operação de serialização informando o destino do texto XML
            xml.Serialize(f, aluno);
            // Fecha o arquivo
            f.Close();
        }
    }
}
