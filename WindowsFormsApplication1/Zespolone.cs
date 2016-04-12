using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Zespolone
    {
        private double rzeczywista;
        private double urojone;

        public Zespolone()
        {

        }
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
            double real = (z1.rzeczywista * z2.rzeczywista) - (z1.urojone * z2.urojone);
            double imaginary = (z1.rzeczywista * z2.urojone) + (z1.urojone * z2.rzeczywista); 
            return new Zespolone(real, imaginary);
        }

        public static Zespolone operator /(Zespolone z1, Zespolone z2)
        {
            //((ac + bd) / (c2 + d2)) + ((bc - ad) / (c2 + d2)i
            double real = ((z1.rzeczywista * z2.rzeczywista) + (z1.urojone * z2.urojone)) / (z2.rzeczywista* z2.rzeczywista + z2.urojone* z2.urojone);
            double imaginary = ((z1.urojone * z2.rzeczywista) - (z1.rzeczywista * z2.urojone)) / (z2.rzeczywista * z2.rzeczywista + z2.urojone * z2.urojone);
            return new Zespolone(real, imaginary);
        }

        public static bool operator !=(Zespolone z1, Zespolone z2)
        {
            if (z1.rzeczywista != z2.rzeczywista)
                if (z1.urojone != z2.urojone)
                    return true;

            return false;
        }

        public static bool operator ==(Zespolone z1, Zespolone z2)
        {
            if (z1.rzeczywista == z2.rzeczywista)
                if (z1.urojone == z2.urojone)
                    return true;

            return false;
        }

        public override string ToString()
        {
            if (urojone < 0)
            {
                return rzeczywista + " - " + Math.Abs(urojone)+"i";
            }else
            {
                return rzeczywista + " + " + urojone+"i";
            }
        }
    }
}
