

using System.Drawing;

namespace sharp_14_11_2022_Straight_line
{
    internal class P_Line<T> where T : struct
    {
        C_Point<T> one;
        C_Point<T> two;
        public P_Line (C_Point<T> one,C_Point <T> two )
        {
            this.one = one;
            this.two = two;
        }
        public P_Line (T Ax, T Ay, T Bx, T By) 
        {
            one = new C_Point<T> (Ax, Ay);
            two = new C_Point<T> (Bx, By);
        }
        public override string ToString()
        {
            return $"Прямая от точки {this.one} до точки {this.two}";
        }
    }
}

