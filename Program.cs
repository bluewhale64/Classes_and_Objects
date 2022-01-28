using System;
using System.Collections.Generic;

namespace Classes_and_Objects
{
    class Program
    {

        class Transaction
        {
            private Int64 Amount;
            private DateTime Date;
            private string Note;

            public Transaction(Int64 amount, DateTime date, string note)
            {
                Amount = amount;
                Date = date;
                Note = note;
            }
        }

        class BankAccount
        {
            private string Name;
            private string Surname;
            private UInt16 Houseno;
            private string Streetname;
            private string City;
            private string Postcode;
            private string Country;
            public UInt64 Money;
            private UInt64 Accountno;

            private List<Transaction> Transactions = new();

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
            private int Deposit(UInt64 amount)
            {
                Money += amount;
                Console.WriteLine($"Money of {0} successfully deposited in account. Total value of account: {2}.", amount, Money);
                return 0;
            }
            private int Withdraw(UInt64 amount)
            {
                if (Money >= amount)
                {
                    Money -= amount;
                    Console.WriteLine($"Money of {0} successfully withdrawn from account. Total value of account: {2}.", amount, Money);
                    return 0;
                }
                else
                {
                    Console.WriteLine($"Account does not have enough money to withdraw selected amount of {1}. Total value of account: {2}", amount, Money);
                    return 1;
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

            public void MakeTransaction(Int64 amount, DateTime date, string note)
            {
                int test = 0;
                if(amount > 0)
                {
                    test = Deposit(Convert.ToUInt64(amount));
                }
                else
                {
                    test = Withdraw(Convert.ToUInt64(amount*-1));
                }
                if(test == 0)
                {
                    Transactions.Add(new Transaction(amount, date, note));
                }
            }
        }

        class MyStack
        {
            List<int> stack = new();
            public MyStack(int item)
            {
                stack.Add(item);
            }

            public void Push(int item)
            {
                stack.Add(item);
            }

            public void Remove(int n)
            {
                for(int i = 0; i < n; i++)
                {
                    if (stack.Count > 0)
                    {
                        stack.RemoveAt(stack.Count - 1);
                    }
                }
            }

            public int Peek()
            {
                if (stack.Count > 0)
                {
                    return (stack[stack.Count - 1]);
                }
                else
                {
                    return (0);
                }
            }

            public int Pop()
            {
                if (stack.Count > 0)
                {
                    int returner = stack[stack.Count - 1];
                    stack.RemoveAt(stack.Count - 1);
                    return (returner);
                }
                else
                {
                    return (0);
                }
            }

        }

        class MyQueue
        {
            List<int> queue = new();
            public MyQueue(int item)
            {
                queue.Add(item);
            }

            public void Enqueue(int item)
            {
                queue.Insert(0, item);
            }

            public void Remove(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    if (queue.Count > 0)
                    {
                        queue.RemoveAt(queue.Count - 1);
                    }
                }
            }

            public int Peek()
            {
                if (queue.Count > 0)
                {
                    return (queue[queue.Count - 1]);
                }
                else
                {
                    return (0);
                }
            }

            public int Dequeue()
            {
                if (queue.Count > 0)
                {
                    int returner = queue[queue.Count - 1];
                    queue.RemoveAt(queue.Count - 1);
                    return (returner);
                }
                else
                {
                    return (0);
                }
            }

        }

        class StudentAccount : BankAccount
        {
            private string University;
            public StudentAccount(string uni, string firstname, string lastname, UInt16 houseno, string streetname, string city, string postcode, string country, UInt64 initialdeposit, UInt64 accountno) : base(firstname, lastname, houseno, streetname, city, postcode, country, initialdeposit, accountno)
            {
                University = uni;
            }
        }

        class InvestmentAccount : BankAccount
        {
            private UInt64 Interest;
            public InvestmentAccount(UInt64 interest, string firstname, string lastname, UInt16 houseno, string streetname, string city, string postcode, string country, UInt64 initialdeposit, UInt64 accountno) : base(firstname, lastname, houseno, streetname, city, postcode, country, initialdeposit, accountno)
            {
                Interest = interest;
            }
            private void ApplyInterest()
            {
                Money = Money + (Money * Interest / 100);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
    }
}
