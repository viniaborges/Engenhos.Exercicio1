using System;

namespace Engenhos.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int m3 = 0;
            int m5 = 0;

            Console.Write("Forneça um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0) m3 += i;
                if (i % 5 == 0) m5 += i;
            }

            Console.WriteLine("A soma dos múltiplos de 3, de 0 (zero) até " + n + " é: " + m3);
            Console.WriteLine("A soma dos múltiplos de 5, de 0 (zero) até " + n + " é: " + m5);

            /* Sugestões de melhorias:
               - Testar se o valor fornecido para o usuário é realmente um número inteiro;
               - Ao invés de fixar os valores 3 e 5 para o cálculo dos múltiplos, pode ser perguntado ao usuário para quais múltiplos ele deseja obter a soma.
            */
        }
    }
}
