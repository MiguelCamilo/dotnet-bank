
public class CheckingAccount : BankAccount {
    // 
    public CheckingAccount(string new_customer_name, double new_balance) : base(new_customer_name, new_balance) {
        deposit(100); // all checking accounts created get $100 more
    }
}