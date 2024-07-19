
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4oop
{
    internal class Duration
    {

        public Duration() { }

        public Duration(int hour, int minut, int second)
        {
            this.hour = hour;
            this.minut = minut;
            this.second = second;
        }

        public int hour { get; set; }
        public int minut { get; set; }
        public int second { get; set; }

        public override bool Equals(object? obj)
        {

            if (obj is Duration)
            {

                Duration d = (Duration)obj;
                if (hour == d?.hour && minut == d?.minut && second == d?.second)
                {
                    return true;
                }

            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
