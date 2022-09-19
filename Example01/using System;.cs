// using System;
// using System.Numerics;
// namespace UtilityLibraries;

//     public static class Example01
//     {
    
//     public static bool CheckNumberGreaterThanMax(string number){
//         ulong MAXVALUE = UInt64.MaxValue;
//         BigInteger _number = BigInteger.Parse(number);
//         return MAXVALUE > _number;
//     }
//     public static string Towards(this BigInteger  number)
//     {
        
//         BigInteger limit = 10000000000000000000;//18456002032011000007
        
//         int number_size = number.ToString().Length;
//         BigInteger hundreds,mut_index= 0;
//         bool add_check = false;
        
//         if (number == 0){
//             return "Zero";
//         }
//         string[] multiples = {"", "quintillion","quadrillion","trillion", "billion", "million","thousand"};
//         string[] first_twenty = {
//             "",        "one",       "two",      "three",
//             "four",    "five",      "six",      "seven",
//             "eight",   "nine",      "ten",      "eleven",
//             "twelve",  "thirteen",  "fourteen", "fifteen",
//             "sixteen", "seventeen", "eighteen", "nineteen"
//         };
//         string[] tens = {
//             "",      "twenty",  "thirty", "forty", "fifty",
//             "sixty", "seventy", "eighty", "ninety" 
//         };

        
//         if ( number < 20 ){
//             return first_twenty[(int)number];
//         }
//         string output = "";
        
//         for (BigInteger i = number; i > 0; i %= limit, limit /= 1000){

//             hundreds = i / limit;
//             add_check = false;
//             while(hundreds == 0){
//                 i %= limit;
//                 limit /= 1000;
//                 hundreds = i / limit;
//                 ++mut_index;
//             }

//             if(hundreds > 99){
//                 // 44545450004545
//                 Console.WriteLine(hundreds);
//                 output += first_twenty[(int)hundreds] + " ";
//             }
//             else if( hundreds % 10 == 0 && hundreds != 0 ){
//                 if (add_check == true){
//                     output+="and ";
//                 }
//                 output += tens[(int)hundreds / 10 - 1 ] + " ";

//             }
            
//             else if( hundreds > 20 && hundreds < 100){
//                 if (add_check == true){
//                     output+="and ";
//                     add_check = false;
//                 }
//                 output += tens[(int)hundreds / 10 - 1] + " " + first_twenty[(int)hundreds % 10] + " ";
//             }
//                 if (mut_index < 6){
//                     output += multiples[(int)++mut_index];
//                 }
//             if ((number_size > 3 )){
//                 output += ", ";
//                 number_size -= 3;
//             } 

//         }
//         // if(output.IndexOf(" ,") != -1){
//         //     string[] output1 = output.Split(",");
//         //     output1[output1.Length -2 ] = " and" + output1[output1.Length-2];
//         //     output =  string.Join(",",  output1[0..(output1.Length-1)]);
//         // }
//         //  string[] lastPart = output.Split(",");


//         // try{
//         //     if(lastPart[lastPart.Length - 1].IndexOf("and") == -1){
//         //         lastPart[lastPart.Length-1] = " and" + lastPart[lastPart.Length - 1];
//         //         output = string.Join(",", lastPart);
//         //     }
//         // }catch(Exception){
//         //     //do something
//         // }
        
 
        
//         return output;//.Trim().Substring(0,output.Length-1);
//     }

// }