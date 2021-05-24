using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class Shibainu : IPrint
    {
        public string Characteristic { get; set; } = "Stand-offish";
        public String Type { get; set; } = "Shibainu";


        public void Print()
        {
            Console.WriteLine($"This dog is a {Type} and its Stand-offish");
        }
    }
}
