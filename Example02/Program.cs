
using System;
using System.Numerics;
using UtilityLibraries;
//This application converts numbers to words. The user enters a number not greater than UInt64.Max that is 
class Program
{
    static void Main(string[] args)
    {
        ulong MAXVALUE = UInt64.MaxValue;
        BigInteger MAXVALUEBIG = MAXVALUE;
        do
        {
            
                Console.WriteLine("Enter numbers: { If you press enter without entering a number it quits! Example Enter : 18,456,002,032,011,000,007 or 18456002032011000007}");
                string? input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;

                    
                        BigInteger userInput = BigInteger.Parse(input);//(input.IndexOf(",") > 0 ? input.Replace(",","") : input) ;
                        Console.WriteLine("Number too big \n" + UInt64.MaxValue);
                        // if ( userInput > MAXVALUEBIG + 1){
                            
                        //     continue;
                        // }
                        Console.WriteLine(userInput.Towards());


            

        } while (true);
        
    }
}