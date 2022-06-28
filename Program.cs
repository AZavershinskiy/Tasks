// "Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа"

/* int randomNumber = new Random().Next(10, 99);

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

int max = firstDigit;

if (secondDigit > max)
{
    max = secondDigit; 
} */

/* Console.WriteLine("Число = " + randomNumber + ", макс цифра = " + max); //конкатенация
/* или */
/* Console.WriteLine($"Число = {randomNumber}, макс цифра = {max}"); //интерполяция  */



// Пример условий И и ИЛИ

/* int number = 70;

/* if (number > 9 && number < 100) // условие И
/* if (number > 9 || number < 100) // условие ИЛИ 
{
    Console.WriteLine(number);
} */



// "Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа"

/* int randomNumber = new Random().Next(100, 1000); //123

int number1 = randomNumber / 100; //123/100=1
int number2 = randomNumber % 10; //123%10=3

Console.WriteLine($"Случайное число = {randomNumber}, это же число без средней цифры {number1}{number2}"); //случайное трехзначное число, 1-е число и 3-е число в одну строку
 */



// "Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли 1-е число кратным 2-у. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления"

/* Console.WriteLine("Введите 1-е число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = number1 % number2;

if (number1 % number2 == 0)
{
    Console.WriteLine($"Число {number1} кратно {number2}");
}
else
{
    Console.WriteLine($"Число {number1} НЕ кратно {number2}, остаток: {result}");
}
 */



// "Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23"

/* Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int check1 = 7;
int check2 = 23;

if(number1 % check1 == 0 && number1 % check2 == 0)
{
    Console.WriteLine($"Число {number1} кратно {check1} и кратно {check2} одновременно");
}
else
{
    Console.WriteLine($"Число {number1} НЕ кратно {check1} и {check2} одновременно");
}
 */


// "Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого"

Console.WriteLine("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
Console.WriteLine("Ни одно из чисел НЕ является квадратом другого");
