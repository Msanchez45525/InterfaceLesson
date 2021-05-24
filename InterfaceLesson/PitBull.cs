using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson
{
    class PitBull : IPrint
    {
        public String HeadSize { get; set; }
        public String Type { get; set; } = "Pitbull";


        public void Print()
        {
            Console.WriteLine($"This dog is a {Type}");
        }
    }
}
