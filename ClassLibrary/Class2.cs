using System.Collections.Generic;

namespace ClassLibrary
{
    public class Class2
    {
        public List<string> ListWithLetters(List<string> list, string letter)
        {
            List<string> letters = list;
            letters.Add(letter);
            return letters;
        }
        public bool FuncReturnTrueOrFalse(int value)
        {
            if (value == 1) return true;
            else return false;
        }
    }
}
