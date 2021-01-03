using System;
using System.Runtime.InteropServices;

namespace addable_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Addable a = new Addable(2,5,10) + new Addable(7,0,1);
            Console.WriteLine(a.x + " " + a.y + " " + a.z);
        }
    }

    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public class Addable : IEquatable<Addable> {

        public float x {get;}
        public float y {get;}
        public float z {get;}
        
        public Addable(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public bool Equals(Addable other) 
        { 
            if (this.x == other.x && this.y == other.y && this.z == other.z) return true; 
            else return false;
        }
        

        // Addition
        public static Addable operator +(Addable a, Addable b) {
            Addable result = new Addable(a.x+b.x, a.y+b.y, a.z+b.z);
            return result;
        }

        // Multiplication
        public static Addable operator *(Addable a, Addable b) {
            Addable result = new Addable(a.x*b.x, a.y*b.y, a.z*b.z);
            return result;
        }

        // Subtraction
        public static Addable operator -(Addable a, Addable b) {
            Addable result = new Addable(a.x-b.x, a.y-b.y, a.z-b.z);
            return result;
        }

        // Division
        public static Addable operator /(Addable a, Addable b) {
            Addable result = new Addable(a.x/b.x, a.y/b.y, a.z/b.z);
            return result;
        }
    }
}
