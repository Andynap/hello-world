using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {

    class Zak {
        public string Jmeno;
        public int Vek;

        public Zak(string jmeno, int vek) {
            Jmeno = jmeno;
            Vek = vek;

            Console.WriteLine("Byl vytvořen nový Žák, jehož jméno je {0} a věk je {1}", jmeno, vek);
        }
    }

    static class Trida {
        
    }

    static class Program {
        static void Main(string[] args) {
            new Zak("Filip", 19);

            Console.ReadKey();
        }

    }

}
