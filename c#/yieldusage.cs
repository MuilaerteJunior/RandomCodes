using System.Collections.Generic;
using System.Linq;
using System;

class Program {
    static IList<int> FillValues(){
        return new List<int>(Enumerable.Range(1,10));
    }

    //Custom usage - returns a partial number of  elements
    static IEnumerable<int> FilterEmpty(IEnumerable<int> items){
        foreach (var item in items){
            if ( item > 5)
                yield return item;
        }
    }

    //Stateful usage - returns a final result of the operation
    static IEnumerable<int> TotalOddNumbers(IEnumerable<int> items){
        var finalValue = 0;
        foreach (var item in items){
            if ( item % 2 != 0){
                finalValue  += item;
                yield return finalValue;
            }
        }
    }

    static void Main(string[] args){
        Console.WriteLine("Yield usage demo - IList Content");
        var numbers = FillValues();
        foreach ( var number in numbers){
            Console.WriteLine(number);
        }
        
        Console.WriteLine("Yield usage demo - Custom filter");
        foreach ( var number in FilterEmpty(numbers)){
            Console.WriteLine(number);
        }
        

        Console.WriteLine("Yield usage demo - Stateful usage");
        foreach ( var number in TotalOddNumbers(numbers)){
            Console.WriteLine(number);
        }
        

        Console.ReadKey();
    }
}