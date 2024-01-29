//ЗАДАНИЕ 1_____________________________________________________________________________

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    Console.WriteLine("Введенные числа равны");
}
else if (num1 > num2)
{
    Console.WriteLine($"Первое число ({num1}) больше второго числа ({num2})");
}
else
{
    Console.WriteLine($"Первое число ({num1}) меньше второго числа ({num2})");
}

//ЗАДАНИЕ 2_____________________________________________________________________________

//Console.WriteLine("Введите число:");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num >= 5 && num <= 10)
//{
//    Console.WriteLine("Число больше 5 и меньше 10");
//}
//else
//{
//    Console.WriteLine("Неизвестное число");
//}

//ЗАДАНИЕ 3_____________________________________________________________________________

//Console.WriteLine("Введите число:");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num == 5)
//{
//    Console.WriteLine("Число равно 5");
//}
//else if (num == 10)
//{
//    Console.WriteLine("Число равно 10");
//}
//else
//{
//    Console.WriteLine("Неизвестное число");
//}

//ЗАДАНИЕ 4_____________________________________________________________________________

//Console.WriteLine("введите сумму вклада:");
//double deposit = Convert.ToDouble(Console.ReadLine());
//double interestrate;
//if (deposit < 100)
//{
//    interestrate = 0.05;
//}
//else if (deposit >= 100 && deposit <= 200)
//{
//    interestrate = 0.07;
//}
//else
//{
//    interestrate = 0.10;
//}
//double total = deposit + deposit * interestrate;
//Console.WriteLine($"сумма вклада с начисленными процентами: {total}");

//ЗАДАНИЕ 5_____________________________________________________________________________

//Console.WriteLine("Введите номер операции: 1-Сложение; 2-Вычитание; 3-Умножение");
//int operation = Convert.ToInt32(Console.ReadLine());
//switch (operation)
//{
//    case 1:
//        Console.WriteLine("Выбрана операция: Сложение");
//        break;
//    case 2:
//        Console.WriteLine("Выбрана операция: Вычитание");
//        break;
//    case 3:
//        Console.WriteLine("Выбрана операция: Умножение");
//        break;
//    default:
//        Console.WriteLine("Операция неопределена");
//        break;
//}

//ЗАДАНИЕ 6_____________________________________________________________________________

//Console.WriteLine("введите сумму вклада:");
//decimal deposit = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine("введите количество месяцев:");
//int months = Convert.ToInt32(Console.ReadLine());
//decimal interestrate = 0.07M;
//for (int i = 0; i < months; i++)
//{
//    deposit += deposit * interestrate;
//}
//Console.WriteLine($"Конечная сумма вклада с учетом начисления процентов: {deposit}"); 

//ЗАДАНИЕ 7_____________________________________________________________________________

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.Write($"{i} * {j} = {i}* {j}");
//        Console.WriteLine();
//    }
//}

//ЗАДАНИЕ 8_____________________________________________________________________________

//while (true)
//{
//    Console.WriteLine("введите первое число (от 0 до 10):");
//    int num1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("введите второе число (от 0 до 10):");
//    int num2 = Convert.ToInt32(Console.ReadLine());
//    if ((num1 >= 0 && num1 <= 10) && (num2 >= 0 && num2 <= 10))
//    {
//        Console.WriteLine($"результат умножения: {num1 * num2}");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("одно из введенных чисел недопустимо. пожалуйста, введите два числа от 0 до 10.");
//    }
//}

//ЗАДАНИЕ 9_____________________________________________________________________________

//int[] numbers = { 41, 12, 376, -14, 5, 0, 72, 38, -9, -1 };
//Console.WriteLine("Нечетные числа из массива:");
//foreach (int num in numbers)
//{
//    if (num % 2 != 0)
//    {
//        Console.WriteLine(num);
//    }
//}

//ЗАДАНИЕ 10____________________________________________________________________________

//string[] array = { "АТК", "Колледж", "ДГТУ", "Ростов-на-Дону", "Практика", "Тремба А.В." };
//Console.WriteLine("введите новую строку:");
//string newstring = Console.ReadLine();
//bool found = false;
//foreach (string str in array)
//{
//    if (str == newstring)
//    {
//        found = true;
//        break;
//    }
//}
//if (found)
//{
//    Console.WriteLine("строка найдена!");
//}
//else
//{
//    Console.WriteLine("строка не найдена!");
//}

//ЗАДАНИЕ 11____________________________________________________________________________

//int[] numbers = { 41, 12, 376, -14, 5, 0, 72, 38, -9, -1 };
//int sum = 0;
//foreach (int number in numbers)
//{
//    sum += number;
//}
//double average = (double)sum / numbers.Length;
//Console.WriteLine($"Сумма элементов массива: {sum}");
//Console.WriteLine($"Среднее арифметическое: {average}");