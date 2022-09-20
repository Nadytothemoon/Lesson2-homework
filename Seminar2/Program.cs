// int n=new Random().Next (10,100);
// System.Console.WriteLine(n);

// int d1=n/10;
// int d2=n%10;

// int max=d1;
// if (max<d2){
//     max=d2;
// }
// System.Console.WriteLine($"Максимальная цифра числа {n}->{max}");


// int n=new Random().Next (100,1000);
// System.Console.WriteLine(n);
// int result=n/100*10 + n%10;
// System.Console.WriteLine($"{n} -> {result}");

// System.Console.Write("Введите число а:");
// int a = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число b:");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a%b==0) {
//     System.Console.WriteLine("кратно");
// }
// else {
//     System.Console.WriteLine($" не кратно, остаток: {a%b}");
// }


// System.Console.Write("Введите число а:");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a%7==0) {
//     if (a%23==0){
//         System.Console.WriteLine("Делится");
//     }
// }
// else {System.Console.WriteLine("Не делится");
// }

System.Console.Write("Введите число а:");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a==b){
    System.Console.WriteLine("a является квадратом b ");
}
else if (b*b==a){
    System.Console.WriteLine("b является квадратом a");
}
else {
    System.Console.WriteLine("не является квадратом");
}






