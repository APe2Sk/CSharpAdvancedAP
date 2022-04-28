﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes.Entities
{
    public abstract class Pet
    {
        public string Name {get; set;} 
        public string Type {get; set;}
        public int Age { get; set; }
        public abstract void PrintInfo();
    }
}
