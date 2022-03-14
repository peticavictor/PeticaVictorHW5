using System;

namespace Task2
{
    class Shop
    {
        public int area { get; set; }

        public static Shop operator + (Shop a, int amount)
        {
            a.area += amount;
            return a;
        }
        public static Shop operator -(Shop a, int amount)
        {
            a.area += amount;
            return a;
        }
        public static bool operator ==(Shop a, Shop b)
        {
            return a.area == b.area;
        }
        public static bool operator !=(Shop a, Shop b)
        {
            return !(a.area == b.area);
        }
        public static bool operator >(Shop a, Shop b)
        {
            return a.area > b.area;
        }
        public static bool operator <(Shop a, Shop b)
        {
            return a.area < b.area;
        }
        public override bool Equals(Object s)
        {
            if (this.ToString() == s.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
