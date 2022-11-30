// Пользователь вводит три числа
string? firstNumber = Console.ReadLine();
string? secondNumber = Console.ReadLine();
string? thirdNumber = Console.ReadLine();
if (firstNumber != null && secondNumber != null && thirdNumber != null); //Проводим проверку на присутствие данных
{   
    //Парсим введенные числа
    int num1 = int.Parse(firstNumber);
    int num2 = int.Parse(secondNumber);
    int num3 = int.Parse(thirdNumber);
   //Присваиваем переменной max значение первого числаю
    int max = num1;
    // Сравниваем числа. Если следующеечисло > записываем его в max
    if (num2>max) max = num2;
    
       
    if (num3>max) max = num3;
    //Выводим max в консоль
    Console.WriteLine(max);
    
} 

