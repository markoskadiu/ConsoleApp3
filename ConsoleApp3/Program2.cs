using System.Data;

namespace ConsoleApp3;

public class Ushtrim1
{
   public static void Ushtrimi1()
   {
      string? emri = "";
        string? mbiemri = "";
        int mosha = 0;
        string? vendLindja = "";
        string? profesioni = "";
        
        char[] numrat = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        
        Console.WriteLine("Ca bot si kalut. Ju lutem pergjigjuni pyetjeve te meposhtme!");
        Console.WriteLine("");
        
        /* Pyetja 1: Emri */
        while (string.IsNullOrWhiteSpace(emri) || emri.ToLower().IndexOfAny(numrat) >= 0)
        {
            Console.WriteLine("Si e keni emrin?");
            emri = Console.ReadLine();
        }
        
        /* Pyetja 2: Mbiemri */
        while (string.IsNullOrWhiteSpace(mbiemri) || mbiemri.ToLower().IndexOfAny(numrat) >= 0)
        {
            Console.WriteLine("Si e keni mbiemrin?");
            mbiemri = Console.ReadLine();
        }
        
        /* Pyetja 3: Mosha */
        while (mosha < 18)
        {
            Console.WriteLine("Sa vjec jeni?");
            string inputMosha = Console.ReadLine();

            // Validojme moshen ne qofte se eshte e sakte
            if (int.TryParse(inputMosha, out mosha))
            {
                if (mosha < 18)
                {
                    Console.WriteLine("Me vjen keq por duhet te jesh te pakten 18 vjec.");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Ju lutem vendosni nje moshe te vlefshme.");
            }
        }
        
        /* Pyetja 4: VendLindja */
        while (string.IsNullOrWhiteSpace(vendLindja) || vendLindja.ToLower().IndexOfAny(numrat) >= 0)
        {
            Console.WriteLine("Ku keni lindur?");
            vendLindja = Console.ReadLine();
        }
        
        /* Pyetja 5: Profesioni */
        while (string.IsNullOrWhiteSpace(profesioni) || profesioni.ToLower().IndexOfAny(numrat) >= 0)
        {
            Console.WriteLine("Cfare pune beni?");
            profesioni = Console.ReadLine();
        }
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine($"Lindur {mosha} vite me pare ne {vendLindja}, {emri} {mbiemri} eshte nje {profesioni} aspirant.");

        
   }
}

public class Ushtrim2
{
   public static void Ushtrimi2()
    {
        /*User imput 2 nr, ku nr1 > nr2, afishon mbetjen*/

        double? numriIPare = null;
        double? numriIDyte = null;
        double? pjestimi;
        double? mbetja;
        
        Console.WriteLine("Ca bot si kalut.");
        Console.WriteLine("Me ane te ketij programi do te jemi ne gjendje te gjejme mbetjen nga dy numra");
        Console.WriteLine("Nuk ka rendesi ne cfare rendi do i vendosni ju numrat se gjithmon ai me i madhi do pjestoj me te voglin.");
        
        Console.WriteLine("");

        // Marrim numrin e Pare
        while (numriIPare == null)
        {
            Console.WriteLine("Vendosni numrin e pare:");
            string inputNumri1 = Console.ReadLine();

            if (double.TryParse(inputNumri1, out double parsedNumriIPare))
            {
                numriIPare = parsedNumriIPare;
                
            }
            else
            {
                Console.WriteLine("Numer i pavlefshem!!");
            }
        }

        // Marrim numrin e Dyte
        while (numriIDyte == null)
        {
            Console.WriteLine("Vendosni numrin e dyte:");
            string inputNumri2 = Console.ReadLine();

            if (double.TryParse(inputNumri2, out double parsedNumriIDyte))
            {
                numriIDyte = parsedNumriIDyte;
            }
            else
            {
                Console.WriteLine("Numer i pavlefshem!!");
            }
            
        }
        
        //Afishojme pjestimin
        

        if (numriIPare > numriIDyte)
        {
            pjestimi = numriIPare/numriIDyte;
            mbetja = numriIPare%numriIDyte;
            Console.WriteLine($"{numriIPare} / {numriIDyte} = {pjestimi} dhe mbetja eshte: {mbetja}");
        }
        
        else
        {
            pjestimi = numriIDyte / numriIPare;
            mbetja = numriIDyte % numriIPare;
            Console.WriteLine($"{numriIDyte} / {numriIPare} = {pjestimi} dhe mbetja eshte: {mbetja}");
        }

    }
}

public class Ushtrim3
{
    public static void Ushtrimi3()
    {
        Console.WriteLine("Ca bot si kalut.");
        
        
        double[] numbers = new double[5];
        string[] input;

        while (true)
        {
            Console.WriteLine("Ju lutem vendosni 5 numra");
            input = Console.ReadLine().Split(' ');
            
            if (input.Length !=5)
            {
                Console.WriteLine("Ju lutem shkruani  **sakte** 5 numra");
                continue;
            }
            
            bool valid = true;

            for (int i = 0; i < 5; i++)
            {
                if (double.TryParse(input[i], out double parsedNum))
                {
                    numbers[i] = parsedNum;
                }
                else
                {
                    Console.WriteLine($"{input[i]} nuk eshte nje numer i vlefshem");
                    valid = false;
                }
            }

            if (valid)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ju lutem provoni perseri");
            }
            
        }
        
        // Afishimi numrave te vendosur

        Console.WriteLine("Numrat e vendosur jane: ");
        foreach (double num in numbers)
        {
            Console.Write($"[{num}] ");
        }

        Console.WriteLine("");
        
        // Afishimi i Shumes 

        double shuma = numbers.Sum();

        Console.WriteLine($" Shuma e numrave eshte: {shuma}");
        
        // Afishimi i Mesatares
        
        double mesatarja = numbers.Average();
        
        Console.WriteLine($" Mesatarja e numrave eshte: {mesatarja}");
        

    }
}

public class Ushtrim4
{
    public static void Ushtrimi4()
    {
        
        // Hyrja 
        Console.WriteLine("Ca bot si kalut");

        Console.WriteLine("Ju lutem shkruani nje ekuacion qe deshironi te zgjidhni.");

        // Marrja e shprehjes numerike nga perdoruesi
        string shprehja = Console.ReadLine();

        // Afishimi i rezultatit
        Console.WriteLine("");
        Console.WriteLine("Rezultati eshte: " );

        Console.WriteLine(SolveEquation(shprehja));

        // Metoda e zgjedhjes se shprehjes
        static double SolveEquation(string ekuacioni)
        {
            try
            {
                var table = new DataTable();
                var rezultati = table.Compute(ekuacioni, "");
                return Convert.ToDouble(rezultati);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Problem : {ex.Message}");
                return double.NaN;
            }
        }
    }
}