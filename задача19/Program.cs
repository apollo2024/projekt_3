Console.WriteLine("number:");
var number = Convert.ToInt32(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("number is uncorrect");
}
else 
{
if (number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10)
        {
            Console.WriteLine("kj");
        }
    else 
    {
    Console.WriteLine("lk");
    }
}