# Kalkulator Pseudo

### Oppsett av verdier til "RegnUt" som er den som får en overload.
```csharp
public static double RegnUt(double a, double b, string oper)
    {
        if (oper == "+") return a + b;
        if (oper == "-") return a - b;
        if (oper == "*") return a * b;
        if (oper == "/") return b != 0 ? a / b : 0;

        return 0;
    }

public static double RegnUt(double a, string oper)
    {
        if (oper == "doble") return a * 2;
        if (oper == "halvere") return a / 2;

        return 0;
    }

```



### Velkomst beskjed osv. Forsøk på interface etter den man kan nå, med litt ACII og farge.
```csharp
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Superkalkulatoren er aktiv!\n");
        Console.ResetColor();
```

### While loop, som forsetter så lenge du vil (j). Eller avslutte om du vil exite.

```csharp
while (fortsett)
        {
            Console.Write("Velg type (1 = vanlig kalkulator, 2 = enkel og rask utregning): ");
            string valg = (Console.ReadLine() ?? "").Trim();

            if (valg == "exit")
                break;

            if (valg == "1")
        }
```

#### Sjekk på om en sann verdi er tastet inn, hvis ikke kommer feilmelding. Litt samme som LesTall, men forsto ikke helt hvordan jeg skulle gjøre det for denne og "+" "-".... operasjonen sammen.
```csharp
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
```

#### Som forsetter hvis du velger 1 eller 2, gjør utregninger å skriver "j" på om du skal forsette.

### Forsøker å gjøre om input til tall med tryparse. Hvis den komme tilbake "false" aka bruker skriver bokstaver, kommer feilmelding. Var ett forslag fra chatgpt for å unngå en del gjenntagende kode, som jeg begynte å skrive.
```csharp
static double LesTall()
    {
        while (true)
        {
            string input = Console.ReadLine() ?? "";
            if (double.TryParse(input, out double tall))
                return tall;
        }
    }                

```


### Avslutning med writeline med ACII og noe foregroundcolor for "bedre" interface.
```csharp
 Console.WriteLine("\n👻Takk for at du ville kalkulere!👻");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
        ░█▀▀░█▀█░█▀█░█░█░█░█░█▀▀░█▀▀░█
        ░▀▀█░█░█░█▀█░█▀▄░█▀▄░█▀▀░▀▀█░▀
        ░▀▀▀░▀░▀░▀░▀░▀░▀░▀░▀░▀▀▀░▀▀▀░▀");
        Console.ResetColor();
```

