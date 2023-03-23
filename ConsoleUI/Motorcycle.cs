using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class  Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            throw new NotImplementedException();
        }

        public override void Test()
        {
            throw new NotImplementedException();
        }

        public bool HasSideCart { get; set; }
        
    }
}
