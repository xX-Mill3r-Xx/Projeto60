using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto60
{
    class Conta
    {
        public int NumeroDaConta { get; set; }
        public string Titular { get; set; }
        public double SaldoInicial { get; set; }
        private double _taxa;

        public Conta()
        {
        }

        public Conta(int numeroDaConta, string titular, double saldoInicial)
        {
            NumeroDaConta = numeroDaConta;
            Titular = titular;
            SaldoInicial = saldoInicial;
        }

        public double Taxa
        {
            get { return 5.00; }
        }

        public void ValDeposito(double deposito)
        {
            SaldoInicial += deposito;
        }

        public void Saque(double saque)
        {
            SaldoInicial -= saque + Taxa; ;
        }

        public override string ToString()
        {
            return $"Conta {NumeroDaConta}, " +
                $"Titula: {Titular}, " +
                $"Saldo: $ {SaldoInicial.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
