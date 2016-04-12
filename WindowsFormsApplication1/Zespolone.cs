using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Zespolone
    {
        private double rzeczywista;
        private double urojone;

        public Zespolone(double rzeczywista, double urojone)
        {
            this.rzeczywista = rzeczywista;
            this.urojone = urojone;
        }

        public static Zespolone operator +(Zespolone z1, Zespolone z2)
        {
            return new Zespolone(z1.rzeczywista + z2.rzeczywista, z1.urojone + z2.urojone);
        }

        public static Zespolone operator -(Zespolone z1, Zespolone z2)
        {
            return new Zespolone(z1.rzeczywista - z2.rzeczywista, z1.urojone - z2.urojone);
        }

        public static Zespolone operator *(Zespolone z1, Zespolone z2)
        {
            
            return new Zespolone();
        }

        public static Zespolone operator /(Zespolone z1, Zespolone z2)
        {

            return new Zespolone();
        }

        public static Zespolone operator !=(Zespolone z1, Zespolone z2)
        {
            
        }

        public static Zespolone operator ==(Zespolone z1, Zespolone z2)
        {
            
        }
    }
}
