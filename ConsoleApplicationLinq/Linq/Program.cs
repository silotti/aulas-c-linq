using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {

        static void ValoresMultiplosDeTre()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var multiplos3 = from inteiro in numeros where inteiro % 3 == 0 select inteiro;
            var outrojeito = numeros.Where(inteiro => inteiro % 3 == 0).Select(inteiro => inteiro);
            foreach (var inteiro in multiplos3)
            {
                Console.WriteLine(inteiro);
            }
        }
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            int total = 10;
            Random r = new Random();
            DateTime dataInicial = new DateTime(1990, 01, 01);
            DateTime dataFinal = DateTime.Now.AddYears(-16);
            TimeSpan tempo = (dataFinal - dataInicial);
            while (total-->0)
            {

                Aluno aluno = new Aluno();
                aluno.nome = "Nome " + r.Next(100);
                aluno.matricula=r.Next (500).ToString();
                aluno.nascimento = dataInicial.AddDays(r.Next((int)tempo.TotalDays));

                alunos.Add(aluno);

                foreach (var materia in materias)
                {
                    int totalProvas = 10;
                    while(totalProvas-->0)
                    {
                        Prova p = new Prova();
                    }
                }


            }

            #region"Aleatorio"
            var maioresDe18Lambda =
                alunos.Where(
                a => (DateTime.Now - a.nascimento).TotalDays
                > (365 * 18)
                ).Select(b => b.nome);

            foreach (String nome in maioresDe18Lambda)
            {
                Console.WriteLine("Alunos: " + nome);
            }
            #endregion

            #region"Crescente"
            var maioresDe18 =
                from a in alunos
                where (DateTime.Now - a.nascimento).TotalDays > (365 * 18)
                orderby a.nome
                select a;

            foreach (Aluno m in maioresDe18)
            {
                Console.WriteLine("Alunos: " + m.nome);
            }
            #endregion

            #region"Decrescente"
            var porPartes =
                alunos.Where(a => (DateTime.Now - a.nascimento).TotalDays
                > (365 * 18))
                .OrderByDescending(a => a.nome)
                .Select(b => b.nome);

            foreach (String x in porPartes)
            {
                Console.WriteLine("Alunos: " + x);
            }
            #endregion


            //            var maioresDe18x =
            //                from a in alunos
            //                where (DateTime.Now - a.nascimento).TotalDays > (365 * 18)
            //                orderby a.nascimento
            //                select new
            //                {
            //                    nome = a.nome,
            //                   idade = DateTime.Now - a.nascimento
            //               }
            //                ;

            //  foreach (String idade in maioresDe18x)
            // {
            //    Console.WriteLine("Nome4: " + idade);
            // }

            #region"Provas"
            var provas = from a in alunos
                         where
                        (DateTime.Now - a.nascimento).TotalDays
                        > (365 * 18)
                        select a.Provas;

            foreach (var a in provas)
            {
                Console.WriteLine("Nome3: " + a);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
