﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCrown
{
    public static class Utilities
    {
        public static string Comma(this IEnumerable<string> word) 
        {
            return string.Join(", ", word);
        }
    }
}
