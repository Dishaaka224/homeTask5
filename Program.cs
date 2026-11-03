using System;
class Program
{
    // ____ Task 1 _____
    static void ShowWelcome()
    {
        Console.WriteLine("Welcome to Dubai");
    }
 
    // ____ Task 2 _____
    static void ShowGreeting(string name)
    {
        Console.WriteLine($"Hello {name}!");
    }
 
    // ____Task 3_____
    static int GetPassingScore()
    {
        return 50 + 10;
    }
 
    // ____Task 4 _____
    static int Add(int a, int b)
    {
        return a + b;
    }
 
    // ____Task 5 _____
    static string CreateOrderMessage(string product, string quantity)
    {
        return $"Order: {quantity} {product}";
    }
 
    // ____Task 8 _____
    static void AddBonus(ref int score, int bonus)
    {
        if (score < 0 || score > 100 || bonus < 0 || bonus > 100)
        {
            return;
        }
 
        score += bonus;
 
        if (score > 100)
        {
            score = 100;
        }
    }
 
    static void TestBonus(int score, int bonus)
    {
        int before = score;
        AddBonus(ref score, bonus);
        Console.WriteLine($"Before: {before}, Bonus: {bonus}, After: {score}");
    }
 
    // ____Task 9_____
    static bool TrySellItems(ref int stock, int quantity)
    {
        if (quantity <= 0 || quantity > stock)
        {
            return false;
        }
 
        stock -= quantity;
        return true;
    }
 
    static void TestSell(int stock, int quantity)
    {
        int before = stock;
        bool result = TrySellItems(ref stock, quantity);
        Console.WriteLine($"Before: {before}, Quantity: {quantity}, After: {stock}, Result: {result}");
    }

    // ____Task 10 ____

    static void GetNumberStats(int first, int second, int third, out int min, out int middle, out int max)
    {
        int a = first;
        int b = second;
        int c = third;
        int temp;

        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }

        min = a;
        middle = b;
        max = c;
    }

    static void TestStats(int first, int second, int third)
    {
        GetNumberStats(first, second, third, out int min, out int middle, out int max);
        Console.WriteLine($"Min: {min}; Middle: {middle}; Max: {max}");
    }

    // ____ Task 11 ____
    static bool TryCalculateAverage (int first, int second, int third, out double average)
    {
        if (first < 0 || first > 100 || second < 0 || second > 100 || third < 0 || third > 100)
        {
            average = 0;
            return false;
        }
        average = (first + second + third) / 3;
        return true;
    }   
     static void TestAverage(int first, int second, int third)
    {
        bool success = TryCalculateAverage(first, second, third, out double average);
        Console.WriteLine($"Success: {success}; Average: {average}");
    }

    // ____ MAIN _____
    static void Main()
    {
        Console.WriteLine("\n___ Task 1 ___");
        ShowWelcome();
 
        Console.WriteLine("\n___ Task 2 ___");
        ShowGreeting("Ali");
        ShowGreeting("Muslima");
 
        Console.WriteLine("\n___ Task 3 ___");
        int score = GetPassingScore();
        Console.WriteLine($"Passing score is: {score}");
 
        Console.WriteLine("\n___ Task 4 ___");
        Console.WriteLine(Add(5, 8));
        Console.WriteLine(Add(7, 8));
        Console.WriteLine(Add(5, 11));
 
        Console.WriteLine("\n___ Task 5 ___");
        Console.WriteLine(CreateOrderMessage("Book", "2"));
        Console.WriteLine(CreateOrderMessage("Ruchka", "2"));
 
        Console.WriteLine("\n___ Task 8 ___");
        TestBonus(70, 20);
        TestBonus(60, 20);
        TestBonus(-50, 30);
        TestBonus(50, -1);
 
        Console.WriteLine("\n___ Task 9 ___");
        TestSell(20, 5);
        TestSell(10, 10);
        TestSell(10, 12);
        TestSell(3, -1);

        Console.WriteLine("\n___ Task 10 ___");
        TestStats(8, 3, 5);
        TestStats(9, 2, 6);
        TestStats(4, 4, 1);
        TestStats(7, 7, 7);

        Console.WriteLine("\n___ Task 11 ___");
        TestAverage(80, 90, 100);
        TestAverage(70, 71, 72);
        TestAverage(0, 50, 100);
        TestAverage(80, -1, 90);
        TestAverage(80, 101, 90);
    
    }
}