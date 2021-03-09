
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Kimlik kml = new Kimlik();
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);
            Console.WriteLine(kml.MEMLEKET);
            Console.Read();
            
        }
    }
}
