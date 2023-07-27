using System;

namespace Calculator 
{
    class Program 
    {
        static void Main (string[] args)
        {
            Console.Clear();
            Cadastro();
            
             
        }
        static void Cadastro ()
        {
            Console.Clear();
            Console.WriteLine("Para iniciarmos o seu Cadastro, primeiro forneça as informações a seguir");
            Console.WriteLine("Por favora informe a sua idade");
            int idade = int.Parse(Console.ReadLine());
           if (idade <= 17)
           {
            Console.WriteLine("Voce nao tem idade o suficiente para continuar.");

           }
           else
           {
            Menu();
           }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite qual operação voce deseja prosseguir");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - multiplicação");
            int numero = int.Parse(Console.ReadLine());
            switch (numero)
            {
               case 1: Soma(); break;
               case 2: Subtração(); break;
               case 3: Divisão(); break;
               case 4: Multiplicação(); break;
               case 5: System.Environment.Exit(0); break;
               default: Menu(); break;
            }

        }
        static void Soma ()
        {
            Console.Clear();
            Console.WriteLine("Insira os numero de soma:");
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());
            float resposta = v1 + v2;
            Console.WriteLine(" O resultado da sua operação foi:" + resposta);
            
            

        }
        static void Subtração ()
        {
            Console.Clear();
            Console.WriteLine("Insira os numero de soma:");
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());
            float resposta = v1 - v2;
            Console.WriteLine("O resultado da sua operação foi:" + resposta);

        }
        static void Divisão()
        {
            Console.Clear();
            Console.WriteLine("Insira os numero de soma:");
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());
            float resposta = v1 / v2;
            Console.WriteLine("O resultado da sua operação foi:" + resposta);

        }
        static void Multiplicação()
        {
            Console.Clear();
            Console.WriteLine("Insira os numero de soma:");
            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());
            float resposta = v1 * v2;
            Console.WriteLine("O resultado da sua operação foi:" + resposta);
        }



    }
}
