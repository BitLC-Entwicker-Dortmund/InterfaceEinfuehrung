namespace InterfaceEinfuehrung {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Interface!");

            ExcelDokument ed = new ExcelDokument();
            ed.SetTitel("Schön ist das Interface");
            
            WordDokument wd = new WordDokument();
            wd.SetTitel("Wörd ist so schön");

            ExotischesDokument exotisches = new ExotischesDokument();

            List<IDruckbar> liste = new List<IDruckbar>();
            liste.Add(ed);
            liste.Add(wd);
            liste.Add(exotisches);

            foreach (IDruckbar item in liste) {
                if (item is WordDokument) {
                    string d = ((WordDokument)item).GetTitel();
                    Console.WriteLine(  d );
                }
                if (item is ExcelDokument) {
                    string e = ((ExcelDokument)item).GetTitel();
                    Console.WriteLine(e);
                }
                //else Console.WriteLine( "ich bin exotisch");
            }

            Console.ReadLine();
        }
    }
}