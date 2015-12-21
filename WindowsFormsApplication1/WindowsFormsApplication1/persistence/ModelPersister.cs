using WindowsFormsApplication1.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.persistence
{
    class MockModelPersister : IModelPersister
    {
        IModelLoader IModelPersister.GetLoader()
        {
            return new MockModelLoader();
        }

        void IModelPersister.Save(Document model)
        {
            throw new NotImplementedException();
        }
    }

    class MockModelLoader : IModelLoader
    {
        private String propFile;
        private int minAge, maxAge;
        private int percMName;//percentuale con cui il mock avrà un secondo nome

        private String mockFName;
        private int numFName;
        private String mockMName;
        private int numMName;
        private String mockLName;
        private int numLName;
        private String mockPlaces;
        private int numPlaces;
        private Random rnd;

        // --- PROPRIETA' ---
        public String PropFile
        {
            set { this.propFile = value; }
            get { return this.propFile; }
        }

        public String FName
        {
            set { this.mockFName = value; }
            get { return this.mockFName; }
        }

        public String MName
        {
            set { this.mockMName = value; }
            get { return this.mockMName; }
        }

        public String LName
        {
            set { this.mockLName = value; }
            get { return this.mockLName; }
        }

        public String Places
        {
            set { this.mockPlaces = value; }
            get { return this.mockPlaces; }
        }
        // -----------------------------------------------

        public MockModelLoader()
        {
            Initialize_1();
        }

        private void Initialize_1()
        {
            String language = "eng";
            this.rnd = new Random((int)DateTime.Now.Ticks);
            this.PropFile = "../prop.txt";
            this.minAge = 18;
            this.maxAge = 65;
            this.percMName = 50;
            //dal file prop dovrei leggere le preferenze e settare gli altri attributi

            this.FName = ("../../resources/" + language + "_fname.txt");
            this.MName = ("../../resources/" + language + "_mname.txt");
            this.LName = ("../../resources/" + language + "_lname.txt");
            this.Places = ("../../resources/" + language + "_places.txt");

            //voglio sapere il numero delle linee all'interno di ogni file
            this.numFName = numLines(this.FName);
            this.numMName = numLines(this.MName);
            this.numLName = numLines(this.LName);
            this.numPlaces = numLines(this.Places);

            Console.WriteLine("[MockModelLoader] numero first names: " + this.numFName + " " + this.numMName + " " + this.numLName + " " + this.numPlaces);
        }

        private int numLines(String path)
        {
            int lineCount = 0;
            using (var reader = File.OpenText(path))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            return lineCount;
        }

        Mock IModelLoader.GetMock()
        {
            string fname = File.ReadLines(this.FName).Skip(this.rnd.Next(0,this.numFName)).Take(1).First();
            string mname = null;
            if (this.rnd.Next(1,101) < this.percMName)
                mname = File.ReadLines(this.MName).Skip(this.rnd.Next(0, this.numMName)).Take(1).First();
            string lname = File.ReadLines(this.LName).Skip(this.rnd.Next(0, this.numLName)).Take(1).First();
            string place = File.ReadLines(this.Places).Skip(this.rnd.Next(0, this.numPlaces)).Take(1).First();
            int age = this.rnd.Next(this.minAge, this.maxAge + 1);
            //Console.WriteLine("nome: " + fname + " " + mname + " " + lname + " " + places + " " + age);
            return new Mock(fname,mname,lname,age,place,this.rnd);
        }
    }

}
