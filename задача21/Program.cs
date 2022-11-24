Console.WriteLine("write_x1:");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write_y1:");
var y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write_z1:");
var z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write_x2:");
var x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write_y2:");
var y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("write_z2:");
var z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
Console.WriteLine(result);