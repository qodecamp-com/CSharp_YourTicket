namespace ClassesAndObjects;
class Program
{
    static void Main(string[] args)
    {
        //Question 1
        Person person1 = new Person("Andy", 35, "Male");
        person1.Introduce();

        //Question 2
        Car car1 = new Car("BMW", "750i", 2016);
        car1.StartEngine();

        //Question 3
        BankAccount bankAccount1 = new BankAccount(1234, 1000.00M, "Andy V");
        bankAccount1.Deposit(200.00M);
        bankAccount1.DisplayBalance();
        bankAccount1.Withdraw(100.00M);
        bankAccount1.DisplayBalance();

        //Question 4
        Book book1 = new Book("Extreme Ownership", "Jocco Willink", 250);
        book1.Read(25);

        //Question 5
        Television tv1 = new Television("Sony", "Bravia 65", 30);
        tv1.TurnOn();
        tv1.TurnOff();
    }
}
