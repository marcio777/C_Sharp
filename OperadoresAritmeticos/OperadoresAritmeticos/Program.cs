using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, soma,sub,mult,div;

            Console.WriteLine("Digite o primeiro numero: "  );
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            soma = (num1 + num2);
            sub = (num1 - num2);
            mult = (num1 * num2);
            div = (num1 / num2);

            Console.WriteLine("A soma e " + soma);
            Console.WriteLine("A Subtração e " + sub);
            Console.WriteLine("A Multiplicação e " + mult);
            Console.WriteLine("A Divisão  e " + div);




        }
    }
}
