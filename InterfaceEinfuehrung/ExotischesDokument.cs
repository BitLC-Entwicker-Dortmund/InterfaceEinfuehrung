using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEinfuehrung {
    internal class ExotischesDokument : IDruckbar  {
        public void Drucken() {
            Console.WriteLine("Drucke Exotisches Nicht Dokument");
        }
    }
}
