using System;
using System.Collections.Generic;
using System.Linq;

namespace Codewars_VowelCount
{
    public class Kata
    {
        public static int GetVowelCount(string str)
        {
            return str.Count(x => x.Equals('a') || x.Equals('e') || x.Equals('i') || x.Equals('o') || x.Equals('u'));
        }
    }
}