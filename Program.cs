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
 
    // ____ MAIN _____
    static void Main()
    {
        Console.WriteLine("--- Task 1 ---");
        ShowWelcome();
 
        Console.WriteLine("\n--- Task 2 ---");
        ShowGreeting("Ali");
        ShowGreeting("Muslima");
 
        Console.WriteLine("\n--- Task 3 ---");
        int score = GetPassingScore();
        Console.WriteLine($"Passing score is: {score}");
 
        Console.WriteLine("\n--- Task 4 ---");
        Console.WriteLine(Add(5, 8));
        Console.WriteLine(Add(7, 8));
        Console.WriteLine(Add(5, 11));
 
        Console.WriteLine("\n--- Task 5 ---");
        Console.WriteLine(CreateOrderMessage("Book", "2"));
        Console.WriteLine(CreateOrderMessage("Ruchka", "2"));
 
        Console.WriteLine("\n--- Task 8 ---");
        TestBonus(70, 20);
        TestBonus(60, 20);
        TestBonus(-50, 30);
        TestBonus(50, -1);
 
        Console.WriteLine("\n--- Task 9 ---");
        TestSell(20, 5);
        TestSell(10, 10);
        TestSell(10, 12);
        TestSell(3, -1);
    }
}