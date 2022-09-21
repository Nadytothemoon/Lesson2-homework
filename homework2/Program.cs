// задача 10

// System.Console.Write("Введите трехзначное число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(n/10%10);

// Задача 13

//int n=new Random().Next (1,100000);
// System.Console.WriteLine(n);

// if (n<100){
//     System.Console.WriteLine("Третьей цифры нет");
// }
// else{
//     int result=n/100%10;
//     System.Console.WriteLine($"Третья цифра числа {n} -> {result}");
// }


// Задача 15

System.Console.Write("Введите число дня недели n: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n==6 || n==7){
    System.Console.WriteLine("Day off");
}
else if(n>0 && n<6){
    System.Console.WriteLine("Weekday");
}
else{
    System.Console.WriteLine("Wrong number");
}
