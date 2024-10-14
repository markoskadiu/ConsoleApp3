using System.Data;
using Newtonsoft.Json.Linq;

namespace ConsoleApp3;

public class Ushtrim1
{
    /**: Shkruani nje program ne C# qe afishon ne rreshta *Emri *Mbiemri *Mosha*Vendlindja *Profesioni*/
    
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
    /**: Krijoni nje program i cili lexon 2 numra dhe tregon mbetjen nga pjestimi i tyre duke perdorur operatorin %, duke supozuar se nr1 > nr2*/
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
    /**: Lexoni 5 numra nga perdoruesi dhe afishoni shumen dhe mesataren e tyre.*/
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
 /**: Krijoni nje program qe afishon rezultatin e shprehjeve te meposhtme*/
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

public class Ushtrim5
{
    /**: Shkruani nje program qe gjen perimetrin dhe siperfaqen e figurave gjeometrike te meposhtme*/
    
    public static void Ushtrimi5()
    {
        Console.WriteLine("Ca bot si kalut \n Ky program ka si qellim me gjet perimetrin dhe siperfaqen e fiigurave  te ndryshme gjeometrike ");

        string figura;
        string[] mundesite = { "d", "t", "r", "tr", "k" };

        do
        {
            Console.WriteLine("Vendosni per figuren gjeometrike te deshiruar \n" + 
                              "[D]rejtkendesh , [K]atror , [R]reth , [T]rekendesh , [Tr]apez \n");

            figura = Console.ReadLine();

            if (figura.ToLower() == "d")
            {
                Console.WriteLine("Shkruani gjatesine a brinjes a");
                double a = double.Parse(Console.ReadLine());
                
                Console.WriteLine("Shkruani gjatesine a brinjes b");
                double b = double.Parse(Console.ReadLine());
            
                Console.WriteLine($"Perimetri eshte= {(2*a) + (2 * b)} \nSiperfaqa eshte = {a*b}");
            }
            else if (figura.ToLower() == "k")
            {
                Console.WriteLine("Shkruani gjatesine a brinjes a");
                double a = double.Parse(Console.ReadLine());

                Console.WriteLine($"Perimetri eshte = {4*a} \nSiperfaqa eshte = {a*a}");
            }
            else if (figura.ToLower() == "r")
            {
                Console.WriteLine("Figura e zgjedhur eshte Rrethi\n");
                Console.WriteLine("Shkruani gjatesine e rrezes :");
                double r = double.Parse(Console.ReadLine());

                Console.WriteLine("Shkruani 17 numrat e pare te π ");
                Thread.Sleep(3000);
                Console.WriteLine(" Hahahaha, bej shaka \n");
                Thread.Sleep(1000);
                Console.WriteLine($"Perimetri i rrethit me rreze {r} eshte = {2 * Math.PI * r} \n" +
                                  $"Siperfaqa eshte = {Math.PI * (r*r)} ");
            }
            else if (figura.ToLower() == "t")
            {
                double a = 0;
                double b = 0;
                double c = 0;
                do
                {
                    Console.WriteLine("Shkruani gjatesine brinjes a:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Shkruani gjatesine e brinjes b");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Shrkuani gjatesine e brinjes c");
                    c = double.Parse(Console.ReadLine());

                    if (a+b<=c || a+c<=b || b+c<=a)
                    {
                        Console.WriteLine("Brinjet e dhena nuk formojne nje trekendesh te vlefshem");   
                    }
                } while (a+b<=c || a+c<=b || b+c<=a);
            
                //Llogarisim perimetrin
                double p = a + b + c;
                // Llogarisim gjysme-perimetrin
                double g = p / 2;
            
                //Llogarisim Siperfaqen
                double s = Math.Sqrt(g * (g - a) * (g - b) * (g - c));
            
                Console.WriteLine($"Perimetri i trekendeshit eshte : {p} \n" +
                                  $"Siperfaqa eshte = {s}");

            }
            else if (figura.ToLower() == "tr")
            {
                Console.WriteLine("Shkruani gjatesine brinjes a:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Shkruani gjatesine e brinjes b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Shrkuani gjatesine e brinjes c");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Shrkuani gjatesine e brinjes d");
                double d = double.Parse(Console.ReadLine());
            
                double p = a + b + c + d;

                double s = 0.25 * Math.Sqrt((a + c) * (b + d) * (a + b - c + d) * (a - b + c + d));
            
                Console.WriteLine($"Perimetri i trapezit eshte : {p} \n" +
                                  $"Siperfaqa eshte = {s}");
            
            }
            else
            {
                Console.WriteLine("Shkronje e vendosur eshte e gabuar:");
            }
        } while (!(figura.ToLower() == "d"|| figura.ToLower() == "k" || figura.ToLower() == "r" || figura.ToLower() == "t" || figura.ToLower() == "tr"));

        Console.WriteLine("Deshironi te riprovoni? [Y/N]");
        string prgj = Console.ReadLine();

        if (prgj.ToLower() == "y")
        {
            Ushtrimi5();
        }
        else
        {
            Console.WriteLine("bye bye");
        }
    }
    
}

public class Ushtrim6
{
    /*Kembimi valutor*/
    private static readonly HttpClient client = new HttpClient();

    public static async Task<double> GetExchangeRateAsync(string apiKey, string baseCurrency, string targetCurrency){
        
        string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{baseCurrency}";

        try
        {
            var response = await client.GetStringAsync(url);
            var data = JObject.Parse(response);
            var exchangeRate = data["conversion_rates"][targetCurrency].Value<double>();
            return exchangeRate;
            
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("Error fetching exchange rates:" + e.Message);
            return -1;
        }
    }

}

public class Ushtrim7
{
    /*Libraria*/
    public void Ushtrimi7()
    { 
        string[,] librat = new string[3, 3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Vendos te dhenat per librin nr {1+i}");
            
            Console.Write("Titulli: ");
            librat[i, 0] = Console.ReadLine();
            
            Console.Write("Autori: ");
            librat[i, 1] = Console.ReadLine();
            
            Console.Write("Cmimi: ");
            librat[i, 2] = Console.ReadLine();
            
        }
        Console.WriteLine("\nTe dhenat e librave te futur:");
        Console.WriteLine("Titulli\t\tAutori\t\tCmimi");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{librat[i, 0]}\t\t{librat[i, 1]}\t\t{librat[i, 2]}");

        }
    }

     
    
}