﻿using System;

namespace EnglishToNepaliNumber
{
    public class Conveter
    {
        public static string EnglishToNepali(string EnglishNumber)
        {
            string[] NepaliNumberArray = { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९", ".", "/", "-" };

            string[] EnglishNumberArray = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ".", "/", "-" };

            int TotalNumber = 13;
            string NepaliNumber = "";
            if (EnglishNumber == null)
            {
                EnglishNumber = " ";
            }
            // conveting input string to char array
            char[] inputString = EnglishNumber.ToCharArray();
            for (int i = 0; i < EnglishNumber.Length; i++)
            {

                for (int j = 0; j < TotalNumber; j++)
                {
                    string value = EnglishNumberArray[j].ToString();
                    string inputvalue = inputString[i].ToString();
                    if (value == inputvalue)
                    {
                        NepaliNumber += NepaliNumberArray[j].ToString();
                    }
                }
            }

            return NepaliNumber;
        }
    }
}
