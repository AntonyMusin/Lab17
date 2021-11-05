using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17
{
    class Program
    {
        static void Create(Account<int> account)
        {
            Console.WriteLine("Номер счета(тип int):");
            account.accId = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Сумма на счете:");
            account.sum = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("ФИО клиента:");
            account.name = Console.ReadLine();
        }
        static void Create(Account<string> account)
        {
            Console.WriteLine("Номер счета(тип string):");
            account.accId = Console.ReadLine();
            Console.WriteLine("Сумма на счете:");
            account.sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ФИО клиента:");
            account.name = Console.ReadLine();
        }
        static void Print (Account<string> account)
        {
            string a = account.accId;
            double b = account.sum;
            string c = account.name;
            Console.WriteLine("Номер счета: {0} Сумма на счете: {1} ФИО Клиента {2}", a, b, c);
        }
        static void Print(Account<int> account)
        {
            int a = account.accId;
            double b = account.sum;
            string c = account.name;
            Console.WriteLine("Номер счета: {0} Сумма на счете: {1} ФИО Клиента {2}", a, b, c);
        }


        static void Main(string[] args)
        {
            Account<int> account1=new Account<int>();
            Create(account1);
            Account<string> account2 = new Account<string>();
            Create(account2);
            Account<int> account3 = new Account<int>();
            Create(account3);
            Print(account1);
            Print(account2);
            Print(account3);
            Console.ReadKey();
        }
    }
    class Account<T>
    {
        private T AccId;
        public T accId
        {
            set
            {
                AccId = value;
            }
            get
            {
                return
                    AccId;
            }
        }
        private double Sum;
        public double sum
        {
            set
            {
                Sum = value;
            }
            get
            {
                return
                    Sum;
            }
        }
        private string Name;
        public string name
        {
            set
            {
                Name = value;
            }
            get
            {
                return
                    Name;
            }
        }
    }
}
