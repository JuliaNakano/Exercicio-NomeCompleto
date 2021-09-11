using System;

namespace Exercicio_NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            
            Console.Write("Digite seu primeiro nome:");
            nome= Console.ReadLine();
            
            Console.Write("Digite seu sobrenome:... ");
            sobrenome=Console.ReadLine();
           
            Console.WriteLine($"{nome} {sobrenome}");
            Console.WriteLine($"{sobrenome.ToUpper()}, {nome}");
         }
    }
}
            