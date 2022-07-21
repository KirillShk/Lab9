using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветсвует калькулятор!");
                Console.Write("Введите целое число X=");
                int x = Convert.ToInt32(Console.Read());
                Console.Write("Введите целое число Y=");
                int y = Convert.ToInt32(Console.Read());
                double result=0;
                Console.WriteLine("Введите код операции: \n\t 1 - сложение \n\t 2 - вычитание \n\t 3 - произведение \n\t 4 - частное");
                int z = Convert.ToInt32(Console.Read());
                switch (z)
                {
                    case 1:
                      { 
                        result = x+y;
                        break;
                      }
                    case 2:
                        {
                            result = x - y;
                            break;
                        }
                     case 3:
                        {
                            result = x * y;
                            break;
                        }
                      case 4:
                        {
                            result = x / y;
                            break;
                        }
                }
                Console.WriteLine("Результат = {0}", result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
