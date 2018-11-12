using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Tower
    {
        private int tow;
        private string name;
        public Tower(string name, int tow)
        {
            this.tow= tow;
            this.name = name;
        }

        public void Move(Tower Destination)
        {
            tow--;
            Destination.tow++;
            Console.WriteLine("{0} -> {1}", name, Destination.name);
        }
        public static void Hanoi(int tower)
        {
            Tower source = new Tower("source", tower);
            Tower temp = new Tower("temp", 0);
            Tower dest = new Tower("dest", 0);
            HanoiDos(tower, source, dest, temp);
        }

        private static void HanoiDos(int tow, Tower source, Tower dest, Tower temp)
        {
            source.tow = tow;
            if (tow != 0)
            {
                HanoiDos(tow - 1, source, temp, dest);
                source.Move(dest);
                HanoiDos(tow - 1, temp, dest, source);
            }
        }
    }
}
