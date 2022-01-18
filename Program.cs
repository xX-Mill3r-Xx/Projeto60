using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto60
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta c1 = new Conta();

            double dep;

            Console.Write("Entre com o número da conta: ");
            c1.NumeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            c1.Titular = Console.ReadLine();

            PerguntaDeposito:
            Console.Write("Haverá deposito inicial (s/n)? ");
            char r1 = char.Parse(Console.ReadLine());
            if(r1 == 's' || r1 == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1.ValDeposito(dep);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(c1);
            }
            else if (r1 == 'n' || r1 == 'N')
            {
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(c1);
            }
            else
            {
                Console.WriteLine("Selecione uma opção valida!");
                goto PerguntaDeposito;
            }
            Console.ReadLine();
            Console.Clear();

            Console.Write("Entre com um valor para deposito: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.ValDeposito(dep);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.ReadLine();
            Console.Clear();

            Console.Write("Entre com um valor para saque: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(dep);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.ReadLine();
        }
    }
}
