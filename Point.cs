

using System.Drawing;

namespace sharp_14_11_2022_Straight_line
{
    internal class C_Point <T>  
    {
        public T x1 { get; set; }
        public T y1 { get; set; }
       

        public C_Point(T X1, T Y1)
        {
            this.x1 = X1;
            this.y1 = Y1;
        }
        public C_Point  ()
        {
            this.x1 = default (T);
            this.y1 = default(T);
        }

        public override string ToString()
        {
            return $"\n Точка  x {this.x1}, y {this.y1}";
        }
    }
}
