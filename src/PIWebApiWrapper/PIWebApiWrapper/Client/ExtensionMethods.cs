using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIWebAPIWrapper.Client
{
    public class ExtensionMethods
    {
        public static List<string> ConvertToList(string text)
        {
            return text.Split(',').ToList();
        }
    }
}
