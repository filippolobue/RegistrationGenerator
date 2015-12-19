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

        public Mock(string f, string m, string l, int a, string p)
        {
            this.firstName = f;
            this.middleName = m;
            this.lastName = l;
            this.age = a;
            this.password = p;
            this.email = this.generateEmail();
        }

        public Mock(string f, string m, string l, int a)
        {
            this.firstName = f;
            this.middleName = m;
            this.lastName = l;
            this.age = a;
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
            get { return this.middleName; }
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
                Random random = new Random();
                Email em = (Email)values.GetValue(random.Next(values.Length));

                ret = ret + em.ToString().ToLower() + ".com";
            }
            else ret = null;

            Console.WriteLine(ret);
            return ret;
        }

        // genera una parola di lunghezza requestedLength con le prime due lettere maiuscole e almeno due cifre
        private string generatePassword(int requestedLength)
        {
            Random rnd = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] vowels = { "a", "e", "i", "o", "u" };
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
            string word = "";

            if (requestedLength == 1)
            {
                word = GetRandomLetter(rnd, vowels).ToUpper();
            }
            else
            {
                word += GetRandomLetter(rnd, consonants).ToUpper() + GetRandomLetter(rnd, consonants).ToUpper();
                word += GetRandomLetter(rnd, numbers) + GetRandomLetter(rnd, numbers);
                for (int i = 4; i < requestedLength; i += 2)
                {
                    word += GetRandomLetter(rnd, consonants) + GetRandomLetter(rnd, vowels);
                }

                word = word.Substring(0, requestedLength); // We may generate a string longer than requested length, but it doesn't matter if cut off the excess.
            }
            Console.WriteLine(word);
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

