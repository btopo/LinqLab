using System.Linq;
public static class myprogram
{
    public static void Main()
    {
        int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

        nums.Min();
        int minVal = nums.Min();
        Console.WriteLine($"The min value is {minVal}");

        nums.Max();
        int maxVal = nums.Max();
        Console.WriteLine($"The max value is {maxVal}");

        var lessThan10000 = nums.Where((x) => x < 10000).ToArray();
        var numbersLessThan10000 = lessThan10000.Max();
        Console.WriteLine($"The max value less than 10000 is{numbersLessThan10000}:");
        

        var numbersBetween10and100 = nums.Where((x) => (x >= 10 && x <= 100)).ToArray();
        Console.WriteLine($"Numbers between 10 and 100 are:");
        foreach (int x in numbersBetween10and100)
            Console.WriteLine($"{x}");

        var numbersBetween10000and99999 = nums.Where((x) => (x >= 10000 && x <= 99999)).ToArray();
        Console.WriteLine($" Numbers between 10000 and 99999: ");
        foreach (var x in numbersBetween10000and99999)
            Console.WriteLine($"{x}");

        var allEvenNumbers = nums.Where((x) => x % 2 == 0).ToArray();
        Console.WriteLine(" Even Numbers are ");
        foreach (var x in allEvenNumbers)
            Console.WriteLine($"{x}");

    }
}


