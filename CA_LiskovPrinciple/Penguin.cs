using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_LiskovPrinciple
{
    public class Penguin:BaseClass
    {
        public override void Run()
        {
            throw new NotSupportedException();
        }
    }
}
