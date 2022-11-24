Console.WriteLine("number:");
var number = Convert.ToInt64(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("number is uncorrect");
}
else 
for (var i = 0; i <= 4; i++)
{
    var sum = number % 10;
    number = number / 10;
    Console.WriteLine(sum);
}
if (sum == number)
    {
        Console.WriteLine("цифра является палиндромом");
    }
    else
    {
        Console.WriteLine("цифра не является палиндромом");
    }