using System;

namespace BuzzDeedQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Welcome to the buzzfeed quiz of the life time.");
            Console.WriteLine("We will determine which cat fatness level you are based on your basic bichiness. ");
            Console.WriteLine("Are you ready?(yes/no");

            string anwser = Console.ReadLine();

            if (anwser == "yes")
            {
                Console.WriteLine("Let us beggin!");

            }
            else if (anwser == "no")
            {

                Console.WriteLine("Then what are you doing here? Waiting for something to happen?" + "\n" + "I mean, you do you, but you could be doing something better with your time." + "\n" + "Dishonar on you and dishonar on your cow");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("im not that smart. think more simpler");
                Environment.Exit(1);
            }

            Console.WriteLine("What would you order at starbucks?" + "\n" +
                "A) chapuchino" + "\n" + "B) a black coffee" + "\n" + "C) a caramel pumkin spised latte");

            string a1 = Console.ReadLine();

            switch (a1)
            {
                case "a":
                    score++;
                    break;
                case "b":
                    score += 2;
                    break;
                case "c":
                    Console.WriteLine("Level: OH LORD HE COMMIN!!" + "\n" + "Only the most basic of bithes pick that, congrats");
                    Environment.Exit(1);
                    break;
            }

            Console.WriteLine("Wow...ok. Next question!" + "\n" + "How many scrunchies do you have?" + "\n"
                + "A) <3" + "\n" + "B) 3 - 10" + "\n" + "C) 10+");


            string a2 = Console.ReadLine();

            switch (a2)
            {
                case "a":
                    score++;
                    break;
                case "b":
                    score += 2;
                    break;
                case "c":
                    score += 3;
                    break;

            }

            Console.WriteLine("Are you for real?...Never mind, NEXT!" + "\n" + "How many stickers do you have on your water bottle?" +
                "\n" + "A) 0 - 1 " + "\n" + "B) 2 - 4" + "\n" + "C) 5+");

            string a3 = Console.ReadLine();

            switch (a3)
            {
                case "a":
                    score++;
                    break;
                case "b":
                    score += 2;
                    break;
                case "c":
                    score += 3;
                    break;

            }

            Console.WriteLine("..., NEXT!" + "\n" + "How often do you do your nails?" +
                "\n" + "A) 0 - 3 a year " + "\n" + "B) 1 - 2 times a week" + "\n" + "C) every week");

            string a4 = Console.ReadLine();

            switch (a4)
            {
                case "a":
                    score++;
                    break;
                case "b":
                    score += 2;
                    break;
                case "c":
                    score += 3;
                    break;

            }

            Console.WriteLine("Your score: " + score);



            switch (score)
            {
                case 4:
                case 5:
                    Console.WriteLine("A FINE BOI");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("A HECKING CHONKER");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("MEGA CHONK");
                    break;
                case 10:
                case 11:
                    Console.WriteLine("OH LAWD HE COMMIN");
                    break;

            }




        }
    }
}


