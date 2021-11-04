using System;

namespace DAY5_Basic_programs
{
    class Program
    {
        public static void Main(string[] args)
        {
            //char ok;
            //ok = 'n';
            //do
            //{

            Console.WriteLine("Enter your Choice : \n1.Flip Coin. \n2.Leap Year. \n3.Harmonic Number. \n4.Power of 2. \n5.Prime Factor. \n6.Even or Odd. \n7.Divisor and Dividend. \n8.Large Number. \n9.Check Vowel or Consonant.\n10.Swap.");

            int key = Convert.ToInt32(Console.ReadLine());

            switch (key)
            {
                case 1:
                    FlipCoin.Flipcoin();
                    break;
                case 2:
                    Leapyear.leapyear();
                    break;
                case 3:
                    HarmonicNum.Harmonicnum();
                    break;
                case 4:
                    PowerofTwo.poweroftwo();
                    break;
                case 5:
                    Primefactor.primefactor();
                    break;
                case 6:
                    Evenodd.evenodd();
                    break;
                case 7:
                    DivisorDividend.divisiordividend();
                    break;
                case 8:
                    LargestNum.largestnum();
                    break;
                case 9:
                    VowelConsonents.vowelsconsonents();
                    break;
                case 10:
                    Swapping.swapping();
                    break;
                default:
                    Console.WriteLine("Number is invalid.");
                    break;
            }
            //} while (ok);
        }
    }
}