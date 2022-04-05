using System;

namespace Aula5vs
{
   class Program 
   {
        // 0 referencias
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre com sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre com sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o seu peso");
            float peso = float.Parse (Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Seu imc é: " + imc);

            if (imc < 18.5)
            { 
                Console.WriteLine("Você esta abaixo do peso. Se alimente melhor!");
            }

            else if (imc < 25)
            { 
                Console.WriteLine("Seu peso esta normal. Procure se manter assim.");
            }

            else if (imc < 30)
            {
                Console.WriteLine("Você esta com sobrepeso. Se alimente melhor e fique em alerta.");
            }

            else
            {
                Console.WriteLine("Você esta com obesidade. Procure um médico.");
            }
            
        }
    }
}
