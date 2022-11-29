// Это комментарий в язке С#
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
// КОД Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); // тип данных имя = значение; // команда console.readLine() используется с переменной string, чтобы использовать с переменной int, нужно использовать Convert.ToInt32((Console.ReadLine())
// // как получить число в квадрате?
// int result = number * number; // number^2 = result // Math.Pow(number, 2(Степень)) но нужен double, а не int
// Console.WriteLine(result);

// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет;

//cameCase => firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumberAndfourthNumber, 
Console.Write("Введите первое число: "); // Текст-подсказка, которая помогает получить число
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: "); // Текст-подсказка, которая помогает получить число
int secondNumber = Convert.ToInt32(Console.ReadLine());
// Точка с запятой не ставится перед "{"
if (secondNumber * secondNumber == firstNumber) // Ветка "Да"
{
    Console.WriteLine("Превое число является квадратом второго ");
}
else Console.WriteLine("Превое число НЕ является квадратом второго ");





