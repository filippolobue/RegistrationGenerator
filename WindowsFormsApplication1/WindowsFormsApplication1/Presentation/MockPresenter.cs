using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Presentation
{
    public class EmailGeneratorEventArgs : EventArgs
    {
        public String text { get; set; }
    }

    class MockPresenter
    {
        private EmailGenerator_v view;

        public MockPresenter(EmailGenerator_v view)
        {
            this.view = view;
            this.view.pressButton += interaction;
        }

        public void interaction(object sender, EventArgs e)
        {
            String control = null;
            if (!(sender.GetType() == typeof(Button)))
                throw new Exception("sender == Button");

            control = ((Button)sender).Name;
            
            if (control == "emailB")//devo aggiornare tutti i campi
            {
                Mock mock = Document.GetInstance().MockSet.Get();
                Clipboard.SetText(mock.Email);
                this.view.changeEmailLabel(mock.Email);

                String middleName = mock.MiddleName;
                if (middleName != "")
                    this.view.changeFNameLabel((mock.FirstName + " " + middleName));
                else
                    this.view.changeFNameLabel(mock.FirstName);

                this.view.changeLNameLabel(mock.LastName);
                this.view.changePasswordLabel(mock.Password);
                this.view.changeAgeLabel(mock.Age.ToString());
                this.view.changeCityLabel(mock.City);
            }
            else
            {
                EmailGeneratorEventArgs ev = null;
                if (e.GetType() == typeof(EmailGeneratorEventArgs))
                {
                    ev = (EmailGeneratorEventArgs)e;
                }

                if (ev!=null)
                {
                    Clipboard.SetText(ev.text);
                    Console.WriteLine(ev.text);
                }
            }

            

            Console.WriteLine("press something: " + ((Button)sender).Name);
          
        }
    }
}
