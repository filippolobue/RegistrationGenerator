using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{    
    public class Mock
    {
        private readonly string firstName;
        private readonly string middleName;
        private readonly string lastName;
        private readonly int age;
        private readonly string password;
        private readonly string email;
        private readonly string city;

        private Random rnd;

        public Mock(string f, string m, string l, int a, string p, string c, Random rnd)
        {
            this.firstName = f;
            this.middleName = m;
            this.lastName = l;
            this.age = a;
            this.password = p;
            this.city = c;
            this.email = this.generateEmail();
            this.rnd = rnd;
        }

        public Mock(string f, string m, string l, int a, string p, string c)
        {
            this.firstName = f;
            this.middleName = m;
            this.lastName = l;
            this.age = a;
            this.password = p;
            this.city = c;
            this.email = this.generateEmail();
            this.rnd = new Random((int)DateTime.Now.Ticks);
        }

        public Mock(string f, string m, string l, int a, string c, Random rnd)
        {
            this.firstName = f;
            this.middleName = m;
            this.lastName = l;
            this.age = a;
            this.rnd = rnd;
            this.city = c;
            this.password = this.generatePassword(8);
            this.email = this.generateEmail();
        }

        // --- PROPRIETA' ---
        public string FirstName
        {
            get { return this.firstName; }
        }

        public string MiddleName
        {
            get {
                if (this.middleName == null)
                    return "";
                return this.middleName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public int Age
        {
            get { return this.age; }
        }

        public string Password
        {
            get { return this.password; }
        }

        public string Email
        {
            get { return this.email; }
        }

        public string City
        {
            get { return this.city; }
        }
        // -----------------------------------------------

        private string generateEmail()
        {
            string ret = "";
            if (this.FirstName != null && this.FirstName != "" &&
               this.LastName != null && this.LastName != "")
            {
                ret = this.FirstName.Replace(" ", String.Empty).ToLower() + ".";
                if (this.MiddleName != null && this.MiddleName != "")
                    ret = ret + this.MiddleName.Replace(" ", String.Empty).ToLower() + ".";
                ret = ret + this.lastName.Replace(" ", String.Empty).ToLower();
                if (this.Age > 0)
                    ret = ret + this.Age + "@";

                Array values = Enum.GetValues(typeof(Email));
                Email em = (Email)values.GetValue(this.rnd.Next(values.Length));

                ret = ret + em.ToString().ToLower() + ".com";
            }
            else ret = null;

            //Console.WriteLine(ret);
            return ret;
        }

        // genera una parola di lunghezza requestedLength con le prime due lettere maiuscole e almeno due cifre
        private string generatePassword(int requestedLength)
        {
            //int Seed = (int)DateTime.Now.Ticks;
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] vowels = { "a", "e", "i", "o", "u" };
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
            string word = "";

            if (requestedLength == 1)
            {
                word = GetRandomLetter(this.rnd, vowels).ToUpper();
            }
            else
            {
                word += GetRandomLetter(this.rnd, consonants).ToUpper() + GetRandomLetter(this.rnd, consonants).ToUpper();
                word += GetRandomLetter(this.rnd, numbers) + GetRandomLetter(this.rnd, numbers);
                for (int i = 4; i < requestedLength; i += 2)
                {
                    word += GetRandomLetter(this.rnd, consonants) + GetRandomLetter(this.rnd, vowels);
                }

                word = word.Substring(0, requestedLength); // We may generate a string longer than requested length, but it doesn't matter if cut off the excess.
            }
           // Console.WriteLine(word);
            return word;
        }

        private static string GetRandomLetter(Random rnd, string[] letters)
        {
            return letters[rnd.Next(0, letters.Length - 1)];
        }

        public override bool Equals(object obj)
        {
            // Se il paramentro è nullo ritorno falso
            if (obj == null)
            {
                return false;
            }

            // Se il paramentro non può essere castato a Mock ritorno false.
            Mock a = obj as Mock;
            if ((System.Object)a == null)
            {
                return false;
            }

            // Ritorno true se il nome e la data sono gli stessi
            return (this.FirstName == a.FirstName && 
                    this.MiddleName == a.MiddleName &&
                    this.LastName == a.LastName &&
                    this.Age == a.Age &&
                    this.Email == a.Email);
        }

        public override string ToString()
        {
   

            // Ritorno true se il nome e la data sono gli stessi
            return (this.FirstName + 
                    this.LastName +
                    this.Age +
                    this.Email);
        }
    }
}

