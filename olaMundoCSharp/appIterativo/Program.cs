using System;

namespace appIterativo
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalInvestido;
            double salario;
            double percent;
            totalInvestido = 10000;
            salario = 100000.12;
            percent=0.1;
            for (int i = 0; i < 12; i++)
            {
                totalInvestido += salario + salario * percent;
                Console.WriteLine("Mês "+(i+1)+":"+totalInvestido);
            }
            Console.WriteLine(totalInvestido);
    }
    }
}
