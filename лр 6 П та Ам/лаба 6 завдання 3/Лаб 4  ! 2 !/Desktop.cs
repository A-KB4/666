using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_3___2__
{
    public class Desktop : Comp
    {
        public Desktop() { }

        public Desktop(string name, string os, string virob, int proc, double bios, double operMemory, bool inch, bool overclocking)
            : base(name, os, virob, proc, bios, operMemory, inch, overclocking) { }

        public override void Configure()
        {
            // Реалізація налаштувань для настільного комп'ютера
        }
    }
}
