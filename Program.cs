//question 1
Console.WriteLine("Enter your name? ");
string name = Console.ReadLine();
Console.WriteLine("which city are you from?");
string city = Console.ReadLine();
Console.WriteLine($"\nName: {name}");
Console.WriteLine($"City:{city}");
Console.WriteLine("department:Computer Engineering");
Console.WriteLine("year:      2");
Console.WriteLine("C#    is fun");
Console.WriteLine($"Hello {name} from {city},welcome to C#");
Console.WriteLine("-----------------------------------------------------------------------");
//question 2
Console.Write("Enter first number: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine($"\n{num1}+{num2}={num1 + num2}");
Console.WriteLine($"\n{num1}-{num2}={num1 - num2}");
Console.WriteLine($"\n{num1}*{num2}={num1 * num2}");
Console.WriteLine($"\n{num1}/{num2}={num1 / num2}");
Console.WriteLine("-----------------------------------------------------------------------");
//question 3
Console.Write("Enter studet name: ");
string Name = Console.ReadLine();
Console.Write("Enter Midterm score: ");
int midterm = int.Parse(Console.ReadLine());
Console.Write("Enter your Final score: ");
int Final = int.Parse(Console.ReadLine());
double average = (midterm + Final) / 2;
Console.WriteLine($"\n{Name},your average is {average} ");
if (Final == 100)
{
    Console.WriteLine("Perfect Final!");
}
if (average > 50)
{
    Console.WriteLine("Passed");
}
else
{
    Console.WriteLine("Failed");
}
Console.WriteLine("-----------------------------------------------------------------------");
//question 4
Console.Write("Enter a 3 digit number: ");
int num = int.Parse(Console.ReadLine());
int hundred = num / 100;
int tens = (num % 100) / 10;
int ones = (num % 100) % 10;
int sum = hundred + tens + ones;
Console.WriteLine($"hundreds:{hundred}");
Console.WriteLine($"tens:{tens}");
Console.WriteLine($"ones:{ones}");
Console.WriteLine($"sum:{sum}");
if (num % 2 == 0)
{
    Console.WriteLine($"{num} is even number");
}
else
{
    Console.WriteLine($"{num} is odd number");
}
if (hundred != ones)
{
    Console.WriteLine("First and Last digits are different");
}
else
{
    Console.WriteLine("First and Last Digits are same");
}