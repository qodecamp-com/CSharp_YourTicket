namespace ClassesAndObjects;

class BankAccount
{
    int _accountNumber;
    decimal _balance;
    string _owner;

    public BankAccount(int accountNumber, decimal balance, string owner)
    {
        this._accountNumber = accountNumber;
        this._balance = balance;
        this._owner = owner;
    }

    public decimal Deposit(decimal amountToDeposit)
    {
        this._balance += amountToDeposit;
        return this._balance; //new balance
    }

    public decimal Withdraw(decimal amountToWithdraw)
    {
        this._balance -= amountToWithdraw;
        return this._balance; //new balance
    }

    public void DisplayBalance()
    {
        Console.WriteLine("Balance = {0}", this._balance);
    }
}