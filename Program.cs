using System;

//task 1 

// class Program
// {
//     static void ShowWelcome()
//     {
//         Console.WriteLine("Welcome to Dubai");
    
//     }
//     static void Main()
//     {
//         ShowWelcome();

//     }
// }

// task 2

// class Program

// {
//     static void ShowGreeting(string name)
//     {
//         Console.WriteLine($" Hello {name}!" );
//     }

// static void Main()
// {
//     ShowGreeting(" Ali ");
//     ShowGreeting( " Muslima");
// }
// }

//task 3

// class Program
// {
//     static int GetPassingScore ()
//     {
//         return 50+10;
//     }
//     static void Main()
//     {
//         int score = GetPassingScore();
//         Console.WriteLine($"Passing score is: {score}");
//     }
// }

// task 4 

// class Program
// {
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }
//     static void Main()
//     {
//         Console.WriteLine(Add(5, 8 ));
//          Console.WriteLine(Add(7, 8 ));
//           Console.WriteLine(Add(5, 11 ));
//     }
// }

// task 5

// class Program
// {
//     static string CreateOrderMEssage (String product, string quantity)
//     {
//         return $"Order: {quantity} {product}";
//     }
//     static void Main()
//     {
//         {
//         Console.WriteLine(CreateOrderMEssage("Book", "2"));
//         Console.WriteLine(CreateOrderMEssage("Ruchka", "2"));
//         }
//     }
// }


// task 8

// class Program
// {
//     static void AddBonus(ref  int score, int bonus)
//     { 
//         if ( score < 0 || score > 100 || bonus < 0 || bonus > 100) 
//         {
//             return;
//         }
//         score += bonus;
//         if (score > 100)
//         {
//             score = 100;
//         }
//     }

//     static void Test ( int score, int bonus)
//     {
//     int before = score;
//     AddBonus(ref score, bonus);
//     Console.WriteLine($"Before: {before}, Bonus: {bonus}, After: {score}");
//     }   

//     static void Main()
//     {
//         Test(70, 20);
//         Test(60, 20);
//         Test (-50, 30);
//         Test ( 50, -1);
//     }
// }    

//task 9 

class Program
{
    static bool TrySellItems ( ref int stock, int quantity)
    {
        if (quantity <= 0 || quantity > stock)
        {
            return false;
        }
        stock -= quantity;
        return true;
    }
    static void Test (int stock, int quantity)
    {
        int before = stock;
        bool result = TrySellItems(ref stock, quantity);
        Console.WriteLine($"Before: {before}, Quantity: {quantity}, After: {stock}, Result: {result}");
    }
    static void Main()
    {
        Test(20, 5);
        Test(10, 10);
        Test(10, 12);
        Test(3, -1);
    }
}