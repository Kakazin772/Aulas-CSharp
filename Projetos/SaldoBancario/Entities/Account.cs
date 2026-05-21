using System;
using System.Collections.Generic;
using System.Text;
using SaldoBancario.Entities.Exception;

namespace SaldoBancario.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < 0)
            {
                throw new AccountException("Nao é possivel relizar um saque com o saldo zerado");
            }

            if (amount > WithdrawLimit)
            {
                throw new AccountException("O seu limite de saque é menor do que o valor de saque solicitado");
            }

            if (amount > Balance)
            {
                throw new AccountException("Saldo insuficiente");
            }

            Balance = Balance - amount;
        }
    }
}
