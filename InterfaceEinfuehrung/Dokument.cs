using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEinfuehrung {
    internal abstract class Dokument {
        private string titel;

        public void SetTitel(string titel) {
            this.titel = titel;
        }

        public string GetTitel() {  
            return titel; 
        }
    }
}
