using System;
using System.Linq;
using System.Globalization;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;
            double salarioo;

            List<Funcionario> Funcionarios = new List<Funcionario>();

            Console.WriteLine("Digite o caminho do arquivo:");
            path = Console.ReadLine();

            using(StreamReader sr = File.OpenText(path))
            {
                while(!sr.EndOfStream)
                {
                    string nome, email;
                    double salario;
                    
                    string[] line = sr.ReadLine().Split(',');

                    nome = line[0];
                    email = line[1];
                    salario = double.Parse(line[2], CultureInfo.InvariantCulture);

                    Funcionarios.Add(new Funcionario(nome, email, salario));
                }
            }

            Console.Write("Digite o salario: ");
            salarioo = double.Parse(Console.ReadLine());

            Console.WriteLine($"Email das pessoas com um salario maior que: {salarioo:F2}");

            if (!Funcionarios.Any(p => p.Salario >= salarioo))
            {
                Console.WriteLine($"Nao existe um funcionario com um salario maior ou igual a {salarioo:F2}");
            }
            else
            {
                var funcionarios = Funcionarios.Where(p => p.Salario >= salarioo).Select(p => p.Email).OrderBy(p => p);

                foreach(var func in funcionarios)
                {
                    Console.WriteLine($"{func}");
                }
            }

            if (!Funcionarios.Any(p => p.Nome[0] == 'M' || p.Nome[0] == 'm'))
            {
                Console.WriteLine($"Nao existe um funcionario com um nome q inicia com M");
            }
            else
            {
                var nomeM = Funcionarios.Where(p => p.Nome[0] == 'M' || p.Nome[0] == 'm').Sum(p => p.Salario);

                Console.WriteLine($"Soma dos salarios das pessoas q o nome comecam com M: {nomeM}");
            }
        }
    }
}