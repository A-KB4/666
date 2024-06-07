using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Лаб_3___2__;

public class Laptop : Comp
{
    public Laptop() { }

    public Laptop(string name, string os, string virob, int proc, double bios, double operMemory, bool inch, bool overclocking)
        : base(name, os, virob, proc, bios, operMemory, inch, overclocking) { }

    public override void Configure()
    {
        // Реалізація налаштувань для ноутбука
    }
}
