// Это комментарий в язке С#
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine()); // тип данных имя = значение; // команда console.readLine() используется с переменной string, чтобы использовать с переменной int, нужно использовать Convert.ToInt32((Console.ReadLine())

// как получить число в квадрате?
int result = number * number; // number^2 = result // Math.Pow(number, 2(Степень)) но нужен double, а не int
Console.WriteLine(result);
