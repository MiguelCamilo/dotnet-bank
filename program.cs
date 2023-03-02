// class     object           
BankAccount new_account = new SavingsAccount("Jim",250);



Console.WriteLine(new_account.customer_name + "'s starting balance is : " + "$" + new_account.get_balance());

new_account.deposit(-100);

Console.WriteLine(new_account.customer_name + "'s starting balance is : " + "$" + new_account.get_balance());
