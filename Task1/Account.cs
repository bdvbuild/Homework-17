using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Account<T>
    {
        private T Num { get; set; }
        private double Balance { get; set; }
        private string Name { get; set; }

        public void Input()
        {
            Console.WriteLine("Введите номер");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя");
            Name = Console.ReadLine();
        }

        public string GetInfo()
        {
            return $"Клиент {Name}\nНомер счета {Num}\nБаланс {Balance}";
        }
    }
}
