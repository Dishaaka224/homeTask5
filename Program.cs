using System;

// task 1 

int son = int.Parse(Console.ReadLine()!.Trim());

if (son > 0)
{
    Console.WriteLine("Positive number");

}
else if (son < 0)
{
    Console.WriteLine("Negative number");
}
else
{
    Console.WriteLine("Zero");
}


// task 2 

int number = int.Parse(Console.ReadLine()!.Trim());

if ( number % 2 == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("Odd number");
}

// task 3 

int first = int.Parse(Console.ReadLine()!.Trim());
int second = int.Parse(Console.ReadLine()!.Trim());

if (first > second)
{
    Console.WriteLine ($"Biggest number is: {first}");

}
else if ( second > first)
{
    Console.WriteLine ($" Biggest number is: { second }");

}
else
{
    Console.WriteLine ($" Both numbers are equal: { first }");
    
    
}

// taskk 4

int grade = int.Parse(Console.ReadLine()!.Trim());

if (grade < 0 || grade > 100)
{ 
    Console.WriteLine($" Invalid grade:{grade}");
}
else if (grade >= 90)
{
    Console.WriteLine($" Excellent grade:{grade}");
}
else if (grade >= 70)
{
 Console.WriteLine($" Good grade:{grade}");   
}
else if (grade >= 60) {
    Console.WriteLine($" Satisfactory grade:{grade}");
}
else {
    Console.WriteLine($" Unsatisfactory grade:{grade}");
}

// task 5 

int a = int.Parse(Console.ReadLine()!.Trim());
int b = int.Parse(Console.ReadLine()!.Trim());
string answer = Console.ReadLine()!.Trim();

switch( answer)
{
     case "+":
        Console.WriteLine($"{a} + {b} = {a + b}");
        break;
    case "-":
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;
    case "*":
        Console.WriteLine($"{a} * {b} = {a * b}");
        break;
    case "/":
        Console.WriteLine($"{a} / {b} = {a / b}");
        break;
    default:
    Console.WriteLine("Invalid operation");
    break;
}

// task 6 


// task 7 

int value = int.Parse(Console.ReadLine()!.Trim());

for (int i = 1; i <= value; i++)
{
    Console.WriteLine(i + "");

}
Console.WriteLine(" ");

// task 8

int num = int.Parse(Console.ReadLine()!.Trim());

while (num >= 1)
{
    Console.WriteLine(num + " ");
    num--;
}
Console.WriteLine();

// task 9

int raqam = int.Parse(Console.ReadLine()!.Trim());
int sum = 0;

for ( int i = 1; i <= raqam; i++)
{
    sum +=i;

}

Console.WriteLine($"Sum of numbers: { sum}");

// task 10 


// task 11

int numbs = int.Parse(Console.ReadLine()!.Trim());
for ( int i = 1 ; i <= numbs; i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i + " ");
    }
}
Console.WriteLine($"Answer: {numbs}");

// task12 

int nomer = int.Parse(Console.ReadLine()!.Trim());
for (int i = 1; i <= 10 ; i++)
{
    Console.WriteLine($"Kara jadval: {nomer}*{i}={nomer*i}");
}

// task 13

int n = int.Parse(Console.ReadLine()!.Trim());                  
int count = 0;
int qushilganda = 0;

for ( int i = 1 ; i <= n; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine(i + " ");
        count++;
        qushilganda+= i;
    }
}
Console.WriteLine($"Count: {count}");
Console.WriteLine($"Sum: {qushilganda}");

// task 14

int chislo = int.Parse(Console.ReadLine()!.Trim());
int factorial = 1;
for (int i=2; i <= chislo; i++)
{
    factorial *= i;
}
Console.WriteLine($"Result of number in FActorial:{chislo}");

// task 15 

int rebmun = int.Parse(Console.ReadLine()!.Trim()); // int dan ken number suzini chappa  tomonidan boshlab yozganman uzim chunaman !

int mus = 0;// bu erdaham huddi shunaqa chappa suz yozilgan

while (rebmun> 0)
{
    mus += rebmun % 12 ;
    rebmun /= 12;

} 
Console.WriteLine($"Yig'indi:{rebmun}");

//task 16 
int sson = int.Parse(Console.ReadLine()!.Trim());
bool isPrime = sson >= 2 ;

for (int i = 2; i <= sson - 1 ; i++)
{
    if (sson % i == 0)
    {
        isPrime = false;
        break;
    }
}
if (isPrime)
{
    Console.WriteLine($"Positive number:{sson})");

}
else
{
    Console.WriteLine($"Negative number:{sson})");
}

