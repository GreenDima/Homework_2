//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// void Test(int num){
//     int result = num / 10 % 10;
//     Console.WriteLine($"Вторая цифра трехзначного числа - {result} ");

// }
// Console.WriteLine("Введите трехзначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test(num);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void Test1(int num){
//     if (num < 100){
//         Console.WriteLine($"В числе {num} нет третьей цифры");
//     }
//     else if (num > 99 & num < 1000) {
//         num = num % 10;
//         Console.WriteLine($"Третья цифра {num}");
//     }
//     else {
//         while (num > 1000) {
//             num = num / 10;
//         }
//         num = num % 10;
//         Console.WriteLine($"Третья цифра {num}");
//     }
// }
// Console.Write("Введите число - ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test1(num);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// void Test2(int num){
//     if (num == 1){
//         Console.WriteLine("Увы! Этот день не выходной");
//     }
//     else if (num == 2){
//         Console.WriteLine("К сожалению этот день не выходной");
//     }
//     else if (num == 3){
//         Console.WriteLine("Печаль, но этот день не выходной");
//     }
//     else if (num == 4){
//         Console.WriteLine("Близко, но этот день не выходной");
//     }
//     else if (num == 5){
//         Console.WriteLine("Очень близко, но все же этот день не выходной");
//     }
//     else if (num == 6){
//         Console.WriteLine("Ура! Этот день выходной");
//     }
//     else if (num == 7){
//         Console.WriteLine("Ура! Этот день выходной");
//     }
//     else {
//         Console.WriteLine("Такого дня не существует");
//     }
// }
// Console.Write("Введите цифру, обозначающую день недели - ");
// int num = Convert.ToInt32(Console.ReadLine());
// Test2(num);
