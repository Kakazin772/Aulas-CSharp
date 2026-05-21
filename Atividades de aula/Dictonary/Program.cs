using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;

            Dictionary<string, int> votos = new Dictionary<string, int>();

            path = Console.ReadLine();

            using(StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] voto = sr.ReadLine().Split(',');
                    
                    if (votos.ContainsKey(voto[0]))
                    {
                        votos[voto[0]] = votos[voto[0]] + int.Parse(voto[1]);
                    }
                    else
                    {
                        votos[voto[0]] = int.Parse(voto[1]);
                    }
                }
            }

            foreach (KeyValuePair<string, int> voto in votos)
            {
                Console.WriteLine($"{voto.Key}: {voto.Value}");
            }
        }
    }
}