using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crystal_store
{
    class Program
    {
        static void Main(string[] args)
        {
            int crystalPrice = 15;
            int goldCount;
            int crystalCount;
            bool enoughGold;

            Console.Write("Введите количество золота: ");
            goldCount = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристалов вы хотите купить?: ");
            crystalCount = Convert.ToInt32(Console.Read());
            
            enoughGold = goldCount >= crystalPrice * crystalCount;
            
            goldCount *= Convert.ToInt32(enoughGold);
            goldCount -= crystalPrice * crystalCount;
            Console.WriteLine("Вы купили " + crystalCount +
                 " кристаллов, у вас осталось " + (goldCount - crystalPrice * crystalCount) + " золота");
           
            Console.ReadKey();
        }
    }
}
