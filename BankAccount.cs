
// class example, adding public makes this available project wide
public class BankAccount {
    // int is for integers
    // double / float is for a floating point decimal

    // adding private only makes it available for this class
    public string customer_name = "";
    public double balance = 0;

    // default constructor, safety net 
    public BankAccount() {
        customer_name = "Bob";
        balance = 0;
    }

    // this is a method due to it doing something
    public BankAccount(string new_customer_name, double new_balance) {
        customer_name = new_customer_name;
        // balance will == information passed to parameter
        balance = new_balance;
    }

    public void deposit(double amount) {

        if(amount <= 0) {
            throw new Exception("amount must be greater than zero");
        }

        balance += amount;
    }


    public double get_balance() {
        return balance;
    }
}