Console.WriteLine("калькуль улучш");
Console.WriteLine("введите число ");

Console.Write("первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите плюс минус и тд (+, -, *, /): ");
string operatror = Console.ReadLine();

Console.WriteLine();

switch (operatror)
{
    case "+":

        Console.WriteLine($"сложения: {num1} + {num2} = {num1 + num2}");
        break;

    case "-":
        Console.WriteLine($"вычитания: {num1} - {num2} = {num1 - num2}");
        break;

    case "*":
        Console.WriteLine($"умножения: {num1} * {num2} = {num1 * num2}");
        break;

    case "/":

        if (num2 == 0)
        {
            Console.WriteLine("на ноль делтть не лья !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }
        else
        {
            Console.WriteLine($"delenie: {num1} / {num2} = {num1 / num2}");
        }
        break;

    default:

        Console.WriteLine($"Ошибка! Символ '{operatror}' не поддерживаетя .");
        break;
}

Console.WriteLine("поставьте 12");
Console.Read();