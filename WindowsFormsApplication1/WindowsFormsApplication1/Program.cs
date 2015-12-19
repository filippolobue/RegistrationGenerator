using System;
using WindowsFormsApplication1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>

        static Mock m1 = new Mock("primo", "", "primo", 1);
        static Mock m2 = new Mock("sec", "", "sec", 2);
        static Mock m3 = new Mock("terzo", "", "terzo", 3);
        static Mock m4 = new Mock("quar", "", "quar", 4);
        static MockSet<Mock> ms = new MockSet<Mock>();

        [STAThread]
        static void Main()
        {
            ms.Add(m1);
            ms.Add(m2);
            ms.Add(m3);
            ms.Add(m4);

            Console.WriteLine("Lunghezza = " + ms.Lenght());
            ms.Add(m2);
            Console.WriteLine("Lunghezza = " + ms.Lenght());

            Console.WriteLine(ms.Get());
            Console.WriteLine("Lunghezza = " + ms.Lenght());
            Console.WriteLine(ms.Get());
            Console.WriteLine("Lunghezza = " + ms.Lenght());
            Console.WriteLine(ms.Get());
            Console.WriteLine("Lunghezza = " + ms.Lenght());
            Console.WriteLine(ms.Get());
            Console.WriteLine("Lunghezza = " + ms.Lenght());
            Console.WriteLine(ms.Get());
            Console.WriteLine("Lunghezza = " + ms.Lenght());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
