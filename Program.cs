using System;

class Kalkulator
{
    public static double RegnUt(double a, double b, string op)
    {
        if (op == "+") return a + b;
        if (op == "-") return a - b;
        if (op == "*") return a * b;
        if (op == "/") return b != 0 ? a / b : 0;

        return 0;
    }

    public static double RegnUt(double a, string ops)
    {
        if (ops == "doble") return a * 2;
        if (ops == "halvere") return a / 2;

        return 0;
    }
}

class Program
{
    static void Main()
    {
        Kalkulator kalkis = new Kalkulator();
        bool fortsett = true;

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Superkalkulatoren er aktiv!\n");
        Console.ResetColor();
        Console.WriteLine(@"
        ░█░█░█▀▀░█░░░█▀▀░█▀█░█▄█░█▀▀░█
        ░█▄█░█▀▀░█░░░█░░░█░█░█░█░█▀▀░▀
        ░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀░▀░▀▀▀░▀");
        Console.WriteLine("\nSkriv 'exit' for å avslutte");

        while (fortsett)
        {
            Console.Write("Velg type (1 = vanlig kalkulator, 2 = enkel og rask utregning): ");
            string valg = (Console.ReadLine() ?? "").Trim();

            if (valg == "exit")
                break;

            if (valg == "1")
            {
                Console.Write("Tall 1: ");
                double a = LesTall();

                Console.Write("Tall 2: ");
                double b = LesTall();

                string op = "";
                bool gyldigOperasjon = false;

                while (!gyldigOperasjon)
                {

                    Console.Write("Velg operasjon (+, -, *, /): ");
                    op = (Console.ReadLine() ?? "").Trim();

                    if (op == "+" || op == "-" || op == "*" || op == "/")
                    {
                        gyldigOperasjon = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ugyldig operasjon!");
                        Console.ResetColor();
                    }
                }

                double resultat = Kalkulator.RegnUt(a, b, op);
                if (double.IsNaN(resultat))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Velg en riktig verdi da! Ikke masse å velge imellom!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"Resultat: {resultat}");
                }


            }
            else if (valg == "2")
            {
                Console.Write("Tall: ");
                double a = LesTall();
                
                string ops = "";
                bool doubleOperasjon = false;

                while (!doubleOperasjon)
                {
                    Console.Write("Velg (doble / halvere): ");
                    ops = (Console.ReadLine() ?? "").Trim().ToLower();
                    if (ops == "doble" || ops == "halvere")
                    {
                        doubleOperasjon = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ugyldig operasjon! Velg mellom å doble eller halvere");
                        Console.ResetColor();
                    }
                }

                double resultat = Kalkulator.RegnUt(a, ops);
                Console.WriteLine($"Resultat: {resultat}");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ugyldig valg, prøv igjen.\n");
                Console.ResetColor();
            }

            string svar = "";
            bool vilDuFortsette = false;

            while (!vilDuFortsette)
            {
                Console.Write("\nVil du fortsette? (j/n): ");
                svar = (Console.ReadLine() ?? "").Trim().ToLower();

                if (svar == "j")
                {
                    vilDuFortsette = true;
                }

                else if (svar == "n")
                {
                    fortsett = false;
                    vilDuFortsette = true;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ugyldig input, prøv igjen");
                    Console.ResetColor();
                }


            }

        }

        Console.WriteLine("\n👻Takk for at du ville kalkulere!👻");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
        ░█▀▀░█▀█░█▀█░█░█░█░█░█▀▀░█▀▀░█
        ░▀▀█░█░█░█▀█░█▀▄░█▀▄░█▀▀░▀▀█░▀
        ░▀▀▀░▀░▀░▀░▀░▀░▀░▀░▀░▀▀▀░▀▀▀░▀");
        Console.ResetColor();
    }


    static double LesTall()
    {
        while (true)
        {
            string input = Console.ReadLine() ?? "";
            if (double.TryParse(input, out double tall))
                return tall;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ugyldig tall, prøv igjen: ");
            Console.ResetColor();

        }
    }
}


