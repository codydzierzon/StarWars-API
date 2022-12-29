using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient.Extensions
{
    public static class StringExtensions
    {
        public static int GetId(this string value)
        {
            string[] values = value.Split("/");
            string id = values[values.Length - 2];
            return int.Parse(id);
        }
    }
}
