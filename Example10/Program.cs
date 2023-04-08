 Console.Write("Enter number : ");

 int number = Convert.ToInt32(Console.ReadLine());

 int number2 = - number;
 
 while(number2 <= number)
 {
 Console.Write($"{number2},");
 
 ++number2;
 }