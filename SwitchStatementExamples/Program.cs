using System;

namespace SwitchStatementExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which country has the highest population of wild tigers?");
            string answer = Console.ReadLine();
            int score = Question1(answer);

            TotalPointsScored(score);

            Console.ReadKey();
        }

        private static int Question1(string answer)
        {
            int score = 0;
            const int bonusPoints = 2;

            switch (answer.ToUpper())
            {
                case "INDIA":
                    score++;
                    Console.WriteLine("Correct");

                    Console.WriteLine("For bonus points name the country with the second highest population of wild tigers.");
                    answer = Console.ReadLine();

                    switch (answer.ToUpper())
                    {
                        case "RUSSIA":
                            Console.WriteLine("Correct!! You have won 2 bonus points.");
                            score = score + bonusPoints;
                            break;
                        case "INDONESIA":
                            Console.WriteLine("Incorrect!! You were close. Indonesia has the third largest population of wild tigers.");
                            break;
                        default:
                            Console.WriteLine("Incorrect answer. No bonus points granted.");
                            break;
                    }


                    break;
                case "MALAYSIA":
                case "RUSSIA":
                case "INDONESIA":
                    Console.WriteLine("'Malaysia', 'Russia' and 'Indonesia' do have wild tigers but 'India' is the country with the most amount of wild tigers.");
                    break;
                default:
                    Console.WriteLine("Incorrect answer");
                    break;
            }

            return score;
        }
        private static void TotalPointsScored(int score)
        {
            switch (score)
            {
                case 0:
                    Console.WriteLine("You scored '0/3' points");
                    break;
                case 1:
                    Console.WriteLine("You scored '1/3' points");
                    break;
                case 3:
                    Console.WriteLine("You scored '3/3' points. Well done!!");
                    break;
                case int x when x < 0 || x > 3:
                    Console.WriteLine("A score cannot be less than 0 or greater than 3");
                    break;
                default:
                    Console.WriteLine("Invalid score");
                    break;
            }

        }

    }
}
