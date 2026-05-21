using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Banco
    {
        private int _numeroDaConta;
        private string _nomeTitular;
        private double _saldo;

        public int NumeroDaConta
        {
            get { return _numeroDaConta; }
            set { _numeroDaConta = value; }
        }

        public string NomeTitular
        {
            get { return _nomeTitular; }
            set { _nomeTitular = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public Banco(double saldo)
        {
           _saldo = saldo;
        }

        public void Deposito(double valorDeposito)
        {
            _saldo = _saldo + valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            _saldo = (_saldo - valorSaque) - 5;
        }

        public override string ToString()
        {
            return $"Conta {_numeroDaConta}, Titular: {_nomeTitular}, Saldo: $ {_saldo:F2}";
        }
    }
}
