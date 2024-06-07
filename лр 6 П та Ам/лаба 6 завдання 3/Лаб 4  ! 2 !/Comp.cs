using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб_3___2__
{
    public abstract class Comp
    {
        public string Name { get; set; }
        public string os { get; set; }
        public string Virob { get; set; }
        public int Proc { get; set; }
        public double Bios { get; set; }
        public double OperMemory { get; set; }
        public bool Inch { get; set; }
        public bool Overclocking { get; set; }

        public Comp() { }

        public Comp(string name, string os, string virob, int proc, double bios, double operMemory, bool inch, bool overclocking)
        {
            Name = name;
            this.os = os;
            Virob = virob;
            Proc = proc;
            Bios = bios;
            OperMemory = operMemory;
            Inch = inch;
            Overclocking = overclocking;
        }

        public abstract void Configure();
    }
}
