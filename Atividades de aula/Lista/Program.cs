using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> ListaF = new List<Funcionario>();
            
            int quantidadefunc, i, idant = -121212, id, aumento;

            Console.WriteLine("Digite a quantidade de funcionario: ");
            quantidadefunc = int.Parse(Console.ReadLine());

            for (i = 0; i < quantidadefunc; i++)
            {
                Funcionario Func = new Funcionario();

                Console.Write("Digite o Id do funcionario: ");
                Func.Id = int.Parse(Console.ReadLine());

                while (idant == Func.Id)
                {
                    Console.Write("Id Invalido digite novamente: ");
                    Func.Id = int.Parse(Console.ReadLine());
                }

                Console.Write("Digte o nome do funcionario: ");
                Func.Nome = Console.ReadLine();

                Console.Write("Digite o salario do Funcionario: ");
                Func.Salario = double.Parse(Console.ReadLine());

                ListaF.Add(Func);

                idant = Func.Id;
            }

            Console.Write("Digite a Id do funcionario que tera o aumento: ");
            id = int.Parse(Console.ReadLine());

            Funcionario encontrada = ListaF.Find(p => p.Id == id);

            if (encontrada != null)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                aumento = int.Parse(Console.ReadLine());
                
                encontrada.AumentoSalario(aumento);
            }
            else
            {
                Console.WriteLine("Id invalida");
            }

            Console.WriteLine("-------------------------");

            foreach (Funcionario obj in ListaF)
            {
                Console.WriteLine(obj);
            }
        }
    }

}