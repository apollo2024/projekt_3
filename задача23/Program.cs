Console.WriteLine("number:");
var number = Convert.ToInt32(Console.ReadLine());
var i = 1;
while(i <= number)
{
    var cube = Math.Pow((i), 3);
    Console.WriteLine(cube);
    i++;
}