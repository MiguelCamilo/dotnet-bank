
public class SavingsAccount : BankAccount {

     public SavingsAccount(string new_customer_name, double new_balance) : base(new_customer_name, new_balance) {
        deposit(200);
     }
}