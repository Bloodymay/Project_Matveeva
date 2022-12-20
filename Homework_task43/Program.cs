int ReadData(string line)//Просим пользователя задать длину массива.
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    return int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение

}

void PrintData (string msg, (double,double) point) // Выводим результат в консоль

{
    Console.WriteLine(msg + point);
}
(double, double) IntersectionPoint(double b1, double a1, double b2, double a2)
{
    double x = ((double)b2 - (double)b1) / ((double)a1 - (double)a2);
    double y = (double)a1 * x + (double)b1;
    return (x, y);
}
double a1 = ReadData("Введите координату a1:");
double b1 = ReadData("Введите координату b1:");
double a2 = ReadData("Введите координату a2: ");
double b2 = ReadData("Введите координату b2: ");
(double x,double y) point = IntersectionPoint(b1, a1, b2, a2);


// double x = -(b1 - b2) / (a1 - a2);
// double y = (a1 * x) + b1;
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
PrintData("Пересечение прямых происходит в точке с координатами: " , point);


// double PointOFIntersection(double a1,double b1,double b2,double a2)
// {
//     double result= x,y;
//     double x = -(b1-b2)/(a1-a2);
//     double y = (a1*x) +b1;
//     x = Math.Round(x,3);
//     y = Math.Round(y,3);

//     return result;
// }
