using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Devices
{
    internal class Scanner : Device, IScanner // Scanner busca o processdoc do device e o Scan do IScanner
    {
        // sobrescrevendo o método ProcessDoc do Abstract Device
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scanner processing: " + document);
        }

        public string Scan()
        {
            return "Scanner scan result: ";
        }
    }
}
