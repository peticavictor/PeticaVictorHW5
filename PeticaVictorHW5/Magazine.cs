using System;
using System.Reflection;
using System.Reflection.Metadata;
using Microsoft.VisualBasic.CompilerServices;

namespace PeticaVictorHW5
{
    class Magazine
    {
        public int empNum { get; set; }
        public Magazine(int empNum)
        {
            this.empNum = empNum;
        }
        public static Magazine operator + (Magazine m, int num)
        {
            m.empNum += num;
            return m;
        }
        public static Magazine operator - (Magazine m, int num)
        {
            m.empNum -= num;
            return m;
        }
        public static bool operator == (Magazine a, Magazine b)
        {
            return a.empNum == b.empNum;
        }
        public static bool operator != (Magazine a, Magazine b)
        {
            return !(a.empNum == b.empNum);
        }
        public static bool operator > (Magazine a, Magazine b)
        {
            return a.empNum > b.empNum;
        }
        public static bool operator < (Magazine a, Magazine b)
        {
            return a.empNum < b.empNum;
        }

        public static Magazine operator ++(Magazine m)
        {
            m.empNum++;
            return m;
        }
        public static Magazine operator --(Magazine m)
        {
            m.empNum--;
            return m;
        }

        static void Main(string[] args)
        {
            Magazine magazine = new Magazine(5);
            magazine = magazine + 5;
            magazine++;

            Magazine magazine2 = new Magazine(5);
            magazine2--;

            Console.WriteLine(magazine == magazine2);
            Console.WriteLine(magazine > magazine2);
        }
    }
}
