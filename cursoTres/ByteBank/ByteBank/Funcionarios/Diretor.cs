using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Construtor Diretor");
        }
        public string Departamento { get; set; }
        public override double GetBonificacao()
        {
            
            return Salario*0.5;
        }

        public override void AumentarSalario()
        {
            //base.AumentarSalario();
            Salario *= 1.15;
        }
    }
}
