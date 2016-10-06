﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voat
{
    public static class StringExtensions
    {
        public static string TrimSafe(this string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                return text.Trim();
            }
            return null;
        }
        public static bool IsTrimmedNullOrEmpty(this string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                text = text.Trim(); 
            }
            return String.IsNullOrEmpty(text);
        }
    }
}
