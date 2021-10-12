using System;
using System.Collections.Generic;
using System.Text;

namespace POO1
{
    class ContaBancaria
    {
        public string Conta;
        public string Agencia;
        public string Nome;
        private string Senha = "123";
        private int Saldo;

        public ContaBancaria(int saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(int valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(int valor)
        {
            Saldo = Saldo - valor;
        }

        public int ConsultatSaldo()
        {
            int taxa = 10;
            int valorTaxa = (Saldo * taxa) / 100;
            return Saldo - valorTaxa;
        }

        public void ImprimirSaldo()
        {
            Console.WriteLine($"(Nome)  o saldo na sua conta (Conta) na agência (Agencia) é: {ConsultatSaldo()}");
        }
    }
}
