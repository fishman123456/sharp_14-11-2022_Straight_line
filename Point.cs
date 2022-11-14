

namespace sharp_14_11_2022_Straight_line
{
    internal class C_Point
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
       

        public C_Point(int X1, int Y1)
        {
            this.x1 = X1;
            this.y1 = Y1;
        }
        public override string ToString()
        {
            return $"\n Точка с координатами x {x1}, y {y1}";
        }
    }
}
