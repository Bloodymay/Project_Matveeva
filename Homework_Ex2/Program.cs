string? firstNumber = Console.ReadLine();//Ввод пользователем первого числа
string? secondNumber = Console.ReadLine();//Ввод пользователем второго числа
 if (firstNumber != null && secondNumber != null); //Проверка присутствия данных

 {
    // Парсим введенные числа
    int num1 = int.Parse(firstNumber);
    int num2 = int.Parse(secondNumber);
    if (num1 > num2) // Сравниваем введенные числа
    {
        Console.WriteLine(num1 + " - Большее число" ); // Выводим полученные данные в консоль
        Console.WriteLine(num2 + " - Меньшее число");  // Выводим полученные данные в консоль

    }
    else 
    {
        Console.WriteLine(num1 + " - Меньшее число");   // Выводим полученные данные в консоль
        Console.WriteLine(num2 +  " - Большее число");  // Выводим полученные данные в консоль
    }
 }