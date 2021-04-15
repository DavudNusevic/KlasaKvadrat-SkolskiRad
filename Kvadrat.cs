using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KlasaKvadrat_SkolskiRad
{
    class Kvadrat
    {
        int a;
        Point o;
        Color boja = Color.Black;

        public Kvadrat() { }

        public Kvadrat(Color boja, int a, Point o)
        {
            this.boja = boja;
            this.a = a;
            this.o = o;
        }
        public void Crtaj(Graphics g)
        {
            g.FillRectangle(new SolidBrush(boja), o.X - a/2, o.Y - a/2, a, a);
        }


    }
}
