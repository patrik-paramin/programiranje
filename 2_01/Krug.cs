using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_01
{
    internal class Krug
    {
        public double Polumjer;

        public double Povrsina()
        {
            return Math.PI * Polumjer * Polumjer;
        }
    }
}
