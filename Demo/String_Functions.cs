﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class String_Functions
    {
        public static int GetCountOfUpperCaseChars(string Name)
        {
            int count = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsUpper(Name[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static int GetCountOfLowerCaseChars(string Name)
        {
            int count = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsLower(Name[i]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}