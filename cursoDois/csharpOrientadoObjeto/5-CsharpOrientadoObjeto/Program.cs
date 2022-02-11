using System;

namespace _5_CsharpOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente nomeCliente = new Cliente();
            nomeCliente.nome = "Gabriela";
            nomeCliente.cpf = "121545454545";
            nomeCliente.profissao = "Gerente do banco";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = nomeCliente;
            conta.saldo = 123456;
            conta.agencia = 29;
            Console.WriteLine(nomeCliente.nome);
            Console.WriteLine(conta.titular.nome);


            nomeCliente.nome = "Gabriela Costa";
            Console.WriteLine(nomeCliente.nome);
            Console.WriteLine(conta.titular.nome);
        }
    }
}
