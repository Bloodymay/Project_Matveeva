int k1 = ReadData("Введите координату k1:");
int b1 = ReadData("Введите координату b1:");
int k2 = ReadData("Введите координату k2: ");
int b2 = ReadData("Введите координату b2: ");
int b3 = ReadData("Введите координату b3: ");
int k3 = ReadData("Введите координату k3: ");
(double x,double y) pointA = IntersectionPoint(b1, k1, b2, k2);
(double x,double y) pointB = IntersectionPoint(b2, k2, b3, k3);
(double x,double y) pointC = IntersectionPoint(b3, k3, b1, k1);
double side1 = LengthSide(pointA.x, pointA.y, pointB.x, pointB.y);
double side2 = LengthSide(pointB.x, pointB.y, pointC.x, pointC.y);
double side3 = LengthSide(pointC.x, pointC.y, pointA.x, pointA.y);


int ReadData(string line)//Просим пользователя задать длину массива.
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    return int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение

}

void PrintData (string msg, double area) // Выводим результат в консоль

{
    Console.WriteLine(msg +area);
}



// найдем точки пересечения.
(double, double) IntersectionPoint(int b1, int k1, int b2, int k2)
{
    double x = ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
    double y = (double)k1 * x + (double)b1;
    return (x, y);
}
// Посчитаем координаты песечения.
double LengthSide(double x1, double y1, double x2, double y2)
{
    double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return result;
}
// double LengthSide(double pointAx,double pointAy,double pointBx,double pointBy)//Высчитаем длину каждой стороны
// {
// double length = (pointBx-pointAx)*(pointBx-pointAx)+(pointBy-pointAy);
// return length;
// }
double TriangleArea(double side1 ,double side2,double side3)//Высчитаем площадь треугольника
{
    double perimeter = side1+side2+side3;
    double halfPerimeter = perimeter/2;
    double area = Math.Sqrt(halfPerimeter*(halfPerimeter-side1)*(halfPerimeter-side2)*(halfPerimeter-side3));
    return area;
}
double area = TriangleArea(side1,side2,side3);
PrintData("Площадь треугольника равна: " , area);