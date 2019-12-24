using ConsoleApp2.Entities.Exceptions;

namespace ConsoleApp2.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(Balance == 0)
            {
                throw new DomainException("There is no balance to withdraw.");
            }
            if(amount > WithdrawLimit)
            {
                throw new DomainException("Value exceeds the withdraw limit.");
            }
            if(amount > Balance)
            {
                throw new DomainException("Value exceeds the current balance.");
            }
            Balance -= amount;
        }
    }
}
