using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        //ctor tab tab para criar construtor
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Construtor funcionário");
            Cpf = cpf;
            TotalDeFuncionarios++;
            Console.WriteLine(TotalDeFuncionarios);
            Salario = salario;

        }
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public virtual void  AumentarSalario() {
            //Salario += (Salario * 0.1);
            Salario *= 1.1;

        }

        public virtual double GetBonificacao() 
        {
            return Salario * 0.10;
        }
    }
}
