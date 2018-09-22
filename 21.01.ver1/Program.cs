using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace _21._01.ver1
{
    class Program
    {
        private static void CarriageListToConsole(List<Carriage> carList)
        {
            List<Carriage> tmp = new List<Carriage>(carList);
            for (int i = 0; i < tmp.Count; i++)
            {
                Console.WriteLine("+++ Номер:{0} Количество пассажиров:{1} Количество багажа:{2} Уровень комфорта:{3} ", tmp[i].Number, tmp[i].PassNum, tmp[i].LuggAmount, tmp[i].Comfort);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать! Выберите имя поезда: ");
            string name = Console.ReadLine();
            Train train = new Train(name);
           
            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите подходящую функцию (1 - добавить вагон, 2 - найти вагоны в заданном диапазоне числа пассажиров, 3 - удалить вагон, 4 - вывести кол-во пассажиров, 5 - вывести кол-во багажа, 6 - отсортировать вагоны по комфорту, 7 - вывести список вагонов, 8 - выход из программы");
                    int condition = int.Parse(Console.ReadLine());
                    switch (condition)
                    {
                        case 1:
                            Console.WriteLine("Введите через пробел: номер, число пассажиров, количество багажа, уровень комфорта(1-4): ");
                            string values = Console.ReadLine();
                            string[] decomposeValues = values.Split(' ');
                            if (int.Parse(decomposeValues[3]) > 0 && int.Parse(decomposeValues[3]) < 5)
                            {
                                switch (int.Parse(decomposeValues[3]))
                                {
                                    case 1:
                                        EconomCarriage economCarriage = new EconomCarriage(int.Parse(decomposeValues[0]), int.Parse(decomposeValues[1]), int.Parse(decomposeValues[2]), int.Parse(decomposeValues[3]));
                                        train.CarriagesConnected.Add(economCarriage);
                                        break;
                                    case 2:
                                        MiddleCarriage middleCarriage = new MiddleCarriage(int.Parse(decomposeValues[0]), int.Parse(decomposeValues[1]), int.Parse(decomposeValues[2]), int.Parse(decomposeValues[3]));
                                        train.CarriagesConnected.Add(middleCarriage);
                                        break;
                                    case 3:
                                        ExpensiveCarriage expensiveCarriage = new ExpensiveCarriage(int.Parse(decomposeValues[0]), int.Parse(decomposeValues[1]), int.Parse(decomposeValues[2]), int.Parse(decomposeValues[3]));
                                        train.CarriagesConnected.Add(expensiveCarriage);
                                        break;
                                    case 4:
                                        LuxuryCarriage luxuryCarriage = new LuxuryCarriage(int.Parse(decomposeValues[0]), int.Parse(decomposeValues[1]), int.Parse(decomposeValues[2]), int.Parse(decomposeValues[3]));
                                        train.CarriagesConnected.Add(luxuryCarriage);
                                        break;
                                }
                               
                            }
                            else
                            {
                                Console.WriteLine("Неверно задан уровень комфорта!");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Введите через пробел: минимальное количество пассажиров, максимальное количество пассажиров: ");
                            string passengersLimits = Console.ReadLine();
                            string[] decomposeLimits = passengersLimits.Split(' ');
                            List<Carriage> result = train.FindAppropiateCarriages(int.Parse(decomposeLimits[0]), int.Parse(decomposeLimits[1]));
                            Console.WriteLine("Результат: ");
                            CarriageListToConsole(result);
                            break;
                        case 3:
                            Console.WriteLine("Введите номер удаляемого вагона: ");
                            int number = int.Parse(Console.ReadLine());
                            train.DisconnectCarriage(number);
                            break;
                        case 4:
                            Console.WriteLine("Общее количество пассажиров: {0}", train.GetPassNumber());
                            break;
                        case 5:
                            Console.WriteLine("Общее количество багажа(кг): {0}", train.GetLuggAmount());
                            break;
                        case 6:
                            Console.WriteLine("Результат: ");
                            train.ComfortSort();
                            CarriageListToConsole(train.CarriagesConnected);
                            break;
                        case 7:
                            Console.WriteLine("Результат: ");
                            CarriageListToConsole(train.CarriagesConnected);
                            break;
                        case 8:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Неверно выбранная операция!");
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Проверьте правильность вводимых данных!");
                }
            }
        }
    }
}
