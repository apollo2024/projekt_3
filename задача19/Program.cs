Console.WriteLine("number:");
var number = Convert.ToInt64(Console.ReadLine());
if (number < 10000 || number > 99999)
{
    Console.WriteLine("number is uncorrect");
}
else
{
    var n = number;
    var i = 0;
    while (i <= 4)
   {
     var sum = n / 10000;
    n = 10 * (number - (n / 10000) * 10000);
    Console.Write(sum);
    i++;
   } 
}