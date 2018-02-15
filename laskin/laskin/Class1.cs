using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laskin
{
    public override class YhteenLaskin : Laskin
    {
        public int yhteenlasku(int Luku1, int Luku2) : base(Laske)
        {
            return Luku1 + Luku2;
        }
    }

    public class VähennysLaskin : Laskin
    {
        public int vähennyslasku(int Luku1, int Luku2) : base(Laske)
        { 
            return Luku1 - Luku2;
        }
    }

    public class JakoLaskin : Laskin
    {
        public int jakolasku(int Luku1, int Luku2) : base(Laske)
        {
            return Luku1 / Luku2;
        }
    }
    public class KertoLaskin : Laskin
    {
        public int Kertolasku(int Luku1, int Luku2) : base(Laske)
        {
            return Luku1 * Luku2;
        }
    }
}
