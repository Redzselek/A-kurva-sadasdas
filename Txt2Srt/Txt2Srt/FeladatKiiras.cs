using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Txt2Srt
{
    class FeladatKiiras
    {
        string szoveg;

        public FeladatKiiras(string szoveg)
        {
            this.szoveg = szoveg;
            
        }

        public void FKiiras()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(this.szoveg);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            
        }

        public string Szoveg { get => szoveg; set => szoveg = value; }
    }
}
