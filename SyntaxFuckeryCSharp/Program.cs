using System;

namespace SyntaxFuckeryCSharp
{
    class A
    {
        public A(int i) { Value = i; }
        public int Value = 0;

        public static implicit operator int(A a)
        {
            return a.Value;
        }

        public static implicit operator A(int i)
        {
            return new A(i);
        }

        public static bool operator ==(A a1, A a2)
        {
            if (System.Object.ReferenceEquals(a1, a2))
            {
                return true;
            }

            if (((object)a1 == null) || ((object)a2 == null))
            {
                return false;
            }

            return a1.Value++ == a2.Value;
        }

        public static bool operator !=(A a1, A a2)
        {
            return !(a1 == a2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A(1);

            if (a == 1 && a == 2 && a == 3)
            {
                Console.WriteLine("Hello World!");
            }

            Console.Read();
        }
    }
}
