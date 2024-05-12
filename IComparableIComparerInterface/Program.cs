

using System.Runtime.InteropServices;
using IComparableIComparerInterface;

class Program
{
    public static void Main(string[] args)
    {
        List<SmartPhone> smartPhones =
            [
                new SmartPhone()
                {
                    Name = "One Plus 8",

                    OS = "Android 10",
                    Price = 55000
                },
                new SmartPhone()
                {
                    Name = "IPhone 11",
                    OS = "IOS 11",
                    Price = 75000
                },
                new SmartPhone()
                {
                    Name = "Samsung Note 10",
                    OS = "Android 10",
                    Price = 110000
                },
                new SmartPhone()
                {
                    Name = "Samsung S20 Ultra",
                    OS = "Android 10",
                    Price = 130000
                },
                new SmartPhone()
                {
                    Name = "IPhone 11 Pro",
                    OS = "IOS 11",
                    Price = 130000
                },
                 new SmartPhone()
                {
                    Name = "IPhone 7",
                    OS = "IOS 11",
                    Price = 10000
                },
            ];
        smartPhones.Sort();    
        foreach (var item in smartPhones)
        {
            Console.WriteLine(item.ToString());
        }
    }

}

