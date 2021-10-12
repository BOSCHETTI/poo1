using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria(200);

            contaBancaria.Agencia = "1234-5";
            contaBancaria.Conta = "147582-5";
            contaBancaria.Nome = "Aldo Boschetti Filho";

            contaBancaria.ImprimirSaldo();

            contaBancaria.Depositar(200);

            contaBancaria.ImprimirSaldo();

            contaBancaria.Depositar(300);

            contaBancaria.ImprimirSaldo();

            contaBancaria.Sacar(100);

            contaBancaria.ImprimirSaldo();

        }
    }
} 
