namespace csapp {
    public class SaverAcc : IBankAcc {

        private decimal _balance;
        
        
        public decimal Balance => _balance;

        public void Deposit(decimal amount) {
            _balance += amount;
        }

        public bool Withdraw(decimal amount) {
            if(_balance >= amount) {
                _balance -= amount;
                return true;
            }else {
                System.Console.WriteLine("insufficient funds!");
                return false;
            }
        }

        public override string ToString() {
            return $"Wallet : Balance = {_balance}";
        }
    }
}
