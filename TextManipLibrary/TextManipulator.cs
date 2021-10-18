using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextManipLibrary
{
    public class TextManipulator
    {
        public string reverseText(string p_input)
        {
            List<char> reversedList = new List<char>();
            reversedList = p_input.ToList<char>();
            reversedList.Reverse();
            string reversed = new string (reversedList.ToArray());
            return reversed;
        }

        public string shuffleText(string p_input)
        {
            char[] array = p_input.ToCharArray();
            Random rng = new Random();

            int n = array.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }

            return new string(array);
        }
    }
}
