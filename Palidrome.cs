﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPalidrome
{
    internal class Palidrome
    {
    }

    public bool IsPalindrome(string a)
    {
        char[] AArray = a.ToCharArray();

        int begin = 0;

        int end = AArray.Length;


        while (begin < end)
        {
            if (AArray[begin] == AArray[end])
            {
                return true;


            }
            else
            {
                begin++;
                end--;
            }
        }
        return false;
    }


}