namespace csapp {
    public interface IBankAcc {

        void Deposit(decimal amount);
        bool Withdraw(decimal amount);

        decimal Balance { get; }

    }
}
