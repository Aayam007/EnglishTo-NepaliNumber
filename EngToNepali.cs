using System;

namespace EnglishToNepaliNumber
{
    public class EngToNepali
    {
        public static string English_Nepali(string EnglishNumericValue)
        {
            if (EnglishNumericValue == null)
            {
                EnglishNumericValue = " ";
            }
            string Eng_Value = EnglishNumericValue; // unicode  numeric chars
            string Nep_value = "";
            string[] Text_Nepali = { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९", ".", "/", "-" };
            string[] Text_English = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "/", "-" };
            char[] Inputtext = Eng_Value.ToString().ToCharArray();
            for (int j = 0; j < Eng_Value.Length; j++)
            {
                for (int i = 0; i < 13; i++)
                {
                    string value = Text_English[i].ToString();
                    string value1 = Inputtext[j].ToString();
                    if (value == value1)
                    {
                        Nep_value += Text_Nepali[i].ToString();
                    }
                }

            }
            return Nep_value;
        }

    }
}
