using System;
using WindowsFormsApplication1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.persistence;
using WindowsFormsApplication1.Presentation;
using WindowsFormsApplication1;

namespace EmailGeneration
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            /*
            int Seed = (int)DateTime.Now.Ticks;
            Random rnd = new Random(Seed);

            Mock m1 = new Mock("primo", "", "primo", 1, rnd);
            Mock m2 = new Mock("sec", "", "sec", 2, rnd);
            Mock m3 = new Mock("terzo", "", "terzo", 3, rnd);
            Mock m4 = new Mock("quar", "", "quar", 4, rnd);
            MockSet<Mock> ms = new MockSet<Mock>();
            ms.Add(m1);
            ms.Add(m2);
            ms.Add(m3);
            ms.Add(m4);*/

            IModelPersister mmp = new MockModelPersister();
            Document.GetInstance().Load(mmp);
            
            //mml.GetMock(); mml.GetMock(); mml.GetMock(); mml.GetMock();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EmailGenerator_v mainView = new EmailGenerator_v();
            MockPresenter mp = new MockPresenter(mainView);
            Application.Run(mainView);
        }
    }
}