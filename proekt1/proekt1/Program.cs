using System;

namespace proekt1
{
    class Class1
    {
        static void Main(string[] args)
        {
            int moneyE = 0;
            int restMoney = 0;
            int profit = 1;
            int savingA;
            int day = 0;
            Console.WriteLine("Hur mycket vill du tjäna ");
            savingA = Convert.ToInt32(Console.ReadLine());
            do
            {
                profit += 2;
                moneyE = moneyE + profit;

                day++;
            }

            while (moneyE < savingA);
            {
                if (moneyE > savingA)
                {
                    restMoney = moneyE % savingA;
                    moneyE -= restMoney;
                }
                Console.WriteLine("Det tog dig: " + day + "dagar att tjäna:" + moneyE + "och en rest på" + restMoney);
                if (restMoney != 0)
                {
                    int val;
                    Console.WriteLine("Vad vill du göra med rest pengarna?");
                    Console.WriteLine("Vill du donera till M? Tryck 1");
                    Console.WriteLine("donnera till nåt? tryck 2");
                    Console.WriteLine("Tryck 3 för att avsluta");
                    val = Convert.ToInt32(Console.ReadLine());
                    switch (val)
                    {
                        case 1:                           
                            Console.WriteLine("DOnera till M");
                            break;
                        case 2:
                            Console.WriteLine("TIll nåt");
                            break;
                        case 3:
                            break;
                        default:
                           Console.WriteLine("inget rest");
                            break;
                    }


                }

                Console.ReadKey();
            }
        }
    }
}
