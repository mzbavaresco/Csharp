using System;

namespace _4_CsharpOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrenteDeUmaPessoa = new ContaCorrente();
            contaCorrenteDeUmaPessoa.saldo -= 10;
            ///
            Console.WriteLine("Antes do saque:"+contaCorrenteDeUmaPessoa.saldo);
            Console.WriteLine(contaCorrenteDeUmaPessoa.Sacar(10));
            Console.WriteLine("Depois do saque:" + contaCorrenteDeUmaPessoa.saldo);
            contaCorrenteDeUmaPessoa.Depositar(10000);
            Console.WriteLine("Depois do deposito"+contaCorrenteDeUmaPessoa.saldo);


            ContaCorrente contaCorrenteDeOutraPessoa = new ContaCorrente();
            contaCorrenteDeUmaPessoa.Transferir(100, contaCorrenteDeOutraPessoa);
            Console.WriteLine("Saldo pessoa 1 pós transferência:"+contaCorrenteDeUmaPessoa.saldo);
            Console.WriteLine("Saldo pessoa 2 pós transferência:" + contaCorrenteDeOutraPessoa.saldo);
        }
    }
}
