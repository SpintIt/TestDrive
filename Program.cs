using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrive
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            // Task4();
            // Task4_v2();
            // Task5();
            // Task5_v2();
            // Task6();
            // Task7();
            // Task8();
        }

        private static void Task1()
        { 
            Console.WriteLine("ЯЮниор");
            Console.ReadKey();
        }

        public static void Task2()
        {
            byte dayOfMonth;
            sbyte temperatureOnEarth;
            ushort moneyOnDeposit;
            int countScore;
            float speedOfCat;
            double distanceToBed;
            uint healthOfBoss;
            char firstSymbolOnWord;
            string namePerson;
            bool isZombie;
        }

        private static void Task3()
        {
            /**
             * int a = 10;
             * int b = 38;
             * int c = (31 – 5 * a) / b;
             * Console.WriteLine(c);
             * 
             * Результатом будет 0 т.к. ожидается целое число 
             * от фактического значения с плавающей точкой -0,5
             * у которого отбрасывается дробная часть.
             */
        }

        private static void Task4()
        {
            Console.Write("Как к Вам обращаться? ");
            string nameOfSubject = Console.ReadLine();

            Console.Write("Сколько Вам полных лет? ");
            int ageOfSubject = Convert.ToInt32(Console.ReadLine());

            Console.Write("С каким животным Вы себя ассоциируете? ");
            string totemAnimal = Console.ReadLine();

            Console.Write("Что вы сегодня кушали? ");
            string lastFood = Console.ReadLine();

            Console.Write("Ваша оценка по математике? ");
            int scoreOnMath = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваш анамнез:");
            Console.WriteLine(
                $"Вас зовут {nameOfSubject}, " +
                $"Вам {ageOfSubject} полных лет, " +
                $"Вы себя ассоциируете с - {totemAnimal}, " +
                $"кушали Вы - {lastFood}, " +
                $"а по математике у Вас {scoreOnMath}."
            );

            Console.ReadKey();
        }

        // Без нормальной обработки
        private static void Task4_v2()
        {
            int countPlayers;
            List<string> playersGuessed = new List<string>();
            List<string> namePlayers = new List<string>();

            Console.Write("Количество игроков? ");
            countPlayers = Convert.ToInt32(Console.ReadLine());

            if (countPlayers <= 0)
                return;

            for (int i = 1; i < countPlayers + 1; i++)
            {
                Console.Write($"Игрок №{i}, как Вас зовут? ");
                namePlayers.Add(Console.ReadLine());
            }

            Console.WriteLine($"\nИгра начинается!\n");

            while (true)
            {
                foreach (string name in namePlayers)
                {
                    Console.Write($"Меня зовут {name}, и я возьму с собой в поход: ");
                    string item = Console.ReadLine();

                    if (char.ToUpper(name[0]) == char.ToUpper(item[0]))
                    {
                        Console.WriteLine($"{name} с {item} ты пойдешь с нами в поход!\n");

                        if (!playersGuessed.Contains(name))
                            playersGuessed.Add(name);
                        
                        if (playersGuessed.Count >= countPlayers)
                            break;
                    }
                    else
                    {
                        Console.WriteLine($"{name} с {item} мы не возьмем тебя с собой в поход!\n");
                    }
                }

                if (playersGuessed.Count >= countPlayers)
                    break;
            }

            Console.WriteLine("Наконец-то мы ушли в поход!");
            Console.ReadKey();
        }

        private static void Task5()
        {
            string firstName = "Митькин";
            string lastName = "Артем";
            string tmpString;

            Console.WriteLine($"Вы перепутали свои данные, приходите завтра: Имя - {firstName}, Фамилия - {lastName}");

            tmpString = firstName;
            firstName = lastName;
            lastName = tmpString;

            Console.WriteLine($"Завтра. Вот теперь правильно: Имя - {firstName}, Фамилия - {lastName}");

            Console.ReadKey();
        }

        private static void Task5_v2()
        {
            string firstName = "Митькин";
            string lastName = "Артем";

            Console.WriteLine($"Вы перепутали свои данные, приходите завтра: Имя - {firstName}, Фамилия - {lastName}");

            (firstName, lastName) = (lastName, firstName);

            Console.WriteLine($"Завтра. Вот теперь правильно: Имя - {firstName}, Фамилия - {lastName}");

            Console.ReadKey();
        }

        private static void Task6()
        {
            int countImages = 52;
            int imagesInRow = 3;

            int filledRows = countImages / imagesInRow;
            int leftImages = countImages % imagesInRow;

            Console.WriteLine($"Всего {countImages} изображений по {imagesInRow} в ряд.\n");
            Console.WriteLine($"Полных рядов - {filledRows}, картинок остается - {leftImages}.");

            Console.ReadKey();
        }

        private static void Task7()
        {
            int goldInWallet;
            int crystalsToBuy;
            int priceOneCrystal = 5;

            bool isAbleToPay;

            Console.WriteLine($"Кристалов покупаете? Цена за шутку - {priceOneCrystal} золотых.\n");

            Console.Write("Сколько у Вас золота? ");
            goldInWallet = Convert.ToInt32(Console.ReadLine());

            Console.Write("Сколько кристаллов Вам нужно? ");
            crystalsToBuy = Convert.ToInt32(Console.ReadLine());

            isAbleToPay = goldInWallet >= crystalsToBuy * priceOneCrystal;
            crystalsToBuy *= Convert.ToInt32(isAbleToPay);
            goldInWallet -= crystalsToBuy * priceOneCrystal;

            Console.WriteLine($"Красивое! Теперь у Вас {crystalsToBuy} кристаллов и {goldInWallet} золота.");

            Console.ReadKey();
        }

        private static void Task8()
        {
            int timeForOneGranny = 10;
            int minutesInHour = 60;

            int granniesInLine;
            int hoursToWait;
            int minutesToWait;

            Console.Write("Сколько бабулек перед вами? ");
            granniesInLine = Convert.ToInt32(Console.ReadLine());

            hoursToWait = timeForOneGranny * granniesInLine / minutesInHour;
            minutesToWait = timeForOneGranny * granniesInLine % minutesInHour;

            Console.WriteLine($"Вам ждать {hoursToWait}ч. и {minutesToWait}мин.");

            Console.ReadKey();
        }
    }
}
