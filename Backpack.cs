﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    internal class Backpack
    {
        private List<Soda> sodas;
        public Backpack()
        {
            this.sodas = new List<Soda>();
        }

        public void AddSoda(Soda soda)
        {
            this.sodas.Add(soda);
            Console.WriteLine($"{soda.Flavor} added to backpack.");
        }
    }
}
