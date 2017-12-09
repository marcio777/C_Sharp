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
            double num1, num2, soma;

            Console.WriteLine("Digite o primeiro numero: "  );
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            soma = (num1 + num2);

            Console.WriteLine("A soma e " + soma);



           
        }
    }
}
