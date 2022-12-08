int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
double Distance(int x1, int x2,int y1,int y2, int z1,int z2)
{
    double res = 0;
    res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1 -z2)*(z1-z2));
    return res;
}
void PrintData(string message, double res)
{
     Console.WriteLine(message+res);
}


int x1 = ReadData("Введите координату X1");
int x2 = ReadData("Введите координату X2");
int y1 = ReadData("Введите координату Y1");
int y2 = ReadData("Введите координату Y2");
int z1 = ReadData("Введите координату Z1");
int z2 = ReadData("Введите координату Z2");

PrintData("Расстояние между точками равно  ", Distance(x1,y1,z1,x2,y2,z2)); 
