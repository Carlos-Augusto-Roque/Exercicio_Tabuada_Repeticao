using System;

namespace Exercicio_Tabuada_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tabuada !");//exibição da mensagem
            Console.Write("Digite um número inteiro para ver sua tabuada: ");//exibição da mensagem
            int tab = int.Parse(Console.ReadLine());//entrada e armazenamento do número inteiro     

                for ( int numero = 1; numero <= 10; numero++) //(começa pelo 1 ; repete até o 10 ; incrementando de 1 em 1)
                {
                    Console.WriteLine(tab + " x " + numero + " = " + tab * numero); //exibição do resultado --> tab => qual número quero a tabuada * número (que vai de 1 até 10)
                }

            Console.WriteLine("Fim da Tabuada !");//exibição da mensagem
        }
            
    }
}
