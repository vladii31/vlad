using System;

namespace vlad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random slump = new Random();
            Console.WriteLine("Välkomen till 21:an!");
            string menyVal = "0";
            while (menyVal != "4")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("välj ett alternativ");
                Console.WriteLine("1. spela 12:an");
                Console.WriteLine("2. Visa senaste vinaren");
                Console.WriteLine("3. Spelets regler");
                Console.WriteLine("4. Avsluta programet");
                menyVal = Console.ReadLine();

                //Tom rad innan användarens val körs
                Console.WriteLine();

                switch (menyVal)
                {
                    //Spela en omgång av 21:an
                    case "1":
                        int datornsPöäng = 0;
                        int spelarensPöäng = 0;
                        Console.WriteLine("Nu kommer två kort dras per spelare");
                        datornsPöäng += slump.Next(1, 11);
                        datornsPöäng += slump.Next(1, 11);
                        spelarensPöäng += slump.Next(1, 11);
                        spelarensPöäng -= slump.Next(1, 11);

                        //Låt användaren dra fler kort
                        string kortVal = "";
                        while (kortVal != "n" && spelarensPöäng <= 21)
                        {
                            Console.WriteLine($"Din poäng:{spelarensPöäng}");
                            Console.WriteLine($"Datornsc poäng:{}")


                            break;

                    //Visa senaste vinnaren
                    case "2":
                        break;

                    //Visa spelets regler
                    case "3":
                        break;

                    //Gör ingenting (programet avslutas)
                    case "4":
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ");
                        break;
                }

                // Tom rad innan nästa körning
                Console.WriteLine();
            }
        }
    }
}