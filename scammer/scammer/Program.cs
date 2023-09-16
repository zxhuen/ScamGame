using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scammer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int money = 30;
            String answer;

            Console.WriteLine("20$ game");
            Console.WriteLine("Do you want to buy this game for 20 bucks,    YES or NO");
            answer = Console.ReadLine();
            
            if (answer.Equals("YES"))
            {
                int yesorno;

                money = money - 20;

                Console.WriteLine("Do you want to play the game ? press 1 on your keybaord if yes, and press 2 on your keyboard if no");
                yesorno = Convert.ToInt32(Console.ReadLine());

                if (yesorno == 1)
                {
                    int plrmoney = 1000;
                    int i = 0;
                    String qwe;

                    Console.WriteLine("Game name : I can guess the future");
                    int futureguesser;

                    while (i == 0)
                    {
                        Console.WriteLine("You currently have : " + plrmoney + "$");
                        Console.WriteLine("Pick a number betweem 1 - 100");
                        futureguesser = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("You picked :");
                        Console.WriteLine(futureguesser);

                        plrmoney = plrmoney - 200;

                        Console.WriteLine("Do you want to play again ?   y or n");
                        qwe = Console.ReadLine();

                        if (qwe.Equals("n"))
                        {
                            i++;
                        }
                        
                    }

                    if (plrmoney <= 0)
                    {
                        Console.WriteLine("YOU LOST!");
                    }
                }
                else
                {
                    Console.WriteLine("Ok, Leaving the game");
                }
            }
            else
            {
                Console.WriteLine("Okay, you're poor");
            }

        }
    }
}
