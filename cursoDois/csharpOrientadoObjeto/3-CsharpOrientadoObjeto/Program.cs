using System;

namespace _3_CsharpOrientadoObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaTitularUm = new ContaCorrente();
            contaTitularUm.saldo = 3;
            contaTitularUm.agencia = 1;
            contaTitularUm.titular = "Pessoa";
            ContaCorrente contaTitularDois = new ContaCorrente();
            contaTitularDois.saldo = 2;
            contaTitularDois.agencia = 1;
            contaTitularDois.titular = "Pessoa";
            // resultado falso porque a variavel está recebendo a referência para o objeto criado
            Console.WriteLine(contaTitularUm == contaTitularDois);

            //Ao atribuir a mesma referência da contatitulardois e contatitularum então os dois são iguais e a resposta é verdadeiro
            contaTitularDois = contaTitularUm;
            Console.WriteLine(contaTitularUm == contaTitularDois);

            //valores = 5 porque a contadois faz referencia ao objeto criado contaum
            contaTitularDois.saldo += 2;
            Console.WriteLine(contaTitularDois.saldo);
        }
    }
}
