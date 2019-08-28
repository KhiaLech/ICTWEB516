using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordProcessor
{
    public class Processor
    {
        public string AlternateCase(string word)
        {
            StringBuilder sb = new StringBuilder();
            bool uppercase = false;

            if (char.IsUpper(word[0]))
            {
                uppercase = true;
            }

            foreach (char c in word)
            {

                if (!char.IsLetter(c))
                {
                    throw new InvalidWordException();
                }


                if (uppercase)
                    sb.Append(char.ToUpper(c));
                else
                    sb.Append(char.ToLower(c));

                uppercase = !uppercase;
            }

            string newWord = sb.ToString();

            return newWord;
            
        }


    }
}
