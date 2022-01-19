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
            Inicio:
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

            Depositar:
            Console.Write("Entre com um valor para deposito: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.ValDeposito(dep);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.ReadLine();
            Console.Clear();

            Sacar:
            Console.Write("Entre com um valor para saque: ");
            dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(dep);

            InformacoesDaConta:
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.Write("Deseja efetuar mais alguma operção no caixa (s/n)? ");
            char r2 = char.Parse(Console.ReadLine());
            if(r2 == 's' || r2 == 'S')
            {
                Console.WriteLine("#1 - Retornar ao Inicio");
                Console.WriteLine("#2 - Informaçoões da conta");
                Console.WriteLine("#3 - Depositar");
                Console.WriteLine("#4 - Sacar");
                Console.WriteLine("#5 - Sair");
                Console.Write("Escolha uma Opção: ");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {

                    case 1:
                        Console.WriteLine("#1 - Retornar ao Inicio");
                        goto Inicio;
                    case 2:
                        Console.WriteLine("#2 - Informaçoões da conta");
                        goto InformacoesDaConta;
                    case 3:
                        Console.WriteLine("#3 - Depositar");
                        goto Depositar;
                    case 4:
                        Console.WriteLine("#4 - Sacar");
                        goto Sacar;
                    case 5:
                        Console.WriteLine("#5 - Sair");
                        break;
                        
                    default:
                        Console.WriteLine("Escolha uma opção valida");
                        break;
                }

            }
            else if (r2 == 'n' || r2 == 'N')
            {
                Console.WriteLine("Obrigado por usar nosso caixa eletronico! Volte sempre.");
            }

            Console.ReadLine();
        }
    }
}
