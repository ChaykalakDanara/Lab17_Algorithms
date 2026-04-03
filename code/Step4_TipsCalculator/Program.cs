// See https://aka.ms/new-console-template for more information
Console.WriteLine("Калькулятор чаевых");

Console.Write("Введите сумму счета (руб): ");
double bill = Convert.ToDouble(Console.ReadLine());
Console.Write("введите процент чаевых(например, 10): ");
double tipPercent = Convert.ToDouble(Console.ReadLine());

double tipAmount = bill * (tipPercent / 100);
double totalAmount = bill + tipAmount;

Console.WriteLine("\nРезультат");
Console.WriteLine($"Сумма счета: {bill} руб");
Console.WriteLine($"Чаевые({tipPercent}%); {tipAmount} руб");
Console.WriteLine($"Итого к оплате: {totalAmount} руб");

Console.WriteLine("Спасибо за использование калькулятора!");