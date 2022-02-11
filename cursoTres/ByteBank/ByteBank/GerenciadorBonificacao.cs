using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario func) 
        {
            _totalBonificacao+=func.GetBonificacao();
        }
        public double GetTotalBonificacao() 
        {
            return _totalBonificacao;
        }
    }
}
