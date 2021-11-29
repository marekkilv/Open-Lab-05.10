using System;

namespace Open_Lab_05._10
{
    public class Challenge
    {
        public int MysteryFunc(int num)
        {
            int cislo = 1;
            char[] num_characters = num.ToString().ToCharArray();
            foreach (var number_char in num_characters)
            {
                int intStr; bool intResultTryParse = int.TryParse(number_char.ToString(), out intStr);
                cislo = cislo * intStr;
            }
            return cislo;
        }
    }
}
