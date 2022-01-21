using System;

namespace Classes_and_Objects
{
    class Program
    {

        class BankAccount
        {
            private string Name;
            private string Surname;
            private UInt16 Houseno;
            private string Streetname;
            private string City;
            private string Postcode;
            private string Country;
            private UInt64 Money;
            private UInt64 Accountno;
            public BankAccount(string firstname, string lastname, UInt16 houseno, string streetname, string city, string postcode, string country, UInt64 initialdeposit, UInt64 accountno)
            {
                Name = firstname;
                Surname = lastname;
                Houseno = houseno;
                Streetname = streetname;
                City = city;
                Postcode = postcode;
                Country = country;
                Money = initialdeposit;
                Accountno = accountno;
            }
            public void Deposit(UInt64 amount, UInt64 accountno)
            {
                if (accountno == Accountno)
                {
                    Money += amount;
                    Console.WriteLine($"Money of {0} successfully deposited in account {1}. Total value of account: {2}.", amount, Accountno, Money);
                }
                else
                {
                    Console.WriteLine($"Account Number inputted and Account Number of selected account do not match.");
                }

            }
            public void Withdraw(UInt64 amount, UInt64 accountno)
            {
                if (accountno == Accountno && Money >= amount)
                {
                    Money -= amount;
                    Console.WriteLine($"Money of {0} successfully withdrawn from account {1}. Total value of account: {2}.", amount, Accountno, Money);
                }
                else if (accountno == Accountno)
                {
                    Console.WriteLine($"Account {0} does not have enough money to withdraw selected amount of {1}. Total value of account: {2}", Accountno, amount, Money);
                }
                else
                {
                    Console.WriteLine($"Account Number inputted and Account Number of selected account do not match.");
                }
            }

            public void PrintInformation(UInt64 accountno)
            {
                if (accountno == Accountno)
                {
                    Console.WriteLine($"Name: {0}\nSurname: {1}\nAddress: {2}, {3}, {4}, {5}, {6}", Name, Surname, Houseno, Streetname, City, Postcode, Country);
                }
                else
                {
                    Console.WriteLine($"Account Number inputted and Account Number of selected account do not match.");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
    }
}
