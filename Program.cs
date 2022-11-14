// See https://aka.ms/new-console-template for more information
// Создать обобщенный класс прямой на плоскости. В классе предусмотреть 2 поля
// обобщенной точки, через которые проходит прямая.
// Реализовать в классе:
// * конструктор который принимает две точки.
// * конструктор который принимает 4 координаты (x и y 
// (координаты для первой и второй точки, метод ToString().
// line - линия
// point - точка
namespace sharp_14_11_2022_Straight_line;
class Program
{
    static void Main(string[] args)
    {
        C_Point <int>p1 = new C_Point<int>  (10, 10);
        C_Point <int>p2 = new C_Point<int>(100, 100);

        P_Line <int> F= new P_Line<int> (p1, p2);
       
       // Console.WriteLine(p1+ " " + p2);
        Console.WriteLine(F.ToString());
    }
}