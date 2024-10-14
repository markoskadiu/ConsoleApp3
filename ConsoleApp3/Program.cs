

using ConsoleApp3;

class Seminar1{

    /*static async Task Main(string[] args) // Per ushtrimin 6
    {

        Console.WriteLine("Per te printual listen e monedhave shkruaj 911");
        string apiKey = "bf08ad4c4daec4ebdb0b501c";

        Console.WriteLine("Vendos monedhen qe ke (prsh. USD, ALL, EUR)");
        
        
        string baseCurrency = Console.ReadLine().ToUpper();
        
        
        Console.WriteLine("Vendos monedhen do te marresh (prsh. USD, ALL, EUR)");

        string targetCurrency = Console.ReadLine().ToUpper();
        
        Console.WriteLine("Vendos sasine");
        double sasia = double.Parse(Console.ReadLine());
        
        double rate = await Ushtrim6.GetExchangeRateAsync(apiKey, baseCurrency, targetCurrency);

        if (rate >= 0)
        {
            Console.WriteLine($"{sasia} {baseCurrency} = {rate * sasia} {targetCurrency}");
        }
        else
        {
            Console.WriteLine("Ka ndodhur nje gabim");
        }
    }*/

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        new Ushtrim7().Ushtrimi7();
    }
    
    
}

