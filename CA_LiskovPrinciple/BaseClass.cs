﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_LiskovPrinciple
{
    public class BaseClass
    {
        public virtual void Run()
        {
            Console.WriteLine("this animal can run");
        }
    }
}
