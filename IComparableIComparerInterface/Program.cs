

using System.Runtime.InteropServices;
using IComparableIComparerInterface;

class Program
{
    public static void Main(string[] args)
    {
        /*
        //  Implementation and example of IComparable
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

        */

         List<Display> displays =
          [
              new Display()  
              {  
                  PPI = 224,  
                  Resolution = "1080 * 1920",  
                  Size = "6.1"                      
              },  
              new Display()  
              {  
                  PPI = 300,  
                  Resolution = "1440 * 2180",  
                  Size = "7.1"  
              },  
              new Display()  
              {  
                  PPI = 115,  
                  Resolution = "564 * 900",  
                  Size = "4.2"  
              },  
              new Display()  
              {  
                  PPI = 160,  
                  Resolution = "880 * 980",  
                  Size = "5"  
              }  
          ];  

          SortedDisplay sorted = new();
          displays.Sort(sorted);
          foreach(var item in displays){
            Console.WriteLine($"PPI : {item.PPI} Resolution : {item.Resolution}");
          }

          




    }

}

