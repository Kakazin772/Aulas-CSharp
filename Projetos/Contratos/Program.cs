using Contratos.Entities;
using Contratos.Entities.Enum;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Contracts;

namespace Contratos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, qt, ano, mes;
            double salario;
            string nomedepartamento, nomefuncionario, dataVt;
            Workerlevel level;
            Departament departamento;
            Worker funcionario;

            Console.Write("Digite o nome do departamento: ");
            nomedepartamento = Console.ReadLine();

            Console.WriteLine("Digite as informações do funcionario:");
            Console.Write("Nome: ");
            nomefuncionario = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Enum.Parse<Workerlevel>(Console.ReadLine());
            Console.Write("Salario Base: ");
            salario = double.Parse(Console.ReadLine());

            departamento = new Departament(nomedepartamento);
            funcionario = new Worker(nomefuncionario, level, salario, departamento);

            Console.WriteLine("Digite a quantidade de contratos do funcionario:");
            qt = int.Parse(Console.ReadLine());

            for (i = 1; i <= qt; i++)
            {
                double valor;
                int horas;
                DateTime data;
                HourContract contract;
                
                Console.WriteLine($"Contrato {i}:");
               
                Console.Write("Data (DD/MM/YYYY): ");
                data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                valor = double.Parse(Console.ReadLine());

                Console.Write("Tempo de duração do contrato: ");
                horas = int.Parse(Console.ReadLine());

                contract = new HourContract(data, valor, horas);
                funcionario.AddContract(contract);
            }

            Console.Write("Entre com o ano e o mes para calcular o valor total: ");
            dataVt = Console.ReadLine();

            mes = int.Parse(dataVt.Substring(0, 2));
            ano = int.Parse(dataVt.Substring(3));

            Console.WriteLine($"Nome: {funcionario.Name}");
            Console.WriteLine($"Departamento: {funcionario.Departament.Name}");
            Console.WriteLine($"Valor total: {funcionario.Income(ano, mes):F2}");
        }
    }
}