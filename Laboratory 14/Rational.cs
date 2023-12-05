using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_14
{
    [DeveloperInfo("Alisa", "2023-04-12")]
    internal class Rational
    {
        private int numerator;
        private int denominator;

        public object HashCode { get; private set; }

        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");

            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
        public static bool operator ==(Rational r1, Rational r2)
        {
            if (ReferenceEquals(r1, r2))
                return true;

            if (ReferenceEquals(r1, null) || ReferenceEquals(r2, null))
                return false;

            return r1.Equals(r2);
        }
        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1 == r2);
        }
        public static bool operator <(Rational r1, Rational r2)
        {
            return r1.ToDouble() < r2.ToDouble();
        }
        public static bool operator >(Rational r1, Rational r2)
        {
            return r1.ToDouble() > r2.ToDouble();
        }
        public static bool operator <=(Rational r1, Rational r2)
        {
            return r1.ToDouble() <= r2.ToDouble();
        }
        public static bool operator >=(Rational r1, Rational r2)
        {
            return r1.ToDouble() >= r2.ToDouble();
        }
        public static Rational operator +(Rational r1, Rational r2)
        {
            int lcm = LCM(r1.denominator, r2.denominator);
            int numerator = (lcm / r1.denominator * r1.numerator) + (lcm / r2.denominator * r2.numerator);
            return new Rational(numerator, lcm);
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            int lcm = LCM(r1.denominator, r2.denominator);
            int numerator = (lcm / r1.denominator * r1.numerator) - (lcm / r2.denominator * r2.numerator);
            return new Rational(numerator, lcm);
        }
        public static Rational operator ++(Rational r)
        {
            return r + new Rational(1, 1);
        }
        public static Rational operator --(Rational r)
        {
            return r - new Rational(1, 1);
        }
        public static implicit operator Rational(float f)
        {
            return new Rational((int)(f * 1000), 1000);
        }
        public static implicit operator Rational(int i)
        {
            return new Rational(i, 1);
        }
        public static explicit operator double(Rational r)
        {
            return r.ToDouble();
        }
        public static explicit operator int(Rational r)
        {
            return (int)r.ToDouble();
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.numerator, r1.denominator * r2.denominator);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            return new Rational(r1.numerator * r2.denominator, r1.denominator * r2.numerator);
        }
        public static Rational operator %(Rational r1, Rational r2)
        {
            int lcm = LCM(r1.denominator, r2.denominator);
            int numerator = (lcm / r1.denominator * r1.numerator) % (lcm / r2.denominator * r2.numerator);
            return new Rational(numerator, lcm);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Rational other = (Rational)obj;
            return numerator == other.numerator && denominator == other.denominator;
        }
        public override int GetHashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode();
        }
        private double ToDouble()
        {
            return (double)numerator / denominator;
        }
        private static int LCM(int a, int b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
